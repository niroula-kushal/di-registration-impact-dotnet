using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace stream_response_ef_core.Services.Authentication;

public interface IUserAuth017Service
{
    Task<int> ProcessUserAuth017(string request);
    int ProcessUserAuth017(object request);
}

public class UserAuth017Service : IUserAuth017Service
{
    private readonly ILogger<UserAuth017Service> _logger;
    private readonly IUserAuth015Service _userAuth015Service;
    private readonly IUserAuth010Service _userAuth010Service;
    private readonly IOAuth016Service _oAuth016Service;

    public UserAuth017Service(ILogger<UserAuth017Service> logger, IUserAuth015Service userAuth015Service, IUserAuth010Service userAuth010Service, IOAuth016Service oAuth016Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _userAuth015Service = userAuth015Service ?? throw new ArgumentNullException(nameof(userAuth015Service));
        _userAuth010Service = userAuth010Service ?? throw new ArgumentNullException(nameof(userAuth010Service));
        _oAuth016Service = oAuth016Service ?? throw new ArgumentNullException(nameof(oAuth016Service));
    }

    public async Task<int> ProcessUserAuth017(string request)
    {
        // Implementation for ProcessUserAuth017
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessUserAuth017), nameof(request), request);
        
        _ = _userAuth010Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

    public int ProcessUserAuth017(object request)
    {
        // Implementation for ProcessUserAuth017
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessUserAuth017), nameof(request), request);
        
        _ = _oAuth016Service; // Using dependency
        return 42;
    }

}
