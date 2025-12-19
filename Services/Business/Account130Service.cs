using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Business;

public interface IAccount130Service
{
    string ProcessAccount130(object value);
    int ExecuteAccount130(string id);
}

public class Account130Service : IAccount130Service
{
    private readonly ILogger<Account130Service> _logger;
    private readonly IProduct040Service _product040Service;
    private readonly IVerify037Service _verify037Service;

    public Account130Service(ILogger<Account130Service> logger, IProduct040Service product040Service, IVerify037Service verify037Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _product040Service = product040Service ?? throw new ArgumentNullException(nameof(product040Service));
        _verify037Service = verify037Service ?? throw new ArgumentNullException(nameof(verify037Service));
    }

    public string ProcessAccount130(object value)
    {
        // Implementation for ProcessAccount130
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessAccount130), nameof(value), value);
        
        _ = _verify037Service; // Using dependency
        return $"Result from ProcessAccount130";
    }

    public int ExecuteAccount130(string id)
    {
        // Implementation for ExecuteAccount130
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ExecuteAccount130), nameof(id), id);
        
        _ = _product040Service; // Using dependency
        return 42;
    }

}
