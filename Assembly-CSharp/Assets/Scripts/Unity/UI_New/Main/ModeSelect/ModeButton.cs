namespace Assets.Scripts.Unity.UI_New.Main.ModeSelect;

public class ModeButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <TimedUnlock>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float unlockDelay; //Field offset: 0x20
		public ModeButton <>4__this; //Field offset: 0x28

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
		public <TimedUnlock>d__12(int <>1__state) { }

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

	public string modeType; //Field offset: 0x20
	public string unlockMode; //Field offset: 0x28
	public float unlockDelay; //Field offset: 0x30
	public Button button; //Field offset: 0x38
	public Animator animator; //Field offset: 0x40
	public GameObject medal; //Field offset: 0x48
	private Animator medalAnimator; //Field offset: 0x50
	private string currentState; //Field offset: 0x58
	private bool initialised; //Field offset: 0x60

	public ModeButton() { }

	public void ButtonClicked() { }

	private void DisplayUnlockAnimation() { }

	public void Initialise() { }

	private void Lock() { }

	private void OverrideSavedGame() { }

	[IteratorStateMachine(typeof(<TimedUnlock>d__12))]
	private IEnumerator TimedUnlock(float unlockDelay) { }

	private void Unlock() { }

	public void Update() { }

}

