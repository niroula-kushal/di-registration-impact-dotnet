using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.External;

namespace stream_response_ef_core.Services.Payment;

public interface IMethodService
{
    bool ProcessMethod(string value);
    Task<int> TransformMethod(string input);
    void ExecuteMethod(object input);
}

public class MethodService : IMethodService
{
    private readonly ILogger<MethodService> _logger;
    private readonly IGateway009Service _gateway009Service;
    private readonly IInvoice059Service _invoice059Service;

    public MethodService(ILogger<MethodService> logger, IGateway009Service gateway009Service, IInvoice059Service invoice059Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _gateway009Service = gateway009Service ?? throw new ArgumentNullException(nameof(gateway009Service));
        _invoice059Service = invoice059Service ?? throw new ArgumentNullException(nameof(invoice059Service));
    }

    public bool ProcessMethod(string value)
    {
        // Implementation for ProcessMethod
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessMethod), nameof(value), value);
        
        _ = _gateway009Service; // Using dependency
        return true;
    }

    public async Task<int> TransformMethod(string input)
    {
        // Implementation for TransformMethod
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(TransformMethod), nameof(input), input);
        
        _ = _invoice059Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

    public void ExecuteMethod(object input)
    {
        // Implementation for ExecuteMethod
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ExecuteMethod), nameof(input), input);
        
        _ = _gateway009Service; // Using dependency
    }

}
