using Models.Models;
using Services.Repository.Core;

namespace Services.Interfaces.Repositories;

public interface IProjectAssignmentRepository : IRepository<ProjectAssignment>
{
    Task<ProjectAssignment> Create(ProjectAssignment projectAssignment);

    Task<ProjectAssignment> Update(ProjectAssignment projectAssignment, int id);

    void Delete(int id);

    Task<ProjectAssignment> GetById(int id);

    Task<IEnumerable<ProjectAssignment>> GetAll();
}
