namespace NinjaKiwi.LiNK.Lobbies;

public class ManualCountdown : Countdown, IDisposable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__6 : IEnumerator<Task`1<Int32>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Task<Int32> <>2__current; //Field offset: 0x18
		public ManualCountdown <>4__this; //Field offset: 0x20

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
		public <GetEnumerator>d__6(int <>1__state) { }

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

	private TaskCompletionSource<Int32> TaskCompletionSource; //Field offset: 0x18

	public bool IsDone
	{
		 get { } //Length: 9
	}

	public ManualCountdown(int ticks) { }

	public override void Dispose() { }

	public bool get_IsDone() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__6))]
	public virtual IEnumerator<Task`1<Int32>> GetEnumerator() { }

	public bool Tick() { }

}

