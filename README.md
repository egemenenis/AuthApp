# AuthApp

AuthApp is an ASP.NET Core application that provides JWT-based authentication for user registration and login. This application allows users to register and log in, and provides JWT tokens to authenticated users.

## Project Structure

### 1. `AuthController`
- A controller that manages user registration and login operations.
- When a user registers, a new user is created based on the provided `RegisterModel`.
- Upon a successful login, a JWT token is generated and sent to the user.

### 2. `TokenService`
- A service that generates JWT tokens.
- It creates a JWT token using the username and returns it to the user.

## Requirements

To run this project, the following requirements must be met:

- .NET 6 or later version.
- Microsoft SQL Server or a compatible database.

## Getting Started

Before you start the project, follow these steps:

###  Edit the `appsettings.json` File

You need to add the database connection string to the `appsettings.json` file used in the project.

Open the `appsettings.json` file and update the connection string as follows:

```json
{
  "ConnectionStrings": {
    "AuthConnString": "Server={SERVER_NAME};Database={DATABASE_NAME};Trusted_Connection=True;"
  },
}

Replace {SERVER_NAME} with the name of your database server.
Replace {DATABASE_NAME} with the name of your database. 
```


### Add Migration and Update Database
If you are running the project for the first time, you will need to update the database by running the Entity Framework Core migration commands.

Run the following commands in the terminal or command prompt to add the migration and update the database:

#### Add the migration:
```
dotnet ef migrations add InitialCreate
```

#### Update the database:
```
dotnet ef database update
```

### Running the Application
To run the project, follow these steps:

Open the terminal or command prompt in the project directory.

Run the following command to start the application:
```
dotnet run
```


## API Endpoints
#### User Registration (POST /api/auth/register)
To register a new user, send a POST request to the following endpoint:
```
URL:
POST /api/auth/register

Body:
{
  "username": "yourusername",
  "email": "youremail@example.com",
  "password": "yourpassword123"
}

A successful response will be:
{
  "message": "User registered successfully."
}
```

#### User Login (POST /api/auth/login)
To log in as a user, send a POST request to the following endpoint:

```
URL:
POST /api/auth/login

Body:
{
  "username": "yourusername",
  "password": "yourpassword123"
}

A successful response will be:
{
  "token": "JWT_TOKEN_HERE"
}
```

### Technologies Used
```
ASP.NET Core 8
ASP.NET Core Identity
Entity Framework Core
JWT (JSON Web Token)
SQL Server
```
---

## **Contact**

For questions, suggestions, or any problems, feel free to contact me:

- **Email**: [enis.egemen25@gmail.com](mailto:enis.egemen25@gmail.com)

---

Thank you for discovering **AuthApp Platform**!
