using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace stream_response_ef_core.Services.Authentication;

public interface IRefreshService
{
    int ProcessRefresh(int value);
    Task<string> TransformRefresh(int input);
    int CreateRefresh(Guid id);
}

public class RefreshService : IRefreshService
{
    private readonly ILogger<RefreshService> _logger;

    public RefreshService(ILogger<RefreshService> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public int ProcessRefresh(int value)
    {
        // Implementation for ProcessRefresh
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessRefresh), nameof(value), value);
        
        return 42;
    }

    public async Task<string> TransformRefresh(int input)
    {
        // Implementation for TransformRefresh
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(TransformRefresh), nameof(input), input);
        
        return $"Result from TransformRefresh";
    }

    public int CreateRefresh(Guid id)
    {
        // Implementation for CreateRefresh
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CreateRefresh), nameof(id), id);
        
        return 42;
    }

}
