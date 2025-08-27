namespace Assets.Scripts.Unity.UI_New.InGame.Stats;

public class NetworkDisplay : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NetworkDisplay <>4__this; //Field offset: 0x20

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
		public <Initialise>d__2(int <>1__state) { }

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

	private NK_TextMeshProUGUI text; //Field offset: 0x20
	private float updateSpan; //Field offset: 0x28

	public NetworkDisplay() { }

	[IteratorStateMachine(typeof(<Initialise>d__2))]
	public virtual IEnumerator Initialise() { }

}

