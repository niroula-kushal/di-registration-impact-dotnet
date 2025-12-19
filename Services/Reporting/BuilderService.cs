using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Reporting;

public interface IBuilderService
{
    Task<int> ProcessBuilder(string request);
    int CalculateBuilder(int request);
    void SortBuilder(object input);
}

public class BuilderService : IBuilderService
{
    private readonly ILogger<BuilderService> _logger;
    private readonly IInvoice043Service _invoice043Service;
    private readonly IProduct080Service _product080Service;

    public BuilderService(ILogger<BuilderService> logger, IInvoice043Service invoice043Service, IProduct080Service product080Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _invoice043Service = invoice043Service ?? throw new ArgumentNullException(nameof(invoice043Service));
        _product080Service = product080Service ?? throw new ArgumentNullException(nameof(product080Service));
    }

    public async Task<int> ProcessBuilder(string request)
    {
        // Implementation for ProcessBuilder
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessBuilder), nameof(request), request);
        
        _ = _invoice043Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

    public int CalculateBuilder(int request)
    {
        // Implementation for CalculateBuilder
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CalculateBuilder), nameof(request), request);
        
        _ = _invoice043Service; // Using dependency
        return 42;
    }

    public void SortBuilder(object input)
    {
        // Implementation for SortBuilder
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SortBuilder), nameof(input), input);
        
        _ = _product080Service; // Using dependency
    }

}
