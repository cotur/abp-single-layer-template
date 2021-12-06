using Microsoft.AspNetCore.Mvc;
using MyCompanyName.MyProjectName.Domain.Todos;
using Volo.Abp.AspNetCore.Mvc;

namespace MyCompanyName.MyProjectName.Controllers.Todos;

[Route("todo")]
public class TodoController : AbpController
{
    public List<Todo> GetList()
    {
        return new List<Todo>
        {
            new(GuidGenerator.Create(), "Todo 1"),
            new(GuidGenerator.Create(), "Todo 2"),
            new(GuidGenerator.Create(), "Todo 3")
        };
    }
}