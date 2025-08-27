namespace NinjaKiwi.LiNK.Lobbies;

public class SecondsCountdown : Countdown, IDisposable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__5 : IEnumerator<Task`1<Int32>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Task<Int32> <>2__current; //Field offset: 0x18
		public SecondsCountdown <>4__this; //Field offset: 0x20

		private override Task<Int32> System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task<System.Int32>>.Current
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
		public <GetEnumerator>d__5(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override Task<Int32> System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task<System.Int32>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <WaitUntil>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public SecondsCountdown <>4__this; //Field offset: 0x20
		public TimeSpan endTime; //Field offset: 0x28
		public int result; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x34

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Stopwatch stopwatch; //Field offset: 0x18
	private TimeSpan NextTickTime; //Field offset: 0x20
	private bool IsDisposed; //Field offset: 0x28

	public SecondsCountdown(int seconds) { }

	public override void Dispose() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__5))]
	public virtual IEnumerator<Task`1<Int32>> GetEnumerator() { }

	[AsyncStateMachine(typeof(<WaitUntil>d__6))]
	private Task<Int32> WaitUntil(TimeSpan endTime, int result) { }

}

