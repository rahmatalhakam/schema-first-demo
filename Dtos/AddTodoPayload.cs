

using SchemaFirstDemo.Models;

namespace SchemaFirstDemo.Dtos
{
  public class AddTodoPayload
  {
    public AddTodoPayload(Todo todo)
    {
      Todo = todo;
    }

    public Todo Todo { get; }
  }
}