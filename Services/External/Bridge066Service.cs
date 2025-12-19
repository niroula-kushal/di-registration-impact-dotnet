using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.External;

public interface IBridge066Service
{
    void ProcessBridge066(int data);
    Task<int> StoreBridge066(Guid request);
}

public class Bridge066Service : IBridge066Service
{
    private readonly ILogger<Bridge066Service> _logger;
    private readonly IContract110Service _contract110Service;
    private readonly IBridge020Service _bridge020Service;

    public Bridge066Service(ILogger<Bridge066Service> logger, IContract110Service contract110Service, IBridge020Service bridge020Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _contract110Service = contract110Service ?? throw new ArgumentNullException(nameof(contract110Service));
        _bridge020Service = bridge020Service ?? throw new ArgumentNullException(nameof(bridge020Service));
    }

    public void ProcessBridge066(int data)
    {
        // Implementation for ProcessBridge066
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessBridge066), nameof(data), data);
        
        _ = _bridge020Service; // Using dependency
    }

    public async Task<int> StoreBridge066(Guid request)
    {
        // Implementation for StoreBridge066
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(StoreBridge066), nameof(request), request);
        
        _ = _bridge020Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

}
