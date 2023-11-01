        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace Shared.Dtos;

        public class TaskDto
        {
            public int? TaskId { get; set; }

            public int? ProjectId { get; set; }

            public string Title { get; set; } = null!;

            public string? Description { get; set; }

            public int? AssignedTo { get; set; }

            public string Status { get; set; } = null!;

            public DateTime? DueDate { get; set; }
        }
