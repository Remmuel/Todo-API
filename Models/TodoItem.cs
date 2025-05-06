namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool Completed {get; set;}
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}


