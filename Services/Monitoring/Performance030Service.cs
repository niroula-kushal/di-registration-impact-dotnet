using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Monitoring;

public interface IPerformance030Service
{
    int ProcessPerformance030(int request);
    Task<string> ExecutePerformance030(int data);
}

public class Performance030Service : IPerformance030Service
{
    private readonly ILogger<Performance030Service> _logger;
    private readonly IInvoice083Service _invoice083Service;
    private readonly IProduct111Service _product111Service;

    public Performance030Service(ILogger<Performance030Service> logger, IInvoice083Service invoice083Service, IProduct111Service product111Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _invoice083Service = invoice083Service ?? throw new ArgumentNullException(nameof(invoice083Service));
        _product111Service = product111Service ?? throw new ArgumentNullException(nameof(product111Service));
    }

    public int ProcessPerformance030(int request)
    {
        // Implementation for ProcessPerformance030
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessPerformance030), nameof(request), request);
        
        _ = _product111Service; // Using dependency
        return 42;
    }

    public async Task<string> ExecutePerformance030(int data)
    {
        // Implementation for ExecutePerformance030
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ExecutePerformance030), nameof(data), data);
        
        _ = _invoice083Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from ExecutePerformance030";
    }

}
