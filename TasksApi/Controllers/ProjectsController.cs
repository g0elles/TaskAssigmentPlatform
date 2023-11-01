using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;
using Shared.Dtos;

namespace TasksApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectsController : Controller
{
    private readonly IProjectService _projectService;

    public ProjectsController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var result = await _projectService.GetAllAsync();
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult> Post(ProjectDto project)
    {
        var result = await _projectService.CreateAsync(project);
        if (result == null) return NotFound();
        return Ok(result);
    }
}
