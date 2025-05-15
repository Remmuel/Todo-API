using System.ComponentModel.DataAnnotations.Schema;

namespace TodoAPI.Models
{
    public class TodoItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Completed {get; set;}
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }

    public class TodoDTO
    {
        public string? Name { get; set; }
        public bool Completed { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}


