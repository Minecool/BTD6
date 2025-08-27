namespace NinjaKiwi.LiNK.Client.Timing;

internal sealed class AsyncTimer
{
	[CompilerGenerated]
	private struct <Start>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AsyncTimer <>4__this; //Field offset: 0x28
		public TimeSpan delay; //Field offset: 0x30
		private Guid <id>5__2; //Field offset: 0x38
		private DateTime <endTime>5__3; //Field offset: 0x48
		private YieldAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Action<Int32> timeUpAction; //Field offset: 0x10
	private Guid currentID; //Field offset: 0x18
	private int counter; //Field offset: 0x28

	public AsyncTimer(Action<Int32> timeUpAction) { }

	public void Cancel() { }

	public void ResetCounter() { }

	[AsyncStateMachine(typeof(<Start>d__5))]
	public void Start(TimeSpan delay) { }

}

