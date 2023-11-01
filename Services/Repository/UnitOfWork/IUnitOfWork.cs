using Services.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    #region Properties

    ITaskRepository TaskRepository { get; }
    IProjectAssignmentRepository ProjectAssignmentRepository { get; }
    IProjectRepository ProjectRepository { get; }
    ITeamMemberRepository TeamMemberRepository { get; }
    #endregion

    #region Methods

    Task CompleteAsync();

    #endregion
}
