using TodoApp.Models;

namespace TodoApp.Services;

public interface ITodoService
{
    IEnumerable<TodoItem> GetAll();
    TodoItem? GetById(int id);
    TodoItem Create(TodoItem todo);
    TodoItem? Update(int id, TodoItem todo);
    bool Delete(int id);
}