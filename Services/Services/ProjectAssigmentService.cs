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

public class ProjectAssigmentService : IProjectAssigmentService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public ProjectAssigmentService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<ProjectAssignmentDto> CreateAsync(ProjectAssignmentDto projectAssignment)
    {
        var projectAssigmentObject = _mapper.Map<ProjectAssignment>(projectAssignment);
        return _mapper.Map<ProjectAssignmentDto>(await _unitOfWork.ProjectAssignmentRepository.Create(projectAssigmentObject));
    }

    public void DeleteAsync(int id)
    {
        _unitOfWork.ProjectAssignmentRepository.Delete(id);
    }

    public async Task<List<ProjectAssignmentDto>> GetAllAsync()
    {
        return _mapper.Map<IEnumerable<ProjectAssignmentDto>>(await _unitOfWork.ProjectAssignmentRepository.GetAll()).ToList();
    }

    public async Task<ProjectAssignmentDto> GetByIdAsync(int id)
    {
        return _mapper.Map<ProjectAssignmentDto>(await _unitOfWork.ProjectAssignmentRepository.GetById(id));
    }

    public async Task<ProjectAssignmentDto> UpdateAsync(ProjectAssignmentDto projectAssignment)
    {
        var projectAssigmentObject = _mapper.Map<ProjectAssignment>(projectAssignment);
        return _mapper.Map<ProjectAssignmentDto>(await _unitOfWork.ProjectAssignmentRepository.UpdateAsync(projectAssigmentObject, projectAssignment.ProjectId));
    }
}
