namespace MonitoringPlanService.Models
{
    public record ApiRequest
    {
        public string? Jsonrpc { get; set; }

        public string? Method { get; set; }

        public string? Id { get; set; }

        public ApiRequestParams? Params { get; set; }
    }
}
