using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Security;

namespace stream_response_ef_core.Services.Monitoring;

public interface IMetricService
{
    string ProcessMetric(Guid value);
    int CreateMetric(Guid input);
}

public class MetricService : IMetricService
{
    private readonly ILogger<MetricService> _logger;
    private readonly IVault065Service _vault065Service;
    private readonly IProduct047Service _product047Service;
    private readonly IRefresh043Service _refresh043Service;

    public MetricService(ILogger<MetricService> logger, IVault065Service vault065Service, IProduct047Service product047Service, IRefresh043Service refresh043Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _vault065Service = vault065Service ?? throw new ArgumentNullException(nameof(vault065Service));
        _product047Service = product047Service ?? throw new ArgumentNullException(nameof(product047Service));
        _refresh043Service = refresh043Service ?? throw new ArgumentNullException(nameof(refresh043Service));
    }

    public string ProcessMetric(Guid value)
    {
        // Implementation for ProcessMetric
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessMetric), nameof(value), value);
        
        _ = _product047Service; // Using dependency
        return $"Result from ProcessMetric";
    }

    public int CreateMetric(Guid input)
    {
        // Implementation for CreateMetric
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CreateMetric), nameof(input), input);
        
        _ = _product047Service; // Using dependency
        return 42;
    }

}
