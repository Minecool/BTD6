namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeEditor : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SpecialCondition, String> <>9__67_0; //Field offset: 0x8
		public static Func<TowerData, Boolean> <>9__67_1; //Field offset: 0x10
		public static Func<TowerData, Boolean> <>9__67_2; //Field offset: 0x18
		public static Func<MapDetails, String> <>9__93_0; //Field offset: 0x20
		public static Func<String, Boolean> <>9__93_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <Randomize>b__93_0(MapDetails map) { }

		internal bool <Randomize>b__93_1(string mapId) { }

		internal string <SetupUI>b__67_0(SpecialCondition x) { }

		internal bool <SetupUI>b__67_1(TowerData t) { }

		internal bool <SetupUI>b__67_2(TowerData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public string str; //Field offset: 0x10

		public <>c__DisplayClass71_0() { }

		internal Task<Boolean> <ContainsProfanity>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass99_0
	{
		public DCModTowerDisplay dcTowerDis; //Field offset: 0x10
		public ChallengeEditor <>4__this; //Field offset: 0x18

		public <>c__DisplayClass99_0() { }

		internal void <TowerSelectClicked>b__0() { }

	}

	[CompilerGenerated]
	private struct <UpdateChallengeTextAsync>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ChallengeEditor <>4__this; //Field offset: 0x28
		public string userInput; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button clearBtn; //Field offset: 0x48
	public Button randomBtn; //Field offset: 0x50
	public Button undoBtn; //Field offset: 0x58
	public MapSelectPanel mapSelectPanel; //Field offset: 0x60
	public Button mapBtn; //Field offset: 0x68
	public Image mapImage; //Field offset: 0x70
	public TMP_Text mapName; //Field offset: 0x78
	public Material grayscaleMaterial; //Field offset: 0x80
	public NK_TextMeshProInputField chalName; //Field offset: 0x88
	public TMP_Dropdown difficulty; //Field offset: 0x90
	public TMP_InputField cash; //Field offset: 0x98
	public TMP_InputField lives; //Field offset: 0xA0
	public TMP_InputField maxLives; //Field offset: 0xA8
	public TMP_InputField round; //Field offset: 0xB0
	public TMP_InputField endRound; //Field offset: 0xB8
	public TMP_Dropdown specialCondition; //Field offset: 0xC0
	public GameObject specialConditionInputGroup; //Field offset: 0xC8
	public Toggle specialConditionAutoset; //Field offset: 0xD0
	public TMP_InputField specialConditionInput; //Field offset: 0xD8
	public TMP_Dropdown gameModeDropdown; //Field offset: 0xE0
	public Button towerBtn; //Field offset: 0xE8
	public Button towerRestrictionBtn; //Field offset: 0xF0
	public Lightbox towerRestrictionBackBtn; //Field offset: 0xF8
	public GameObject towerRestrictionMenu; //Field offset: 0x100
	public GameObject towerDisplayPrefab; //Field offset: 0x108
	public GameObject selectedHeroDisplayPrefab; //Field offset: 0x110
	public Transform towerContainer; //Field offset: 0x118
	public TMP_Text maxTowerTxt; //Field offset: 0x120
	public GameObject maxTowersObject; //Field offset: 0x128
	public GameObject towerSelectObject; //Field offset: 0x130
	private bool towerSelectInit; //Field offset: 0x138
	public TMP_InputField maxTowers; //Field offset: 0x140
	public Transform excludedTowers; //Field offset: 0x148
	public Transform includedTowers; //Field offset: 0x150
	public Transform excludedTowerSlots; //Field offset: 0x158
	public Transform includedTowerSlots; //Field offset: 0x160
	public Lightbox towerSelectBGBackBtn; //Field offset: 0x168
	public ChallengeEditorSliderSettings sliderSettings; //Field offset: 0x170
	public ChallengeEditorModifierSettings modifierSettings; //Field offset: 0x178
	public DailyChallengeModel dcm; //Field offset: 0x180
	public DailyChallengeModel originalDcm; //Field offset: 0x188
	protected List<String> difficulties; //Field offset: 0x190
	protected List<String> difficultiesLocs; //Field offset: 0x198
	protected List<String> gameModes; //Field offset: 0x1A0
	protected List<String> gameModesLocs; //Field offset: 0x1A8
	protected Restrictions settingsRestrictions; //Field offset: 0x1B0
	protected RandomGenerator rng; //Field offset: 0x1B8
	public GameObject debugMenu; //Field offset: 0x1C0
	public TMP_InputField importTxt; //Field offset: 0x1C8
	public Button importBtn; //Field offset: 0x1D0
	public Button exportBtn; //Field offset: 0x1D8
	public Toggle instaRewardToggle; //Field offset: 0x1E0
	public Toggle displayExcludedTowersToggle; //Field offset: 0x1E8
	public TMP_InputField rewards; //Field offset: 0x1F0
	public GamepadContext gamepadContext; //Field offset: 0x1F8
	public GamepadContext mapGamepadContext; //Field offset: 0x200
	public GamepadContext towerSelectGamepadContext; //Field offset: 0x208
	public Button resetJewelBarBtn; //Field offset: 0x210
	public Button incJewelBarBtn; //Field offset: 0x218
	public Button decJewelBarBtn; //Field offset: 0x220
	public Button toggleAddRemoveBtn; //Field offset: 0x228
	public Button towerIncBtn; //Field offset: 0x230
	public Button towerDecBtn; //Field offset: 0x238
	public Button maxTowersBtn; //Field offset: 0x240
	protected List<SliderConfig> sliderConfigs; //Field offset: 0x248
	private List<DCModTowerDisplay> allTowerDisplays; //Field offset: 0x250
	private DCModTowerDisplay[] orderList; //Field offset: 0x258

	public ChallengeEditor() { }

	[CompilerGenerated]
	private void <GamepadInit>b__108_0(GameObject x) { }

	[CompilerGenerated]
	private void <GamepadInit>b__108_1() { }

	[CompilerGenerated]
	private void <GamepadInit>b__108_2() { }

	[CompilerGenerated]
	private void <GamepadInit>b__108_3() { }

	protected void AddListeners() { }

	private void AddRemoveTower(DCModTowerDisplay dcTowerDisp) { }

	protected override void ApplyDcmSettingsToUI() { }

	public override void ApplyUiSettingsToDCM() { }

	protected override void Clear() { }

	private void ClearOrderArray() { }

	private void CloseMapSelect() { }

	private void CloseTowerSelect() { }

	private bool ContainsProfanity(string str) { }

	private void DecJewelBarClicked() { }

	public void DisplayTowers() { }

	private void GamepadInit() { }

	private void GamepadSelectFirst() { }

	private SliderConfig GetSliderConfig() { }

	protected string GetSpecialConditionDisplayString(int value, bool isAutoSet) { }

	private void IncJewelBarClicked() { }

	protected override bool IsSpecialConditionAutosetOn() { }

	protected void MapSelectClicked() { }

	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	protected int ParseValue(string v, int defaultValue = -1) { }

	protected void Randomize() { }

	private void RecieveMapInfo(string mapID) { }

	private void ResetJewelBarClicked() { }

	protected bool SelectedSpecialConditionIs(SpecialConditionType type) { }

	protected override void SetCash(string val) { }

	protected override void SetEndRound(string val) { }

	protected void SetLives(string val) { }

	public void SetMap() { }

	protected void SetMaxLives(string val) { }

	protected void SetMaxTowers(string val) { }

	protected override void SetRound(string val) { }

	protected void SetSpecialCondition(int index) { }

	protected void SetSpecialConditionAutoset(bool val) { }

	protected override void SetSpecialConditionAutosetOn(bool isOn) { }

	protected void SetSpecialConditionValue(string val) { }

	private void SetTowerSelectNav() { }

	protected void SetupSliderValues() { }

	private void SetupUI() { }

	private void ShowProfanityPopUp() { }

	private void SortTowersInOrder() { }

	private void TowerRestrictionBackClicked() { }

	private void TowerRestrictionClicked() { }

	private void TowerSelectClicked() { }

	private bool TryGetSelectedDCModTowerDisplay(out DCModTowerDisplay comp) { }

	private void Undo() { }

	[AsyncStateMachine(typeof(<UpdateChallengeTextAsync>d__76))]
	private void UpdateChallengeTextAsync(string userInput) { }

	protected override void UpdateInputFieldVisuals() { }

	protected override void ValidateInputFields() { }

}

