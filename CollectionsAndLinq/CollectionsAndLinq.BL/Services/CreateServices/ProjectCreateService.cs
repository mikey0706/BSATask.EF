using AutoMapper;
using BASTask.DAL.Entities;
using CollectionsAndLinq.BL.Exceptions;
using CollectionsAndLinq.BL.Interfaces;
using CollectionsAndLinq.BL.Models.Projects;
using Task = System.Threading.Tasks.Task;

namespace CollectionsAndLinq.BL.Services.CreateServices
{
    public class ProjectCreateService : IProjectCreateService
    {
        private IDataProvider _provider;
        private IMapper _mapper;

        public ProjectCreateService(IDataProvider provider, IMapper mapper) 
        {
            _provider = provider;
            _mapper = mapper;
        }
        public async Task CreateProject(CreateUpdateProjectDto project) 
        {
            var data = await _provider.GetProjectsAsync();
            data.AddProject(
                _mapper.Map<Project>(project)
                );
            await _provider.SaveChangesAsync();
        }
        public async Task DeleteProject(int projectId) 
        {
            var data = await _provider.GetProjectsAsync();
            var projects = await data.GetProjectsAsync();
            var project = projects.FirstOrDefault(p => p.Id == projectId);

            if (project != null) 
            {
              data.DeleteProject(project);
            }
            else
            {
                throw new NotFoundException(projectId);
            }
            await _provider.SaveChangesAsync();   
        }
        public async Task UpdateProject(int id, CreateUpdateProjectDto project)
        {
            var data = await _provider.GetProjectsAsync();
            var projects = await data.GetProjectsAsync();
            var projectData = projects.FirstOrDefault(p => p.Id == id);

            if (projectData != null)
            {
                projectData.AuthorId = project.AuthorId;
                projectData.TeamId = project.TeamId;
                projectData.Name = project.Name;
                projectData.Description = project.Description;
                projectData.CreatedAt = project.CreatedAt;
                projectData.Deadline = project.Deadline;

                data.UpdateProject(projectData);

            }
            else 
            {
                throw new WrongIdException(id);
            }
            await _provider.SaveChangesAsync();
        }
    }
}
