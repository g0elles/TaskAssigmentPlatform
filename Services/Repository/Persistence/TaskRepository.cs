using Models.Models;
using Services.Interfaces.Repositories;
using Services.Repository.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.Persistence;

public class TaskRepository : Repository<Models.Models.Task>, ITaskRepository
{
    public TaskRepository(TeamTaskTrackerDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Models.Models.Task> Create(Models.Models.Task task)
    {
        return await AddAsync(task);
    }

    public async void Delete(int id)
    {
        var task = await GetByIdAsync(id);
        await DeleteAsync(task);
    }

    public async Task<IEnumerable<Models.Models.Task>> GetAll()
    {
        return await GetAllAsync();
    }

    public async Task<Models.Models.Task> GetById(int id)
    {
        return await GetByIdAsync(id);
    }

    public async Task<Models.Models.Task> Update(Models.Models.Task task, int id)
    {
        return await UpdateAsync(task,id);
    }
}
