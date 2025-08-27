namespace Assets.Scripts.Models.ServerEvents;

[Extension]
public static class CtEventExtensions
{
	[CompilerGenerated]
	private struct <GetCtEventStatus>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtEventStatus> <>t__builder; //Field offset: 0x8
		public CtEvent ctEvent; //Field offset: 0x20
		private TaskAwaiter<Btd6CtSettings> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetNextAvailableCtEvent>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtEvent> <>t__builder; //Field offset: 0x8
		private CtEvent <ctEvent>5__2; //Field offset: 0x20
		private TaskAwaiter<CtEventStatus> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<GetCtEventStatus>d__3))]
	[Extension]
	public static Task<CtEventStatus> GetCtEventStatus(CtEvent ctEvent) { }

	[Extension]
	public static CtEventStatus GetCtEventStatusCached(CtEvent ctEvent) { }

	[AsyncStateMachine(typeof(<GetNextAvailableCtEvent>d__1))]
	public static Task<CtEvent> GetNextAvailableCtEvent() { }

	public static CtEvent GetNextAvailableCtEventCached() { }

	private static CtEvent GetNextAvailableCtEventCached(CtEvent ctEvent = null) { }

}

