using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.External;
using stream_response_ef_core.Services.Validation;

namespace stream_response_ef_core.Services.Monitoring;

public interface IAggregator021Service
{
    bool ProcessAggregator021(Guid request);
    bool FilterAggregator021(string data);
}

public class Aggregator021Service : IAggregator021Service
{
    private readonly ILogger<Aggregator021Service> _logger;
    private readonly IValidator011Service _validator011Service;
    private readonly IInterface073Service _interface073Service;

    public Aggregator021Service(ILogger<Aggregator021Service> logger, IValidator011Service validator011Service, IInterface073Service interface073Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _validator011Service = validator011Service ?? throw new ArgumentNullException(nameof(validator011Service));
        _interface073Service = interface073Service ?? throw new ArgumentNullException(nameof(interface073Service));
    }

    public bool ProcessAggregator021(Guid request)
    {
        // Implementation for ProcessAggregator021
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessAggregator021), nameof(request), request);
        
        _ = _interface073Service; // Using dependency
        return true;
    }

    public bool FilterAggregator021(string data)
    {
        // Implementation for FilterAggregator021
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(FilterAggregator021), nameof(data), data);
        
        _ = _interface073Service; // Using dependency
        return true;
    }

}
