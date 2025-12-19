using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Monitoring;

public interface IMetric028Service
{
    int ProcessMetric028(string request);
    bool TransformMetric028(string input);
}

public class Metric028Service : IMetric028Service
{
    private readonly ILogger<Metric028Service> _logger;
    private readonly IProposal067Service _proposal067Service;
    private readonly IQuote030Service _quote030Service;

    public Metric028Service(ILogger<Metric028Service> logger, IProposal067Service proposal067Service, IQuote030Service quote030Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _proposal067Service = proposal067Service ?? throw new ArgumentNullException(nameof(proposal067Service));
        _quote030Service = quote030Service ?? throw new ArgumentNullException(nameof(quote030Service));
    }

    public int ProcessMetric028(string request)
    {
        // Implementation for ProcessMetric028
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessMetric028), nameof(request), request);
        
        _ = _proposal067Service; // Using dependency
        return 42;
    }

    public bool TransformMetric028(string input)
    {
        // Implementation for TransformMetric028
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(TransformMetric028), nameof(input), input);
        
        _ = _quote030Service; // Using dependency
        return true;
    }

}
