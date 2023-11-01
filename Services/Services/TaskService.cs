using AutoMapper;
using Microsoft.Extensions.Logging;
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

public class TaskService : ITaskService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public TaskService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<TaskDto> CreateAsync(TaskDto task)
    {
        var taskObject = _mapper.Map<Models.Models.Task>(task);        
        return _mapper.Map<TaskDto>(await _unitOfWork.TaskRepository.Create(taskObject));
    }

    public async void DeleteAsync(int id)
    {
        _unitOfWork.TaskRepository.Delete(id);
    }

    public async Task<List<TaskDto>> GetAllAsync()
    {
        return  _mapper.Map<IEnumerable<TaskDto>>(await _unitOfWork.TaskRepository.GetAllAsync()).ToList();
    }

    public async Task<TaskDto> GetByIdAsync(int id)
    {
        return _mapper.Map<TaskDto>(await _unitOfWork.TaskRepository.GetById(id));
    }

    public async Task<TaskDto> UpdateAsync(TaskDto task)
    {
        var taskObject = _mapper.Map<Models.Models.Task>(task);        
        return _mapper.Map<TaskDto>(await _unitOfWork.TaskRepository.Update(taskObject, (int) task.TaskId));
    }
}
