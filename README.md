# WeFSTE Blog Application

This is an ASP.NET Core MVC web application built with Entity Framework Core and Identity for user management. It targets **.NET 8.0**.

WeFSTE is a blogging platform for FSTE students and professors, enabling content sharing, user roles, and comments.


## 🛠 Requirements

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- SQL Server
- Visual Studio 2022+ or any code editor (e.g., VS Code with C# extension)
- Internet connection (for restoring NuGet packages)

## 🚀 Getting Started

### 1. Clone the repository
```
git clone https://github.com/MohamedAgdid/WeFSTE.git
cd WeFSTE
```

### 2. Restore dependencies and build the project
``` dotnet build  ```

This will:

Restore all required NuGet packages

Compile the project


## 3. Database Setup

### Step 1: Create the database manually

Using **SQL Server Management Studio (SSMS)**, run:

```sql
CREATE DATABASE wefsteDB;
```

### Step 2: Update Connection String

In `appsettings.json`, update the `DefaultConnection` string to match your SQL Server instance name.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SQL_SERVER_NAME;Database=wefsteDB;"
}
```

### Step 3: Apply Entity Framework Core migrations
Open Package Manager Console (PMC) in Visual Studio:

```
Add-Migration CreateInitialDatabaseTable
Update-Database
```

```
Add-Migration SeedingInitialData
Update-Database

```

## 4. Run the project
```
dotnet run

```

## 5. Test Users

To help you test the application, the database seeds two default users with these credentials:

| Role  | Email             | Password    |
|-------|-------------------|-------------|
| Admin | admin@wefste.com  | Admin@123   |
| User  | user@wefste.com   | User@123    |

- **Admin** has full privileges.
- **User** has limited access.


## Notes
This project uses the following packages:

``` bash
Microsoft.EntityFrameworkCore.SqlServer

Microsoft.AspNetCore.Identity.EntityFrameworkCore

Microsoft.IdentityModel.Tokens and JWT support

System.Text.Json
```

## Mohamed Agdid

Feel free to contribute or report issues.
