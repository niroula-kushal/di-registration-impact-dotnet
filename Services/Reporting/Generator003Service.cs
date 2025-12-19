using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.External;

namespace stream_response_ef_core.Services.Reporting;

public interface IGenerator003Service
{
    string ProcessGenerator003(Guid input);
    void DeleteGenerator003(Guid request);
}

public class Generator003Service : IGenerator003Service
{
    private readonly ILogger<Generator003Service> _logger;
    private readonly IInterface013Service _interface013Service;
    private readonly IApi070Service _api070Service;

    public Generator003Service(ILogger<Generator003Service> logger, IInterface013Service interface013Service, IApi070Service api070Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _interface013Service = interface013Service ?? throw new ArgumentNullException(nameof(interface013Service));
        _api070Service = api070Service ?? throw new ArgumentNullException(nameof(api070Service));
    }

    public string ProcessGenerator003(Guid input)
    {
        // Implementation for ProcessGenerator003
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessGenerator003), nameof(input), input);
        
        _ = _api070Service; // Using dependency
        return $"Result from ProcessGenerator003";
    }

    public void DeleteGenerator003(Guid request)
    {
        // Implementation for DeleteGenerator003
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(DeleteGenerator003), nameof(request), request);
        
        _ = _interface013Service; // Using dependency
    }

}
