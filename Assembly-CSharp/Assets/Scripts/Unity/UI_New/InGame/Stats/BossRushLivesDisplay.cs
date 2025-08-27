namespace Assets.Scripts.Unity.UI_New.InGame.Stats;

public class BossRushLivesDisplay : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BossRushLivesDisplay <>4__this; //Field offset: 0x20

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

	[SerializeField]
	private Transform bonusHeartsContainer; //Field offset: 0x20
	[SerializeField]
	private GameObject bonusHeartTemplate; //Field offset: 0x28
	[SerializeField]
	private Animator anim; //Field offset: 0x30
	private List<GameObject> bonusHearts; //Field offset: 0x38

	public BossRushLivesDisplay() { }

	private void AddListeners() { }

	public virtual void Destroy() { }

	[IteratorStateMachine(typeof(<Initialise>d__4))]
	public virtual IEnumerator Initialise() { }

	private void InitLives() { }

	private void OnInfinitHealthModeDetected() { }

	private void RevivesChanged(int lives) { }

	private void UpdateRevives(int lives) { }

}

