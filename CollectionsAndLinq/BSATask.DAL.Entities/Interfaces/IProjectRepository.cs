using BASTask.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSATask.DAL.Interfaces
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetProjectsAsync();
        void AddProject(Project project);
        void DeleteProject(Project project);
        void UpdateProject(Project project);
    }
}
