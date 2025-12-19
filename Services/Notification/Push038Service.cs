using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;
using stream_response_ef_core.Services.External;

namespace stream_response_ef_core.Services.Notification;

public interface IPush038Service
{
    bool ProcessPush038(string request);
    bool ExecutePush038(int request);
}

public class Push038Service : IPush038Service
{
    private readonly ILogger<Push038Service> _logger;
    private readonly IAdapter031Service _adapter031Service;
    private readonly IEnforce014Service _enforce014Service;

    public Push038Service(ILogger<Push038Service> logger, IAdapter031Service adapter031Service, IEnforce014Service enforce014Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _adapter031Service = adapter031Service ?? throw new ArgumentNullException(nameof(adapter031Service));
        _enforce014Service = enforce014Service ?? throw new ArgumentNullException(nameof(enforce014Service));
    }

    public bool ProcessPush038(string request)
    {
        // Implementation for ProcessPush038
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessPush038), nameof(request), request);
        
        _ = _adapter031Service; // Using dependency
        return true;
    }

    public bool ExecutePush038(int request)
    {
        // Implementation for ExecutePush038
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ExecutePush038), nameof(request), request);
        
        _ = _enforce014Service; // Using dependency
        return true;
    }

}
