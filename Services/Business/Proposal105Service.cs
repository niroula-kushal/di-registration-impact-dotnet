using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Business;

public interface IProposal105Service
{
    string ProcessProposal105(int id);
    int CreateProposal105(string value);
}

public class Proposal105Service : IProposal105Service
{
    private readonly ILogger<Proposal105Service> _logger;
    private readonly IProposal075Service _proposal075Service;
    private readonly ISession018Service _session018Service;
    private readonly IEnforce016Service _enforce016Service;

    public Proposal105Service(ILogger<Proposal105Service> logger, IProposal075Service proposal075Service, ISession018Service session018Service, IEnforce016Service enforce016Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _proposal075Service = proposal075Service ?? throw new ArgumentNullException(nameof(proposal075Service));
        _session018Service = session018Service ?? throw new ArgumentNullException(nameof(session018Service));
        _enforce016Service = enforce016Service ?? throw new ArgumentNullException(nameof(enforce016Service));
    }

    public string ProcessProposal105(int id)
    {
        // Implementation for ProcessProposal105
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessProposal105), nameof(id), id);
        
        _ = _enforce016Service; // Using dependency
        return $"Result from ProcessProposal105";
    }

    public int CreateProposal105(string value)
    {
        // Implementation for CreateProposal105
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CreateProposal105), nameof(value), value);
        
        _ = _enforce016Service; // Using dependency
        return 42;
    }

}
