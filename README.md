# QuickSale — Point of Sale System

A fully-featured Windows desktop **Point of Sale (POS)** application built with **C# / Windows Forms on .NET 9**. Manages products, inventory, sales, customers, invoices, and users — everything a small retail store needs at the register.

---

## Table of Contents

- [Features](#features)
- [Screenshots](#screenshots)
- [Tech Stack](#tech-stack)
- [Architecture](#architecture)
- [Project Structure](#project-structure)
- [Database Schema](#database-schema)
- [Getting Started](#getting-started)
- [Default Credentials](#default-credentials)
- [Keyboard Shortcuts](#keyboard-shortcuts)
- [Assignment Requirements](#assignment-requirements)

---

## Features

| Module | What it does |
|--------|-------------|
| **Login** | Secure login with SHA-256 hashed passwords, role-based access (Admin / Cashier) |
| **Products** | Add, edit, delete products with categories and live stock levels |
| **New Sale** | Fast checkout — search/add items, set quantities, apply discounts, complete sale, print invoice |
| **Customers** | Store and search customer contact information, view purchase history |
| **Reports** | Sales summaries filtered by date range, revenue totals, best-selling products |
| **Users** | Admin-only user management — create, edit, delete cashier/admin accounts |
| **Invoices** | Auto-generated invoice per sale with line items and totals |
| **Register** | Self-service account creation screen |

---

## Screenshots

> Run the app to see it in action — login with `admin / admin123`

---

## Tech Stack

| Layer | Technology | Details |
|-------|-----------|---------|
| UI | **Windows Forms** | .NET 9, custom-painted controls, dark sidebar navigation |
| Business Logic | **C# Class Libraries** | Separation via BLL (QuickSale.BLL) |
| Data Access | **Entity Framework Core 9** | Code-first, repository pattern |
| Database | **SQLite** | File-based, zero config, auto-created on first run |
| ORM | **EF Core Migrations** | Schema versioned, seeded with demo data |
| Password Security | **SHA-256** | `System.Security.Cryptography` — no plaintext passwords stored |

---

## Architecture

```
┌─────────────────────────────────────────────┐
│              UI Layer (WinForms)             │
│  frmLogin  frmMain  frmProducts  frmNewSale  │
│  frmCustomers  frmReports  frmUsers  ...     │
└─────────────────┬───────────────────────────┘
                  │ calls
┌─────────────────▼───────────────────────────┐
│         Business Logic Layer (BLL)           │
│  UserManager   ProductManager               │
│  SaleManager   CustomerManager              │
└─────────────────┬───────────────────────────┘
                  │ calls
┌─────────────────▼───────────────────────────┐
│         Data Access Layer (DAL)              │
│  Repository<T>   UserRepository             │
│  ProductRepository  SaleRepository          │
│  AppDbContext  (Entity Framework Core)      │
└─────────────────┬───────────────────────────┘
                  │
┌─────────────────▼───────────────────────────┐
│            SQLite Database                   │
│            quicksale.db                      │
└─────────────────────────────────────────────┘
```

---

## Project Structure

```
20240305307_QuickSale/          ← Solution root
│
├── 20240305307_QuickSale/      ← WinForms UI project
│   ├── Program.cs              ← Entry point; initialises DB then opens frmLogin
│   ├── Session.cs              ← Static session holder (CurrentUser, IsAdmin)
│   ├── frmLogin.cs/.Designer   ← Login screen with demo credentials box
│   ├── frmMain.cs/.Designer    ← Shell: dark sidebar nav + content panel
│   ├── frmProducts.cs          ← Product list with search and CRUD buttons
│   ├── frmProductEdit.cs       ← Add/Edit product dialog
│   ├── frmNewSale.cs           ← Checkout / POS screen (F2 shortcut)
│   ├── frmCustomers.cs         ← Customer list with search
│   ├── frmCustomerEdit.cs      ← Add/Edit customer dialog
│   ├── frmReports.cs           ← Date-range sales report
│   ├── frmUsers.cs             ← Admin-only user list
│   ├── frmUserEdit.cs          ← Add/Edit user dialog
│   ├── frmInvoice.cs           ← Invoice viewer
│   └── frmRegister.cs          ← New account registration
│
├── QuickSale.BLL/              ← Business Logic Layer
│   └── Managers/
│       ├── UserManager.cs      ← Login, add/update/delete users, SHA-256 hashing
│       ├── ProductManager.cs   ← Product CRUD, stock check, low-stock query
│       ├── SaleManager.cs      ← Create sale, deduct stock, generate invoice
│       └── CustomerManager.cs  ← Customer CRUD and multi-field search
│
└── QuickSale.DAL/              ← Data Access Layer
    ├── AppDbContext.cs         ← EF Core DbContext, relationships, seed data
    ├── DatabaseInitializer.cs  ← Called at startup: ctx.Database.Migrate()
    ├── Models/                 ← Entity classes
    │   ├── User.cs
    │   ├── Product.cs
    │   ├── Category.cs
    │   ├── Customer.cs
    │   ├── Sale.cs
    │   ├── SaleItem.cs
    │   └── Invoice.cs
    ├── Interfaces/             ← IRepository<T>, IUserRepository, etc.
    ├── Repositories/           ← Concrete EF Core repository implementations
    └── Migrations/             ← EF Core auto-generated migration files
```

---

## Database Schema

```
Categories          Products
──────────          ────────────────────────
CategoryId (PK)◄──  CategoryId (FK, RESTRICT)
Name                ProductId (PK)
                    Name | Price | Stock

Users               Sales                    Customers
─────               ─────────────────────    ─────────
UserId (PK)◄──┐     SaleId (PK)              CustomerId (PK)◄─┐
Username       │     Date | Total | Discount  Name | Phone       │
PasswordHash   └──── UserId (FK, RESTRICT)    Email              │
Role                 CustomerId (FK) ─────────┘                  │
                     └────────────────────────────────────────────┘

SaleItems           Invoices
─────────────────   ────────────────
SaleItemId (PK)     InvoiceId (PK)
SaleId (FK, CASCADE)►Sale         SaleId (FK, CASCADE, 1:1)
ProductId (FK)      IssuedAt
Quantity | UnitPrice TotalAmount
```

---

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Windows 10 or 11

### Clone and Run

```bash
git clone https://github.com/Dotzy2482/QuickSale.git
cd QuickSale
dotnet run --project 20240305307_QuickSale
```

The SQLite database (`quicksale.db`) is **automatically created** on first launch with seed data (demo products, categories, and users).

---

## Default Credentials

| Role | Username | Password | Access |
|------|----------|----------|--------|
| Admin | `admin` | `admin123` | Full access including Users screen |
| Cashier | `cashier` | `cashier123` | Sales, Products, Customers, Reports |

> Passwords are stored as SHA-256 hashes — never in plaintext.

---

## Keyboard Shortcuts

| Key | Action |
|-----|--------|
| `F2` | Jump to New Sale screen from anywhere |
| `Enter` | Submit login form |

---

## Assignment Requirements

This section maps each course requirement to the exact implementation.

### a. GUI/WebForm with at least 3 active forms

**12 Windows Forms implemented:**

| Form | Purpose |
|------|---------|
| `frmLogin` | Authentication screen |
| `frmMain` | Application shell with sidebar navigation |
| `frmProducts` | Product inventory list |
| `frmProductEdit` | Add / edit product |
| `frmNewSale` | POS checkout screen |
| `frmCustomers` | Customer directory |
| `frmCustomerEdit` | Add / edit customer |
| `frmReports` | Sales reports |
| `frmUsers` | User management (Admin only) |
| `frmUserEdit` | Add / edit user |
| `frmInvoice` | Invoice viewer |
| `frmRegister` | New account registration |

---

### b. At least two Classes implementing business logic

**4 Manager classes in `QuickSale.BLL/Managers/`:**

| Class | Business Logic |
|-------|---------------|
| `UserManager` | Login with SHA-256 hash verification, add/update/delete users, role validation |
| `ProductManager` | Product CRUD, stock availability check before sale, low-stock threshold query |
| `SaleManager` | Create complete sale transaction — validates stock, deducts inventory, calculates totals, creates invoice |
| `CustomerManager` | Customer CRUD, multi-field search (name + phone + email) |

**7 Entity model classes in `QuickSale.DAL/Models/`:** `User`, `Product`, `Category`, `Customer`, `Sale`, `SaleItem`, `Invoice`

---

### c. LINQ — at least one array or collection with LINQ

LINQ is used extensively throughout the data and business layers:

```csharp
// ProductManager.cs — filter + sort with LINQ
return _productRepo.GetAll()
    .Where(p => p.Stock <= threshold)
    .OrderBy(p => p.Stock)
    .ToList();

// CustomerManager.cs — multi-field search
return _customerRepo.GetAll()
    .Where(c => c.Name.ToLower().Contains(kw)
             || c.Phone.ToLower().Contains(kw)
             || c.Email.ToLower().Contains(kw))
    .ToList();

// SaleManager.cs — aggregate sum
var totalRevenue = sales.Sum(s => s.Total);

// SaleRepository.cs — date range + eager loading
return _ctx.Sales
    .Include(s => s.SaleItems).ThenInclude(si => si.Product)
    .Where(s => s.Date >= start && s.Date < end)
    .OrderBy(s => s.Date)
    .ToList();

// UserRepository.cs — credential validation
return _ctx.Users.Any(u => u.Username == username
                         && u.PasswordHash == hash);
```

**LINQ operators used:** `.Where()`, `.Select()`, `.OrderBy()`, `.OrderByDescending()`, `.FirstOrDefault()`, `.Any()`, `.Sum()`, `.ToList()`, `.Include()`, `.ThenInclude()`

---

### d. Database using Entity Framework Core

- `AppDbContext : DbContext` in `QuickSale.DAL/AppDbContext.cs`
- SQLite database: `quicksale.db` (auto-created via `ctx.Database.Migrate()`)
- 7 `DbSet<T>` properties (Categories, Products, Customers, Users, Sales, SaleItems, Invoices)
- Cascade/Restrict delete behaviours explicitly configured
- Seed data: demo categories, products, users, and a default walk-in customer
- Migration file: `QuickSale.DAL/Migrations/20260422194711_InitialCreate.cs`

---

### e. Submitted in zip/rar at OIS-LMS & GitHub

- **GitHub:** https://github.com/Dotzy2482/QuickSale
- **OIS-LMS:** submitted as `20240305307_QuickSale.zip`
