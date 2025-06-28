using BenchmarkDotNet.Attributes;
using MonitoringPlanService.Models;
using MonitoringPlanService.UI.PresentationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlanService.UI
{
    [MemoryDiagnoser]
    public class MonitoringUI
    {
        [Benchmark]
        public void PrintMonitoringPlan(MonitoringPlanModel monitoringPlan)
        {
            monitoringPlan.Print();

            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
        }
    }
}
