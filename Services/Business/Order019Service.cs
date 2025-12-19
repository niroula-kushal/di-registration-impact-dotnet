using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;

namespace stream_response_ef_core.Services.Business;

public interface IOrder019Service
{
    string ProcessOrder019(int request);
    int UpdateOrder019(Guid data);
}

public class Order019Service : IOrder019Service
{
    private readonly ILogger<Order019Service> _logger;
    private readonly IProductService _productService;
    private readonly IGuard009Service _guard009Service;

    public Order019Service(ILogger<Order019Service> logger, IProductService productService, IGuard009Service guard009Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        _guard009Service = guard009Service ?? throw new ArgumentNullException(nameof(guard009Service));
    }

    public string ProcessOrder019(int request)
    {
        // Implementation for ProcessOrder019
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessOrder019), nameof(request), request);
        
        _ = _productService; // Using dependency
        return $"Result from ProcessOrder019";
    }

    public int UpdateOrder019(Guid data)
    {
        // Implementation for UpdateOrder019
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(UpdateOrder019), nameof(data), data);
        
        _ = _productService; // Using dependency
        return 42;
    }

}
