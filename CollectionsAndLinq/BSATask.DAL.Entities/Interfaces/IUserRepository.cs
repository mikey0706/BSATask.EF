using BASTask.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSATask.DAL.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
    }
}
