using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.External;

public interface IAdapter031Service
{
    int ProcessAdapter031(Guid data);
    string UpdateAdapter031(string id);
}

public class Adapter031Service : IAdapter031Service
{
    private readonly ILogger<Adapter031Service> _logger;
    private readonly IContract038Service _contract038Service;
    private readonly IExport013Service _export013Service;

    public Adapter031Service(ILogger<Adapter031Service> logger, IContract038Service contract038Service, IExport013Service export013Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _contract038Service = contract038Service ?? throw new ArgumentNullException(nameof(contract038Service));
        _export013Service = export013Service ?? throw new ArgumentNullException(nameof(export013Service));
    }

    public int ProcessAdapter031(Guid data)
    {
        // Implementation for ProcessAdapter031
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessAdapter031), nameof(data), data);
        
        _ = _contract038Service; // Using dependency
        return 42;
    }

    public string UpdateAdapter031(string id)
    {
        // Implementation for UpdateAdapter031
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(UpdateAdapter031), nameof(id), id);
        
        _ = _export013Service; // Using dependency
        return $"Result from UpdateAdapter031";
    }

}
