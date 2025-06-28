using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MonitoringPlanService.Models
{
    public record GeneralTechnicalPlace
    {
        public string Name { get; set; } = default!;

        public List<TechnicalPlace> TechnicalPlaces { get; set; } = default!;
    }
}
