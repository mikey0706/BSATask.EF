using AutoMapper;
using CollectionsAndLinq.BL.Exceptions;
using CollectionsAndLinq.BL.Interfaces;
using CollectionsAndLinq.BL.Models.Projects;
using CollectionsAndLinq.BL.Models.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndLinq.BL.Services.ReaderServices
{
    public class TeamReadService : ITeamReadService
    {
        private IDataProvider _provider;
        private IMapper _mapper;

        public TeamReadService(IDataProvider provider, IMapper mapper)
        {
            _provider = provider;
            _mapper = mapper;
        }
        public async Task<List<TeamDto>> GetAllTeams()
        {
            var data = await _provider.GetTeamsAsync();
            return _mapper.Map<List<TeamDto>>(await data.GetTeamsAsync());
        }
        public async Task<TeamDto> GetTeamById(int id)
        {
            var data = await _provider.GetTeamsAsync();
            var teams = await data.GetTeamsAsync();
            var team = teams.FirstOrDefault(p => p.Id == id);
            return (team != null)?_mapper.Map<TeamDto>(team) : throw new NotFoundException(id);
        }
    }
}
