using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Business;

public interface IQuote086Service
{
    int ProcessQuote086(Guid value);
    void FilterQuote086(string input);
}

public class Quote086Service : IQuote086Service
{
    private readonly ILogger<Quote086Service> _logger;
    private readonly IProduct040Service _product040Service;
    private readonly IPermission038Service _permission038Service;

    public Quote086Service(ILogger<Quote086Service> logger, IProduct040Service product040Service, IPermission038Service permission038Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _product040Service = product040Service ?? throw new ArgumentNullException(nameof(product040Service));
        _permission038Service = permission038Service ?? throw new ArgumentNullException(nameof(permission038Service));
    }

    public int ProcessQuote086(Guid value)
    {
        // Implementation for ProcessQuote086
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessQuote086), nameof(value), value);
        
        _ = _product040Service; // Using dependency
        return 42;
    }

    public void FilterQuote086(string input)
    {
        // Implementation for FilterQuote086
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(FilterQuote086), nameof(input), input);
        
        _ = _permission038Service; // Using dependency
    }

}
