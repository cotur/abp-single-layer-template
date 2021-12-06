using Microsoft.AspNetCore.Mvc;
using MyCompanyName.MyProjectName.Domain.Todos;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Domain.Repositories;

namespace MyCompanyName.MyProjectName.Controllers.Todos;

[Route("todo")]
public class TodoController : AbpController
{
    private readonly IRepository<Todo, Guid> _todoRepository;

    public TodoController(IRepository<Todo, Guid> todoRepository)
    {
        _todoRepository = todoRepository;
    }

    [HttpGet]
    public async Task<List<Todo>> GetListAsync()
    {
        return await _todoRepository.GetListAsync();
    }

    [HttpGet("{id:guid}")]
    public async Task<Todo> GetAsync(Guid id)
    {
        var todo = await _todoRepository.GetAsync(id);

        return todo;
    }

    [HttpPost]
    public async Task<Todo> CreateAsync(string name)
    {
        var todo = new Todo(GuidGenerator.Create(), name);

        await _todoRepository.InsertAsync(todo);

        return todo;
    }
    
    [HttpPut("{id:guid}")]
    public async Task<Todo> CreateAsync(Guid id, string name)
    {
        var todo = await _todoRepository.GetAsync(id);

        todo.SetName(name);

        await _todoRepository.UpdateAsync(todo);

        return todo;
    }
    
    [HttpDelete("{id:guid}")]
    public Task DeleteAsync(Guid id)
    {
        return _todoRepository.DeleteAsync(id);
    }
}