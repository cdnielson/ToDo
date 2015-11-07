using System.Data.Entity;

namespace ToDo.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }
        public string Item { get; set; }
        public bool Completed { get; set; }
    }

    public class ToDoDBContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}