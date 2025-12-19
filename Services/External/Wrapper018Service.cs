using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.External;

public interface IWrapper018Service
{
    void ProcessWrapper018(int request);
    int CreateWrapper018(object request);
}

public class Wrapper018Service : IWrapper018Service
{
    private readonly ILogger<Wrapper018Service> _logger;
    private readonly IQuote138Service _quote138Service;
    private readonly IApiKey003Service _apiKey003Service;

    public Wrapper018Service(ILogger<Wrapper018Service> logger, IQuote138Service quote138Service, IApiKey003Service apiKey003Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _quote138Service = quote138Service ?? throw new ArgumentNullException(nameof(quote138Service));
        _apiKey003Service = apiKey003Service ?? throw new ArgumentNullException(nameof(apiKey003Service));
    }

    public void ProcessWrapper018(int request)
    {
        // Implementation for ProcessWrapper018
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessWrapper018), nameof(request), request);
        
        _ = _apiKey003Service; // Using dependency
    }

    public int CreateWrapper018(object request)
    {
        // Implementation for CreateWrapper018
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CreateWrapper018), nameof(request), request);
        
        _ = _quote138Service; // Using dependency
        return 42;
    }

}
