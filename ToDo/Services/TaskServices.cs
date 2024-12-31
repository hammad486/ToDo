using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Services
{
    public class TaskServices
    {
        
        private readonly AppDbContext _context;

        public TaskServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoTask>> GetTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task AddTaskAsync(TodoTask task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTaskAsync(TodoTask task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }
    }
}
