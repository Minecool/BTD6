namespace NinjaKiwi.LiNK.Lobbies;

public class DebugGameConnection : GameConnection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DebugPlayer, DebugPlayer, Boolean> <>9__8_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<Byte, OtherPlayerPrivate>, DebugOtherPlayer> <>9__13_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal DebugOtherPlayer <.ctor>b__13_1(KeyValuePair<Byte, OtherPlayerPrivate> kvp) { }

		internal bool <get_AllPlayers>b__8_0(DebugPlayer s, DebugPlayer p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public ICollection instance; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal int <.ctor>b__0() { }

	}

	internal class DebugOtherPlayer : DebugPlayer, Player
	{
		private readonly OtherPlayerPrivate BasePlayer; //Field offset: 0x10
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

		public override int LastMessageReceived
		{
			 get { } //Length: 26
		}

		public override TimeSpan Latency
		{
			 get { } //Length: 27
		}

		public override TimeSpan LatencyVariance
		{
			 get { } //Length: 27
		}

		public override int MessageDeliveryConfirmed
		{
			 get { } //Length: 26
		}

		public override byte PlayerNumber
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public DebugOtherPlayer(byte playerNumber, OtherPlayerPrivate basePlayer) { }

		public override string get_Info() { }

		public override bool get_IsAWOL() { }

		public override bool get_IsDisconnected() { }

		public override int get_LastMessageReceived() { }

		public override TimeSpan get_Latency() { }

		public override TimeSpan get_LatencyVariance() { }

		public override int get_MessageDeliveryConfirmed() { }

		[CompilerGenerated]
		public override byte get_PlayerNumber() { }

	}

	internal interface DebugPlayer : Player
	{

		public int LastMessageReceived
		{
			 get { } //Length: 0
		}

		public int MessageDeliveryConfirmed
		{
			 get { } //Length: 0
		}

		public int get_LastMessageReceived() { }

		public int get_MessageDeliveryConfirmed() { }

	}

	internal class DebugSelfPlayer : DebugPlayer, Player
	{
		private SelfPlayer BasePlayer; //Field offset: 0x10

		public override string Info
		{
			 get { } //Length: 27
		}

		public override bool IsAWOL
		{
			 get { } //Length: 29
		}

		public override bool IsDisconnected
		{
			 get { } //Length: 29
		}

		public override int LastMessageReceived
		{
			 get { } //Length: 3
		}

		public override TimeSpan Latency
		{
			 get { } //Length: 27
		}

		public override TimeSpan LatencyVariance
		{
			 get { } //Length: 27
		}

		public override int MessageDeliveryConfirmed
		{
			 get { } //Length: 3
		}

		public override byte PlayerNumber
		{
			 get { } //Length: 27
		}

		public DebugSelfPlayer(SelfPlayer basePlayer) { }

		public override string get_Info() { }

		public override bool get_IsAWOL() { }

		public override bool get_IsDisconnected() { }

		public override int get_LastMessageReceived() { }

		public override TimeSpan get_Latency() { }

		public override TimeSpan get_LatencyVariance() { }

		public override int get_MessageDeliveryConfirmed() { }

		public override byte get_PlayerNumber() { }

	}

	[CompilerGenerated]
	private Action<TimeSpan, TimeSpan, Boolean> OtherPlayerLatencyUpdatedEvent; //Field offset: 0xC8
	[CompilerGenerated]
	private Action<TimeSpan, TimeSpan> OtherPlayerPredictionUpdatedEvent; //Field offset: 0xD0
	public readonly IEnumerable<DebugPlayer> OtherPlayers; //Field offset: 0xD8
	private DebugSelfPlayer DebugSelf; //Field offset: 0xE0
	private readonly Func<Int32> GetMessageHistoryLength; //Field offset: 0xE8

	public event Action<TimeSpan, TimeSpan, Boolean> OtherPlayerLatencyUpdatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public event Action<TimeSpan, TimeSpan> OtherPlayerPredictionUpdatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public IEnumerable<DebugPlayer> AllPlayers
	{
		 get { } //Length: 270
	}

	public int MessageHistoryLength
	{
		 get { } //Length: 40
	}

	public DebugGameConnection(NKMultiConnection connection, string lobbyID, Dictionary<Byte, String> players) { }

	[CompilerGenerated]
	private void <.ctor>b__13_2(TimeSpan l, TimeSpan t, bool d) { }

	[CompilerGenerated]
	private void <.ctor>b__13_3(TimeSpan t, TimeSpan err) { }

	[CompilerGenerated]
	public void add_OtherPlayerLatencyUpdatedEvent(Action<TimeSpan, TimeSpan, Boolean> value) { }

	[CompilerGenerated]
	public void add_OtherPlayerPredictionUpdatedEvent(Action<TimeSpan, TimeSpan> value) { }

	public IEnumerable<DebugPlayer> get_AllPlayers() { }

	public int get_MessageHistoryLength() { }

	[CompilerGenerated]
	public void remove_OtherPlayerLatencyUpdatedEvent(Action<TimeSpan, TimeSpan, Boolean> value) { }

	[CompilerGenerated]
	public void remove_OtherPlayerPredictionUpdatedEvent(Action<TimeSpan, TimeSpan> value) { }

}

