namespace NinjaKiwi.LiNK.Lobbies;

public class OtherPlayer : Player
{
	protected readonly OtherPlayerPrivate P; //Field offset: 0x10
	[CompilerGenerated]
	private readonly byte <PlayerNumber>k__BackingField; //Field offset: 0x18

	public override string Info
	{
		 get { } //Length: 27
	}

	public override bool IsAWOL
	{
		 get { } //Length: 27
	}

	public override bool IsDisconnected
	{
		 get { } //Length: 27
	}

	public override TimeSpan Latency
	{
		 get { } //Length: 27
	}

	public override TimeSpan LatencyVariance
	{
		 get { } //Length: 27
	}

	public override byte PlayerNumber
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public OtherPlayer(byte playerNumber, OtherPlayerPrivate otherPlayer) { }

	public override string get_Info() { }

	public override bool get_IsAWOL() { }

	public override bool get_IsDisconnected() { }

	public override TimeSpan get_Latency() { }

	public override TimeSpan get_LatencyVariance() { }

	[CompilerGenerated]
	public override byte get_PlayerNumber() { }

}

