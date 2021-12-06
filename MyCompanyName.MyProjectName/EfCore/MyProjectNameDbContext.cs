using Microsoft.EntityFrameworkCore;
using MyCompanyName.MyProjectName.Domain.Todos;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MyCompanyName.MyProjectName.EfCore;

[ConnectionStringName("Default")]
public class MyProjectNameDbContext : AbpDbContext<MyProjectNameDbContext>
{
    public DbSet<Todo> Todos { get; set; }
    
    public MyProjectNameDbContext(DbContextOptions<MyProjectNameDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Todo>(b =>
        {
            b.ToTable("Todos");
            
            b.ConfigureByConvention();

            b.Property(x => x.Name).IsRequired();
        });
    }
}