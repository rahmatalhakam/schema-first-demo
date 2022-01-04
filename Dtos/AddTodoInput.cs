using System;

namespace SchemaFirstDemo.Dtos
{
  public record AddTodoInput(
      string Task,
      bool Completed
  );
}