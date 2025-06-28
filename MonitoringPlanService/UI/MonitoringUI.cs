using MonitoringPlanService.UI.PresentationModels;

namespace MonitoringPlanService.UI
{
    public class MonitoringUI
    {
        public void PrintMonitoringPlan(MonitoringPlanModel monitoringPlan)
        {
            monitoringPlan.Print();

            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
        }
    }
}
