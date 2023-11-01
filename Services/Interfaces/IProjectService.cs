using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces;

public interface IProjectService
{
    Task<List<ProjectDto>> GetAllAsync();

    Task<ProjectDto> CreateAsync(ProjectDto project);

    Task<ProjectDto> UpdateAsync(ProjectDto project);

    void DeleteAsync(int id);

    Task<ProjectDto> GetByIdAsync(int id);
}