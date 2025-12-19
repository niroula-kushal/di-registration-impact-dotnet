using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.Payment;

public interface IReceipt061Service
{
    void ProcessReceipt061(string data);
    Task<string> CreateReceipt061(int data);
}

public class Receipt061Service : IReceipt061Service
{
    private readonly ILogger<Receipt061Service> _logger;
    private readonly ICommand060Service _command060Service;
    private readonly IVerify036Service _verify036Service;

    public Receipt061Service(ILogger<Receipt061Service> logger, ICommand060Service command060Service, IVerify036Service verify036Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _command060Service = command060Service ?? throw new ArgumentNullException(nameof(command060Service));
        _verify036Service = verify036Service ?? throw new ArgumentNullException(nameof(verify036Service));
    }

    public void ProcessReceipt061(string data)
    {
        // Implementation for ProcessReceipt061
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessReceipt061), nameof(data), data);
        
        _ = _verify036Service; // Using dependency
    }

    public async Task<string> CreateReceipt061(int data)
    {
        // Implementation for CreateReceipt061
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CreateReceipt061), nameof(data), data);
        
        _ = _command060Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from CreateReceipt061";
    }

}
