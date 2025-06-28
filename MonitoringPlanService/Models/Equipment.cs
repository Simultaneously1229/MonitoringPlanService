using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlanService.Models
{
    public record Equipment
    {
        public string Name { get; set; } = default!;

        public List<MonitoringTask> MonitoringTasks { get; set; } = default!;
    }
}
