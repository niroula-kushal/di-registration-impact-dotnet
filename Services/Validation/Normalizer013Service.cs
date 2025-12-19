using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Notification;

namespace stream_response_ef_core.Services.Validation;

public interface INormalizer013Service
{
    Task<string> ProcessNormalizer013(Guid input);
    Task<bool> FormatNormalizer013(Guid input);
}

public class Normalizer013Service : INormalizer013Service
{
    private readonly ILogger<Normalizer013Service> _logger;
    private readonly IInvoice037Service _invoice037Service;
    private readonly ISms008Service _sms008Service;
    private readonly IProposal067Service _proposal067Service;

    public Normalizer013Service(ILogger<Normalizer013Service> logger, IInvoice037Service invoice037Service, ISms008Service sms008Service, IProposal067Service proposal067Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _invoice037Service = invoice037Service ?? throw new ArgumentNullException(nameof(invoice037Service));
        _sms008Service = sms008Service ?? throw new ArgumentNullException(nameof(sms008Service));
        _proposal067Service = proposal067Service ?? throw new ArgumentNullException(nameof(proposal067Service));
    }

    public async Task<string> ProcessNormalizer013(Guid input)
    {
        // Implementation for ProcessNormalizer013
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessNormalizer013), nameof(input), input);
        
        _ = _invoice037Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return $"Result from ProcessNormalizer013";
    }

    public async Task<bool> FormatNormalizer013(Guid input)
    {
        // Implementation for FormatNormalizer013
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(FormatNormalizer013), nameof(input), input);
        
        _ = _proposal067Service; // Using dependency
        await Task.CompletedTask; // Simulate async operation
        return true;
    }

}
