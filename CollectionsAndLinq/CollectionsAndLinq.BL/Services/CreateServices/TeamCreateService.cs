using AutoMapper;
using BASTask.DAL.Entities;
using CollectionsAndLinq.BL.Exceptions;
using CollectionsAndLinq.BL.Interfaces;
using CollectionsAndLinq.BL.Models.Teams;
using CollectionsAndLinq.BL.Models.Users;
using Task = System.Threading.Tasks.Task;

namespace CollectionsAndLinq.BL.Services.CreateServices
{
    public class TeamCreateService : ITeamCreateService
    {
        private IDataProvider _provider;
        private IMapper _mapper;

        public TeamCreateService(IDataProvider provider,
            IMapper mapper)
        {
            _provider = provider;
            _mapper = mapper;
        }
        public async Task CreateTeam(TeamCreateUpdateDto team)
        {
            var repo = await _provider.GetTeamsAsync();

            repo.AddTeam(
                _mapper.Map<Team>(team)
                );

            await _provider.SaveChangesAsync();
        }
        public async Task DeleteTeam(int teamId) 
        {

            var data = await _provider.GetTeamsAsync();
            var teams = await data.GetTeamsAsync();
            var team = teams.FirstOrDefault(p => p.Id == teamId);

            if (team != null)
            {
                data.DeleteTeam(team);
            }
            else
            {
                throw new NotFoundException(teamId);
            }
            await _provider.SaveChangesAsync();
        }
        public async Task UpdateTeam(int id, TeamCreateUpdateDto team) 
        {
            var data = await _provider.GetTeamsAsync();
            var teams = await data.GetTeamsAsync();
            var teamData = teams.FirstOrDefault(p => p.Id == id);

            if (teamData != null)
            {
                teamData.Name = team.Name;
                teamData.CreatedAt = team.CreatedAt;
               data.UpdateTeam(teamData);
            }
            else
            {
                throw new WrongIdException(id);
            }
            await _provider.SaveChangesAsync();
        }
    }
}
