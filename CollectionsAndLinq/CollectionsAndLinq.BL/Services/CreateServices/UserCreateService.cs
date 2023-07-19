using AutoMapper;
using BASTask.DAL.Entities;
using CollectionsAndLinq.BL.Exceptions;
using CollectionsAndLinq.BL.Interfaces;
using CollectionsAndLinq.BL.Models.Users;
using Task = System.Threading.Tasks.Task;

namespace CollectionsAndLinq.BL.Services.CreateServices
{
    public class UserCreateService : IUserCreateService
    {
        private IDataProvider _provider;
        private IMapper _mapper;

        public UserCreateService(IDataProvider provider, IMapper mapper)
        {
            _provider = provider;
            _mapper = mapper;
        }
        public async Task CreateUser(CreateUpdateUserDto user)
        {
            var data = await _provider.GetUsersAsync();
            data.AddUser(
                _mapper.Map<User>(user)
                );

            await _provider.SaveChangesAsync();
        }
        public async Task DeleteUser(int userId)
        {
            var data = await _provider.GetUsersAsync();
            var users = await data.GetUsersAsync();
            var user = users.FirstOrDefault(p => p.Id == userId);

            if (user != null)
            {
            
                data.DeleteUser(user);
            }
            else
            {
                throw new NotFoundException(userId);
            }
            await _provider.SaveChangesAsync();
        }
        public async Task UpdateUser(int id, CreateUpdateUserDto user)
        {
            var data = await _provider.GetUsersAsync();
            var users = await data.GetUsersAsync();
            var userData = users.FirstOrDefault(p => p.Id == id);

            if (userData != null)
            {
                userData.TeamId = user.TeamId;
                userData.FirstName = user.FirstName;
                userData.LastName = user.LastName;
                userData.BirthDay = user.BirthDay;
                userData.Email = user.Email;
                userData.RegisteredAt = user.RegisteredAt;

                data.UpdateUser(userData);
            }
            else
            {
                throw new WrongIdException(id);
            }

            await _provider.SaveChangesAsync();
        }
    }
}
