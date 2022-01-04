using System;
using System.Collections.Generic;

#nullable disable

namespace SchemaFirstDemo.Models
{
  public partial class Todo
  {
    public int Id { get; set; }
    public string Task { get; set; }
    public Boolean Completed { get; set; }
    public DateTime? Created_At { get; set; }
  }
}
