using BASTask.DAL.Entities;
using BSATask.DAL.Context;
using BSATask.DAL.Interfaces;
using BSATask.DAL.Repositories;
using CollectionsAndLinq.BL.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace CollectionsAndLinq.BL.Context
{
    public class DataProvider : IDataProvider
    {
        private BSATaskContext _context;

        private readonly IProjectRepository _projects;
        private readonly IUserRepository _users;
        private readonly ITeamRepository _teams;
        private readonly ITaskRepository _tasks;

        public DataProvider(IProjectRepository projects, IUserRepository users, ITeamRepository teams, ITaskRepository tasks, BSATaskContext context) 
        {
            _projects = projects;
            _users = users;
            _teams = teams;
            _tasks = tasks;
            _context = context;
        }

        public async Task<IProjectRepository> GetProjectsAsync() 
        {
            return await Task.Run(()=> _projects);
        }
        public async Task<ITaskRepository> GetTasksAsync() 
        {
            return await Task.Run(()=> _tasks);
        }
        public async Task<ITeamRepository> GetTeamsAsync() 
        {
            return await Task.Run(()=>_teams);
        }
        public async Task<IUserRepository> GetUsersAsync() 
        {
            return await Task.Run(()=> _users);
        }
        public async Task SaveChangesAsync() 
        {
         await _context.SaveChangesAsync();
        }
    }
}
