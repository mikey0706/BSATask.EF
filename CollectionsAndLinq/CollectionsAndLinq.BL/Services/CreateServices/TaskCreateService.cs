using AutoMapper;
using BASTask.DAL.Entities;
using CollectionsAndLinq.BL.Exceptions;
using CollectionsAndLinq.BL.Interfaces;
using CollectionsAndLinq.BL.Models.Tasks;
using Task = System.Threading.Tasks.Task;

namespace CollectionsAndLinq.BL.Services.CreateServices
{
    public class TaskCreateService : ITaskCreateService
    {
        private IDataProvider _provider;
        private IMapper _mapper;

        public TaskCreateService(IDataProvider provider, IMapper mapper)
        {
            _provider = provider;
            _mapper = mapper;
        }
        public async Task CreateTask(CreateUpdateTaskDto task) 
        {
            var data = await _provider.GetTasksAsync();
            data.AddTask(
                _mapper.Map<BASTask.DAL.Entities.Task>(task)
                );
            await _provider.SaveChangesAsync();
        }
        public async Task DeleteTask(int taskId) 
        {
            var data = await _provider.GetTasksAsync();
            var tasks = await data.GetTasksAsync();
            var task = tasks.FirstOrDefault(p => p.Id == taskId);

            if (task != null)
            {
                data.DeleteTask(task);
            }
            else
            {
                throw new NotFoundException(taskId);
            }
            await _provider.SaveChangesAsync();
        }
        public async Task UpdateTask(int id, CreateUpdateTaskDto task) 
        {
            var data = await _provider.GetTasksAsync();
            var tasks = await data.GetTasksAsync();
            var taskData = tasks.FirstOrDefault(p => p.Id == id);

            if (taskData != null)
            {
                taskData.Name = task.Name;
                taskData.PerformerId = task.PerformerId;
                taskData.State = task.State;
                taskData.Description = task.Description;

                data.UpdateTask(taskData);
            }
            else
            {
                throw new WrongIdException(id);
            }
            await _provider.SaveChangesAsync();
        }
    }
}
