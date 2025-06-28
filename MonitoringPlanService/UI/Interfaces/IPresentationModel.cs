using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlanService.UI.Interfaces
{
    public interface IPresentationModel
    {
        void Print(int treeLevel = 0);
    }
}
