using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.External;

public interface IApi040Service
{
    bool ProcessApi040(int value);
    void SortApi040(object data);
}

public class Api040Service : IApi040Service
{
    private readonly ILogger<Api040Service> _logger;
    private readonly IMigration070Service _migration070Service;
    private readonly ITransaction027Service _transaction027Service;

    public Api040Service(ILogger<Api040Service> logger, IMigration070Service migration070Service, ITransaction027Service transaction027Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _migration070Service = migration070Service ?? throw new ArgumentNullException(nameof(migration070Service));
        _transaction027Service = transaction027Service ?? throw new ArgumentNullException(nameof(transaction027Service));
    }

    public bool ProcessApi040(int value)
    {
        // Implementation for ProcessApi040
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessApi040), nameof(value), value);
        
        _ = _migration070Service; // Using dependency
        return true;
    }

    public void SortApi040(object data)
    {
        // Implementation for SortApi040
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SortApi040), nameof(data), data);
        
        _ = _migration070Service; // Using dependency
    }

}
