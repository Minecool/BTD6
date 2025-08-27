namespace NinjaKiwi.Common;

[Extension]
public static class TaskExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Task task; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <Await>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <Await>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Task task; //Field offset: 0x20
		private <>c__DisplayClass5_0 <>8__1; //Field offset: 0x28
		public TaskExceptionHandling taskExceptionHandling; //Field offset: 0x30

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
		public <Await>d__5(int <>1__state) { }

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
	private struct <RunAsync>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Task task; //Field offset: 0x28
		public TaskExceptionHandling taskExceptionHandling; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WithTimeout>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public Task<T> task; //Field offset: 0x0
		public Nullable<TimeSpan> timeout; //Field offset: 0x0
		public Nullable<CancellationToken> canceller; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WithTimeout>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Nullable<TimeSpan> timeout; //Field offset: 0x20
		public Nullable<CancellationToken> canceller; //Field offset: 0x30
		public Task task; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter<Task> <>u__2; //Field offset: 0x50
		private TaskAwaiter <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Extension]
	[IteratorStateMachine(typeof(<Await>d__5))]
	public static IEnumerator Await(Task task, TaskExceptionHandling taskExceptionHandling) { }

	private static void HandleTaskException(Exception exception, TaskExceptionHandling taskExceptionHandling) { }

	[AsyncStateMachine(typeof(<RunAsync>d__0))]
	[Extension]
	public static void RunAsync(Task task, TaskExceptionHandling taskExceptionHandling) { }

	[Extension]
	public static Task WithTimeout(Task task, TimeSpan timeout) { }

	[Extension]
	public static Task<T> WithTimeout(Task<T> task, TimeSpan timeout) { }

	[AsyncStateMachine(typeof(<WithTimeout>d__3`1))]
	[Extension]
	public static Task<T> WithTimeout(Task<T> task, Nullable<TimeSpan> timeout, Nullable<CancellationToken> canceller) { }

	[AsyncStateMachine(typeof(<WithTimeout>d__4))]
	[Extension]
	public static Task WithTimeout(Task task, Nullable<TimeSpan> timeout, Nullable<CancellationToken> canceller) { }

}

