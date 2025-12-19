using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Analytics;
using stream_response_ef_core.Services.External;
using stream_response_ef_core.Services.Logging;
using stream_response_ef_core.Services.Notification;

namespace stream_response_ef_core.Services.Monitoring;

public interface ICollector010Service
{
    string ProcessCollector010(int data);
    Task<string> ReceiveCollector010(object id);
}

public class Collector010Service : ICollector010Service
{
    private readonly ILogger<Collector010Service> _logger;
    private readonly IApi040Service _api040Service;
    private readonly ITemplate021Service _template021Service;
    private readonly IMetric044Service _metric044Service;
    private readonly IAppender010Service _appender010Service;

    public Collector010Service(ILogger<Collector010Service> logger, IApi040Service api040Service, ITemplate021Service template021Service, IMetric044Service metric044Service, IAppender010Service appender010Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _api040Service = api040Service ?? throw new ArgumentNullException(nameof(api040Service));
        _template021Service = template021Service ?? throw new ArgumentNullException(nameof(template021Service));
        _metric044Service = metric044Service ?? throw new ArgumentNullException(nameof(metric044Service));
        _appender010Service = appender010Service ?? throw new ArgumentNullException(nameof(appender010Service));
    }

    public string ProcessCollector010(int data)
    {
        // Implementation for ProcessCollector010
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessCollector010), nameof(data), data);
        
        _ = _template021Service; // Using dependency
        return $"Result from ProcessCollector010";
    }

    public async Task<string> ReceiveCollector010(object id)
    {
        // Implementation for ReceiveCollector010
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ReceiveCollector010), nameof(id), id);
        
        _ = _metric044Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from ReceiveCollector010";
    }

}
