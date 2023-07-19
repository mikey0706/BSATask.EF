using AutoMapper;
using BASTask.DAL.Entities;
using CollectionsAndLinq.BL.Models.Projects;
using CollectionsAndLinq.BL.Models.Tasks;
using CollectionsAndLinq.BL.Models.Teams;
using CollectionsAndLinq.BL.Models.Users;
using Task = BASTask.DAL.Entities.Task;

namespace CollectionsAndLinq.BL.MappingProfiles
{
    public sealed class BusionessLayerProfile : Profile
    {

        public BusionessLayerProfile() 
        {
            CreateMap<TaskDto, Task>().ForMember(d => d.State, o => o.MapFrom(s => s.State.ToString()));
            CreateMap<Task, TaskDto>();
            CreateMap<CreateUpdateUserDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<Project, ProjectDto>();
            CreateMap<CreateUpdateProjectDto, Project>();
            CreateMap<CreateUpdateTaskDto, Task>();
            CreateMap<TeamCreateUpdateDto, Team>();
            CreateMap<Team, TeamDto>().ReverseMap();
        }
    }
}
