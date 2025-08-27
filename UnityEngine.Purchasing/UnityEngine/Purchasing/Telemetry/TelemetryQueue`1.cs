namespace UnityEngine.Purchasing.Telemetry;

internal class TelemetryQueue
{
	private readonly Action<TTelemetryEventParams> m_SendTelemetryEvent; //Field offset: 0x0
	private ConcurrentQueue<TTelemetryEventParams> m_Queue; //Field offset: 0x0

	public TelemetryQueue`1(Action<TTelemetryEventParams> sendTelemetryEvent) { }

	internal void QueueEvent(TTelemetryEventParams telemetryEvent) { }

	internal void SendQueuedEvents() { }

}

