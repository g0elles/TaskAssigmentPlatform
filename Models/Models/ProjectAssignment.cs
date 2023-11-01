using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ProjectAssignment
{
    public int AssignmentId { get; set; }

    public int? ProjectId { get; set; }

    public int? MemberId { get; set; }

    public DateTime? AssignmentDate { get; set; }

    public virtual TeamMember? Member { get; set; }

    public virtual Project? Project { get; set; }
}
