namespace NinjaKiwi.LiNK.Lobbies;

public class SelfPlayer : Player
{
	[CompilerGenerated]
	private readonly byte <PlayerNumber>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Info>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private TimeSpan <Latency>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private TimeSpan <LatencyVariance>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsBanned>k__BackingField; //Field offset: 0x30
	private readonly LatencyHistory LatencyHistory; //Field offset: 0x38

	public override string Info
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool IsAWOL
	{
		 get { } //Length: 3
	}

	public private bool IsBanned
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool IsDisconnected
	{
		 get { } //Length: 3
	}

	public private override TimeSpan Latency
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private override TimeSpan LatencyVariance
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public override byte PlayerNumber
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public SelfPlayer(byte playerNumber, string info, ConnectionConfig config) { }

	public void ClearLatencyHistory() { }

	[CompilerGenerated]
	public override string get_Info() { }

	public override bool get_IsAWOL() { }

	[CompilerGenerated]
	public bool get_IsBanned() { }

	public override bool get_IsDisconnected() { }

	[CompilerGenerated]
	public override TimeSpan get_Latency() { }

	[CompilerGenerated]
	public override TimeSpan get_LatencyVariance() { }

	[CompilerGenerated]
	public override byte get_PlayerNumber() { }

	[CompilerGenerated]
	private void set_IsBanned(bool value) { }

	[CompilerGenerated]
	private void set_Latency(TimeSpan value) { }

	[CompilerGenerated]
	private void set_LatencyVariance(TimeSpan value) { }

	public void SetBanned(bool isNowBanned) { }

	public void UpdateLatency(LatencyMeasurement newMeasurement) { }

}

