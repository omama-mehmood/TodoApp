using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly List<TodoItem> _todos;
        private int _nextId;

        public TodoService()
        {
            _todos = new List<TodoItem>();
            _nextId = 1;
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todos;
        }

        public TodoItem GetById(int id)
        {
            return _todos.FirstOrDefault(t => t.Id == id);
        }

        public TodoItem Create(TodoItem todo)
        {
            todo.Id = _nextId++;
            todo.CreatedAt = DateTime.UtcNow;
            _todos.Add(todo);
            return todo;
        }

        public TodoItem Update(int id, TodoItem todo)
        {
            var existingTodo = GetById(id);
            if (existingTodo == null)
                return null;

            existingTodo.Title = todo.Title;
            existingTodo.Description = todo.Description;
            existingTodo.IsCompleted = todo.IsCompleted;

            if (todo.IsCompleted && existingTodo.CompletedAt == null)
                existingTodo.CompletedAt = DateTime.UtcNow;
            else if (!todo.IsCompleted)
                existingTodo.CompletedAt = null;

            return existingTodo;
        }

        public bool Delete(int id)
        {
            var todo = GetById(id);
            if (todo == null)
                return false;

            _todos.Remove(todo);
            return true;
        }
    }
}