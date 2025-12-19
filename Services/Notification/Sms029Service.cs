using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;
using stream_response_ef_core.Services.Infrastructure;

namespace stream_response_ef_core.Services.Notification;

public interface ISms029Service
{
    int ProcessSms029(string input);
    string CalculateSms029(int data);
    void SearchSms029(int request);
}

public class Sms029Service : ISms029Service
{
    private readonly ILogger<Sms029Service> _logger;
    private readonly IProvider015Service _provider015Service;
    private readonly IProvider070Service _provider070Service;
    private readonly IPermission023Service _permission023Service;

    public Sms029Service(ILogger<Sms029Service> logger, IProvider015Service provider015Service, IProvider070Service provider070Service, IPermission023Service permission023Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _provider015Service = provider015Service ?? throw new ArgumentNullException(nameof(provider015Service));
        _provider070Service = provider070Service ?? throw new ArgumentNullException(nameof(provider070Service));
        _permission023Service = permission023Service ?? throw new ArgumentNullException(nameof(permission023Service));
    }

    public int ProcessSms029(string input)
    {
        // Implementation for ProcessSms029
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessSms029), nameof(input), input);
        
        _ = _provider015Service; // Using dependency
        return 42;
    }

    public string CalculateSms029(int data)
    {
        // Implementation for CalculateSms029
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CalculateSms029), nameof(data), data);
        
        _ = _provider015Service; // Using dependency
        return $"Result from CalculateSms029";
    }

    public void SearchSms029(int request)
    {
        // Implementation for SearchSms029
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SearchSms029), nameof(request), request);
        
        _ = _provider015Service; // Using dependency
    }

}
