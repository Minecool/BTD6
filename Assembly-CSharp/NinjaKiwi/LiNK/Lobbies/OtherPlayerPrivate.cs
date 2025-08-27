namespace NinjaKiwi.LiNK.Lobbies;

public class OtherPlayerPrivate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LatencyMeasurement, Nullable`1<Int32>> <>9__58_0; //Field offset: 0x8
		public static Func<TimeSpan, Int64> <>9__64_1; //Field offset: 0x10
		public static Func<TimeSpan, Int64> <>9__64_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal long <CalculateStats>b__64_1(TimeSpan t) { }

		internal long <CalculateStats>b__64_2(TimeSpan t) { }

		internal Nullable<Int32> <OnLatencyUpdated>b__58_0(LatencyMeasurement m) { }

	}

	private class NormalisedStats
	{
		public readonly TimeSpan Variance; //Field offset: 0x10
		public readonly TimeSpan PredictedTime; //Field offset: 0x18

		public NormalisedStats(TimeSpan predictedTime, TimeSpan error) { }

	}

	public readonly string Info; //Field offset: 0x10
	public int LastMessageReceived; //Field offset: 0x18
	public int MessageDeliveryConfirmed; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly OtherPlayer <Public>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private TimeSpan <Latency>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private TimeSpan <LatencyVariance>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsStarted>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsDisconnected>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	private bool <IsAWOL>k__BackingField; //Field offset: 0x3A
	[CompilerGenerated]
	private bool <IsBanned>k__BackingField; //Field offset: 0x3B
	private int Cooldown; //Field offset: 0x3C
	private int TotalAwolCount; //Field offset: 0x40
	private readonly ConnectionConfig Config; //Field offset: 0x48
	private readonly LatencyHistory LatencyMeasurements; //Field offset: 0x50
	private readonly Queue<LatencyMeasurement> PendingLatencyMeasurements; //Field offset: 0x58
	private readonly Queue<TimeSpan> RecentAwolTimes; //Field offset: 0x60
	private readonly TimeSpan StartTime; //Field offset: 0x68
	[CompilerGenerated]
	private Action<TimeSpan, TimeSpan, Boolean> LatencyUpdateEvent; //Field offset: 0x70
	[CompilerGenerated]
	private Action<TimeSpan, TimeSpan> PredictionUpdateEvent; //Field offset: 0x78
	[CompilerGenerated]
	private Action AWOLEvent; //Field offset: 0x80
	[CompilerGenerated]
	private Action KickedEvent; //Field offset: 0x88
	private NormalisedStats Stats; //Field offset: 0x90

	public event Action AWOLEvent
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event Action KickedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event Action<TimeSpan, TimeSpan, Boolean> LatencyUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<TimeSpan, TimeSpan> PredictionUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	private TimeSpan ElapsedTime
	{
		private get { } //Length: 91
	}

	public private bool IsAWOL
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsBanned
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsDisconnected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsStarted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private TimeSpan Latency
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private TimeSpan LatencyVariance
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public byte PlayerNumber
	{
		 get { } //Length: 27
	}

	public OtherPlayer Public
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public OtherPlayerPrivate(byte playerNumber, string info, ConnectionConfig config) { }

	[CompilerGenerated]
	private TimeSpan <CalculateStats>b__64_0(LatencyMeasurement m) { }

	[CompilerGenerated]
	public void add_AWOLEvent(Action value) { }

	[CompilerGenerated]
	public void add_KickedEvent(Action value) { }

	[CompilerGenerated]
	public void add_LatencyUpdateEvent(Action<TimeSpan, TimeSpan, Boolean> value) { }

	[CompilerGenerated]
	public void add_PredictionUpdateEvent(Action<TimeSpan, TimeSpan> value) { }

	private NormalisedStats CalculateStats(LatencyHistory latencyMeasurements) { }

	private TimeSpan get_ElapsedTime() { }

	[CompilerGenerated]
	public bool get_IsAWOL() { }

	[CompilerGenerated]
	public bool get_IsBanned() { }

	[CompilerGenerated]
	public bool get_IsDisconnected() { }

	[CompilerGenerated]
	public bool get_IsStarted() { }

	[CompilerGenerated]
	public TimeSpan get_Latency() { }

	[CompilerGenerated]
	public TimeSpan get_LatencyVariance() { }

	public byte get_PlayerNumber() { }

	[CompilerGenerated]
	public OtherPlayer get_Public() { }

	private void GoAwol() { }

	private bool MeasurementIsLate(NormalisedStats stats, LatencyMeasurement measurement, TimeSpan limit) { }

	public void OnLatencyUpdated(LatencyMeasurement latencyMeasurement) { }

	public void OnOwnLatencyUpdated(LatencyMeasurement ownLatestMeasurement) { }

	[CompilerGenerated]
	public void remove_AWOLEvent(Action value) { }

	[CompilerGenerated]
	public void remove_KickedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_LatencyUpdateEvent(Action<TimeSpan, TimeSpan, Boolean> value) { }

	[CompilerGenerated]
	public void remove_PredictionUpdateEvent(Action<TimeSpan, TimeSpan> value) { }

	[CompilerGenerated]
	private void set_IsAWOL(bool value) { }

	[CompilerGenerated]
	private void set_IsBanned(bool value) { }

	[CompilerGenerated]
	private void set_IsDisconnected(bool value) { }

	[CompilerGenerated]
	private void set_IsStarted(bool value) { }

	[CompilerGenerated]
	private void set_Latency(TimeSpan value) { }

	[CompilerGenerated]
	private void set_LatencyVariance(TimeSpan value) { }

	public void SetAWOL(bool isNowAWOL) { }

	public void SetBanned(bool isNowBanned) { }

	public void SetDisconnected(bool isNowDisconnected) { }

	public void SetStarted() { }

}

