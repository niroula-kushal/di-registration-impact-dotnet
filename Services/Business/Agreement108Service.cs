using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Business;

public interface IAgreement108Service
{
    string ProcessAgreement108(Guid request);
    Task<bool> StoreAgreement108(int value);
}

public class Agreement108Service : IAgreement108Service
{
    private readonly ILogger<Agreement108Service> _logger;
    private readonly IQuote091Service _quote091Service;
    private readonly IVerify037Service _verify037Service;

    public Agreement108Service(ILogger<Agreement108Service> logger, IQuote091Service quote091Service, IVerify037Service verify037Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _quote091Service = quote091Service ?? throw new ArgumentNullException(nameof(quote091Service));
        _verify037Service = verify037Service ?? throw new ArgumentNullException(nameof(verify037Service));
    }

    public string ProcessAgreement108(Guid request)
    {
        // Implementation for ProcessAgreement108
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessAgreement108), nameof(request), request);
        
        _ = _quote091Service; // Using dependency
        return $"Result from ProcessAgreement108";
    }

    public async Task<bool> StoreAgreement108(int value)
    {
        // Implementation for StoreAgreement108
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(StoreAgreement108), nameof(value), value);
        
        _ = _verify037Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return true;
    }

}
