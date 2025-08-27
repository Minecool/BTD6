namespace Assets.Scripts.Unity.Network;

public class Btd6CoopGameReplay : Btd6CoopGame, IDisposable
{
	[CompilerGenerated]
	private byte <OwnPlayerNumber>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private byte <NumPlayers>k__BackingField; //Field offset: 0x11
	public CoopReplay replay; //Field offset: 0x18

	public override event Action<String> DisconnectedEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action LatencyWarningEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action<String> LogEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action NoPlayersAWOLEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action<IEnumerable`1<Task`1<Int32>>, Byte> PlayerAWOLEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action<Byte, String> PlayerLeftEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action<Byte> PlayerNotAWOLEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action<Byte> PlayerRejoinedEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action ReconnectedEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action<IEnumerable`1<Task`1<Int32>>> ReconnectingEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override event Action RejoinedEvent
	{
		 add { } //Length: 3
		 remove { } //Length: 3
	}

	public override IEnumerable<CoopPlayerInfo> AllPlayers
	{
		 get { } //Length: 27
	}

	public bool IsConnected
	{
		 get { } //Length: 3
	}

	public override string LobbyID
	{
		 get { } //Length: 44
	}

	public private override byte NumPlayers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override IEnumerable<CoopPlayerInfo> OtherPlayers
	{
		 get { } //Length: 27
	}

	public override TimeSpan OwnLatency
	{
		 get { } //Length: 3
	}

	public override TimeSpan OwnLatencyVariance
	{
		 get { } //Length: 3
	}

	public private override byte OwnPlayerNumber
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override Queue<ReceivedMessage> ReceiveQueue
	{
		 get { } //Length: 85
	}

	public Btd6CoopGameReplay(CoopReplay replay) { }

	public override void add_DisconnectedEvent(Action<String> value) { }

	public override void add_LatencyWarningEvent(Action value) { }

	public override void add_LogEvent(Action<String> value) { }

	public override void add_NoPlayersAWOLEvent(Action value) { }

	public override void add_PlayerAWOLEvent(Action<IEnumerable`1<Task`1<Int32>>, Byte> value) { }

	public override void add_PlayerLeftEvent(Action<Byte, String> value) { }

	public override void add_PlayerNotAWOLEvent(Action<Byte> value) { }

	public override void add_PlayerRejoinedEvent(Action<Byte> value) { }

	public override void add_ReconnectedEvent(Action value) { }

	public override void add_ReconnectingEvent(Action<IEnumerable`1<Task`1<Int32>>> value) { }

	public override void add_RejoinedEvent(Action value) { }

	public override byte Authority() { }

	public override void Ban(byte playerNumber) { }

	public override void ChooseNewAuthority(List<Byte> invalidPlayers) { }

	public override void Dispose() { }

	public override IEnumerable<CoopPlayerInfo> get_AllPlayers() { }

	public bool get_IsConnected() { }

	public override string get_LobbyID() { }

	[CompilerGenerated]
	public override byte get_NumPlayers() { }

	public override IEnumerable<CoopPlayerInfo> get_OtherPlayers() { }

	public override TimeSpan get_OwnLatency() { }

	public override TimeSpan get_OwnLatencyVariance() { }

	[CompilerGenerated]
	public override byte get_OwnPlayerNumber() { }

	public override Queue<ReceivedMessage> get_ReceiveQueue() { }

	public override bool IsAuthority() { }

	public override bool IsAuthority(byte playerNumber) { }

	public override Task Rejoin(CancellationToken _) { }

	public override void remove_DisconnectedEvent(Action<String> value) { }

	public override void remove_LatencyWarningEvent(Action value) { }

	public override void remove_LogEvent(Action<String> value) { }

	public override void remove_NoPlayersAWOLEvent(Action value) { }

	public override void remove_PlayerAWOLEvent(Action<IEnumerable`1<Task`1<Int32>>, Byte> value) { }

	public override void remove_PlayerLeftEvent(Action<Byte, String> value) { }

	public override void remove_PlayerNotAWOLEvent(Action<Byte> value) { }

	public override void remove_PlayerRejoinedEvent(Action<Byte> value) { }

	public override void remove_ReconnectedEvent(Action value) { }

	public override void remove_ReconnectingEvent(Action<IEnumerable`1<Task`1<Int32>>> value) { }

	public override void remove_RejoinedEvent(Action value) { }

	public override void Send(Writable content) { }

	[CompilerGenerated]
	private void set_NumPlayers(byte value) { }

	[CompilerGenerated]
	private void set_OwnPlayerNumber(byte value) { }

	public override void SetAuthority(byte playerNumber) { }

}

