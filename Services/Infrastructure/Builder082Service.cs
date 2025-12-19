using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.Infrastructure;

public interface IBuilder082Service
{
    int ProcessBuilder082(Guid data);
    Task<int> ProcessBuilder082(string request);
}

public class Builder082Service : IBuilder082Service
{
    private readonly ILogger<Builder082Service> _logger;
    private readonly IRestore079Service _restore079Service;
    private readonly ISetting017Service _setting017Service;

    public Builder082Service(ILogger<Builder082Service> logger, IRestore079Service restore079Service, ISetting017Service setting017Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _restore079Service = restore079Service ?? throw new ArgumentNullException(nameof(restore079Service));
        _setting017Service = setting017Service ?? throw new ArgumentNullException(nameof(setting017Service));
    }

    public int ProcessBuilder082(Guid data)
    {
        // Implementation for ProcessBuilder082
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessBuilder082), nameof(data), data);
        
        _ = _restore079Service; // Using dependency
        return 42;
    }

    public async Task<int> ProcessBuilder082(string request)
    {
        // Implementation for ProcessBuilder082
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessBuilder082), nameof(request), request);
        
        _ = _restore079Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

}
