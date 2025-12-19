using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;

namespace stream_response_ef_core.Services.Data;

public interface IExport087Service
{
    string ProcessExport087(object request);
    int SendExport087(string input);
}

public class Export087Service : IExport087Service
{
    private readonly ILogger<Export087Service> _logger;
    private readonly ITransform034Service _transform034Service;
    private readonly ISession021Service _session021Service;

    public Export087Service(ILogger<Export087Service> logger, ITransform034Service transform034Service, ISession021Service session021Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _transform034Service = transform034Service ?? throw new ArgumentNullException(nameof(transform034Service));
        _session021Service = session021Service ?? throw new ArgumentNullException(nameof(session021Service));
    }

    public string ProcessExport087(object request)
    {
        // Implementation for ProcessExport087
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessExport087), nameof(request), request);
        
        _ = _session021Service; // Using dependency
        return $"Result from ProcessExport087";
    }

    public int SendExport087(string input)
    {
        // Implementation for SendExport087
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SendExport087), nameof(input), input);
        
        _ = _session021Service; // Using dependency
        return 42;
    }

}
