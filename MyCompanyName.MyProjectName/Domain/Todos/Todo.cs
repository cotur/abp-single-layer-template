using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace MyCompanyName.MyProjectName.Domain.Todos;

public class Todo : Entity<Guid>
{
    public string Name { get; set; }

    protected Todo()
    {
    }

    public Todo(Guid id, [NotNull] string name) : base(id)
    {
        SetName(name);
    }

    public void SetName(string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name), TodoConsts.MaxNameLength, TodoConsts.MinNameLength);
    }
}