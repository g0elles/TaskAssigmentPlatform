using Microsoft.EntityFrameworkCore;
using Models.Models;
using Services.Interfaces.Repositories;
using Services.Repository.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.Persistence;

public class ProjectAssignmentRepository : Repository<ProjectAssignment>, IProjectAssignmentRepository
{
    public ProjectAssignmentRepository(DbContext dbContext) : base(dbContext)
    {
    }

    public async Task<ProjectAssignment> Create(ProjectAssignment projectAssignment)
    {
        return await AddAsync(projectAssignment);
    }

    public async void Delete(int id)
    {
        var projectAssignment = await GetByIdAsync(id);
        await DeleteAsync(projectAssignment);
    }

    public async Task<IEnumerable<ProjectAssignment>> GetAll()
    {
        return await GetAllAsync();
    }

    public async Task<ProjectAssignment> GetById(int id)
    {
       return await GetByIdAsync(id);
    }

    public async Task<ProjectAssignment> Update(ProjectAssignment projectAssignment, int id)
    {
      return await UpdateAsync(projectAssignment, id);
    }
}
