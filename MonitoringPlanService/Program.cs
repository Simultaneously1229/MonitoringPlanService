using AutoMapper;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.DependencyInjection;
using MonitoringPlanService.Services;
using MonitoringPlanService.UI;
using MonitoringPlanService.UI.PresentationModels;

namespace MonitoringPlanService
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection().AddAutoMapper(typeof(MappingProfile));
             
            var mapper = services.BuildServiceProvider().GetRequiredService<IMapper>();

            var monitoringPlan = await new MonitoringService().GetMonitoringPlanAsync();
            var monitoringPlanForPresentation = mapper.Map<MonitoringPlanModel>(monitoringPlan);

            new MonitoringUI().PrintMonitoringPlan(monitoringPlanForPresentation);
        }
    }
}
