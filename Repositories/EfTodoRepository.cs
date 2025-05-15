using Microsoft.EntityFrameworkCore;
using TodoAPI.Models;

namespace TodoAPI.Repositories
{
    public class EfTodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public EfTodoRepository(TodoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            return await _context.TodoItems.ToListAsync();
        }

        public async Task<TodoItem?> GetByIdAsync(long id)
        {
            return await _context.TodoItems.FindAsync(id);
        }

        public async Task<TodoItem> AddAsync(TodoItem item)
        {
            await this._context.TodoItems.AddAsync(item);
            await this._context.SaveChangesAsync();
            return item;
        }

        public async Task<bool> UpdateAsync(int id, TodoItem updatedItem)
        {
            var existingItem = await _context.TodoItems.FindAsync(id);
            if (existingItem == null) return false;

            existingItem.Name = updatedItem.Name;
            existingItem.Completed = updatedItem.Completed;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item == null) return false;

            _context.TodoItems.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<TodoItem?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}