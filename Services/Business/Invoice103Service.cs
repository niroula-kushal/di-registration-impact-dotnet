using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Business;

public interface IInvoice103Service
{
    bool ProcessInvoice103(int value);
    string FormatInvoice103(string input);
}

public class Invoice103Service : IInvoice103Service
{
    private readonly ILogger<Invoice103Service> _logger;
    private readonly ILogout020Service _logout020Service;
    private readonly IQuote086Service _quote086Service;
    private readonly IPolicy046Service _policy046Service;

    public Invoice103Service(ILogger<Invoice103Service> logger, ILogout020Service logout020Service, IQuote086Service quote086Service, IPolicy046Service policy046Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _logout020Service = logout020Service ?? throw new ArgumentNullException(nameof(logout020Service));
        _quote086Service = quote086Service ?? throw new ArgumentNullException(nameof(quote086Service));
        _policy046Service = policy046Service ?? throw new ArgumentNullException(nameof(policy046Service));
    }

    public bool ProcessInvoice103(int value)
    {
        // Implementation for ProcessInvoice103
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessInvoice103), nameof(value), value);
        
        _ = _logout020Service; // Using dependency
        return true;
    }

    public string FormatInvoice103(string input)
    {
        // Implementation for FormatInvoice103
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(FormatInvoice103), nameof(input), input);
        
        _ = _logout020Service; // Using dependency
        return $"Result from FormatInvoice103";
    }

}
