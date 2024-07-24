# .NET 8 MVC Project with Entity Framework and SQLite

This is a simple ASP.NET Core MVC application built using .NET 8. The project demonstrates basic CRUD (Create, Read, Update, Delete) operations using Entity Framework Core with SQLite as the database provider.

## Features

- **MVC Architecture**: Utilizes the Model-View-Controller pattern for separation of concerns and clean code organization.
- **Entity Framework Core**: Leverages EF Core for database access, providing an easy-to-use and powerful ORM.
- **SQLite Database**: Uses SQLite for a lightweight and cross-platform database solution.
- **CRUD Operations**: Implements basic Create, Read, Update, and Delete functionality.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQLite3](https://www.sqlite.org/download.html)
- [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/) (optional)

## Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-username/your-repository.git
   cd your-repository
2. **Build the project:**
    ```bash
    dotnet build
3. **Apply migrations:**
    ```bash
    dotnet ef database update
4. **Run the aplication:**
    ```bash
    dotnet run
5. **Access the application:**
    ```bash
    https://localhost:specified_port

## Project Structure
- **Controllers**: Contains the MVC controllers responsible for handling user input and returning responses.
- **Models**: Includes the data models and entities representing the database schema.
- **Views**: Holds the Razor views used to render the HTML pages for the application.
- **Data**: Contains the DbContext class for managing database interactions.
- **Migrations**: Holds the Entity Framework migrations for database schema changes.
