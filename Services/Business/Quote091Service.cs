using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;

namespace stream_response_ef_core.Services.Business;

public interface IQuote091Service
{
    Task<string> ProcessQuote091(object value);
    void SearchQuote091(object data);
}

public class Quote091Service : IQuote091Service
{
    private readonly ILogger<Quote091Service> _logger;
    private readonly IProposal070Service _proposal070Service;
    private readonly ICredential030Service _credential030Service;
    private readonly ITransaction027Service _transaction027Service;
    private readonly IProposal057Service _proposal057Service;

    public Quote091Service(ILogger<Quote091Service> logger, IProposal070Service proposal070Service, ICredential030Service credential030Service, ITransaction027Service transaction027Service, IProposal057Service proposal057Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _proposal070Service = proposal070Service ?? throw new ArgumentNullException(nameof(proposal070Service));
        _credential030Service = credential030Service ?? throw new ArgumentNullException(nameof(credential030Service));
        _transaction027Service = transaction027Service ?? throw new ArgumentNullException(nameof(transaction027Service));
        _proposal057Service = proposal057Service ?? throw new ArgumentNullException(nameof(proposal057Service));
    }

    public async Task<string> ProcessQuote091(object value)
    {
        // Implementation for ProcessQuote091
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessQuote091), nameof(value), value);
        
        _ = _transaction027Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from ProcessQuote091";
    }

    public void SearchQuote091(object data)
    {
        // Implementation for SearchQuote091
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SearchQuote091), nameof(data), data);
        
        _ = _transaction027Service; // Using dependency
    }

}
