namespace Assets.Scripts.Unity.UI_New.InGame.Stats;

public class HealthDisplay : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HealthDisplay <>4__this; //Field offset: 0x20

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
		public <Initialise>d__5(int <>1__state) { }

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
	private float cachedHealth; //Field offset: 0x28
	private bool infinitHealth; //Field offset: 0x2C
	private bool bossRushHealth; //Field offset: 0x2D
	private float bossRushStartingHealth; //Field offset: 0x30

	public HealthDisplay() { }

	private void AddListeners() { }

	public virtual void Destroy() { }

	[IteratorStateMachine(typeof(<Initialise>d__5))]
	public virtual IEnumerator Initialise() { }

	private void OnInfinitHealthModeDetected() { }

	public virtual void OnUpdate() { }

}

