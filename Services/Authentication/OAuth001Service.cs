using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace stream_response_ef_core.Services.Authentication;

public interface IOAuth001Service
{
    Task<int> ProcessOAuth001(Guid value);
    void ExecuteOAuth001(object data);
}

public class OAuth001Service : IOAuth001Service
{
    private readonly ILogger<OAuth001Service> _logger;
    private readonly IRefreshService _refreshService;

    public OAuth001Service(ILogger<OAuth001Service> logger, IRefreshService refreshService)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _refreshService = refreshService ?? throw new ArgumentNullException(nameof(refreshService));
    }

    public async Task<int> ProcessOAuth001(Guid value)
    {
        // Implementation for ProcessOAuth001
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessOAuth001), nameof(value), value);
        
        _ = _refreshService; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

    public void ExecuteOAuth001(object data)
    {
        // Implementation for ExecuteOAuth001
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ExecuteOAuth001), nameof(data), data);
        
        _ = _refreshService; // Using dependency
    }

}
