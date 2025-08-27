namespace Assets.Scripts.Unity.UI_New.InGame.Stats;

public class RoundDisplay : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RoundDisplay <>4__this; //Field offset: 0x20

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
		public <Initialise>d__4(int <>1__state) { }

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
	private int cachedRoundDisp; //Field offset: 0x28
	private bool infinitRoundsButShowRoundNum; //Field offset: 0x2C
	private bool endlessRoundsNoUpdateEvent; //Field offset: 0x2D

	public RoundDisplay() { }

	private void AddListeners() { }

	public virtual void Destroy() { }

	[IteratorStateMachine(typeof(<Initialise>d__4))]
	public virtual IEnumerator Initialise() { }

	private void OnEndlessRoundsModeDetected(bool showCurrentRoundNum) { }

	public virtual void OnUpdate() { }

}

