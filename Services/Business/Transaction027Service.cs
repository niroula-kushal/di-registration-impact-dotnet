using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Business;

public interface ITransaction027Service
{
    bool ProcessTransaction027(object input);
    string FormatTransaction027(int data);
}

public class Transaction027Service : ITransaction027Service
{
    private readonly ILogger<Transaction027Service> _logger;
    private readonly IPermission019Service _permission019Service;
    private readonly IGuard009Service _guard009Service;

    public Transaction027Service(ILogger<Transaction027Service> logger, IPermission019Service permission019Service, IGuard009Service guard009Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _permission019Service = permission019Service ?? throw new ArgumentNullException(nameof(permission019Service));
        _guard009Service = guard009Service ?? throw new ArgumentNullException(nameof(guard009Service));
    }

    public bool ProcessTransaction027(object input)
    {
        // Implementation for ProcessTransaction027
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessTransaction027), nameof(input), input);
        
        _ = _permission019Service; // Using dependency
        return true;
    }

    public string FormatTransaction027(int data)
    {
        // Implementation for FormatTransaction027
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(FormatTransaction027), nameof(data), data);
        
        _ = _guard009Service; // Using dependency
        return $"Result from FormatTransaction027";
    }

}
