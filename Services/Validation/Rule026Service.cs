using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.External;
using stream_response_ef_core.Services.Infrastructure;

namespace stream_response_ef_core.Services.Validation;

public interface IRule026Service
{
    void ProcessRule026(object request);
    void UpdateRule026(string data);
}

public class Rule026Service : IRule026Service
{
    private readonly ILogger<Rule026Service> _logger;
    private readonly IChecker020Service _checker020Service;
    private readonly ILocator067Service _locator067Service;
    private readonly IWrapper038Service _wrapper038Service;

    public Rule026Service(ILogger<Rule026Service> logger, IChecker020Service checker020Service, ILocator067Service locator067Service, IWrapper038Service wrapper038Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _checker020Service = checker020Service ?? throw new ArgumentNullException(nameof(checker020Service));
        _locator067Service = locator067Service ?? throw new ArgumentNullException(nameof(locator067Service));
        _wrapper038Service = wrapper038Service ?? throw new ArgumentNullException(nameof(wrapper038Service));
    }

    public void ProcessRule026(object request)
    {
        // Implementation for ProcessRule026
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessRule026), nameof(request), request);
        
        _ = _locator067Service; // Using dependency
    }

    public void UpdateRule026(string data)
    {
        // Implementation for UpdateRule026
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(UpdateRule026), nameof(data), data);
        
        _ = _locator067Service; // Using dependency
    }

}
