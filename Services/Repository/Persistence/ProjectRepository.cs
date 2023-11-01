using Microsoft.EntityFrameworkCore;
using Models.Models;
using Services.Interfaces.Repositories;
using Services.Repository.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.Persistence;

public class ProjectRepository : Repository<Project>, IProjectRepository
{
    public ProjectRepository(DbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Project> Create(Project project)
    {
       return await AddAsync(project);
    }

    public async void Delete(int id)
    {
        var project = await GetByIdAsync(id);
        await DeleteAsync(project);
    }

    public async Task<IEnumerable<Project>> GetAll()
    {
        return await GetAllAsync();
    }

    public async Task<Project> GetById(int id)
    {
        return await GetByIdAsync(id);
    }

    public async Task<Project> Update(Project project, int id)
    {
        return await UpdateAsync(project, id);
    }
}
