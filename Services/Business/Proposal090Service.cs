using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace stream_response_ef_core.Services.Business;

public interface IProposal090Service
{
    int ProcessProposal090(int request);
    Task<int> FilterProposal090(object data);
}

public class Proposal090Service : IProposal090Service
{
    private readonly ILogger<Proposal090Service> _logger;
    private readonly IInvoice066Service _invoice066Service;
    private readonly IAgreement022Service _agreement022Service;
    private readonly IInvoice031Service _invoice031Service;

    public Proposal090Service(ILogger<Proposal090Service> logger, IInvoice066Service invoice066Service, IAgreement022Service agreement022Service, IInvoice031Service invoice031Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _invoice066Service = invoice066Service ?? throw new ArgumentNullException(nameof(invoice066Service));
        _agreement022Service = agreement022Service ?? throw new ArgumentNullException(nameof(agreement022Service));
        _invoice031Service = invoice031Service ?? throw new ArgumentNullException(nameof(invoice031Service));
    }

    public int ProcessProposal090(int request)
    {
        // Implementation for ProcessProposal090
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessProposal090), nameof(request), request);
        
        _ = _agreement022Service; // Using dependency
        return 42;
    }

    public async Task<int> FilterProposal090(object data)
    {
        // Implementation for FilterProposal090
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(FilterProposal090), nameof(data), data);
        
        _ = _agreement022Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

}
