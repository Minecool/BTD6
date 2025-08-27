namespace Assets.Scripts.Unity.Player;

public class PubSub
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PubSubMessageModel, DateTime> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DateTime <CheckForMessagesAndGifts>b__10_0(PubSubMessageModel x) { }

	}

	[CompilerGenerated]
	private struct <CheckForMessagesAndGifts>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PubSub <>4__this; //Field offset: 0x20
		private OnlineProfileModel <onlineData>5__2; //Field offset: 0x28
		private List<PubSubMessageModel> <pubsubMessages>5__3; //Field offset: 0x30
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter<PubSubMessageModel[]> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetInboxMessages>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PubSubMessageModel[]> <>t__builder; //Field offset: 0x8
		public PubSub <>4__this; //Field offset: 0x20
		private TaskAwaiter<PubSubChannelModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetPubSubMessages>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PubSubMessageModel[]> <>t__builder; //Field offset: 0x8
		public PubSub <>4__this; //Field offset: 0x20
		public string channelId; //Field offset: 0x28
		private TaskAwaiter<PubSubChannelModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryCheckForMessagesAndGifts>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PubSub <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum MessageType
	{
		Unknown = 0,
		Gift = 2,
		Mail = 3,
		Sweepstakes = 6676,
	}

	internal sealed class NewMessageReceived : MulticastDelegate
	{

		public NewMessageReceived(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private Task messageAndGiftCheckTask; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Btd6Player <Player>k__BackingField; //Field offset: 0x18

	private bool IsDestroyed
	{
		private get { } //Length: 29
	}

	private Btd6Player Player
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public PubSub(Btd6Player player) { }

	[AsyncStateMachine(typeof(<CheckForMessagesAndGifts>d__10))]
	private Task CheckForMessagesAndGifts() { }

	private bool get_IsDestroyed() { }

	[CompilerGenerated]
	private Btd6Player get_Player() { }

	[AsyncStateMachine(typeof(<GetInboxMessages>d__11))]
	private Task<PubSubMessageModel[]> GetInboxMessages() { }

	[AsyncStateMachine(typeof(<GetPubSubMessages>d__12))]
	private Task<PubSubMessageModel[]> GetPubSubMessages(string channelId) { }

	public void ProcessGiftMessage(PubSubMessageModel pubsubMessage) { }

	private void ProcessSweepstakesMessage(OnlineProfileModel onlineData, PubSubMessageModel message) { }

	[AsyncStateMachine(typeof(<TryCheckForMessagesAndGifts>d__9))]
	public Task TryCheckForMessagesAndGifts() { }

}

