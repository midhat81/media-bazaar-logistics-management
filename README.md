# Media Bazaar Logistics Management System

A full-stack logistics management system built with **C# and .NET 8** for managing employees, departments, inventory, restocking, scheduling, availability, contracts, emergency contacts, and role-based access.

## Overview

The system provides both a **Windows Forms desktop application** and an **ASP.NET Core Razor Pages web application** backed by a layered architecture and SQL Server database.

The project is organized to keep the presentation, business logic, data access, and data-transfer responsibilities separated while reusing the existing application and database model.

## Key Features

- Role-based authentication and authorization
- Employee management
- Department management
- Product and inventory management
- Stock tracking
- Restocking requests
- Employee worksheets and scheduling
- Availability management
- Contract management
- Emergency contact management
- Administrative workforce statistics
- Web-based administration dashboard
- Windows Forms desktop application

## Dashboard

The web administration dashboard provides an overview of workforce and inventory activity using the existing application data.

Current dashboard metrics include:

- Active employees
- Employees hired during different time periods
- Deactivated employees
- Employees fired during different time periods
- Total products
- Total units in stock
- Products currently in stock
- Products currently out of stock
- Employee activity visualization
- Employee directory

The dashboard is designed to consume the existing business and data-access layers rather than introducing a separate data model.

## Technology Stack

### Backend

- C#
- .NET 8
- ASP.NET Core Razor Pages
- Windows Forms
- SQL Server
- ADO.NET / System.Data.SqlClient
- BCrypt password hashing

### Frontend

- Razor Pages
- HTML5
- CSS3
- Bootstrap
- JavaScript
- Chart.js

### Architecture

- Presentation Layer
- Business Logic Layer
- Data Access Layer
- DTO Layer
- SQL Server database

## Project Structure

```text
MediaBazaar/
├── MediaBazaar/
│   └── Windows Forms desktop application
├── MediaBazaarWebsite/
│   └── ASP.NET Core Razor Pages web application
├── BusinessLogicLayer/
│   └── Application managers and business operations
├── DataAccessLayer/
│   └── SQL Server data-access classes
├── DTOLayer/
│   └── Data transfer objects
├── Documentation/
├── UML/
└── img/
```

## Database

The application uses a SQL Server database containing the existing logistics data model.

The repository includes database schema documentation under:

```text
MediaBazaar/DataAccessLayer/DB_Schematic.txt
```

The database layer contains entities and relationships for areas such as:

- Employees
- Contracts
- Departments
- Products
- Stock
- Restocking
- Availability
- Employee worksheets
- Roles
- Working times
- Emergency contacts

**Important:** The application is intended to work with the existing database model. Database structure and production data should not be modified as part of dashboard/UI development.

## Authentication

The application includes role-based access control and cookie-based authentication for the web application.

Different application roles can access functionality appropriate to their responsibilities.

## Running the Web Application

From the repository root:

```powershell
cd .\MediaBazaar\MediaBazaarWebsite
dotnet run
```

The web application will start using the ASP.NET Core development server.

If the configured SQL Server instance is unavailable, the application may fail when services attempt to load database-backed data. In that case, verify the required SQL Server connectivity and configuration before troubleshooting the application code.

## Development

Restore dependencies and build the web project with:

```powershell
cd .\MediaBazaar\MediaBazaarWebsite
dotnet restore
dotnet build
```

Run the application with:

```powershell
dotnet run
```

For desktop development, open the solution in Visual Studio with the required .NET and Windows Forms tooling installed.

## Development Principles

The project is being modernized incrementally while preserving the existing application architecture.

Current principles:

- Preserve the existing database model
- Reuse existing DAL, BLL, and DTO functionality
- Avoid unnecessary schema changes
- Keep desktop and web applications available
- Improve the web dashboard incrementally
- Make focused, reviewable changes
- Keep existing business functionality intact

## Future Improvements

Potential improvements include:

- More detailed inventory analytics
- Restocking analytics
- Workforce trends
- Improved dashboard filtering
- Advanced reporting
- Better validation and error handling
- Improved configuration and secret management
- Additional automated tests
- Performance improvements for data-access operations
- Further UI modernization

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.
