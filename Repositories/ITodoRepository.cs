using TodoAPI.Models;

namespace TodoAPI.Repositories
{
    public interface ITodoRepository
    {
        Task<IEnumerable<TodoItem>> GetAllAsync();
        Task<TodoItem?> GetByIdAsync(long id);
        Task<TodoItem> AddAsync(TodoItem item);
        Task<bool> UpdateAsync(long id, TodoItem item);
        Task<bool> DeleteAsync(long id);
        //bool TodoItemExists(long id);
    }
}
