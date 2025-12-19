using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace stream_response_ef_core.Services.Authentication;

public interface ILogin033Service
{
    Task<int> ProcessLogin033(int data);
    int CreateLogin033(string data);
}

public class Login033Service : ILogin033Service
{
    private readonly ILogger<Login033Service> _logger;
    private readonly ILogout012Service _logout012Service;
    private readonly IUserAuth010Service _userAuth010Service;

    public Login033Service(ILogger<Login033Service> logger, ILogout012Service logout012Service, IUserAuth010Service userAuth010Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _logout012Service = logout012Service ?? throw new ArgumentNullException(nameof(logout012Service));
        _userAuth010Service = userAuth010Service ?? throw new ArgumentNullException(nameof(userAuth010Service));
    }

    public async Task<int> ProcessLogin033(int data)
    {
        // Implementation for ProcessLogin033
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessLogin033), nameof(data), data);
        
        _ = _userAuth010Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

    public int CreateLogin033(string data)
    {
        // Implementation for CreateLogin033
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CreateLogin033), nameof(data), data);
        
        _ = _userAuth010Service; // Using dependency
        return 42;
    }

}
