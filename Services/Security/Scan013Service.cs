using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Infrastructure;
using stream_response_ef_core.Services.Payment;

namespace stream_response_ef_core.Services.Security;

public interface IScan013Service
{
    void ProcessScan013(string request);
    string ReceiveScan013(object id);
}

public class Scan013Service : IScan013Service
{
    private readonly ILogger<Scan013Service> _logger;
    private readonly ILocator037Service _locator037Service;
    private readonly IProcessor030Service _processor030Service;

    public Scan013Service(ILogger<Scan013Service> logger, ILocator037Service locator037Service, IProcessor030Service processor030Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _locator037Service = locator037Service ?? throw new ArgumentNullException(nameof(locator037Service));
        _processor030Service = processor030Service ?? throw new ArgumentNullException(nameof(processor030Service));
    }

    public void ProcessScan013(string request)
    {
        // Implementation for ProcessScan013
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessScan013), nameof(request), request);
        
        _ = _processor030Service; // Using dependency
    }

    public string ReceiveScan013(object id)
    {
        // Implementation for ReceiveScan013
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ReceiveScan013), nameof(id), id);
        
        _ = _locator037Service; // Using dependency
        return $"Result from ReceiveScan013";
    }

}
