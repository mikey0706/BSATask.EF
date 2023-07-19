using AutoMapper;
using CollectionsAndLinq.BL.Exceptions;
using CollectionsAndLinq.BL.Interfaces;
using CollectionsAndLinq.BL.Models.Projects;
using CollectionsAndLinq.BL.Models.Tasks;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndLinq.BL.Services.ReaderServices
{
    public class TaskReadService : ITaskReadService
    {
        private IDataProvider _provider;
        private IMapper _mapper;

        public TaskReadService(IDataProvider provider, IMapper mapper)
        {
            _provider = provider;
            _mapper = mapper;
        }
        public async Task<List<TaskDto>> GetAllTasks()
        {
            var data = await _provider.GetTasksAsync();
            return _mapper.Map<List<TaskDto>>(await data.GetTasksAsync());
        }
        public async Task<TaskDto> GetTaskById(int id) 
        {
            var data = await _provider.GetTasksAsync();
            var tasks = await data.GetTasksAsync();
            var task = tasks.FirstOrDefault(p => p.Id == id);
            return (task != null)?_mapper.Map<TaskDto>(task) : throw new NotFoundException(id);
        }
    }
}
