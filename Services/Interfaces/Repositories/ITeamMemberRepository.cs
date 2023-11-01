using Models.Models;
using Services.Repository.Core;

namespace Services.Interfaces.Repositories;

public interface ITeamMemberRepository : IRepository<TeamMember>
{
    Task<TeamMember> Create(TeamMember teamMember);

    Task<TeamMember> Update(TeamMember teamMember, int id);

    void Delete(int id);

    Task<TeamMember> GetById(int id);

    Task<IEnumerable<TeamMember>> GetAll();
}
