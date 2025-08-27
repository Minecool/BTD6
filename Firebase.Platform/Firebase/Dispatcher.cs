namespace Firebase;

internal class Dispatcher
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public CallbackStorage<TResult> result; //Field offset: 0x0
		public Func<TResult> callback; //Field offset: 0x0
		public EventWaitHandle waitHandle; //Field offset: 0x0

		public <>c__DisplayClass4_0`1() { }

		internal void <Run>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public TaskCompletionSource<TResult> tcs; //Field offset: 0x0
		public Func<TResult> callback; //Field offset: 0x0

		public <>c__DisplayClass5_0`1() { }

		internal void <RunAsync>b__0() { }

	}

	private class CallbackStorage
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private TResult <Result>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private Exception <Exception>k__BackingField; //Field offset: 0x0

		public Exception Exception
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public TResult Result
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public CallbackStorage`1() { }

		[CompilerGenerated]
		public Exception get_Exception() { }

		[CompilerGenerated]
		public TResult get_Result() { }

		[CompilerGenerated]
		public void set_Exception(Exception value) { }

		[CompilerGenerated]
		public void set_Result(TResult value) { }

	}

	private int ownerThreadId; //Field offset: 0x10
	private Queue<Action> queue; //Field offset: 0x18

	public Dispatcher() { }

	internal bool ManagesThisThread() { }

	public void PollJobs() { }

	public TResult Run(Func<TResult> callback) { }

	public Task<TResult> RunAsync(Func<TResult> callback) { }

	internal static Task<TResult> RunAsyncNow(Func<TResult> callback) { }

}

