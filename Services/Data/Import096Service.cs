using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;

namespace stream_response_ef_core.Services.Data;

public interface IImport096Service
{
    int ProcessImport096(string id);
    bool SortImport096(Guid data);
}

public class Import096Service : IImport096Service
{
    private readonly ILogger<Import096Service> _logger;
    private readonly ISession045Service _session045Service;
    private readonly ICommand081Service _command081Service;

    public Import096Service(ILogger<Import096Service> logger, ISession045Service session045Service, ICommand081Service command081Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _session045Service = session045Service ?? throw new ArgumentNullException(nameof(session045Service));
        _command081Service = command081Service ?? throw new ArgumentNullException(nameof(command081Service));
    }

    public int ProcessImport096(string id)
    {
        // Implementation for ProcessImport096
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessImport096), nameof(id), id);
        
        _ = _session045Service; // Using dependency
        return 42;
    }

    public bool SortImport096(Guid data)
    {
        // Implementation for SortImport096
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SortImport096), nameof(data), data);
        
        _ = _session045Service; // Using dependency
        return true;
    }

}
