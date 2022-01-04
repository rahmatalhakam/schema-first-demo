using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using SchemaFirstDemo.Models;

namespace SchemaFirstDemo
{
  public class Query
  {
    public IQueryable<Todo> GetTodos([Service] TodoListContext context) =>
        context.Todos;
    public IQueryable<Todo> GetTodoById(int id, [Service] TodoListContext context) =>
         context.Todos.Where(t => t.Id == id).AsQueryable();
  }
}