namespace Assets.Scripts.Unity.UI_New.InGame.Stats;

public class CashDisplay : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CashDisplay <>4__this; //Field offset: 0x20

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
		public <Initialise>d__1(int <>1__state) { }

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

	public CashDisplay() { }

	private void AddListeners() { }

	public virtual void Destroy() { }

	[IteratorStateMachine(typeof(<Initialise>d__1))]
	public virtual IEnumerator Initialise() { }

	public void OnCashChanged() { }

}

