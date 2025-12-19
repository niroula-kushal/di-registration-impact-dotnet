using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.External;
using stream_response_ef_core.Services.Infrastructure;

namespace stream_response_ef_core.Services.Notification;

public interface IEmail012Service
{
    int ProcessEmail012(int request);
    Task<int> ReceiveEmail012(string value);
}

public class Email012Service : IEmail012Service
{
    private readonly ILogger<Email012Service> _logger;
    private readonly IAdapter077Service _adapter077Service;
    private readonly IBuilder025Service _builder025Service;

    public Email012Service(ILogger<Email012Service> logger, IAdapter077Service adapter077Service, IBuilder025Service builder025Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _adapter077Service = adapter077Service ?? throw new ArgumentNullException(nameof(adapter077Service));
        _builder025Service = builder025Service ?? throw new ArgumentNullException(nameof(builder025Service));
    }

    public int ProcessEmail012(int request)
    {
        // Implementation for ProcessEmail012
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessEmail012), nameof(request), request);
        
        _ = _builder025Service; // Using dependency
        return 42;
    }

    public async Task<int> ReceiveEmail012(string value)
    {
        // Implementation for ReceiveEmail012
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ReceiveEmail012), nameof(value), value);
        
        _ = _adapter077Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

}
