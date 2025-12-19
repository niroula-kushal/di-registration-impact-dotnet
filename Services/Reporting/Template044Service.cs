using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Infrastructure;

namespace stream_response_ef_core.Services.Reporting;

public interface ITemplate044Service
{
    void ProcessTemplate044(int input);
    string SendTemplate044(string input);
}

public class Template044Service : ITemplate044Service
{
    private readonly ILogger<Template044Service> _logger;
    private readonly IGenerator042Service _generator042Service;
    private readonly IInvoice094Service _invoice094Service;
    private readonly IManager016Service _manager016Service;
    private readonly IInvoice059Service _invoice059Service;

    public Template044Service(ILogger<Template044Service> logger, IGenerator042Service generator042Service, IInvoice094Service invoice094Service, IManager016Service manager016Service, IInvoice059Service invoice059Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _generator042Service = generator042Service ?? throw new ArgumentNullException(nameof(generator042Service));
        _invoice094Service = invoice094Service ?? throw new ArgumentNullException(nameof(invoice094Service));
        _manager016Service = manager016Service ?? throw new ArgumentNullException(nameof(manager016Service));
        _invoice059Service = invoice059Service ?? throw new ArgumentNullException(nameof(invoice059Service));
    }

    public void ProcessTemplate044(int input)
    {
        // Implementation for ProcessTemplate044
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessTemplate044), nameof(input), input);
        
        _ = _generator042Service; // Using dependency
    }

    public string SendTemplate044(string input)
    {
        // Implementation for SendTemplate044
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SendTemplate044), nameof(input), input);
        
        _ = _invoice094Service; // Using dependency
        return $"Result from SendTemplate044";
    }

}
