using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Data;

public interface IQuery058Service
{
    void ProcessQuery058(int input);
    void SearchQuery058(Guid data);
}

public class Query058Service : IQuery058Service
{
    private readonly ILogger<Query058Service> _logger;
    private readonly IProduct047Service _product047Service;
    private readonly IProposal070Service _proposal070Service;

    public Query058Service(ILogger<Query058Service> logger, IProduct047Service product047Service, IProposal070Service proposal070Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _product047Service = product047Service ?? throw new ArgumentNullException(nameof(product047Service));
        _proposal070Service = proposal070Service ?? throw new ArgumentNullException(nameof(proposal070Service));
    }

    public void ProcessQuery058(int input)
    {
        // Implementation for ProcessQuery058
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessQuery058), nameof(input), input);
        
        _ = _product047Service; // Using dependency
    }

    public void SearchQuery058(Guid data)
    {
        // Implementation for SearchQuery058
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SearchQuery058), nameof(data), data);
        
        _ = _product047Service; // Using dependency
    }

}
