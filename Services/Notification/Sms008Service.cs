using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.External;

namespace stream_response_ef_core.Services.Notification;

public interface ISms008Service
{
    Task<int> ProcessSms008(Guid id);
    int ProcessSms008(string id);
}

public class Sms008Service : ISms008Service
{
    private readonly ILogger<Sms008Service> _logger;
    private readonly IInterface054Service _interface054Service;
    private readonly IProposal075Service _proposal075Service;

    public Sms008Service(ILogger<Sms008Service> logger, IInterface054Service interface054Service, IProposal075Service proposal075Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _interface054Service = interface054Service ?? throw new ArgumentNullException(nameof(interface054Service));
        _proposal075Service = proposal075Service ?? throw new ArgumentNullException(nameof(proposal075Service));
    }

    public async Task<int> ProcessSms008(Guid id)
    {
        // Implementation for ProcessSms008
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessSms008), nameof(id), id);
        
        _ = _proposal075Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return 42;
    }

    public int ProcessSms008(string id)
    {
        // Implementation for ProcessSms008
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessSms008), nameof(id), id);
        
        _ = _proposal075Service; // Using dependency
        return 42;
    }

}
