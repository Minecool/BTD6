namespace Assets.Scripts.Unity.UI_New.InGame.Stats;

public class GameMessageManager : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GameMessageManager <>4__this; //Field offset: 0x20

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
		public <Initialise>d__3(int <>1__state) { }

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

	internal enum MessageType
	{
		HelperMessage = 0,
		MaxMonkeysHelperMessage = 1,
	}

	public GameObject[] messagePrefabs; //Field offset: 0x20
	public bool showingMessage; //Field offset: 0x28

	public GameMessageManager() { }

	public virtual void Destroy() { }

	[IteratorStateMachine(typeof(<Initialise>d__3))]
	public virtual IEnumerator Initialise() { }

	public void OnEnterPlacingTower() { }

	public void OnExitPlacingTower() { }

	public void OnHelperMessageChanged(string strMessage, float timeUntilClear = -1) { }

	public void ShowMessage(MessageType m, string strMessage, float timeUntilClear = -1) { }

}

