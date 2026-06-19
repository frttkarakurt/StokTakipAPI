namespace api.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public Company Company { get; set; } = null!;

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public UserRole Role { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
