using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.Dtos;

namespace TasksApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MembersController : Controller
{
    private readonly ITeamMemberService _memberService;

    public MembersController(ITeamMemberService memberService)
    {
        _memberService = memberService;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var result = await _memberService.GetAllAsync();
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult> Post(TeamMemberDto member)
    {
        var result = await _memberService.CreateAsync(member);
        if (result == null) return NotFound();
        return Ok(result);
    }
}
