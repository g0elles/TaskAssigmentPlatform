using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public int? ProjectId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int? AssignedTo { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? DueDate { get; set; }

    public virtual TeamMember? AssignedToNavigation { get; set; }

    public virtual Project? Project { get; set; }
}
