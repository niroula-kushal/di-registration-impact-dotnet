using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Data;

public interface IBackup011Service
{
    string ProcessBackup011(Guid request);
    void ReceiveBackup011(string id);
}

public class Backup011Service : IBackup011Service
{
    private readonly ILogger<Backup011Service> _logger;
    private readonly ITransaction015Service _transaction015Service;
    private readonly ICheck002Service _check002Service;
    private readonly IAccess018Service _access018Service;

    public Backup011Service(ILogger<Backup011Service> logger, ITransaction015Service transaction015Service, ICheck002Service check002Service, IAccess018Service access018Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _transaction015Service = transaction015Service ?? throw new ArgumentNullException(nameof(transaction015Service));
        _check002Service = check002Service ?? throw new ArgumentNullException(nameof(check002Service));
        _access018Service = access018Service ?? throw new ArgumentNullException(nameof(access018Service));
    }

    public string ProcessBackup011(Guid request)
    {
        // Implementation for ProcessBackup011
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessBackup011), nameof(request), request);
        
        _ = _access018Service; // Using dependency
        return $"Result from ProcessBackup011";
    }

    public void ReceiveBackup011(string id)
    {
        // Implementation for ReceiveBackup011
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ReceiveBackup011), nameof(id), id);
        
        _ = _check002Service; // Using dependency
    }

}
