using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace stream_response_ef_core.Services.Data;

public interface IImport030Service
{
    string ProcessImport030(int value);
    void ValidateImport030(object request);
}

public class Import030Service : IImport030Service
{
    private readonly ILogger<Import030Service> _logger;
    private readonly IRestore004Service _restore004Service;
    private readonly IRestore020Service _restore020Service;

    public Import030Service(ILogger<Import030Service> logger, IRestore004Service restore004Service, IRestore020Service restore020Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _restore004Service = restore004Service ?? throw new ArgumentNullException(nameof(restore004Service));
        _restore020Service = restore020Service ?? throw new ArgumentNullException(nameof(restore020Service));
    }

    public string ProcessImport030(int value)
    {
        // Implementation for ProcessImport030
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessImport030), nameof(value), value);
        
        _ = _restore020Service; // Using dependency
        return $"Result from ProcessImport030";
    }

    public void ValidateImport030(object request)
    {
        // Implementation for ValidateImport030
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ValidateImport030), nameof(request), request);
        
        _ = _restore004Service; // Using dependency
    }

}
