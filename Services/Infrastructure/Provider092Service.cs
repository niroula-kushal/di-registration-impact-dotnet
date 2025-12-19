using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Data;
using stream_response_ef_core.Services.External;

namespace stream_response_ef_core.Services.Infrastructure;

public interface IProvider092Service
{
    string ProcessProvider092(string id);
    int UpdateProvider092(Guid data);
}

public class Provider092Service : IProvider092Service
{
    private readonly ILogger<Provider092Service> _logger;
    private readonly IQuote089Service _quote089Service;
    private readonly IApi078Service _api078Service;
    private readonly IImport096Service _import096Service;

    public Provider092Service(ILogger<Provider092Service> logger, IQuote089Service quote089Service, IApi078Service api078Service, IImport096Service import096Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _quote089Service = quote089Service ?? throw new ArgumentNullException(nameof(quote089Service));
        _api078Service = api078Service ?? throw new ArgumentNullException(nameof(api078Service));
        _import096Service = import096Service ?? throw new ArgumentNullException(nameof(import096Service));
    }

    public string ProcessProvider092(string id)
    {
        // Implementation for ProcessProvider092
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessProvider092), nameof(id), id);
        
        _ = _import096Service; // Using dependency
        return $"Result from ProcessProvider092";
    }

    public int UpdateProvider092(Guid data)
    {
        // Implementation for UpdateProvider092
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(UpdateProvider092), nameof(data), data);
        
        _ = _api078Service; // Using dependency
        return 42;
    }

}
