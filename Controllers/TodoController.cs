using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController(ITodoService todoService) : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<TodoItem>> Get()
    {
        return Ok(todoService.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult<TodoItem> Get(int id)
    {
        var todo = todoService.GetById(id);
        if (todo == null)
            return NotFound();

        return Ok(todo);
    }

    [HttpPost]
    public ActionResult<TodoItem> Post([FromBody] TodoItem todo)
    {
        if (string.IsNullOrWhiteSpace(todo.Title))
            return BadRequest("Title is required");

        var createdTodo = todoService.Create(todo);
        return CreatedAtAction(nameof(Get), new { id = createdTodo.Id }, createdTodo);
    }

    [HttpPut("{id}")]
    public ActionResult<TodoItem> Put(int id, [FromBody] TodoItem todo)
    {
        if (string.IsNullOrWhiteSpace(todo.Title))
            return BadRequest("Title is required");

        var updatedTodo = todoService.Update(id, todo);
        if (updatedTodo == null)
            return NotFound();

        return Ok(updatedTodo);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var deleted = todoService.Delete(id);
        if (!deleted)
            return NotFound();

        return NoContent();
    }
}