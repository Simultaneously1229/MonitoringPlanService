namespace MonitoringPlanService.Models
{
    public record Equipment
    {
        public string Name { get; set; } = default!;

        public List<MonitoringTask> MonitoringTasks { get; set; } = default!;
    }
}
