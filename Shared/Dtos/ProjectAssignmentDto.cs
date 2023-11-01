using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos;

public class ProjectAssignmentDto
{
    public int? AssignmentId { get; set; }

    public int? ProjectId { get; set; }

    public int? MemberId { get; set; }

    public DateTime? AssignmentDate { get; set; }
}
