using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Data;

public interface IExport013Service
{
    int ProcessExport013(int data);
    bool SearchExport013(int value);
}

public class Export013Service : IExport013Service
{
    private readonly ILogger<Export013Service> _logger;
    private readonly IProduct097Service _product097Service;
    private readonly ICustomer011Service _customer011Service;

    public Export013Service(ILogger<Export013Service> logger, IProduct097Service product097Service, ICustomer011Service customer011Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _product097Service = product097Service ?? throw new ArgumentNullException(nameof(product097Service));
        _customer011Service = customer011Service ?? throw new ArgumentNullException(nameof(customer011Service));
    }

    public int ProcessExport013(int data)
    {
        // Implementation for ProcessExport013
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessExport013), nameof(data), data);
        
        _ = _customer011Service; // Using dependency
        return 42;
    }

    public bool SearchExport013(int value)
    {
        // Implementation for SearchExport013
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SearchExport013), nameof(value), value);
        
        _ = _customer011Service; // Using dependency
        return true;
    }

}
