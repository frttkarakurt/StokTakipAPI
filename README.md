# StockTakipAPI

## 📌 Proje Hakkında

StockTakipAPI, küçük ve orta ölçekli işletmeler için geliştirilmekte olan modern bir Stok ve Ön Muhasebe Yönetim Sistemidir.

Projenin amacı;

* Ürün yönetimi
* Stok takibi
* Cari/Müşteri yönetimi
* Fatura işlemleri
* Kullanıcı ve yetkilendirme sistemi
* Raporlama

gibi işletmelerin temel ihtiyaçlarını tek bir platform üzerinden yönetebilmektir.

---

## 🚀 Kullanılan Teknolojiler

### Backend

* ASP.NET Core Web API
* Entity Framework Core
* PostgreSQL
* JWT Authentication
* BCrypt Password Hashing

### Mimari

* Controller Layer
* Service Layer
* DTO Pattern
* Entity Pattern
* Dependency Injection

---

## 📂 Proje Yapısı

```text
api
│
├── Controllers
├── Services
├── DTOs
├── Entities
├── Data
├── Helpers
└── Migrations
```

### Katmanlar

#### Controllers

HTTP isteklerini karşılar ve ilgili servislere yönlendirir.

#### Services

Uygulamanın iş kurallarını içerir.

#### DTOs

İstemci ile veri alışverişinde kullanılan nesnelerdir.

#### Entities

Veritabanı tablolarını temsil eder.

#### Data

Entity Framework DbContext sınıfını içerir.

---

## 🔐 Authentication Sistemi

Projede JWT tabanlı kimlik doğrulama kullanılmaktadır.

Özellikler:

* Kullanıcı Kaydı (Register)
* Kullanıcı Girişi (Login)
* BCrypt ile şifre hashleme
* JWT Token üretimi
* Yetkilendirme altyapısı

### Auth Endpointleri

```http
POST /api/auth/register
POST /api/auth/login
```

---

## 📋 Planlanan Modüller

### Kullanıcı Yönetimi

* Kullanıcı oluşturma
* Kullanıcı güncelleme
* Rol yönetimi

### Ürün Yönetimi

* Ürün ekleme
* Ürün güncelleme
* Ürün silme
* Ürün listeleme

### Stok Yönetimi

* Stok giriş
* Stok çıkış
* Stok hareket geçmişi

### Cari Yönetimi

* Cari oluşturma
* Cari güncelleme
* Cari listeleme

### Fatura Yönetimi

* Satış faturaları
* Alış faturaları
* Fatura geçmişi

### Raporlama

* Stok raporları
* Satış raporları
* Cari raporları

---

## 📈 Yol Haritası

### Aşama 1

* [x] ASP.NET Core Kurulumu
* [x] PostgreSQL Bağlantısı
* [x] Entity Yapılarının Oluşturulması
* [x] DTO Yapısının Kurulması
* [x] Service Katmanının Oluşturulması

### Aşama 2

* [ ] JWT Authentication
* [ ] Role Based Authorization
* [ ] Refresh Token

### Aşama 3

* [ ] Ürün Yönetimi
* [ ] Stok Yönetimi
* [ ] Cari Yönetimi

### Aşama 4

* [ ] Fatura Sistemi
* [ ] Dashboard
* [ ] Raporlama

### Aşama 5

* [ ] Docker
* [ ] CI/CD
* [ ] Production Deployment

---

## 👨‍💻 Geliştirici

Ferit Karakurt

Bilgisayar Mühendisliği öğrencisi olarak gerçek dünya problemlerini çözen yazılımlar geliştirmeyi hedefleyen bir backend geliştirici adayı.
