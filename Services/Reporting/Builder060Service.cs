using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using stream_response_ef_core.Services.Data;

namespace stream_response_ef_core.Services.Reporting;

public interface IBuilder060Service
{
    bool ProcessBuilder060(object id);
    void DeleteBuilder060(int data);
}

public class Builder060Service : IBuilder060Service
{
    private readonly ILogger<Builder060Service> _logger;
    private readonly IBackup086Service _backup086Service;
    private readonly IReportingBuilder005Service _reportingBuilder005Service;

    public Builder060Service(ILogger<Builder060Service> logger, IBackup086Service backup086Service, IReportingBuilder005Service reportingBuilder005Service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _backup086Service = backup086Service ?? throw new ArgumentNullException(nameof(backup086Service));
        _reportingBuilder005Service = reportingBuilder005Service ?? throw new ArgumentNullException(nameof(reportingBuilder005Service));
    }

    public bool ProcessBuilder060(object id)
    {
        // Implementation for ProcessBuilder060
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(ProcessBuilder060), nameof(id), id);
        
        _ = _reportingBuilder005Service; // Using dependency
        return true;
    }

    public void DeleteBuilder060(int data)
    {
        // Implementation for DeleteBuilder060
        _logger.LogInformation("Executing {MethodName} with {ParamName}: {ParamValue}", nameof(DeleteBuilder060), nameof(data), data);
        
        _ = _backup086Service; // Using dependency
    }

}
