# TodoApp - ASP.NET Core 3.1 REST API

A simple Todo API built with ASP.NET Core 3.1 that provides RESTful web services for managing todo items.

## Tech Stack

- **Framework**: ASP.NET Core 3.1
- **Language**: C# 9.0
- **Architecture**: RESTful API with MVC pattern
- **Documentation**: Swagger/OpenAPI 3.0
- **Storage**: In-memory (List<T>)
- **Dependency Injection**: Built-in ASP.NET Core DI container

## Features

- ✅ Full CRUD operations for Todo items
- ✅ RESTful API endpoints
- ✅ Swagger UI documentation
- ✅ Input validation
- ✅ Proper HTTP status codes
- ✅ Dependency injection pattern
- ✅ Service layer architecture

## API Endpoints

- `GET /api/todo` - Get all todos
- `GET /api/todo/{id}` - Get todo by ID
- `POST /api/todo` - Create new todo
- `PUT /api/todo/{id}` - Update existing todo
- `DELETE /api/todo/{id}` - Delete todo

## Getting Started

### Prerequisites
- .NET Core 3.1 SDK

### Running the Application
```bash
dotnet run
```

The API will be available at:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`
- Swagger UI: `https://localhost:5001` (root URL)

## Project Structure

```
TodoApp/
├── Controllers/
│   ├── TodoController.cs      # Main API controller
│   └── WeatherForecastController.cs
├── Models/
│   └── TodoItem.cs           # Data model
├── Services/
│   ├── ITodoService.cs       # Service interface
│   └── TodoService.cs        # Service implementation
├── Properties/
│   └── launchSettings.json
├── Program.cs                # Application entry point
├── Startup.cs               # DI and middleware configuration
└── TodoApp.csproj           # Project file
```

## Architecture Highlights

- **Separation of Concerns**: Controllers handle HTTP, Services handle business logic
- **Dependency Injection**: Loose coupling between components
- **Interface-Based Design**: ITodoService abstraction for testability
- **Model Validation**: Input validation with proper error responses
- **RESTful Design**: Standard HTTP methods and status codes