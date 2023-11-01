using Shared.Dtos;

namespace Services.Interfaces;

public interface ITaskService
{
    Task<List<TaskDto>> GetAllAsync();

    Task<TaskDto> CreateAsync(TaskDto task);

    Task<TaskDto> UpdateAsync(TaskDto task);

    void DeleteAsync(int id);

    Task<TaskDto> GetByIdAsync(int id);
}
