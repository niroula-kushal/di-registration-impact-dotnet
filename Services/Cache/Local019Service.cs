using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Infrastructure;

namespace stream_response_ef_core.Services.Cache;

public interface ILocal019Service
{
    string ProcessLocal019(int id);
    string StoreLocal019(int input);
}

public class Local019Service : ILocal019Service
{
    private readonly ILogger<Local019Service> _logger;
    private readonly ICustomer042Service _customer042Service;
    private readonly ISetting003Service _setting003Service;

    public Local019Service(ILogger<Local019Service> logger, ICustomer042Service customer042Service, ISetting003Service setting003Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _customer042Service = customer042Service ?? throw new ArgumentNullException(nameof(customer042Service));
        _setting003Service = setting003Service ?? throw new ArgumentNullException(nameof(setting003Service));
    }

    public string ProcessLocal019(int id)
    {
        // Implementation for ProcessLocal019
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessLocal019), nameof(id), id);
        
        _ = _setting003Service; // Using dependency
        return $"Result from ProcessLocal019";
    }

    public string StoreLocal019(int input)
    {
        // Implementation for StoreLocal019
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(StoreLocal019), nameof(input), input);
        
        _ = _customer042Service; // Using dependency
        return $"Result from StoreLocal019";
    }

}
