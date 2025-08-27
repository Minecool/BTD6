namespace Assets.Scripts.Unity.Map.Effects;

public class HideObjectOnRemoveableSold : OnRemoveableSold
{
	[CompilerGenerated]
	private sealed class <WaitUntilHide>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public HideObjectOnRemoveableSold <>4__this; //Field offset: 0x28

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
		public <WaitUntilHide>d__6(int <>1__state) { }

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

	[Tooltip("A non 0 value will delay the hide")]
	public float delay; //Field offset: 0x28
	public GameObject obj; //Field offset: 0x30
	private Coroutine delayedAction; //Field offset: 0x38

	public HideObjectOnRemoveableSold() { }

	public virtual void GotoPostAction() { }

	public virtual void PerformAction() { }

	public virtual void SetToOriginalState(bool mapEventActive) { }

	[IteratorStateMachine(typeof(<WaitUntilHide>d__6))]
	public IEnumerator WaitUntilHide(float delay) { }

}

