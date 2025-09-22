# TodoApp - .NET 8 Edition (v2)

A modern, high-performance Todo API built with **ASP.NET Core 8.0** featuring the latest C# 12 language features and .NET 8 capabilities.

## 🚀 Features

- ✅ **ASP.NET Core 8.0** with minimal hosting model
- ✅ **C# 12 Language Features**: Primary constructors, collection expressions, required properties
- ✅ **Modern API Design** with OpenAPI 3.0 support
- ✅ **Thread-Safe Operations** using ConcurrentDictionary
- ✅ **Nullable Reference Types** for better code safety
- ✅ **File-Scoped Namespaces** for cleaner code structure
- ✅ **Implicit Using Directives** to reduce boilerplate
- ✅ **Enhanced Performance** with .NET 8 optimizations

## 📋 Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Any code editor (Visual Studio, VS Code, Rider, etc.)

## 🏃‍♂️ Quick Start

1. **Clone the repository**
   ```bash
   git clone https://github.com/omama-mehmood/TodoApp.git
   cd TodoApp
   git checkout upgrade-to-net8-v2
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Access the API**
   - Swagger UI: `https://localhost:7169` or `http://localhost:5169`
   - API Base URL: `https://localhost:7169/api/todo`

## 🔧 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/todo` | Get all todo items |
| `GET` | `/api/todo/{id}` | Get a specific todo item |
| `POST` | `/api/todo` | Create a new todo item |
| `PUT` | `/api/todo/{id}` | Update an existing todo item |
| `DELETE` | `/api/todo/{id}` | Delete a todo item |

## 📊 Data Model

```csharp
public class TodoItem
{
    public int Id { get; set; }
    
    [Required]
    public required string Title { get; set; }
    
    public string? Description { get; set; }
    
    public bool IsCompleted { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime? CompletedAt { get; set; }
}
```

## 🆕 .NET 8 Features Utilized

### **1. Primary Constructors**
```csharp
public class TodoController(ITodoService todoService) : ControllerBase
{
    // Simplified dependency injection
}
```

### **2. Collection Expressions**
```csharp
private readonly ConcurrentDictionary<int, TodoItem> _todos = [];
```

### **3. Required Properties**
```csharp
[Required]
public required string Title { get; set; }
```

### **4. Switch Expressions with Pattern Matching**
```csharp
existingTodo.CompletedAt = todo.IsCompleted switch
{
    true when !wasCompleted => DateTime.UtcNow,
    false => null,
    _ => existingTodo.CompletedAt
};
```

### **5. Minimal Hosting Model**
```csharp
var builder = WebApplication.CreateBuilder(args);
// Configure services...
var app = builder.Build();
// Configure pipeline...
app.Run();
```

## 🛠️ Development

### Building the Project
```bash
dotnet build
```

### Running Tests
```bash
dotnet test
```

### Publishing for Production
```bash
dotnet publish -c Release -o ./publish
```

## 📈 Performance Improvements

- **Thread-Safe Collections**: Using `ConcurrentDictionary` for better concurrency
- **Reduced Allocations**: Leveraging C# 12 features for more efficient memory usage
- **Native AOT Ready**: Compatible with .NET 8 Native AOT compilation
- **Optimized Startup**: Minimal hosting model reduces startup time

## 🔒 Security Features

- **Nullable Reference Types**: Helps prevent null reference exceptions
- **Input Validation**: Built-in model validation with data annotations
- **HTTPS Redirection**: Automatic HTTPS enforcement in production

## 🎯 Migration from .NET 3.1

This version represents a complete modernization from .NET Core 3.1:

### Key Changes:
- ✅ Upgraded from `netcoreapp3.1` → `net8.0`
- ✅ Replaced Startup.cs with minimal hosting pattern
- ✅ Added nullable reference types throughout
- ✅ Implemented primary constructors
- ✅ Used collection expressions
- ✅ Enhanced thread safety with concurrent collections
- ✅ Updated to latest package versions

### Breaking Changes:
- Startup.cs has been removed (functionality moved to Program.cs)
- Service signatures now use nullable reference types
- Some dependencies may require updates for consuming applications

## 📚 Additional Resources

- [.NET 8 Release Notes](https://docs.microsoft.com/en-us/dotnet/core/release-notes/8.0/)
- [C# 12 Language Features](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)
- [ASP.NET Core 8.0 Documentation](https://docs.microsoft.com/en-us/aspnet/core/)

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

**Built with ❤️ using .NET 8.0 and modern C# features**