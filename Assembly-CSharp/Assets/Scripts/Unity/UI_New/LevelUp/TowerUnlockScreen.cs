namespace Assets.Scripts.Unity.UI_New.LevelUp;

internal class TowerUnlockScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <WaitForAnimationEnd>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TowerUnlockScreen <>4__this; //Field offset: 0x20

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
		public <WaitForAnimationEnd>d__17(int <>1__state) { }

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

	internal sealed class ReturnCallback : MulticastDelegate
	{

		public ReturnCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UnlockTowerButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UnlockTowerButton button) { }

	}

	public UnlockTowerButton[] towerButtons; //Field offset: 0x48
	public NK_TextMeshProUGUI title; //Field offset: 0x50
	public NK_TextMeshProUGUI towerName; //Field offset: 0x58
	public NK_TextMeshProUGUI towerInfo; //Field offset: 0x60
	public float towerUnlockDelay; //Field offset: 0x68
	private bool towerUnlocked; //Field offset: 0x6C
	private UnlockTowerButton selectedButton; //Field offset: 0x70
	private TowerSet towerSet; //Field offset: 0x78

	public TowerUnlockScreen() { }

	[CompilerGenerated]
	private void <Open>b__9_0(GameObject x) { }

	public virtual void Close() { }

	public List<TowerModel> GetTowerList() { }

	public void OnUnlockTower() { }

	public virtual void Open(object data) { }

	public void SelectTower(UnlockTowerButton button) { }

	public void SetUpTowers() { }

	public void TowerSelectedCallback(UnlockTowerButton towerButton) { }

	private void UnlockedTower() { }

	[IteratorStateMachine(typeof(<WaitForAnimationEnd>d__17))]
	private IEnumerator WaitForAnimationEnd() { }

}

