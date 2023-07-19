using BASTask.DAL.Entities;
using BSATask.DAL.Context;
using BSATask.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSATask.DAL.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private BSATaskContext _context;
        public TeamRepository(BSATaskContext context) 
        {
        _context = context;
        }

        public void AddTeam(Team team) 
        {
        _context.Teams.Add(team);
        }

        public void DeleteTeam(Team team) 
        {
        _context.Teams.Remove(team);
        }
        public async Task<List<Team>> GetTeamsAsync() 
        {
            return await _context.Teams.ToListAsync();
        }
        public void UpdateTeam(Team team) 
        {
        _context.Teams.Update(team);
        }
    }
}
