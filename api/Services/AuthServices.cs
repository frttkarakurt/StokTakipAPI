using api.Data;
using api.DTOs;
using api.Entities;
using api.Helpers;
using Microsoft.EntityFrameworkCore;

namespace api.Services;

public class AuthService
{
    private readonly AppDbContext _context;
    private readonly JwtHelper _jwtHelper;

    public AuthService(
        AppDbContext context,
        JwtHelper jwtHelper)
    {
        _context = context;
        _jwtHelper = jwtHelper;
    }

    public async Task Register(RegisterRequest request)
    {
        var existingUser = await _context.Users
            .FirstOrDefaultAsync(x => x.Email == request.Email);

        if (existingUser != null)
        {
            throw new Exception("Bu email zaten kullanılıyor.");
        }

        var company = new Company
        {
            Name = request.CompanyName
        };

        _context.Companies.Add(company);

        var user = new User
        {
            Company = company,
            FullName = request.FullName,
            Email = request.Email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
            Role = UserRole.Admin
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();
    }

    public async Task<LoginResponse> Login(LoginRequest request)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(x => x.Email == request.Email);

        if (user == null)
        {
            throw new Exception("Bu email kullanımda değil.");
        }

        var isPasswordCorrect = BCrypt.Net.BCrypt.Verify(
            request.Password,
            user.PasswordHash);

        if (!isPasswordCorrect)
        {
            throw new Exception("Kullanıcı Adı veya Şifre yanlış!");
        }

        var token = _jwtHelper.GenerateToken(user);

        return new LoginResponse
        {
            Token = token,
            FullName = user.FullName,
            Email = user.Email,
            Role = user.Role.ToString()
        };
    }
}