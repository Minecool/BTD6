namespace NinjaKiwi.LiNK.Transfer;

internal sealed class TemporarySession : Session
{
	[CompilerGenerated]
	private struct <Refresh>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public TemporarySession <>4__this; //Field offset: 0x20
		private bool <success>5__2; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30
		private SessionModel <>7__wrap2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Api liNK; //Field offset: 0x20
	private readonly Func<Task`1<String>> getSessionTicket; //Field offset: 0x28

	public TemporarySession(SessionModel sessionModel, Api liNK, Func<Task`1<String>> getSessionTicket) { }

	[AsyncStateMachine(typeof(<Refresh>d__3))]
	public virtual Task<Boolean> Refresh() { }

}

