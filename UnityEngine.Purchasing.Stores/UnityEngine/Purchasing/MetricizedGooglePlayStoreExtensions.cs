namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class MetricizedGooglePlayStoreExtensions : GooglePlayStoreExtensions
{
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; //Field offset: 0x38

	internal MetricizedGooglePlayStoreExtensions(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

}

