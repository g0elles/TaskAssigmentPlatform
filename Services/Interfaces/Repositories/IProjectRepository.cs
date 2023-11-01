using Models.Models;
using Services.Repository.Core;

namespace Services.Interfaces.Repositories;

public interface IProjectRepository : IRepository<Project>
{
    Task<Project> Create(Project project);

    Task<Project> Update(Project project, int id);

    void Delete(int id);

    Task<Project> GetById(int id);

    Task<IEnumerable<Project>> GetAll();
}
