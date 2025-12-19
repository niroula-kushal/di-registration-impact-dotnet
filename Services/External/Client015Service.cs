using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.External;

public interface IClient015Service
{
    Task<string> ProcessClient015(Guid input);
    Task<string> SendClient015(Guid data);
}

public class Client015Service : IClient015Service
{
    private readonly ILogger<Client015Service> _logger;
    private readonly IQuote086Service _quote086Service;
    private readonly IExport005Service _export005Service;

    public Client015Service(ILogger<Client015Service> logger, IQuote086Service quote086Service, IExport005Service export005Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _quote086Service = quote086Service ?? throw new ArgumentNullException(nameof(quote086Service));
        _export005Service = export005Service ?? throw new ArgumentNullException(nameof(export005Service));
    }

    public async Task<string> ProcessClient015(Guid input)
    {
        // Implementation for ProcessClient015
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessClient015), nameof(input), input);
        
        _ = _quote086Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from ProcessClient015";
    }

    public async Task<string> SendClient015(Guid data)
    {
        // Implementation for SendClient015
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SendClient015), nameof(data), data);
        
        _ = _export005Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from SendClient015";
    }

}
