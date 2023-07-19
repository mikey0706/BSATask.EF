using BASTask.DAL.Entities;
using BSATask.DAL.Context;
using BSATask.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace BSATask.DAL.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly BSATaskContext _context;
        public ProjectRepository(BSATaskContext context) 
        {
        _context = context;
        }

        public void AddProject(Project project) 
        {
        _context.Projects.Add(project);
        }

        public void DeleteProject(Project project) 
        {
        _context.Projects.Remove(project);
        }
        public async Task<List<Project>> GetProjectsAsync() 
        {
            return await _context.Projects.ToListAsync();
        }
        public void UpdateProject(Project project) 
        {
            _context.Projects.Update(project);
        }
    }
}
