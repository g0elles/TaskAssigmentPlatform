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

public class TeamMemberRepository : Repository<TeamMember>, ITeamMemberRepository
{
    public TeamMemberRepository(DbContext dbContext) : base(dbContext)
    {
    }

    public async Task<TeamMember> Create(TeamMember teamMember)
    {
        return await AddAsync(teamMember);
    }

    public async void Delete(int id)
    {
        var teamMember = await GetByIdAsync(id);
        await DeleteAsync(teamMember);
    }

    public async Task<IEnumerable<TeamMember>> GetAll()
    {
        return await GetAllAsync();
    }

    public async Task<TeamMember> GetById(int id)
    {
        return await GetByIdAsync(id);
    }

    public async Task<TeamMember> Update(TeamMember teamMember, int id)
    {
        return await UpdateAsync(teamMember, id);
    }
}
