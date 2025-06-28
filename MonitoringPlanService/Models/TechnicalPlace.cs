using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlanService.Models
{
    public record TechnicalPlace
    {
        public string Name { get; set; } = default!;

        public List<Equipment> Equipments { get; set; } = default!;
    }
}
