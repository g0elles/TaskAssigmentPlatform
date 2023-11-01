using AutoMapper;
using Models.Models;
using Services.Interfaces;
using Services.Repository.UnitOfWork;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services;

public class ProjectService : IProjectService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public ProjectService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<ProjectDto> CreateAsync(ProjectDto project)
    {
        var projectObject = _mapper.Map<Project>(project);
        return _mapper.Map<ProjectDto>(await _unitOfWork.ProjectRepository.Create(projectObject));
    }

    public void DeleteAsync(int id)
    {
        _unitOfWork.ProjectRepository.Delete(id);
    }

    public async Task<List<ProjectDto>> GetAllAsync()
    {
        return _mapper.Map<IEnumerable<ProjectDto>>(await _unitOfWork.ProjectRepository.GetAll()).ToList();
    }

    public async Task<ProjectDto> GetByIdAsync(int id)
    {
        return _mapper.Map<ProjectDto>(await _unitOfWork.ProjectRepository.GetById(id));
    }

    public async Task<ProjectDto> UpdateAsync(ProjectDto project)
    {
        var projectObject = _mapper.Map<Project>(project);
        return _mapper.Map<ProjectDto>(await _unitOfWork.ProjectRepository.Update(projectObject, projectObject.ProjectId));
    }
}
