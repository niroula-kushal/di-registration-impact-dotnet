using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Authorization;
using stream_response_ef_core.Services.Business;

namespace stream_response_ef_core.Services.Data;

public interface IBackupService
{
    int ProcessBackup(Guid input);
    int ProcessBackup(string request);
    int GetBackup(Guid data);
}

public class BackupService : IBackupService
{
    private readonly ILogger<BackupService> _logger;
    private readonly IAccount130Service _account130Service;
    private readonly IPermission023Service _permission023Service;
    private readonly IProduct016Service _product016Service;

    public BackupService(ILogger<BackupService> logger, IAccount130Service account130Service, IPermission023Service permission023Service, IProduct016Service product016Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _account130Service = account130Service ?? throw new ArgumentNullException(nameof(account130Service));
        _permission023Service = permission023Service ?? throw new ArgumentNullException(nameof(permission023Service));
        _product016Service = product016Service ?? throw new ArgumentNullException(nameof(product016Service));
    }

    public int ProcessBackup(Guid input)
    {
        // Implementation for ProcessBackup
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessBackup), nameof(input), input);
        
        _ = _account130Service; // Using dependency
        return 42;
    }

    public int ProcessBackup(string request)
    {
        // Implementation for ProcessBackup
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessBackup), nameof(request), request);
        
        _ = _product016Service; // Using dependency
        return 42;
    }

    public int GetBackup(Guid data)
    {
        // Implementation for GetBackup
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(GetBackup), nameof(data), data);
        
        _ = _product016Service; // Using dependency
        return 42;
    }

}
