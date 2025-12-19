using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.External;

public interface IInterface073Service
{
    void ProcessInterface073(int input);
    int SendInterface073(Guid request);
}

public class Interface073Service : IInterface073Service
{
    private readonly ILogger<Interface073Service> _logger;
    private readonly IApi014Service _api014Service;
    private readonly IToken011Service _token011Service;
    private readonly IInvoice053Service _invoice053Service;

    public Interface073Service(ILogger<Interface073Service> logger, IApi014Service api014Service, IToken011Service token011Service, IInvoice053Service invoice053Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _api014Service = api014Service ?? throw new ArgumentNullException(nameof(api014Service));
        _token011Service = token011Service ?? throw new ArgumentNullException(nameof(token011Service));
        _invoice053Service = invoice053Service ?? throw new ArgumentNullException(nameof(invoice053Service));
    }

    public void ProcessInterface073(int input)
    {
        // Implementation for ProcessInterface073
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessInterface073), nameof(input), input);
        
        _ = _token011Service; // Using dependency
    }

    public int SendInterface073(Guid request)
    {
        // Implementation for SendInterface073
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SendInterface073), nameof(request), request);
        
        _ = _api014Service; // Using dependency
        return 42;
    }

}
