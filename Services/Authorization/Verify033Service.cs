using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authentication;

namespace stream_response_ef_core.Services.Authorization;

public interface IVerify033Service
{
    int ProcessVerify033(Guid input);
    int CreateVerify033(Guid id);
}

public class Verify033Service : IVerify033Service
{
    private readonly ILogger<Verify033Service> _logger;
    private readonly IJwt032Service _jwt032Service;
    private readonly IRule030Service _rule030Service;

    public Verify033Service(ILogger<Verify033Service> logger, IJwt032Service jwt032Service, IRule030Service rule030Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _jwt032Service = jwt032Service ?? throw new ArgumentNullException(nameof(jwt032Service));
        _rule030Service = rule030Service ?? throw new ArgumentNullException(nameof(rule030Service));
    }

    public int ProcessVerify033(Guid input)
    {
        // Implementation for ProcessVerify033
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessVerify033), nameof(input), input);
        
        _ = _jwt032Service; // Using dependency
        return 42;
    }

    public int CreateVerify033(Guid id)
    {
        // Implementation for CreateVerify033
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(CreateVerify033), nameof(id), id);
        
        _ = _rule030Service; // Using dependency
        return 42;
    }

}
