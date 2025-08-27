namespace Assets.Scripts.Unity.UI_New.HeroInGame;

public class HeroInGameScreen : GameMenu
{
	[CompilerGenerated]
	private struct <SetHeroFontMaterial>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HeroInGameScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartBackgroundColourSwap>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SkinData skinData; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public NK_TextMeshProUGUI heroName; //Field offset: 0x48
	public NK_TextMeshProUGUI heroShortDescription; //Field offset: 0x50
	public NK_TextMeshProUGUI heroDescription; //Field offset: 0x58
	public NK_TextMeshProUGUI heroBoosterCostTxt; //Field offset: 0x60
	public NK_TextMeshProUGUI heroBoosterCaveatTxt; //Field offset: 0x68
	public NK_TextMeshProUGUI ingameLevel; //Field offset: 0x70
	public NK_TextMeshProUGUI ingameLevelOnBarTxt; //Field offset: 0x78
	public Image heroPortrait; //Field offset: 0x80
	public GameObject xpBar; //Field offset: 0x88
	public Image xpBarImg; //Field offset: 0x90
	public Button heroBoosterButton; //Field offset: 0x98
	public GameObject unlockHeroPanel; //Field offset: 0xA0
	public Button btnUnlockHero; //Field offset: 0xA8
	public NK_TextMeshProUGUI unlockHeroCost; //Field offset: 0xB0
	private HeroUpgradeButton[] heroUpgrades; //Field offset: 0xB8
	private string heroId; //Field offset: 0xC0
	private TowerToSimulation selectedHero; //Field offset: 0xC8
	private int selectedUpgradeIndex; //Field offset: 0xD0
	private int heroBoosterMMCost; //Field offset: 0xD4
	private SkinData skinData; //Field offset: 0xD8

	private LocalizationManager locManager
	{
		private get { } //Length: 48
	}

	public HeroInGameScreen() { }

	[CompilerGenerated]
	private bool <CanPurchaseHero>b__27_0(HeroDetailsModel x) { }

	protected virtual void Awake() { }

	private bool CanPurchaseHero() { }

	private LocalizationManager get_locManager() { }

	public void OnHeroBoosterButtonClicked() { }

	public void OnUseHeroBooster() { }

	public void OnUseHeroBoosterCancel() { }

	private void OnUseHeroBoosterSuccess(bool success) { }

	public virtual void Open(object data) { }

	private void PurchaseHero() { }

	[AsyncStateMachine(typeof(<SetHeroFontMaterial>d__30))]
	private Task SetHeroFontMaterial() { }

	private void ShowUnlockHeroButton() { }

	[AsyncStateMachine(typeof(<StartBackgroundColourSwap>d__24))]
	private void StartBackgroundColourSwap(SkinData skinData) { }

	private void UpdateDisplay(int levelOverride = 0) { }

	public void UpdateSelectedUpgrade(HeroUpgradeButton upgradeSelected) { }

	public void UpdateXpBar(TowerToSimulation tower, int levelOverride = 0) { }

}

