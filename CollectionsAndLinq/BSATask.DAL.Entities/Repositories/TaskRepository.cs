using BSATask.DAL.Context;
using BSATask.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSATask.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly BSATaskContext _context;
        public TaskRepository(BSATaskContext context) 
        {
            _context = context;
        }

        public void AddTask(BASTask.DAL.Entities.Task task) 
        {
        _context.Tasks.Add(task);
        }

        public void DeleteTask(BASTask.DAL.Entities.Task task) 
        {
        _context.Tasks.Remove(task);
        }
        public async Task<List<BASTask.DAL.Entities.Task>> GetTasksAsync() 
        {
            return await _context.Tasks.ToListAsync();
        }
        public void UpdateTask(BASTask.DAL.Entities.Task task) 
        {
        _context.Tasks.Update(task);
        }
    }
}
