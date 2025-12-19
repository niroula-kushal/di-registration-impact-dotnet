using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.Infrastructure;

public interface IResource091Service
{
    string ProcessResource091(string request);
    void SearchResource091(object value);
}

public class Resource091Service : IResource091Service
{
    private readonly ILogger<Resource091Service> _logger;
    private readonly IBuilder068Service _builder068Service;
    private readonly IRestore088Service _restore088Service;

    public Resource091Service(ILogger<Resource091Service> logger, IBuilder068Service builder068Service, IRestore088Service restore088Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _builder068Service = builder068Service ?? throw new ArgumentNullException(nameof(builder068Service));
        _restore088Service = restore088Service ?? throw new ArgumentNullException(nameof(restore088Service));
    }

    public string ProcessResource091(string request)
    {
        // Implementation for ProcessResource091
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessResource091), nameof(request), request);
        
        _ = _builder068Service; // Using dependency
        return $"Result from ProcessResource091";
    }

    public void SearchResource091(object value)
    {
        // Implementation for SearchResource091
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SearchResource091), nameof(value), value);
        
        _ = _builder068Service; // Using dependency
    }

}
