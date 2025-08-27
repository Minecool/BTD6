namespace Assets.Scripts.Unity.Network;

public class Btd6CoopGameNetworked : Btd6CoopGame, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Exception> <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__14_0(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <get_AllPlayers>d__34 : IEnumerable<CoopPlayerInfo>, IEnumerable, IEnumerator<CoopPlayerInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private CoopPlayerInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Btd6CoopGameNetworked <>4__this; //Field offset: 0x28
		private IEnumerator<Player> <>7__wrap1; //Field offset: 0x30

		private override CoopPlayerInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Network.CoopPlayerInfo>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_AllPlayers>d__34(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<CoopPlayerInfo> System.Collections.Generic.IEnumerable<Assets.Scripts.Unity.Network.CoopPlayerInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override CoopPlayerInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Network.CoopPlayerInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_OtherPlayers>d__32 : IEnumerable<CoopPlayerInfo>, IEnumerable, IEnumerator<CoopPlayerInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private CoopPlayerInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Btd6CoopGameNetworked <>4__this; //Field offset: 0x28
		private IEnumerator<Player> <>7__wrap1; //Field offset: 0x30

		private override CoopPlayerInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Network.CoopPlayerInfo>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_OtherPlayers>d__32(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<CoopPlayerInfo> System.Collections.Generic.IEnumerable<Assets.Scripts.Unity.Network.CoopPlayerInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override CoopPlayerInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Network.CoopPlayerInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private byte <OwnPlayerNumber>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private byte <NumPlayers>k__BackingField; //Field offset: 0x11
	public readonly GameConnection Connection; //Field offset: 0x18
	private readonly Dictionary<Byte, CoopPlayerInfo> PlayersInfo; //Field offset: 0x20
	private byte eapn; //Field offset: 0x28

	public override event Action<String> DisconnectedEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action LatencyWarningEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action<String> LogEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action NoPlayersAWOLEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action<IEnumerable`1<Task`1<Int32>>, Byte> PlayerAWOLEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action<Byte, String> PlayerLeftEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action<Byte> PlayerNotAWOLEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action<Byte> PlayerRejoinedEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action ReconnectedEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action<IEnumerable`1<Task`1<Int32>>> ReconnectingEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override event Action RejoinedEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public override IEnumerable<CoopPlayerInfo> AllPlayers
	{
		[IteratorStateMachine(typeof(<get_AllPlayers>d__34))]
		 get { } //Length: 101
	}

	private byte expectedAuthorityPlayerNumber
	{
		private get { } //Length: 5
		private set { } //Length: 9
	}

	public GameDetails GameDetails
	{
		 get { } //Length: 29
	}

	public override string LobbyID
	{
		 get { } //Length: 27
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
		[IteratorStateMachine(typeof(<get_OtherPlayers>d__32))]
		 get { } //Length: 101
	}

	public override TimeSpan OwnLatency
	{
		 get { } //Length: 29
	}

	public override TimeSpan OwnLatencyVariance
	{
		 get { } //Length: 29
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
		 get { } //Length: 27
	}

	public Btd6CoopGameNetworked(GameConnection connection) { }

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

	public void ChooseAuthorityWhenRejoining() { }

	public override void ChooseNewAuthority(List<Byte> invalidPlayers) { }

	public override void Dispose() { }

	[IteratorStateMachine(typeof(<get_AllPlayers>d__34))]
	public override IEnumerable<CoopPlayerInfo> get_AllPlayers() { }

	private byte get_expectedAuthorityPlayerNumber() { }

	public GameDetails get_GameDetails() { }

	public override string get_LobbyID() { }

	[CompilerGenerated]
	public override byte get_NumPlayers() { }

	[IteratorStateMachine(typeof(<get_OtherPlayers>d__32))]
	public override IEnumerable<CoopPlayerInfo> get_OtherPlayers() { }

	public override TimeSpan get_OwnLatency() { }

	public override TimeSpan get_OwnLatencyVariance() { }

	[CompilerGenerated]
	public override byte get_OwnPlayerNumber() { }

	public override Queue<ReceivedMessage> get_ReceiveQueue() { }

	private CoopPlayerInfo GetPlayerInfo(Player player) { }

	public override bool IsAuthority() { }

	public override bool IsAuthority(byte playerNumber) { }

	public override Task Rejoin(CancellationToken canceller) { }

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

	private void set_expectedAuthorityPlayerNumber(byte value) { }

	[CompilerGenerated]
	private void set_NumPlayers(byte value) { }

	[CompilerGenerated]
	private void set_OwnPlayerNumber(byte value) { }

	public override void SetAuthority(byte playerNumber) { }

}

