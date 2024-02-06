# .NET Core 8 Layered Architecture Template

## Overview

This project is built using C# .NET Core 8 and follows a layered architecture. It consists of the following main layers:

- **Core Layer**: Contains core application services, utilities, and shared functionality.

- **Business Layer**: Contains the application's business logic. Data validation, business processes, and other operations take place here.

- **Data Access Layer**: Responsible for interacting with the database. Access to the database, queries, and other data processing operations occur in this layer.

- **Entities**: Contains entity classes representing database tables.


## Running the Project

The project is developed with .NET Core 8 SDK. To run the project, follow these steps:

1. Clone the project to your machine.

    ```bash
    git@github.com:Trou95/NLayeredAppTemplate.git
    ```

2. Navigate to the project directory.

    ```bash
    cd <directory_name>
    ```

3. Run the application.

    ```bash
    dotnet run
    ```

4. View the application in your browser at [https://localhost:5001](https://localhost:5001).

## Requirements

- [.NET Core 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

