namespace Assets.Scripts.Unity.UI_New.InGame;

public class DynamicUiObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Initialise>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <Initialise>d__0(int <>1__state) { }

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


	public DynamicUiObject() { }

	public override void Destroy() { }

	[IteratorStateMachine(typeof(<Initialise>d__0))]
	public override IEnumerator Initialise() { }

	public override void OnGameEnd() { }

	public override void OnGameStart() { }

	public override void OnRestartGame() { }

	public override void OnUpdate() { }

	public override bool OverrideOpenPauseMenu() { }

	public override void PostInitialised() { }

}

