using Models.Models;
using Services.Interfaces.Repositories;
using Services.Repository.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private TaskRepository _taskRepository;
    public ITaskRepository TaskRepository => _taskRepository ?? (_taskRepository = new TaskRepository(_dbContext));

    private ProjectAssignmentRepository _projectAssignmentRepository;
    public IProjectAssignmentRepository ProjectAssignmentRepository => _projectAssignmentRepository ?? (_projectAssignmentRepository = new ProjectAssignmentRepository(_dbContext));

    private ProjectRepository _projectRepository;
    public IProjectRepository ProjectRepository => _projectRepository ?? (_projectRepository = new ProjectRepository(_dbContext));

    private TeamMemberRepository _teamMemberRepository;
    public ITeamMemberRepository TeamMemberRepository => _teamMemberRepository ?? (_teamMemberRepository = new TeamMemberRepository(_dbContext));


    #region Readonlys
    private readonly TeamTaskTrackerDbContext _dbContext;
    #endregion    
    
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">The Database Context</param>
    public UnitOfWork(TeamTaskTrackerDbContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public async System.Threading.Tasks.Task CompleteAsync() => await _dbContext.SaveChangesAsync();


    #region Implements IDisposable

    #region Private Dispose Fields

    private bool _disposed;

    #endregion

    /// <summary>
    /// Cleans up any resources being used.
    /// </summary>
    /// <returns><see cref="ValueTask"/></returns>
    public async ValueTask DisposeAsync()
    {
        await DisposeAsync(true);

        // Take this object off the finalization queue to prevent 
        // finalization code for this object from executing a second time.
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Cleans up any resources being used.
    /// </summary>
    /// <param name="disposing">Whether or not we are disposing</param> 
    /// <returns><see cref="ValueTask"/></returns>
    protected virtual async ValueTask DisposeAsync(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Dispose managed resources.
                await _dbContext.DisposeAsync();
            }

            // Dispose any unmanaged resources here...

            _disposed = true;
        }
    }

    #endregion
}
