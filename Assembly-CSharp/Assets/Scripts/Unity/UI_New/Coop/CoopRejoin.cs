namespace Assets.Scripts.Unity.UI_New.Coop;

[Extension]
public static class CoopRejoin
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public CoopGameDetails coopGameDetails; //Field offset: 0x10
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		internal Task <ShowMainMenuRejoinOption>b__0(CancellationToken cancellationToken) { }

		internal void <ShowMainMenuRejoinOption>b__1() { }

		internal void <ShowMainMenuRejoinOption>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <enumerateThenCompleteTask>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public IEnumerator enumerator; //Field offset: 0x20
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <enumerateThenCompleteTask>d__5(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <Rejoin>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopGameDetails coopGameDetails; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private GameConnection <gameConnection>5__2; //Field offset: 0x30
		private TaskAwaiter<GameConnection> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[IteratorStateMachine(typeof(<enumerateThenCompleteTask>d__5))]
	private static IEnumerator enumerateThenCompleteTask(IEnumerator enumerator, TaskCompletionSource<Boolean> tcs) { }

	[Extension]
	private static TaskAwaiter GetAwaiter(IEnumerator enumerator) { }

	[AsyncStateMachine(typeof(<Rejoin>d__2))]
	public static Task Rejoin(CoopGameDetails coopGameDetails, CancellationToken canceller) { }

	public static Task<Boolean> ShowMainMenuRejoinOption(CoopGameDetails coopGameDetails) { }

	public static Task<Int32> TestIfGameCanBeRejoined(CoopGameDetails coopGameDetails, CancellationToken canceller) { }

	[Extension]
	private static Task ToTask(IEnumerator enumerator) { }

}

