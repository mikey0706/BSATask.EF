using BASTask.DAL.Entities;
using BSATask.DAL.Interfaces;
using Task = BASTask.DAL.Entities.Task;

namespace CollectionsAndLinq.BL.Interfaces;

public interface IDataProvider
{
    Task<IProjectRepository> GetProjectsAsync();
    Task<ITaskRepository> GetTasksAsync();
    Task<ITeamRepository> GetTeamsAsync();
    Task<IUserRepository> GetUsersAsync();
    System.Threading.Tasks.Task SaveChangesAsync();
}
