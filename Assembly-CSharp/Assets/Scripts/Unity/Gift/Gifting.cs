namespace Assets.Scripts.Unity.Gift;

public class Gifting
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public string giftId; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <ProcessGiftMessage>b__0(ValueTuple<GiftMessageModel, PubSubMessageModel> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Gifting <>4__this; //Field offset: 0x10
		public GiftMessageModel gift; //Field offset: 0x18
		public PubSubMessageModel pubsubMessage; //Field offset: 0x20

		public <>c__DisplayClass15_0() { }

		internal void <ShowPendingGifts>b__0() { }

		internal void <ShowPendingGifts>b__1() { }

		internal void <ShowPendingGifts>b__2() { }

		internal void <ShowPendingGifts>b__3() { }

	}

	[CompilerGenerated]
	private struct <CheckForGiftAndShow>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Gifting <>4__this; //Field offset: 0x20
		public PubSubMessageModel pubsubMessage; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessGiftMessage>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PubSubMessageModel pubsubMessage; //Field offset: 0x20
		public Gifting <>4__this; //Field offset: 0x28
		private GiftMessageModel <gift>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly Btd6Player <Player>k__BackingField; //Field offset: 0x10
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"gift", "message"}])]
	private readonly Queue<ValueTuple`2<GiftMessageModel, PubSubMessageModel>> pendingGifts; //Field offset: 0x18
	private bool showingPopup; //Field offset: 0x20
	private bool needsSync; //Field offset: 0x21

	private HashSet<String> GiftsReceived
	{
		private get { } //Length: 81
	}

	public bool HasPendingGifts
	{
		 get { } //Length: 58
	}

	private bool IsDestroyed
	{
		private get { } //Length: 29
	}

	private Btd6Player Player
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public Gifting(Btd6Player player) { }

	[CompilerGenerated]
	private void <RecieveGift>b__16_0() { }

	[AsyncStateMachine(typeof(<CheckForGiftAndShow>d__11))]
	public Task CheckForGiftAndShow(PubSubMessageModel pubsubMessage) { }

	private HashSet<String> get_GiftsReceived() { }

	public bool get_HasPendingGifts() { }

	private bool get_IsDestroyed() { }

	[CompilerGenerated]
	private Btd6Player get_Player() { }

	[AsyncStateMachine(typeof(<ProcessGiftMessage>d__12))]
	public Task ProcessGiftMessage(PubSubMessageModel pubsubMessage) { }

	public void RecieveGift(GiftMessageModel gift, PubSubMessageModel pubsubMessage) { }

	public void ShowPendingGifts() { }

}

