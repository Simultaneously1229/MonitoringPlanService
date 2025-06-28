using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlanService.Models
{
    public record MonitoringPlan
    {
        public List<GeneralTechnicalPlace> TechnicalPlaces { get; set; } = default!;
    }
}
