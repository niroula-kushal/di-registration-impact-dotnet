using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.External;

namespace stream_response_ef_core.Services.Logging;

public interface IFormatter003Service
{
    void ProcessFormatter003(object data);
    int ReceiveFormatter003(Guid request);
}

public class Formatter003Service : IFormatter003Service
{
    private readonly ILogger<Formatter003Service> _logger;
    private readonly IEnforce027Service _enforce027Service;
    private readonly IContract061Service _contract061Service;
    private readonly IApi027Service _api027Service;
    private readonly IQuote058Service _quote058Service;

    public Formatter003Service(ILogger<Formatter003Service> logger, IEnforce027Service enforce027Service, IContract061Service contract061Service, IApi027Service api027Service, IQuote058Service quote058Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _enforce027Service = enforce027Service ?? throw new ArgumentNullException(nameof(enforce027Service));
        _contract061Service = contract061Service ?? throw new ArgumentNullException(nameof(contract061Service));
        _api027Service = api027Service ?? throw new ArgumentNullException(nameof(api027Service));
        _quote058Service = quote058Service ?? throw new ArgumentNullException(nameof(quote058Service));
    }

    public void ProcessFormatter003(object data)
    {
        // Implementation for ProcessFormatter003
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessFormatter003), nameof(data), data);
        
        _ = _contract061Service; // Using dependency
    }

    public int ReceiveFormatter003(Guid request)
    {
        // Implementation for ReceiveFormatter003
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ReceiveFormatter003), nameof(request), request);
        
        _ = _enforce027Service; // Using dependency
        return 42;
    }

}
