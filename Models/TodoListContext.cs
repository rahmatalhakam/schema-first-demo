using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SchemaFirstDemo;
#nullable disable

namespace SchemaFirstDemo.Models
{
  public partial class TodoListContext : DbContext
  {
    public TodoListContext()
    {
    }

    public TodoListContext(DbContextOptions<TodoListContext> options)
        : base(options)
    {
    }

    public DbSet<Todo> Todos { get; set; }

  }
}
