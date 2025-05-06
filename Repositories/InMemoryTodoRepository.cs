using TodoAPI.Models;

namespace TodoAPI.Repositories
{
    public class InMemoryTodoRepository : ITodoRepository
    {
        private readonly List<TodoItem> _todoItems = new();
        private long _nextId = 1;

        public Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<TodoItem>>(_todoItems);
        }

        public Task<TodoItem?> GetByIdAsync(long id)
        {
            var item = _todoItems.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(item);
        }

        public Task<TodoItem> AddAsync(TodoItem item)
        {
            item.Id = _nextId++;
            _todoItems.Add(item);
            return Task.FromResult(item);
        }

        public Task<bool> UpdateAsync(long id, TodoItem updatedItem)
        {
            var index = _todoItems.FindIndex(x => x.Id == id);
            if (index == -1) return Task.FromResult(false);

            updatedItem.Id = id;
            _todoItems[index] = updatedItem;
            return Task.FromResult(true);
        }

        public Task<bool> DeleteAsync(long id)
        {
            var item = _todoItems.FirstOrDefault(x => x.Id == id);
            if (item == null) return Task.FromResult(false);

            _todoItems.Remove(item);
            return Task.FromResult(true);
        }
    }
}
