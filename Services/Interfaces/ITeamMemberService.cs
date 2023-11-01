using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces;

public interface ITeamMemberService
{
    Task<List<TeamMemberDto>> GetAllAsync();

    Task<TeamMemberDto> CreateAsync(TeamMemberDto teamMember);

    Task<TeamMemberDto> UpdateAsync(TeamMemberDto teamMember);

    void DeleteAsync(int id);

    Task<TeamMemberDto> GetByIdAsync(int id);
}
