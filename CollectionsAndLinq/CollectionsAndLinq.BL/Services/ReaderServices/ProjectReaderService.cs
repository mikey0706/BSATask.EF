using AutoMapper;
using CollectionsAndLinq.BL.Exceptions;
using CollectionsAndLinq.BL.Interfaces;
using CollectionsAndLinq.BL.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndLinq.BL.Services.ReaderServices
{
    public class ProjectReaderService : IProjectReaderService
    {
        private IDataProvider _provider;
        private IMapper _mapper;

        public ProjectReaderService(IDataProvider provider, IMapper mapper) 
        {
            _provider = provider;
            _mapper = mapper;
        }
        public async Task<List<ProjectDto>> GetAllProjecs() 
        {
            var data = await _provider.GetProjectsAsync();
            return _mapper.Map<List<ProjectDto>>(await data.GetProjectsAsync());
        }
        public async Task<ProjectDto> GetProjectById(int id) 
        {
            var data = await _provider.GetProjectsAsync();
            var projects = await data.GetProjectsAsync();
            var project = projects.FirstOrDefault(p => p.Id == id);

            return (project !=null) ? _mapper.Map<ProjectDto>(project) : throw new NotFoundException(id);
        }
    }
}
