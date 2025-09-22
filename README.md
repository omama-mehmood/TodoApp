# Todo API - .NET 6

A simple and modern Todo API built with **ASP.NET Core 6.0** featuring minimal hosting, nullable reference types, and clean architecture patterns.

## 🚀 Features

- ✅ **ASP.NET Core 6.0** with minimal hosting pattern
- ✅ **Nullable Reference Types** for better null safety
- ✅ **File-scoped namespaces** for cleaner code
- ✅ **Implicit usings** for reduced boilerplate
- ✅ **RESTful API** with full CRUD operations
- ✅ **Swagger/OpenAPI** documentation
- ✅ **Dependency Injection** for services
- ✅ **In-memory data storage** for simplicity

## 🔧 Tech Stack

- **Framework**: .NET 6.0
- **Web Framework**: ASP.NET Core 6.0
- **Documentation**: Swagger/OpenAPI 3.0
- **Architecture**: Clean Architecture with separation of concerns

## 📋 Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later
- Any IDE that supports .NET 6 (Visual Studio 2022, VS Code, JetBrains Rider)

## 🏃‍♂️ Getting Started

### Clone the repository
```bash
git clone https://github.com/omama-mehmood/TodoApp.git
cd TodoApp
```

### Run the application
```bash
dotnet restore
dotnet run
```

The API will be available at:
- **HTTPS**: `https://localhost:7169`
- **HTTP**: `http://localhost:5169`
- **Swagger UI**: `https://localhost:7169` (root path)

## 📚 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/todo` | Get all todos |
| `GET` | `/api/todo/{id}` | Get a specific todo |
| `POST` | `/api/todo` | Create a new todo |
| `PUT` | `/api/todo/{id}` | Update an existing todo |
| `DELETE` | `/api/todo/{id}` | Delete a todo |

## 📝 API Usage Examples

### Create a Todo
```bash
curl -X POST "https://localhost:7169/api/todo" \
     -H "Content-Type: application/json" \
     -d '{
       "title": "Learn .NET 6",
       "description": "Study the new features in .NET 6",
       "isCompleted": false
     }'
```

### Get All Todos
```bash
curl -X GET "https://localhost:7169/api/todo"
```

### Update a Todo
```bash
curl -X PUT "https://localhost:7169/api/todo/1" \
     -H "Content-Type: application/json" \
     -d '{
       "title": "Learn .NET 6",
       "description": "Study the new features in .NET 6",
       "isCompleted": true
     }'
```

## 🏗️ Project Structure

```
TodoApp/
├── Controllers/
│   └── TodoController.cs       # API endpoints
├── Models/
│   └── TodoItem.cs            # Data model
├── Services/
│   ├── ITodoService.cs        # Service interface
│   └── TodoService.cs         # Service implementation
├── Properties/
│   └── launchSettings.json    # Launch configuration
├── Program.cs                 # Application entry point (minimal hosting)
├── TodoApp.csproj            # Project file
└── appsettings.json          # Configuration
```

## 🆕 .NET 6 Features Used

### Minimal Hosting Pattern
```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// Configuration in Program.cs only
```

### File-scoped Namespaces
```csharp
namespace TodoApp.Models;

public class TodoItem
{
    // Class implementation
}
```

### Nullable Reference Types
```csharp
public string Title { get; set; } = string.Empty;
public string? Description { get; set; }
```

### Implicit Usings
Enabled in the project file to reduce using statements.

## 🧪 Testing

Run the application and test the endpoints using:

1. **Swagger UI** - Navigate to the root URL when running
2. **Postman** - Import the API and test endpoints
3. **curl** - Use the examples provided above

## 🔄 Migration from .NET Core 3.1

This project has been upgraded from .NET Core 3.1 to .NET 6.0 with the following changes:

1. ✅ Updated target framework to `net6.0`
2. ✅ Migrated from `Startup.cs` to minimal hosting pattern
3. ✅ Added nullable reference types
4. ✅ Implemented file-scoped namespaces
5. ✅ Enabled implicit usings
6. ✅ Updated Swashbuckle to version 6.2.3

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

## 🙋‍♂️ Support

If you have any questions or need help, please open an issue in the GitHub repository.