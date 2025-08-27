namespace NinjaKiwi.Common;

public class CoroutineRunner : MonoBehaviourSingleton<CoroutineRunner>
{
	[CompilerGenerated]
	private sealed class <DoWork>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoroutineRunner <>4__this; //Field offset: 0x20
		public IEnumerator enumerator; //Field offset: 0x28

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
		public <DoWork>d__2(int <>1__state) { }

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

	private int nActiveCoroutines; //Field offset: 0x20

	public CoroutineRunner() { }

	[IteratorStateMachine(typeof(<DoWork>d__2))]
	private IEnumerator DoWork(IEnumerator enumerator) { }

	public static void Run(IEnumerator routine) { }

}

