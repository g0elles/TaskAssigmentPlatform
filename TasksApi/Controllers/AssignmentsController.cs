using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.Dtos;

namespace TasksApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AssignmentsController : Controller
{
    private readonly IProjectAssigmentService _assigmentService;

    public AssignmentsController(IProjectAssigmentService assigmentService)
    {
        _assigmentService = assigmentService;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var result = await _assigmentService.GetAllAsync();
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult> Post(ProjectAssignmentDto assignment)
    {
        var result = await _assigmentService.CreateAsync(assignment);
        if (result == null) return NotFound();
        return Ok(result);
    }
}
