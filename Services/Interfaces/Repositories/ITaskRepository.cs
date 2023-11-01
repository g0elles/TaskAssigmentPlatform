using Services.Repository.Core;

namespace Services.Interfaces.Repositories;

public interface ITaskRepository : IRepository<Models.Models.Task>
{
    Task<Models.Models.Task> Create(Models.Models.Task task);

    Task<Models.Models.Task> Update(Models.Models.Task task, int id);

    void Delete(int id);

    Task<Models.Models.Task> GetById(int id);

    Task<IEnumerable<Models.Models.Task>> GetAll();
}
