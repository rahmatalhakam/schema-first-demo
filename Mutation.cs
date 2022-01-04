using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;
using SchemaFirstDemo.Dtos;
using SchemaFirstDemo.Models;


namespace SchemaFirstDemo
{
  public class Mutation
  {
    public async Task<AddTodoPayload> AddTodoAsync(
        AddTodoInput input,
        [Service] TodoListContext context)
    {
      var todo = new Todo
      {
        Task = input.Task,
        Completed = input.Completed,
        Created_At = System.DateTime.Now
      };

      context.Todos.Add(todo);
      await context.SaveChangesAsync();

      return new AddTodoPayload(todo);
    }

    public async Task<AddTodoPayload> UpdateTodoAsync(int id,
        AddTodoInput input,
        [Service] TodoListContext context)
    {
      var result = context.Todos.Where(c => c.Id == id).FirstOrDefault();
      if (result != null)
      {
        result.Task = input.Task;
        result.Completed = input.Completed;
        await context.SaveChangesAsync();
      }


      // var todo = new Todo
      // {
      //   Id = result.Id,
      //   Task = result.Task,
      //   Completed = result.Completed,
      //   Created_At = result.Created_At
      // };
      return new AddTodoPayload(result);
    }

    public async Task<AddTodoPayload> DeleteTodoAsync(int id,
        [Service] TodoListContext context)
    {
      var result = context.Todos.Where(c => c.Id == id).FirstOrDefault();
      if (result != null)
      {
        context.Todos.Remove(result);
        await context.SaveChangesAsync();
      }
      // var todo = new Todo
      // {
      //   Id = result.Id,
      //   Task = result.Task,
      //   Completed = result.Completed,
      //   Created_At = result.Created_At
      // };

      // var obj = new DeleteTodoPayload
      // {
      //   result = $"Data id {id} berhasil didelete"
      // };
      return new AddTodoPayload(result);
    }
  }
}