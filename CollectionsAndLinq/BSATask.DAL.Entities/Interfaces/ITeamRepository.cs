using BASTask.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSATask.DAL.Interfaces
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetTeamsAsync();
        void AddTeam(Team team);
        void DeleteTeam(Team team);
        void UpdateTeam(Team team);
    }
}
