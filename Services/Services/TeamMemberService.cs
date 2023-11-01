using AutoMapper;
using Models.Models;
using Services.Interfaces;
using Services.Repository.UnitOfWork;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services;

public class TeamMemberService : ITeamMemberService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public TeamMemberService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<TeamMemberDto> CreateAsync(TeamMemberDto teamMember)
    {
        var teamMemberObject = _mapper.Map<TeamMember>(teamMember);
        return _mapper.Map<TeamMemberDto>(await _unitOfWork.TeamMemberRepository.Create(teamMemberObject));           
    }

    public void DeleteAsync(int id)
    {
        _unitOfWork.TeamMemberRepository.Delete(id);
    }

    public async Task<List<TeamMemberDto>> GetAllAsync()
    {
        return _mapper.Map<IEnumerable<TeamMemberDto>>(await _unitOfWork.TeamMemberRepository.GetAllAsync()).ToList();
    }

    public async Task<TeamMemberDto> GetByIdAsync(int id)
    {
        return _mapper.Map<TeamMemberDto>(await _unitOfWork.TeamMemberRepository.GetById(id));
    }

    public async Task<TeamMemberDto> UpdateAsync(TeamMemberDto teamMember)
    {
        var teamMemberObject = _mapper.Map<TeamMember>(teamMember);
        return _mapper.Map<TeamMemberDto>(await _unitOfWork.TeamMemberRepository.Update(teamMemberObject, teamMemberObject.MemberId));
    }
}
