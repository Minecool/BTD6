namespace Assets.Scripts.Unity.Player;

public class PubSub
{
	[CompilerGenerated]
	private struct <CheckForMessagesAndGifts>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PubSub <>4__this; //Field offset: 0x20
		private OnlineProfileModel <onlineData>5__2; //Field offset: 0x28
		private List<PubSubMessageModel> <pubsubMessages>5__3; //Field offset: 0x30
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter<PubSubMessageModel[]> <>u__2; //Field offset: 0x40
		private Enumerator<PubSubMessageModel> <>7__wrap3; //Field offset: 0x48
		private TaskAwaiter <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetInboxMessages>d__9 : IAsyncStateMachine
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
	private struct <GetPubSubMessages>d__10 : IAsyncStateMachine
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
	private struct <TryCheckForMessagesAndGifts>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PubSub <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class NewMessageReceived : MulticastDelegate
	{

		public NewMessageReceived(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	private readonly Btd6Player <Player>k__BackingField; //Field offset: 0x10

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

	[AsyncStateMachine(typeof(<CheckForMessagesAndGifts>d__8))]
	private Task CheckForMessagesAndGifts() { }

	private bool get_IsDestroyed() { }

	[CompilerGenerated]
	private Btd6Player get_Player() { }

	[AsyncStateMachine(typeof(<GetInboxMessages>d__9))]
	private Task<PubSubMessageModel[]> GetInboxMessages() { }

	[AsyncStateMachine(typeof(<GetPubSubMessages>d__10))]
	private Task<PubSubMessageModel[]> GetPubSubMessages(string channelId) { }

	private void ProcessSweepstakesMessage(OnlineProfileModel onlineData, PubSubMessageModel message) { }

	[AsyncStateMachine(typeof(<TryCheckForMessagesAndGifts>d__7))]
	public Task TryCheckForMessagesAndGifts() { }

}

