# Recipe App

A simple ASP.NET Core MVC application designed to manage and organize recipes, ingredients, and categories. This project leverages Entity Framework Core for a **Code-First** approach to database management, streamlining the process of building the database schema directly from the application's C# models.



## Prerequisites

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any other compatible database)

## 📋 Features

* **Recipe Management**: View, create, edit, and delete recipes.
* **Ingredient Management**: Full CRUD operations for managing a list of ingredients.
* **Category Management**: Manage categories to organize recipes.

## 🛠️ Technology Stack

* **ASP.NET Core MVC**: The web framework used to build the application.
* **Entity Framework Core (EF Core)**: An object-relational mapper (ORM) for interacting with the database.
* **SQL Server**: The relational database used to store application data.
* **C#**: The primary programming language.
* **Bootstrap**: Used for styling and responsive design.

## 📂 Project Structure

* `Controllers/`: Contains the MVC controllers that handle user requests.
* `Data/`: Holds the `RecipeDbContext` class for database interaction.
* `Migrations/`: Automatically generated files that manage database schema changes.
* `Models/`: Defines the C# classes that represent the database tables (`Recipe`, `Ingredient`, `Category`).
* `Views/`: Contains the Razor views for the user interface.

## 📈 Development Process

This project was built using a **Code-First** approach with Entity Framework Core.

1.  **Model Creation**: C# classes (`Recipe`, `Ingredient`, `Category`) were defined to represent the data structure.
2.  **DbContext Setup**: A `RecipeDbContext` class was created to act as the bridge to the database.
3.  **Migrations**: The initial database schema was generated using the following commands:
    * `dotnet ef migrations add InitialCreate`
    * `dotnet ef database update`
4.  **Scaffolding**: CRUD controllers and views for the `Ingredient` model were automatically generated using `dotnet aspnet-codegenerator`.
5.  **Ongoing Work**: Currently, we are integrating navigation links in `_Layout.cshtml` to improve user experience.


---

**Author:** Hija Happy
