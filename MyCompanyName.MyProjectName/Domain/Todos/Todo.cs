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
        Name = Check.NotNullOrWhiteSpace(name, nameof(name));
    }
}