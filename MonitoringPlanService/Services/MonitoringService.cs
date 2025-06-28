using Microsoft.Extensions.Configuration;
using MonitoringPlanService.Models;
using System.IO.Compression;
using System.Text;
using System.Text.Json;

namespace MonitoringPlanService.Services
{
    public class MonitoringService
    {
        private readonly HttpClient _httpClient;

        public MonitoringService() => _httpClient = new();

        public async Task<MonitoringPlan> GetMonitoringPlanAsync()
        {
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new("gzip"));

            var apiRequest = GetApiRequest();
            var apiUrl = GetApiUrl();

            var requestJson = JsonSerializer.Serialize(apiRequest);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(apiUrl, content);
            response.EnsureSuccessStatusCode();

            using var compressedStream = await response.Content.ReadAsStreamAsync();
            using var responseStream = new GZipStream(compressedStream, CompressionMode.Decompress);

            var monitoringPlan = 
                await JsonSerializer.DeserializeAsync(
                        responseStream, SerializerContext.Default.JsonRpcResponseMonitoringPlan);

            if (monitoringPlan is null)
            {
                throw new Exception($"{nameof(monitoringPlan)} is null here.");
            }
           
            return monitoringPlan.Result;
        }

        private ApiRequest GetApiRequest()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var apiRequestParams = new ApiRequestParams()
            {
                PersonnelNumber = config["ApiRequest:ApiRequestParams:PersonnelNumber"],
                FactoryCode = config["ApiRequest:ApiRequestParams:FactoryCode"],
                Date = config["ApiRequest:ApiRequestParams:Date"],
                Mode = config["ApiRequest:ApiRequestParams:Mode"],
            };

            return new ApiRequest()
            {
                Jsonrpc = config["ApiRequest:Jsonrpc"],
                Method = config["ApiRequest:Method"],
                Id = config["ApiRequest:Id"],
                Params = apiRequestParams,
            };
        }

        private string? GetApiUrl()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return config["ApiUrl"];
        }
    }

    public record JsonRpcResponse<T>
    {
        public T Result { get; set; } = default!;
    }
}
