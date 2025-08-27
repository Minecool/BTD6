namespace Unity.Services.Core.Telemetry.Internal;

public interface IDiagnosticsFactory : IServiceComponent
{

	public IDiagnostics Create(string packageName) { }

}

