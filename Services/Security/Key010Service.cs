using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Security;

public interface IKey010Service
{
    string ProcessKey010(string input);
    bool StoreKey010(Guid request);
}

public class Key010Service : IKey010Service
{
    private readonly ILogger<Key010Service> _logger;
    private readonly IPermission019Service _permission019Service;
    private readonly IQuote003Service _quote003Service;

    public Key010Service(ILogger<Key010Service> logger, IPermission019Service permission019Service, IQuote003Service quote003Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _permission019Service = permission019Service ?? throw new ArgumentNullException(nameof(permission019Service));
        _quote003Service = quote003Service ?? throw new ArgumentNullException(nameof(quote003Service));
    }

    public string ProcessKey010(string input)
    {
        // Implementation for ProcessKey010
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessKey010), nameof(input), input);
        
        _ = _quote003Service; // Using dependency
        return $"Result from ProcessKey010";
    }

    public bool StoreKey010(Guid request)
    {
        // Implementation for StoreKey010
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(StoreKey010), nameof(request), request);
        
        _ = _quote003Service; // Using dependency
        return true;
    }

}
