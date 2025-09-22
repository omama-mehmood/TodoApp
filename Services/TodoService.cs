using System.Collections.Concurrent;
using TodoApp.Models;

namespace TodoApp.Services;

public class TodoService : ITodoService
{
    private readonly ConcurrentDictionary<int, TodoItem> _todos = [];
    private int _nextId = 1;

    public IEnumerable<TodoItem> GetAll()
    {
        return _todos.Values.OrderBy(t => t.CreatedAt);
    }

    public TodoItem? GetById(int id)
    {
        return _todos.TryGetValue(id, out var todo) ? todo : null;
    }

    public TodoItem Create(TodoItem todo)
    {
        var id = Interlocked.Increment(ref _nextId);
        var newTodo = new TodoItem
        {
            Id = id,
            Title = todo.Title,
            Description = todo.Description,
            IsCompleted = false,
            CreatedAt = DateTime.UtcNow
        };
        
        _todos[id] = newTodo;
        return newTodo;
    }

    public TodoItem? Update(int id, TodoItem todo)
    {
        if (!_todos.TryGetValue(id, out var existingTodo))
            return null;

        existingTodo.Title = todo.Title;
        existingTodo.Description = todo.Description;
        
        var wasCompleted = existingTodo.IsCompleted;
        existingTodo.IsCompleted = todo.IsCompleted;

        // Update completion timestamp
        existingTodo.CompletedAt = todo.IsCompleted switch
        {
            true when !wasCompleted => DateTime.UtcNow,
            false => null,
            _ => existingTodo.CompletedAt
        };

        return existingTodo;
    }

    public bool Delete(int id)
    {
        return _todos.TryRemove(id, out _);
    }
}