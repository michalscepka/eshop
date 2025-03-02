# Eshop WebApi Application Setup

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
  > Alternatively, use a Dockerized container
- [Docker](https://docs.docker.com/desktop/setup/install/windows-install/)
- IDE of your choice
  > Examples: JetBrains Rider, Visual Studio 2022, Visual Studio Code, etc.

## Getting Started

### 1. Set up the Database Server

- **Using Docker**  
  If you prefer Docker, run the database container with the following command:
    ```shell
    docker compose -f docker-compose.local.yaml up eshop-db
    ```

- **Using Local MSSQL Server**  
  If you're using MSSQL Server locally, update the connection strings in the following files:
    - `Eshop.Api\appsettings.Development.json`
    - `Eshop.Migrations\appsettings.Development.json`

  Replace the existing connection string with your local server's connection string.
  > Default connection string example: `Source=.;Initial Catalog=EshopDb;Integrated Security=True`

### 2. Apply Migrations

- **Using IDE**  
  Run the `Eshop.Migrations` project.

- **Using Terminal**  
  Navigate to the `.\src\Eshop.Migrations` folder and run:
    ```shell
    dotnet run
    ```

### 3. Run the WebApi Project

- **Using IDE**  
  Run the `Eshop.Api` project.

- **Using Terminal**  
  Navigate to the `.\src\Eshop.Api` folder and run:
    ```shell
    dotnet run
    ```

## Creating a New Migration

1. Navigate to the `.\src\Eshop.Migrations` folder.
2. Run the following command:
    ```shell
    dotnet ef migrations add <MIGRATION_NAME> --project "..\..\src\Eshop.Infrastructure.Persistence"
    ```

## Running Unit Tests

- **Using IDE**  
  Use the Test Explorer in your IDE.

- **Using Terminal**  
  Navigate to the `.\src\Eshop.Api` folder and run:
    ```shell
    dotnet test
    ```
