using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.Notification;

public interface IQueue036Service
{
    Task<int> ProcessQueue036(int data);
    string DeleteQueue036(string id);
}

public class Queue036Service : IQueue036Service
{
    private readonly ILogger<Queue036Service> _logger;
    private readonly ICommand081Service _command081Service;
    private readonly ICustomer021Service _customer021Service;

    public Queue036Service(ILogger<Queue036Service> logger, ICommand081Service command081Service, ICustomer021Service customer021Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _command081Service = command081Service ?? throw new ArgumentNullException(nameof(command081Service));
        _customer021Service = customer021Service ?? throw new ArgumentNullException(nameof(customer021Service));
    }

    public async Task<int> ProcessQueue036(int data)
    {
        // Implementation for ProcessQueue036
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessQueue036), nameof(data), data);
        
        _ = _customer021Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

    public string DeleteQueue036(string id)
    {
        // Implementation for DeleteQueue036
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(DeleteQueue036), nameof(id), id);
        
        _ = _customer021Service; // Using dependency
        return $"Result from DeleteQueue036";
    }

}
