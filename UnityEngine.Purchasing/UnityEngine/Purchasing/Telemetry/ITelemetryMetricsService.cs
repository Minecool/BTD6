namespace UnityEngine.Purchasing.Telemetry;

internal interface ITelemetryMetricsService
{

	public void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition) { }

}

