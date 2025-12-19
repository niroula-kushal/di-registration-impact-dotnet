using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Infrastructure;

public interface IManager026Service
{
    Task<int> ProcessManager026(Guid request);
    void ProcessManager026(int request);
}

public class Manager026Service : IManager026Service
{
    private readonly ILogger<Manager026Service> _logger;
    private readonly IProduct099Service _product099Service;
    private readonly IRegistry001Service _registry001Service;

    public Manager026Service(ILogger<Manager026Service> logger, IProduct099Service product099Service, IRegistry001Service registry001Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _product099Service = product099Service ?? throw new ArgumentNullException(nameof(product099Service));
        _registry001Service = registry001Service ?? throw new ArgumentNullException(nameof(registry001Service));
    }

    public async Task<int> ProcessManager026(Guid request)
    {
        // Implementation for ProcessManager026
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessManager026), nameof(request), request);
        
        _ = _product099Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

    public void ProcessManager026(int request)
    {
        // Implementation for ProcessManager026
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessManager026), nameof(request), request);
        
        _ = _registry001Service; // Using dependency
    }

}
