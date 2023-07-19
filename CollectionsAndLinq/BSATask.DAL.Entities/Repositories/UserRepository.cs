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
    public class UserRepository : IUserRepository
    {
        private readonly BSATaskContext _context;
        public UserRepository(BSATaskContext context) 
        {
            _context = context;
        }

        public void AddUser(User user) 
        {
            _context.Users.Add(user);
        }

        public void DeleteUser(User user) 
        {
            _context.Users.Remove(user);
        }
        public async Task<List<User>> GetUsersAsync() 
        {
            return await _context.Users.ToListAsync();
        }
        public void UpdateUser(User user) 
        {
            _context.Users.Update(user);
        }
    }
}
