using AutoMapper;
using Models.Models;
using Shared.Dtos;
using Task = Models.Models.Task;

namespace Services.Mappers;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<Task, TaskDto>().ReverseMap();
        CreateMap<Project, ProjectDto>().ReverseMap();
        CreateMap<TeamMember, TeamMemberDto>().ReverseMap();
        CreateMap<ProjectAssignment, ProjectAssignmentDto>().ReverseMap();
    }
}
