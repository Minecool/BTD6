namespace Unity.Services.Core.Telemetry.Internal;

public interface IMetricsFactory : IServiceComponent
{

	public IMetrics Create(string packageName) { }

}

