using AutoMapper;
using BASTask.DAL.Entities;
using BSATask.WebAPI.Models.CreateModels;
using CollectionsAndLinq.BL.Models.Projects;
using CollectionsAndLinq.BL.Models.Tasks;
using CollectionsAndLinq.BL.Models.Teams;
using CollectionsAndLinq.BL.Models.Users;

namespace BSATask.WebAPI.MappingProfile
{
    public class ViewsMappingProfile : Profile
    {
        public ViewsMappingProfile() 
        {
            CreateMap<ProjectCreateModel, CreateUpdateProjectDto>();
            CreateMap<TaskCreateModel, CreateUpdateTaskDto>();
            CreateMap<UserCreateModel, CreateUpdateUserDto>();
            CreateMap<User, CreateUpdateUserDto>();
            CreateMap<TeamCreateModel, TeamCreateUpdateDto>();
        }
    }
}
