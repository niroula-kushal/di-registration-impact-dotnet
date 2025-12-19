using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Data;
using stream_response_ef_core.Services.Infrastructure;

namespace stream_response_ef_core.Services.Monitoring;

public interface ICollector004Service
{
    string ProcessCollector004(object data);
    Task<string> HandleCollector004(int request);
}

public class Collector004Service : ICollector004Service
{
    private readonly ILogger<Collector004Service> _logger;
    private readonly ISync085Service _sync085Service;
    private readonly ILocator063Service _locator063Service;

    public Collector004Service(ILogger<Collector004Service> logger, ISync085Service sync085Service, ILocator063Service locator063Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _sync085Service = sync085Service ?? throw new ArgumentNullException(nameof(sync085Service));
        _locator063Service = locator063Service ?? throw new ArgumentNullException(nameof(locator063Service));
    }

    public string ProcessCollector004(object data)
    {
        // Implementation for ProcessCollector004
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessCollector004), nameof(data), data);
        
        _ = _sync085Service; // Using dependency
        return $"Result from ProcessCollector004";
    }

    public async Task<string> HandleCollector004(int request)
    {
        // Implementation for HandleCollector004
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(HandleCollector004), nameof(request), request);
        
        _ = _sync085Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from HandleCollector004";
    }

}
