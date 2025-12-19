using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.External;
using stream_response_ef_core.Services.Infrastructure;

namespace stream_response_ef_core.Services.Workflow;

public interface IEngine004Service
{
    void ProcessEngine004(object data);
    void DeleteEngine004(object id);
}

public class Engine004Service : IEngine004Service
{
    private readonly ILogger<Engine004Service> _logger;
    private readonly IApi001Service _api001Service;
    private readonly IBuilder082Service _builder082Service;

    public Engine004Service(ILogger<Engine004Service> logger, IApi001Service api001Service, IBuilder082Service builder082Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _api001Service = api001Service ?? throw new ArgumentNullException(nameof(api001Service));
        _builder082Service = builder082Service ?? throw new ArgumentNullException(nameof(builder082Service));
    }

    public void ProcessEngine004(object data)
    {
        // Implementation for ProcessEngine004
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessEngine004), nameof(data), data);
        
        _ = _api001Service; // Using dependency
    }

    public void DeleteEngine004(object id)
    {
        // Implementation for DeleteEngine004
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(DeleteEngine004), nameof(id), id);
        
        _ = _api001Service; // Using dependency
    }

}
