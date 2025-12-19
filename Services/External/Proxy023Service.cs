using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.External;

public interface IProxy023Service
{
    void ProcessProxy023(object request);
    string CreateProxy023(Guid data);
}

public class Proxy023Service : IProxy023Service
{
    private readonly ILogger<Proxy023Service> _logger;
    private readonly IAgreement106Service _agreement106Service;
    private readonly IInvoice036Service _invoice036Service;
    private readonly IRestore020Service _restore020Service;

    public Proxy023Service(ILogger<Proxy023Service> logger, IAgreement106Service agreement106Service, IInvoice036Service invoice036Service, IRestore020Service restore020Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _agreement106Service = agreement106Service ?? throw new ArgumentNullException(nameof(agreement106Service));
        _invoice036Service = invoice036Service ?? throw new ArgumentNullException(nameof(invoice036Service));
        _restore020Service = restore020Service ?? throw new ArgumentNullException(nameof(restore020Service));
    }

    public void ProcessProxy023(object request)
    {
        // Implementation for ProcessProxy023
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessProxy023), nameof(request), request);
        
        _ = _invoice036Service; // Using dependency
    }

    public string CreateProxy023(Guid data)
    {
        // Implementation for CreateProxy023
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CreateProxy023), nameof(data), data);
        
        _ = _agreement106Service; // Using dependency
        return $"Result from CreateProxy023";
    }

}
