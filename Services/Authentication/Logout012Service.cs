using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace stream_response_ef_core.Services.Authentication;

public interface ILogout012Service
{
    void ProcessLogout012(int value);
    int ExecuteLogout012(Guid data);
}

public class Logout012Service : ILogout012Service
{
    private readonly ILogger<Logout012Service> _logger;
    private readonly IApiKey003Service _apiKey003Service;
    private readonly IOAuth001Service _oAuth001Service;

    public Logout012Service(ILogger<Logout012Service> logger, IApiKey003Service apiKey003Service, IOAuth001Service oAuth001Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _apiKey003Service = apiKey003Service ?? throw new ArgumentNullException(nameof(apiKey003Service));
        _oAuth001Service = oAuth001Service ?? throw new ArgumentNullException(nameof(oAuth001Service));
    }

    public void ProcessLogout012(int value)
    {
        // Implementation for ProcessLogout012
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessLogout012), nameof(value), value);
        
        _ = _apiKey003Service; // Using dependency
    }

    public int ExecuteLogout012(Guid data)
    {
        // Implementation for ExecuteLogout012
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ExecuteLogout012), nameof(data), data);
        
        _ = _oAuth001Service; // Using dependency
        return 42;
    }

}
