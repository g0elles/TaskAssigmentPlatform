using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.Dtos;

namespace TasksApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TasksController : Controller
{
    private readonly ITaskService _taskService;

    public TasksController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var result = await _taskService.GetAllAsync();
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult> Post(TaskDto task)
    {
        var result = await _taskService.CreateAsync(task);
        if (result == null) return NotFound();
        return Ok(result);
    }
}
