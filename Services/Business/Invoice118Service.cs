using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Business;

public interface IInvoice118Service
{
    Task<string> ProcessInvoice118(object id);
    Task<int> SearchInvoice118(object id);
}

public class Invoice118Service : IInvoice118Service
{
    private readonly ILogger<Invoice118Service> _logger;
    private readonly IUserAuth010Service _userAuth010Service;
    private readonly IAccessService _accessService;
    private readonly IProduct033Service _product033Service;

    public Invoice118Service(ILogger<Invoice118Service> logger, IUserAuth010Service userAuth010Service, IAccessService accessService, IProduct033Service product033Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _userAuth010Service = userAuth010Service ?? throw new ArgumentNullException(nameof(userAuth010Service));
        _accessService = accessService ?? throw new ArgumentNullException(nameof(accessService));
        _product033Service = product033Service ?? throw new ArgumentNullException(nameof(product033Service));
    }

    public async Task<string> ProcessInvoice118(object id)
    {
        // Implementation for ProcessInvoice118
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessInvoice118), nameof(id), id);
        
        _ = _product033Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from ProcessInvoice118";
    }

    public async Task<int> SearchInvoice118(object id)
    {
        // Implementation for SearchInvoice118
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SearchInvoice118), nameof(id), id);
        
        _ = _product033Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

}
