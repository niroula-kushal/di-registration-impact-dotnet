using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;

namespace stream_response_ef_core.Services.Authorization;

public interface IEnforce027Service
{
    string ProcessEnforce027(int input);
    void SortEnforce027(string id);
}

public class Enforce027Service : IEnforce027Service
{
    private readonly ILogger<Enforce027Service> _logger;
    private readonly IPermission023Service _permission023Service;
    private readonly IRefresh034Service _refresh034Service;

    public Enforce027Service(ILogger<Enforce027Service> logger, IPermission023Service permission023Service, IRefresh034Service refresh034Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _permission023Service = permission023Service ?? throw new ArgumentNullException(nameof(permission023Service));
        _refresh034Service = refresh034Service ?? throw new ArgumentNullException(nameof(refresh034Service));
    }

    public string ProcessEnforce027(int input)
    {
        // Implementation for ProcessEnforce027
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessEnforce027), nameof(input), input);
        
        _ = _refresh034Service; // Using dependency
        return $"Result from ProcessEnforce027";
    }

    public void SortEnforce027(string id)
    {
        // Implementation for SortEnforce027
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SortEnforce027), nameof(id), id);
        
        _ = _permission023Service; // Using dependency
    }

}
