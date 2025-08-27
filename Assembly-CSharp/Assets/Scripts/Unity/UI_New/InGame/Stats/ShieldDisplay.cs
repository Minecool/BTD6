namespace Assets.Scripts.Unity.UI_New.InGame.Stats;

public class ShieldDisplay : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ShieldDisplay <>4__this; //Field offset: 0x20

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

	public NK_TextMeshProUGUI text; //Field offset: 0x20
	public Animator animator; //Field offset: 0x28
	private bool showingShield; //Field offset: 0x30
	private float cachedShield; //Field offset: 0x34

	public ShieldDisplay() { }

	public virtual void Destroy() { }

	private void HideShield() { }

	[IteratorStateMachine(typeof(<Initialise>d__4))]
	public virtual IEnumerator Initialise() { }

	public virtual void OnUpdate() { }

	private void ShowShield() { }

}

