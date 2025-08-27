namespace Assets.Scripts.Unity.UI_New.Tutorial;

public class InGameTutorial : RatioObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__41_1; //Field offset: 0x8
		public static ReturnCallback <>9__56_0; //Field offset: 0x10
		public static Action <>9__57_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <CheckLoseLevel>b__57_0() { }

		internal void <Round10Over>b__56_0() { }

		internal void <ShowUpgradeScreenPopup>b__41_1() { }

	}

	[CompilerGenerated]
	private sealed class <Delay>d__27 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float secs; //Field offset: 0x20
		public Action action; //Field offset: 0x28

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
		public <Delay>d__27(int <>1__state) { }

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

	public GameObject monkeyArrow; //Field offset: 0x20
	public GameObject heroArrow; //Field offset: 0x28
	public GameObject placementCircle; //Field offset: 0x30
	public GameObject placementAnimationStart; //Field offset: 0x38
	public GameObject placementAnimationEnd; //Field offset: 0x40
	public GameObject monkeySelectAnimation; //Field offset: 0x48
	public GameObject monkeySelectAnimation3D; //Field offset: 0x50
	public GameObject upgradeMonkeyAnimation; //Field offset: 0x58
	public AudioClip victorySound; //Field offset: 0x60
	private GameObject goAnimation; //Field offset: 0x68
	private Button upgradesButton; //Field offset: 0x70
	public GameObject[] upgradeArrows; //Field offset: 0x78
	public bool debugSkipTutorial; //Field offset: 0x80
	public bool placedFirstTower; //Field offset: 0x81
	private int pathPurchased; //Field offset: 0x84
	private Vector2 firstTowerPos; //Field offset: 0x88
	private BlockerZone blockerZone; //Field offset: 0x90
	private int towersCreated; //Field offset: 0x98
	private Action OnClickEvent; //Field offset: 0xA0
	private GameObject shopPanelTowerGlow; //Field offset: 0xA8
	private GameObject upgradeButtonGlow; //Field offset: 0xB0
	private bool upgradesScreenOpened; //Field offset: 0xB8
	private bool purchasedUpgrade; //Field offset: 0xB9
	private bool upgradesMenuClosed; //Field offset: 0xBA
	private bool towerUpgraded; //Field offset: 0xBB

	public InGameTutorial() { }

	[CompilerGenerated]
	private void <Round2Over>b__35_0() { }

	[CompilerGenerated]
	private void <Round3Over>b__51_0() { }

	[CompilerGenerated]
	private void <ShowUpgradeScreenPopup>b__41_0() { }

	public void AutoCloseUpgradeScreenAndSelectMonkey() { }

	private void CheckLoseLevel() { }

	private void CreateUpgradeGlow() { }

	[IteratorStateMachine(typeof(<Delay>d__27))]
	private IEnumerator Delay(float secs, Action action) { }

	private void HeroInfo() { }

	private void InstantiateTowerTowerObject(Transform parent) { }

	private void Intro() { }

	private void OnDestroy() { }

	private void OnPlacedFirstTower(TowerToSimulation tower) { }

	private void OnPlacedSecondTower(TowerToSimulation tower) { }

	private void OnPurchasedUpgrade(UpgradeModel upgradeModel) { }

	private void OnRoundOver(int round) { }

	private void OnRoundStart(int round) { }

	private void OnSelectionChanged(Selectable s) { }

	private void OnTowerCreated(TowerToSimulation tower) { }

	private void OnTowerUpgraded(TowerToSimulation tower) { }

	public void OnUpgradesMenuClosed() { }

	private void PlacedQuincy() { }

	private void PlaceFirstTower() { }

	private void PlaceSecondTower() { }

	private void PlayVictorySound() { }

	public virtual void PostInitialised() { }

	private void Round10Over() { }

	private void Round1Over() { }

	private void Round2Over() { }

	private void Round3Over() { }

	private void Round9Over() { }

	private void SelectMonkey() { }

	private void ShowHowToOpenUpgradesMenu() { }

	private void ShowUpgrades() { }

	private void ShowUpgradeScreenPopup() { }

	private void StepComplete(int step) { }

	private void Update() { }

	private void WaitForHeroPurchased() { }

}

