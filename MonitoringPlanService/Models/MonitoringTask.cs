using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlanService.Models
{
    public record MonitoringTask
    {
        public string CharacteristicName { get; set; } = default!;
    }
}
