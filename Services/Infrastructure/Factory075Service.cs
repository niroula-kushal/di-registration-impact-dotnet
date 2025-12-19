using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.External;

namespace stream_response_ef_core.Services.Infrastructure;

public interface IFactory075Service
{
    string ProcessFactory075(Guid data);
    string CreateFactory075(Guid id);
}

public class Factory075Service : IFactory075Service
{
    private readonly ILogger<Factory075Service> _logger;
    private readonly IProvider054Service _provider054Service;
    private readonly IManager002Service _manager002Service;
    private readonly IHandler025Service _handler025Service;

    public Factory075Service(ILogger<Factory075Service> logger, IProvider054Service provider054Service, IManager002Service manager002Service, IHandler025Service handler025Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _provider054Service = provider054Service ?? throw new ArgumentNullException(nameof(provider054Service));
        _manager002Service = manager002Service ?? throw new ArgumentNullException(nameof(manager002Service));
        _handler025Service = handler025Service ?? throw new ArgumentNullException(nameof(handler025Service));
    }

    public string ProcessFactory075(Guid data)
    {
        // Implementation for ProcessFactory075
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessFactory075), nameof(data), data);
        
        _ = _manager002Service; // Using dependency
        return $"Result from ProcessFactory075";
    }

    public string CreateFactory075(Guid id)
    {
        // Implementation for CreateFactory075
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CreateFactory075), nameof(id), id);
        
        _ = _handler025Service; // Using dependency
        return $"Result from CreateFactory075";
    }

}
