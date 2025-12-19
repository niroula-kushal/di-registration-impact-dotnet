using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Payment;

public interface IPaymentInvoice031Service
{
    int ProcessPaymentInvoice031(Guid id);
    bool SendPaymentInvoice031(int data);
}

public class PaymentInvoice031Service : IPaymentInvoice031Service
{
    private readonly ILogger<PaymentInvoice031Service> _logger;
    private readonly IQuote116Service _quote116Service;
    private readonly ITransaction060Service _transaction060Service;

    public PaymentInvoice031Service(ILogger<PaymentInvoice031Service> logger, IQuote116Service quote116Service, ITransaction060Service transaction060Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _quote116Service = quote116Service ?? throw new ArgumentNullException(nameof(quote116Service));
        _transaction060Service = transaction060Service ?? throw new ArgumentNullException(nameof(transaction060Service));
    }

    public int ProcessPaymentInvoice031(Guid id)
    {
        // Implementation for ProcessPaymentInvoice031
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessPaymentInvoice031), nameof(id), id);
        
        _ = _transaction060Service; // Using dependency
        return 42;
    }

    public bool SendPaymentInvoice031(int data)
    {
        // Implementation for SendPaymentInvoice031
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SendPaymentInvoice031), nameof(data), data);
        
        _ = _quote116Service; // Using dependency
        return true;
    }

}
