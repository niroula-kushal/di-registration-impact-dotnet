using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Data;
using stream_response_ef_core.Services.Infrastructure;

namespace stream_response_ef_core.Services.Monitoring;

public interface IMetric034Service
{
    int ProcessMetric034(int data);
    int StoreMetric034(string id);
}

public class Metric034Service : IMetric034Service
{
    private readonly ILogger<Metric034Service> _logger;
    private readonly ITransform009Service _transform009Service;
    private readonly IRegistry099Service _registry099Service;
    private readonly IAggregator001Service _aggregator001Service;
    private readonly ILocator020Service _locator020Service;

    public Metric034Service(ILogger<Metric034Service> logger, ITransform009Service transform009Service, IRegistry099Service registry099Service, IAggregator001Service aggregator001Service, ILocator020Service locator020Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _transform009Service = transform009Service ?? throw new ArgumentNullException(nameof(transform009Service));
        _registry099Service = registry099Service ?? throw new ArgumentNullException(nameof(registry099Service));
        _aggregator001Service = aggregator001Service ?? throw new ArgumentNullException(nameof(aggregator001Service));
        _locator020Service = locator020Service ?? throw new ArgumentNullException(nameof(locator020Service));
    }

    public int ProcessMetric034(int data)
    {
        // Implementation for ProcessMetric034
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessMetric034), nameof(data), data);
        
        _ = _registry099Service; // Using dependency
        return 42;
    }

    public int StoreMetric034(string id)
    {
        // Implementation for StoreMetric034
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(StoreMetric034), nameof(id), id);
        
        _ = _locator020Service; // Using dependency
        return 42;
    }

}
