using BASTask.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = BASTask.DAL.Entities.Task;

namespace BSATask.DAL.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<Task>> GetTasksAsync();
        void AddTask(Task task);
        void DeleteTask(Task task);
        void UpdateTask(Task task);
    }
}
