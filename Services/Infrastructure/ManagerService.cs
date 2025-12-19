using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.Infrastructure;

public interface IManagerService
{
    bool ProcessManager(object request);
    int StoreManager(Guid request);
}

public class ManagerService : IManagerService
{
    private readonly ILogger<ManagerService> _logger;
    private readonly ITransform024Service _transform024Service;
    private readonly ITransaction015Service _transaction015Service;

    public ManagerService(ILogger<ManagerService> logger, ITransform024Service transform024Service, ITransaction015Service transaction015Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _transform024Service = transform024Service ?? throw new ArgumentNullException(nameof(transform024Service));
        _transaction015Service = transaction015Service ?? throw new ArgumentNullException(nameof(transaction015Service));
    }

    public bool ProcessManager(object request)
    {
        // Implementation for ProcessManager
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessManager), nameof(request), request);
        
        _ = _transaction015Service; // Using dependency
        return true;
    }

    public int StoreManager(Guid request)
    {
        // Implementation for StoreManager
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(StoreManager), nameof(request), request);
        
        _ = _transaction015Service; // Using dependency
        return 42;
    }

}
