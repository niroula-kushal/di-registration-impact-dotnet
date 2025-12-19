using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Data;
using stream_response_ef_core.Services.Reporting;
using stream_response_ef_core.Services.Validation;

namespace stream_response_ef_core.Services.Monitoring;

public interface IMetric005Service
{
    string ProcessMetric005(int request);
    void SearchMetric005(object id);
}

public class Metric005Service : IMetric005Service
{
    private readonly ILogger<Metric005Service> _logger;
    private readonly IExporter062Service _exporter062Service;
    private readonly IGuard041Service _guard041Service;
    private readonly ITransform037Service _transform037Service;
    private readonly IGuard056Service _guard056Service;

    public Metric005Service(ILogger<Metric005Service> logger, IExporter062Service exporter062Service, IGuard041Service guard041Service, ITransform037Service transform037Service, IGuard056Service guard056Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _exporter062Service = exporter062Service ?? throw new ArgumentNullException(nameof(exporter062Service));
        _guard041Service = guard041Service ?? throw new ArgumentNullException(nameof(guard041Service));
        _transform037Service = transform037Service ?? throw new ArgumentNullException(nameof(transform037Service));
        _guard056Service = guard056Service ?? throw new ArgumentNullException(nameof(guard056Service));
    }

    public string ProcessMetric005(int request)
    {
        // Implementation for ProcessMetric005
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessMetric005), nameof(request), request);
        
        _ = _guard041Service; // Using dependency
        return $"Result from ProcessMetric005";
    }

    public void SearchMetric005(object id)
    {
        // Implementation for SearchMetric005
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SearchMetric005), nameof(id), id);
        
        _ = _guard056Service; // Using dependency
    }

}
