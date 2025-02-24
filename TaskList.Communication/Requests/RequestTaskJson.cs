using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.Communication.Enums;

namespace TaskList.Communication.Requests
{
    public class RequestTaskJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PriorityEnum Priority { get; set; }
        public DateTime Deadline { get; set; }
        public StatusEnum Status { get; set; }

    }
}
