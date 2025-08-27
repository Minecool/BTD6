namespace Assets.Scripts.Unity.UI_New;

public class MainHudRightAlign : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<AsyncOperationHandle`1<GameObject>> <>9__28_4; //Field offset: 0x8
		public static ReturnCallback <>9__40_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Initialise>b__28_4(AsyncOperationHandle<GameObject> asyncOpHandle) { }

		internal void <OpenArtifactsPopup>b__40_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public PropSpawningChallenge behavior; //Field offset: 0x10
		public MainHudRightAlign <>4__this; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal void <Initialise>b__6(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <Initialise>d__28 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MainHudRightAlign <>4__this; //Field offset: 0x20
		private bool <forceRogueUiOn>5__2; //Field offset: 0x28
		private SimulationBehavior[] <>7__wrap2; //Field offset: 0x30
		private int <>7__wrap3; //Field offset: 0x38

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
		public <Initialise>d__28(int <>1__state) { }

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

	public static MainHudRightAlign instance; //Field offset: 0x0
	public GameObject panel; //Field offset: 0x20
	public Animator panelAnimator; //Field offset: 0x28
	public Animator roundPanelAnimator; //Field offset: 0x30
	public Button roundButton; //Field offset: 0x38
	public GameObject roundObj; //Field offset: 0x40
	public PrefabReference racePrefab; //Field offset: 0x48
	public PrefabReference leastCashPrefab; //Field offset: 0x50
	public PrefabReference leastTiersPrefab; //Field offset: 0x58
	public PrefabReference collectionBar; //Field offset: 0x60
	public PrefabReference bossRushPrefab; //Field offset: 0x68
	public PrefabReference roguePrefab; //Field offset: 0x70
	public PrefabReference rogueLeastCashPrefab; //Field offset: 0x78
	public Transform extraUIAnchor; //Field offset: 0x80
	public Button artifactsBtn; //Field offset: 0x88
	public GameObject artifactsObj; //Field offset: 0x90
	public Button queuedBoostsBtn; //Field offset: 0x98
	public PauseButton pauseButton; //Field offset: 0xA0
	public Animator checkpointAnimator; //Field offset: 0xA8
	public Animator fastTrackAnimator; //Field offset: 0xB0
	private LeastCashUsedHud leastCashHud; //Field offset: 0xB8
	private LeastTiersUsedHud leastTiersHud; //Field offset: 0xC0
	private CollectionBarHud collectionBarHud; //Field offset: 0xC8
	private RaceUI raceUI; //Field offset: 0xD0
	private RogueHudUI rogueUI; //Field offset: 0xD8
	private RogueLeastCashHud leastCashHudRogue; //Field offset: 0xE0
	private bool visibilityDisabled; //Field offset: 0xE8

	public MainHudRightAlign() { }

	[CompilerGenerated]
	private void <Initialise>b__28_0(AsyncOperationHandle<GameObject> h) { }

	[CompilerGenerated]
	private void <Initialise>b__28_1(AsyncOperationHandle<GameObject> h) { }

	[CompilerGenerated]
	private void <Initialise>b__28_2(AsyncOperationHandle<GameObject> h) { }

	[CompilerGenerated]
	private void <Initialise>b__28_3(AsyncOperationHandle<GameObject> h) { }

	[CompilerGenerated]
	private void <Initialise>b__28_5(AsyncOperationHandle<GameObject> h) { }

	private void AddListeners() { }

	private void Awake() { }

	private void CheckpointCreated() { }

	[IteratorStateMachine(typeof(<Initialise>d__28))]
	public virtual IEnumerator Initialise() { }

	private void OnArtifactAdded() { }

	private void OnDestroy() { }

	private void OnEnterTowerPlacementMode() { }

	private void OnExitTowerPlacementMode() { }

	public virtual void OnGameStart() { }

	private void OnRestart() { }

	private void OnRogueBoostQueueChanged() { }

	public void OnRoundButtonClicked() { }

	private void OnRoundStarted(int round) { }

	private void OnToggleUiVisibility(bool visible) { }

	private void OpenArtifactsPopup() { }

	private void QueuedBoostsClicked() { }

}

