namespace MonitoringPlanService.Models
{
    public record ApiRequestParams
    {
        public string? PersonnelNumber { get; set; }

        public string? FactoryCode { get; set; }

        public string? Date { get; set; }

        public string? Mode { get; set; }
    }
}
