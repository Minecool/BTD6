namespace NinjaKiwi.LiNK.Lobbies;

public interface Player
{

	public string Info
	{
		 get { } //Length: 0
	}

	public bool IsAWOL
	{
		 get { } //Length: 0
	}

	public bool IsDisconnected
	{
		 get { } //Length: 0
	}

	public TimeSpan Latency
	{
		 get { } //Length: 0
	}

	public TimeSpan LatencyVariance
	{
		 get { } //Length: 0
	}

	public byte PlayerNumber
	{
		 get { } //Length: 0
	}

	public string get_Info() { }

	public bool get_IsAWOL() { }

	public bool get_IsDisconnected() { }

	public TimeSpan get_Latency() { }

	public TimeSpan get_LatencyVariance() { }

	public byte get_PlayerNumber() { }

}

