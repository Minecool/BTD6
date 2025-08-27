namespace Assets.Scripts.Unity.UI_New;

public class MainHudLeftAlign : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MainHudLeftAlign <>4__this; //Field offset: 0x20

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
		public <Initialise>d__18(int <>1__state) { }

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

	internal struct CashRushData
	{
		public int cashGoal; //Field offset: 0x0

	}

	public static MainHudLeftAlign instance; //Field offset: 0x0
	public Animator statsMenuAnimator; //Field offset: 0x20
	public Button healthButton; //Field offset: 0x28
	public Button cashButton; //Field offset: 0x30
	public GameObject thriveGlow; //Field offset: 0x38
	public Animator livesDrainAnimator; //Field offset: 0x40
	public NK_TextMeshProUGUI livesDrainText; //Field offset: 0x48
	public GameObject doubleCashEnabledObject; //Field offset: 0x50
	public Animator animator; //Field offset: 0x58
	public GameObject cashGoalObj; //Field offset: 0x60
	public Image cashGoalFill; //Field offset: 0x68
	[SerializeField]
	private GameObject fxObj; //Field offset: 0x70
	private bool isVisible; //Field offset: 0x78
	[CompilerGenerated]
	private CashRushData <cashRushData>k__BackingField; //Field offset: 0x7C

	public CashRushData cashRushData
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MainHudLeftAlign() { }

	private void AddListeners() { }

	private void Awake() { }

	[CompilerGenerated]
	public CashRushData get_cashRushData() { }

	[IteratorStateMachine(typeof(<Initialise>d__18))]
	public virtual IEnumerator Initialise() { }

	public void InitialiseCashRushMode(CashRushData data) { }

	public void OnCashButtonClicked() { }

	public void OnCashChanged() { }

	private void OnCashManagersChanged(Dictionary<Int32, CashManager> cashManagers) { }

	private void OnDestroy() { }

	private void OnEnterTowerPlacementMode() { }

	private void OnExitTowerPlacementMode() { }

	public void OnHealthButtonClicked() { }

	private void OnLivesDrained(int amount) { }

	public void OnRestart() { }

	private void OnThriveStatusChanged(bool enabled) { }

	private void OnToggleUiVisibility(bool visible) { }

	private void RefreshFXState(float scale) { }

	[CompilerGenerated]
	public void set_cashRushData(CashRushData value) { }

}

