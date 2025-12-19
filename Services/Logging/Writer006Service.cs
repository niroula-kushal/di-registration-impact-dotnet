using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Reporting;
using stream_response_ef_core.Services.Workflow;

namespace stream_response_ef_core.Services.Logging;

public interface IWriter006Service
{
    int ProcessWriter006(Guid id);
    void UpdateWriter006(int request);
}

public class Writer006Service : IWriter006Service
{
    private readonly ILogger<Writer006Service> _logger;
    private readonly IHandler017Service _handler017Service;
    private readonly IAggregator004Service _aggregator004Service;

    public Writer006Service(ILogger<Writer006Service> logger, IHandler017Service handler017Service, IAggregator004Service aggregator004Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _handler017Service = handler017Service ?? throw new ArgumentNullException(nameof(handler017Service));
        _aggregator004Service = aggregator004Service ?? throw new ArgumentNullException(nameof(aggregator004Service));
    }

    public int ProcessWriter006(Guid id)
    {
        // Implementation for ProcessWriter006
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessWriter006), nameof(id), id);
        
        _ = _handler017Service; // Using dependency
        return 42;
    }

    public void UpdateWriter006(int request)
    {
        // Implementation for UpdateWriter006
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(UpdateWriter006), nameof(request), request);
        
        _ = _aggregator004Service; // Using dependency
    }

}
