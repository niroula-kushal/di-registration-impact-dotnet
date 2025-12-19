using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Notification;

namespace stream_response_ef_core.Services.Security;

public interface IKey014Service
{
    int ProcessKey014(int request);
    void SendKey014(Guid data);
}

public class Key014Service : IKey014Service
{
    private readonly ILogger<Key014Service> _logger;
    private readonly ISms029Service _sms029Service;
    private readonly IQueue049Service _queue049Service;

    public Key014Service(ILogger<Key014Service> logger, ISms029Service sms029Service, IQueue049Service queue049Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _sms029Service = sms029Service ?? throw new ArgumentNullException(nameof(sms029Service));
        _queue049Service = queue049Service ?? throw new ArgumentNullException(nameof(queue049Service));
    }

    public int ProcessKey014(int request)
    {
        // Implementation for ProcessKey014
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessKey014), nameof(request), request);
        
        _ = _queue049Service; // Using dependency
        return 42;
    }

    public void SendKey014(Guid data)
    {
        // Implementation for SendKey014
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SendKey014), nameof(data), data);
        
        _ = _queue049Service; // Using dependency
    }

}
