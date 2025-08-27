namespace Assets.Scripts.Unity.Network;

public interface Btd6CoopGame : IDisposable
{

	public event Action<String> DisconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action LatencyWarningEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<String> LogEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action NoPlayersAWOLEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IEnumerable`1<Task`1<Int32>>, Byte> PlayerAWOLEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<Byte, String> PlayerLeftEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<Byte> PlayerNotAWOLEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<Byte> PlayerRejoinedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action ReconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IEnumerable`1<Task`1<Int32>>> ReconnectingEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action RejoinedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IEnumerable<CoopPlayerInfo> AllPlayers
	{
		 get { } //Length: 0
	}

	public string LobbyID
	{
		 get { } //Length: 0
	}

	public byte NumPlayers
	{
		 get { } //Length: 0
	}

	public IEnumerable<CoopPlayerInfo> OtherPlayers
	{
		 get { } //Length: 0
	}

	public TimeSpan OwnLatency
	{
		 get { } //Length: 0
	}

	public TimeSpan OwnLatencyVariance
	{
		 get { } //Length: 0
	}

	public byte OwnPlayerNumber
	{
		 get { } //Length: 0
	}

	public Queue<ReceivedMessage> ReceiveQueue
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_DisconnectedEvent(Action<String> value) { }

	[CompilerGenerated]
	public void add_LatencyWarningEvent(Action value) { }

	[CompilerGenerated]
	public void add_LogEvent(Action<String> value) { }

	[CompilerGenerated]
	public void add_NoPlayersAWOLEvent(Action value) { }

	[CompilerGenerated]
	public void add_PlayerAWOLEvent(Action<IEnumerable`1<Task`1<Int32>>, Byte> value) { }

	[CompilerGenerated]
	public void add_PlayerLeftEvent(Action<Byte, String> value) { }

	[CompilerGenerated]
	public void add_PlayerNotAWOLEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void add_PlayerRejoinedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void add_ReconnectedEvent(Action value) { }

	[CompilerGenerated]
	public void add_ReconnectingEvent(Action<IEnumerable`1<Task`1<Int32>>> value) { }

	[CompilerGenerated]
	public void add_RejoinedEvent(Action value) { }

	public byte Authority() { }

	public void Ban(byte playerNumber) { }

	public void ChooseNewAuthority(List<Byte> invalidPlayers) { }

	public IEnumerable<CoopPlayerInfo> get_AllPlayers() { }

	public string get_LobbyID() { }

	public byte get_NumPlayers() { }

	public IEnumerable<CoopPlayerInfo> get_OtherPlayers() { }

	public TimeSpan get_OwnLatency() { }

	public TimeSpan get_OwnLatencyVariance() { }

	public byte get_OwnPlayerNumber() { }

	public Queue<ReceivedMessage> get_ReceiveQueue() { }

	public bool IsAuthority() { }

	public bool IsAuthority(byte playerNumber) { }

	public Task Rejoin(CancellationToken canceller) { }

	[CompilerGenerated]
	public void remove_DisconnectedEvent(Action<String> value) { }

	[CompilerGenerated]
	public void remove_LatencyWarningEvent(Action value) { }

	[CompilerGenerated]
	public void remove_LogEvent(Action<String> value) { }

	[CompilerGenerated]
	public void remove_NoPlayersAWOLEvent(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerAWOLEvent(Action<IEnumerable`1<Task`1<Int32>>, Byte> value) { }

	[CompilerGenerated]
	public void remove_PlayerLeftEvent(Action<Byte, String> value) { }

	[CompilerGenerated]
	public void remove_PlayerNotAWOLEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void remove_PlayerRejoinedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void remove_ReconnectedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_ReconnectingEvent(Action<IEnumerable`1<Task`1<Int32>>> value) { }

	[CompilerGenerated]
	public void remove_RejoinedEvent(Action value) { }

	public void Send(Writable content) { }

	public void SetAuthority(byte playerNumber) { }

}

