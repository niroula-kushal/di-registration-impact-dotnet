using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Notification;
using stream_response_ef_core.Services.Payment;

namespace stream_response_ef_core.Services.Security;

public interface ICertificateService
{
    void ProcessCertificate(string value);
    void SendCertificate(string value);
}

public class CertificateService : ICertificateService
{
    private readonly ILogger<CertificateService> _logger;
    private readonly IReceipt005Service _receipt005Service;
    private readonly IQueue036Service _queue036Service;

    public CertificateService(ILogger<CertificateService> logger, IReceipt005Service receipt005Service, IQueue036Service queue036Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _receipt005Service = receipt005Service ?? throw new ArgumentNullException(nameof(receipt005Service));
        _queue036Service = queue036Service ?? throw new ArgumentNullException(nameof(queue036Service));
    }

    public void ProcessCertificate(string value)
    {
        // Implementation for ProcessCertificate
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessCertificate), nameof(value), value);
        
        _ = _receipt005Service; // Using dependency
    }

    public void SendCertificate(string value)
    {
        // Implementation for SendCertificate
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(SendCertificate), nameof(value), value);
        
        _ = _queue036Service; // Using dependency
    }

}
