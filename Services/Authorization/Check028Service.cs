using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;

namespace stream_response_ef_core.Services.Authorization;

public interface ICheck028Service
{
    string ProcessCheck028(string request);
    string DeleteCheck028(Guid value);
}

public class Check028Service : ICheck028Service
{
    private readonly ILogger<Check028Service> _logger;
    private readonly IAccessService _accessService;
    private readonly ICheck002Service _check002Service;
    private readonly IJwt049Service _jwt049Service;

    public Check028Service(ILogger<Check028Service> logger, IAccessService accessService, ICheck002Service check002Service, IJwt049Service jwt049Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _accessService = accessService ?? throw new ArgumentNullException(nameof(accessService));
        _check002Service = check002Service ?? throw new ArgumentNullException(nameof(check002Service));
        _jwt049Service = jwt049Service ?? throw new ArgumentNullException(nameof(jwt049Service));
    }

    public string ProcessCheck028(string request)
    {
        // Implementation for ProcessCheck028
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessCheck028), nameof(request), request);
        
        _ = _jwt049Service; // Using dependency
        return $"Result from ProcessCheck028";
    }

    public string DeleteCheck028(Guid value)
    {
        // Implementation for DeleteCheck028
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(DeleteCheck028), nameof(value), value);
        
        _ = _check002Service; // Using dependency
        return $"Result from DeleteCheck028";
    }

}
