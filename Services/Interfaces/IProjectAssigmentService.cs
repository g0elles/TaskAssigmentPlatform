using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces;

public interface IProjectAssigmentService
{
    Task<List<ProjectAssignmentDto>> GetAllAsync();

    Task<ProjectAssignmentDto> CreateAsync(ProjectAssignmentDto projectAssignment);

    Task<ProjectAssignmentDto> UpdateAsync(ProjectAssignmentDto projectAssignment);

    void DeleteAsync(int id);

    Task<ProjectAssignmentDto> GetByIdAsync(int id);
}
