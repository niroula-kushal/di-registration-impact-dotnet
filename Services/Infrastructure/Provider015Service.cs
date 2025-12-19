using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.External;

namespace stream_response_ef_core.Services.Infrastructure;

public interface IProvider015Service
{
    void ProcessProvider015(object value);
    Task<string> FormatProvider015(int input);
}

public class Provider015Service : IProvider015Service
{
    private readonly ILogger<Provider015Service> _logger;
    private readonly IQuote138Service _quote138Service;
    private readonly IClient015Service _client015Service;

    public Provider015Service(ILogger<Provider015Service> logger, IQuote138Service quote138Service, IClient015Service client015Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _quote138Service = quote138Service ?? throw new ArgumentNullException(nameof(quote138Service));
        _client015Service = client015Service ?? throw new ArgumentNullException(nameof(client015Service));
    }

    public void ProcessProvider015(object value)
    {
        // Implementation for ProcessProvider015
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessProvider015), nameof(value), value);
        
        _ = _quote138Service; // Using dependency
    }

    public async Task<string> FormatProvider015(int input)
    {
        // Implementation for FormatProvider015
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(FormatProvider015), nameof(input), input);
        
        _ = _client015Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from FormatProvider015";
    }

}
