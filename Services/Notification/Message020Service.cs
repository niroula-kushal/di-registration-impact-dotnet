using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.Notification;

public interface IMessage020Service
{
    Task<int> ProcessMessage020(string value);
    int ExecuteMessage020(string value);
}

public class Message020Service : IMessage020Service
{
    private readonly ILogger<Message020Service> _logger;
    private readonly IInvoice146Service _invoice146Service;
    private readonly IImport030Service _import030Service;

    public Message020Service(ILogger<Message020Service> logger, IInvoice146Service invoice146Service, IImport030Service import030Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _invoice146Service = invoice146Service ?? throw new ArgumentNullException(nameof(invoice146Service));
        _import030Service = import030Service ?? throw new ArgumentNullException(nameof(import030Service));
    }

    public async Task<int> ProcessMessage020(string value)
    {
        // Implementation for ProcessMessage020
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessMessage020), nameof(value), value);
        
        _ = _import030Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

    public int ExecuteMessage020(string value)
    {
        // Implementation for ExecuteMessage020
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ExecuteMessage020), nameof(value), value);
        
        _ = _import030Service; // Using dependency
        return 42;
    }

}
