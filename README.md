# QuickSale

A Windows desktop Point of Sale (POS) application built with C# and Windows Forms (.NET 9).

## Features

- **Products** — manage inventory with categories and stock levels
- **New Sale** — ring up items with a fast checkout flow (press **F2** anywhere to jump straight to New Sale)
- **Customers** — store customer contact information
- **Reports** — view sales summaries and history
- **Users** — admin-only user management with role-based access (Admin / Cashier)

## Tech Stack

| Layer | Technology |
|-------|-----------|
| UI | Windows Forms (.NET 9) |
| Business Logic | Class Library (QuickSale.BLL) |
| Data Access | Entity Framework Core + SQLite (QuickSale.DAL) |

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Windows 10/11

### Run

```bash
git clone https://github.com/Dotzy2482/QuickSale.git
cd QuickSale
dotnet run --project 20240305307_QuickSale
```

The SQLite database (`quicksale.db`) is created automatically on first launch with seed data.

## Default Credentials

| Role | Username | Password |
|------|----------|----------|
| Admin | `admin` | `admin123` |
| Cashier | `cashier` | `cashier123` |

## Project Structure

```
QuickSale/
├── 20240305307_QuickSale/   # WinForms UI project
├── QuickSale.BLL/           # Business Logic Layer
│   └── Managers/            # UserManager, ProductManager, SaleManager, CustomerManager
└── QuickSale.DAL/           # Data Access Layer
    ├── Models/              # EF Core entity models
    ├── Repositories/        # Repository pattern implementations
    └── Migrations/          # EF Core migrations
```

## Keyboard Shortcuts

| Key | Action |
|-----|--------|
| `F2` | Open New Sale screen |
