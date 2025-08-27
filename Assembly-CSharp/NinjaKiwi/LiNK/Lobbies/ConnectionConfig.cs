namespace NinjaKiwi.LiNK.Lobbies;

public class ConnectionConfig
{
	internal class AwolConfig
	{
		public float ToleranceFactor; //Field offset: 0x10
		public TimeSpan TimeTillDisconnect; //Field offset: 0x18
		public int MaxOccurrences; //Field offset: 0x20
		public int MaxRecentOccurrences; //Field offset: 0x24
		public TimeSpan RecentPeriod; //Field offset: 0x28

		public AwolConfig() { }

	}

	internal class LatencyConfig
	{
		public TimeSpan MaxAllowed; //Field offset: 0x10
		public int SampleCount; //Field offset: 0x18
		public TimeSpan SampleInterval; //Field offset: 0x20
		public TimeSpan MeasurementTimeout; //Field offset: 0x28

		public LatencyConfig() { }

	}

	internal class ReconnectConfig
	{
		public int MaxAttempts; //Field offset: 0x10
		public TimeSpan Interval; //Field offset: 0x18

		public ReconnectConfig() { }

	}

	internal class RejoinConfig
	{
		public TimeSpan ConfirmationPeriod; //Field offset: 0x10
		public TimeSpan TestPeriod; //Field offset: 0x18

		public RejoinConfig() { }

	}

	public ReconnectConfig Reconnect; //Field offset: 0x10
	public RejoinConfig Rejoin; //Field offset: 0x18
	public LatencyConfig Latency; //Field offset: 0x20
	public AwolConfig Awol; //Field offset: 0x28

	public ConnectionConfig() { }

}

