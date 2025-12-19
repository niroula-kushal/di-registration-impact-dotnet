using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;

namespace stream_response_ef_core.Services.Authorization;

public interface IGuard010Service
{
    void ProcessGuard010(string request);
    void ValidateGuard010(int value);
}

public class Guard010Service : IGuard010Service
{
    private readonly ILogger<Guard010Service> _logger;
    private readonly IUserAuth017Service _userAuth017Service;
    private readonly IRefresh040Service _refresh040Service;

    public Guard010Service(ILogger<Guard010Service> logger, IUserAuth017Service userAuth017Service, IRefresh040Service refresh040Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _userAuth017Service = userAuth017Service ?? throw new ArgumentNullException(nameof(userAuth017Service));
        _refresh040Service = refresh040Service ?? throw new ArgumentNullException(nameof(refresh040Service));
    }

    public void ProcessGuard010(string request)
    {
        // Implementation for ProcessGuard010
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessGuard010), nameof(request), request);
        
        _ = _refresh040Service; // Using dependency
    }

    public void ValidateGuard010(int value)
    {
        // Implementation for ValidateGuard010
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ValidateGuard010), nameof(value), value);
        
        _ = _refresh040Service; // Using dependency
    }

}
