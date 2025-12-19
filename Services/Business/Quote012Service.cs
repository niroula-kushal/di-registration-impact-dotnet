using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Business;

public interface IQuote012Service
{
    int ProcessQuote012(Guid request);
    int ParseQuote012(string value);
}

public class Quote012Service : IQuote012Service
{
    private readonly ILogger<Quote012Service> _logger;
    private readonly IRefresh028Service _refresh028Service;
    private readonly IAccess040Service _access040Service;
    private readonly IVerify013Service _verify013Service;

    public Quote012Service(ILogger<Quote012Service> logger, IRefresh028Service refresh028Service, IAccess040Service access040Service, IVerify013Service verify013Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _refresh028Service = refresh028Service ?? throw new ArgumentNullException(nameof(refresh028Service));
        _access040Service = access040Service ?? throw new ArgumentNullException(nameof(access040Service));
        _verify013Service = verify013Service ?? throw new ArgumentNullException(nameof(verify013Service));
    }

    public int ProcessQuote012(Guid request)
    {
        // Implementation for ProcessQuote012
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessQuote012), nameof(request), request);
        
        _ = _refresh028Service; // Using dependency
        return 42;
    }

    public int ParseQuote012(string value)
    {
        // Implementation for ParseQuote012
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ParseQuote012), nameof(value), value);
        
        _ = _refresh028Service; // Using dependency
        return 42;
    }

}
