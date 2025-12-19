using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Data;

public interface ICommand033Service
{
    void ProcessCommand033(string value);
    void ExecuteCommand033(object input);
}

public class Command033Service : ICommand033Service
{
    private readonly ILogger<Command033Service> _logger;
    private readonly ICheck007Service _check007Service;
    private readonly IPermission029Service _permission029Service;

    public Command033Service(ILogger<Command033Service> logger, ICheck007Service check007Service, IPermission029Service permission029Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _check007Service = check007Service ?? throw new ArgumentNullException(nameof(check007Service));
        _permission029Service = permission029Service ?? throw new ArgumentNullException(nameof(permission029Service));
    }

    public void ProcessCommand033(string value)
    {
        // Implementation for ProcessCommand033
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessCommand033), nameof(value), value);
        
        _ = _permission029Service; // Using dependency
    }

    public void ExecuteCommand033(object input)
    {
        // Implementation for ExecuteCommand033
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ExecuteCommand033), nameof(input), input);
        
        _ = _check007Service; // Using dependency
    }

}
