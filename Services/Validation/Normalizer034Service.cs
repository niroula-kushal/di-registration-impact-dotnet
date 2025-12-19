using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;
using stream_response_ef_core.Services.Payment;

namespace stream_response_ef_core.Services.Validation;

public interface INormalizer034Service
{
    void ProcessNormalizer034(int request);
    int SendNormalizer034(int data);
    string SendNormalizer034(string id);
}

public class Normalizer034Service : INormalizer034Service
{
    private readonly ILogger<Normalizer034Service> _logger;
    private readonly IInvoice044Service _invoice044Service;
    private readonly IPaymentInvoice031Service _paymentInvoice031Service;

    public Normalizer034Service(ILogger<Normalizer034Service> logger, IInvoice044Service invoice044Service, IPaymentInvoice031Service paymentInvoice031Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _invoice044Service = invoice044Service ?? throw new ArgumentNullException(nameof(invoice044Service));
        _paymentInvoice031Service = paymentInvoice031Service ?? throw new ArgumentNullException(nameof(paymentInvoice031Service));
    }

    public void ProcessNormalizer034(int request)
    {
        // Implementation for ProcessNormalizer034
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessNormalizer034), nameof(request), request);
        
        _ = _paymentInvoice031Service; // Using dependency
    }

    public int SendNormalizer034(int data)
    {
        // Implementation for SendNormalizer034
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SendNormalizer034), nameof(data), data);
        
        _ = _paymentInvoice031Service; // Using dependency
        return 42;
    }

    public string SendNormalizer034(string id)
    {
        // Implementation for SendNormalizer034
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SendNormalizer034), nameof(id), id);
        
        _ = _paymentInvoice031Service; // Using dependency
        return $"Result from SendNormalizer034";
    }

}
