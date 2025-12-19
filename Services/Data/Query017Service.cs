using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Data;

public interface IQuery017Service
{
    Task<string> ProcessQuery017(Guid request);
    Task<string> GetQuery017(int request);
}

public class Query017Service : IQuery017Service
{
    private readonly ILogger<Query017Service> _logger;
    private readonly IVerify035Service _verify035Service;
    private readonly IEnforce021Service _enforce021Service;

    public Query017Service(ILogger<Query017Service> logger, IVerify035Service verify035Service, IEnforce021Service enforce021Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _verify035Service = verify035Service ?? throw new ArgumentNullException(nameof(verify035Service));
        _enforce021Service = enforce021Service ?? throw new ArgumentNullException(nameof(enforce021Service));
    }

    public async Task<string> ProcessQuery017(Guid request)
    {
        // Implementation for ProcessQuery017
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessQuery017), nameof(request), request);
        
        _ = _verify035Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from ProcessQuery017";
    }

    public async Task<string> GetQuery017(int request)
    {
        // Implementation for GetQuery017
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(GetQuery017), nameof(request), request);
        
        _ = _enforce021Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from GetQuery017";
    }

}
