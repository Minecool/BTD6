namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyEventScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<OdysseyMapData, Boolean> <>9__137_0; //Field offset: 0x8
		public static Func<PowerData, String> <>9__193_0; //Field offset: 0x10
		public static Func<IGrouping`2<String, PowerData>, PowerData> <>9__193_1; //Field offset: 0x18
		public static Func<String, String> <>9__193_2; //Field offset: 0x20
		public static Func<PowerData, String> <>9__193_3; //Field offset: 0x28
		public static Func<String, PowerData, PowerData> <>9__193_4; //Field offset: 0x30
		public static Func<TowerData, String> <>9__194_0; //Field offset: 0x38
		public static Func<IGrouping`2<String, TowerData>, TowerData> <>9__194_1; //Field offset: 0x40
		public static Func<String, String> <>9__194_2; //Field offset: 0x48
		public static Func<TowerData, String> <>9__194_3; //Field offset: 0x50
		public static Func<String, TowerData, TowerData> <>9__194_4; //Field offset: 0x58

		private static <>c() { }

		public <>c() { }

		internal bool <CheckForInvalidSaveData>b__137_0(OdysseyMapData x) { }

		internal string <ValidatePowerSet>b__193_0(PowerData x) { }

		internal PowerData <ValidatePowerSet>b__193_1(IGrouping<String, PowerData> y) { }

		internal string <ValidatePowerSet>b__193_2(string x) { }

		internal string <ValidatePowerSet>b__193_3(PowerData y) { }

		internal PowerData <ValidatePowerSet>b__193_4(string x, PowerData y) { }

		internal string <ValidateTowerSet>b__194_0(TowerData x) { }

		internal TowerData <ValidateTowerSet>b__194_1(IGrouping<String, TowerData> y) { }

		internal string <ValidateTowerSet>b__194_2(string x) { }

		internal string <ValidateTowerSet>b__194_3(TowerData y) { }

		internal TowerData <ValidateTowerSet>b__194_4(string x, TowerData y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass193_0
	{
		public PowerModel powerModel; //Field offset: 0x10

		public <>c__DisplayClass193_0() { }

		internal bool <ValidatePowerSet>b__5(PowerData p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass194_0
	{
		public TowerDetailsModel towerDets; //Field offset: 0x10

		public <>c__DisplayClass194_0() { }

		internal bool <ValidateTowerSet>b__5(TowerData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass194_1
	{
		public TowerDetailsModel towerDets; //Field offset: 0x10

		public <>c__DisplayClass194_1() { }

		internal bool <ValidateTowerSet>b__6(TowerData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass197_0
	{
		public OdysseyEventScreen <>4__this; //Field offset: 0x10
		public int mapIndexSelected; //Field offset: 0x18

		public <>c__DisplayClass197_0() { }

		internal void <OnEditorPlayBtnClicked>b__0() { }

	}

	[CompilerGenerated]
	private struct <CheckOnlineThenStartNewGame>d__160 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public OdysseyEventScreen <>4__this; //Field offset: 0x28
		public int mapSaveId; //Field offset: 0x30
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HideMinCrewNeededPopup>d__155 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public OdysseyEventScreen <>4__this; //Field offset: 0x28
		private float <delay>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x34

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayVoyageAnimationToNextIsland>d__159 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public OdysseyEventScreen <>4__this; //Field offset: 0x28
		public int mapSaveId; //Field offset: 0x30
		private float <delay>5__2; //Field offset: 0x34
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public NK_TextMeshProUGUI txtOdysseyTitle; //Field offset: 0x48
	public NK_TextMeshProUGUI txtOdysseySubTitle; //Field offset: 0x50
	public GameObject objTimeRemaining; //Field offset: 0x58
	public NK_TextMeshProUGUI txtTimeRemaining; //Field offset: 0x60
	public NK_TextMeshProUGUI txtDifficulty; //Field offset: 0x68
	public Image imgDifficulty; //Field offset: 0x70
	public Image imgDifficultyEasy; //Field offset: 0x78
	public Image imgDifficultyMedium; //Field offset: 0x80
	public Image imgDifficultyHard; //Field offset: 0x88
	public GameObject objLivesPanel; //Field offset: 0x90
	public NK_TextMeshProUGUI txtLivesMessage; //Field offset: 0x98
	public NK_TextMeshProUGUI txtLives; //Field offset: 0xA0
	public NK_TextMeshProUGUI txtUserCreatedOdysseyLives; //Field offset: 0xA8
	public NK_TextMeshProUGUI txtEditorOdysseyLives; //Field offset: 0xB0
	public NK_TextMeshProUGUI txtEditorMapsLeft; //Field offset: 0xB8
	public LootPanel lootPanel; //Field offset: 0xC0
	public Button btnCrewDetails; //Field offset: 0xC8
	public Button btnIslandRules; //Field offset: 0xD0
	public Button btnDifficultyLeft; //Field offset: 0xD8
	public Button btnDifficultyRight; //Field offset: 0xE0
	public Button btnResetCurrentVoyageData; //Field offset: 0xE8
	public Button btnFirstTimeInfoPanel; //Field offset: 0xF0
	public Button btnExtendedLoot; //Field offset: 0xF8
	public Button btnOdysseyEditor; //Field offset: 0x100
	public GameObject crewDetailsHighlight; //Field offset: 0x108
	public GameObject islandRulesHighlight; //Field offset: 0x110
	public OdysseyCrewDetailsPanelPopup objCrewDetails; //Field offset: 0x118
	public OdysseyIslandInfoPanelPopup objIslandRules; //Field offset: 0x120
	public OdysseyCompletedPopup objCompletedOdyssey; //Field offset: 0x128
	public OdysseyBoatLoadoutPanel objBoatLoadout; //Field offset: 0x130
	public OdysseyBoatLoadoutEditor objBoatLoadoutEditor; //Field offset: 0x138
	public OdysseyIntroPanelPopup objIntroPanel; //Field offset: 0x140
	public OdysseyExtendedLootPanel objExtendedLootPanel; //Field offset: 0x148
	public GameObject objMinCrewNeeded; //Field offset: 0x150
	public GameObject objDifficultyPanel; //Field offset: 0x158
	public GameObject objDifficultyCompleteBottomBanner; //Field offset: 0x160
	public GameObject objDifficultyClaimedBottomBanner; //Field offset: 0x168
	public GameObject objEditorContainer; //Field offset: 0x170
	public GameObject objEditorUserDataContainer; //Field offset: 0x178
	public GameObject objEditorModeConstructionOverlayTop; //Field offset: 0x180
	public GameObject objEditorModeConstructionOverlayBottom; //Field offset: 0x188
	public GameObject objChallengeLivesContainer; //Field offset: 0x190
	public GameObject extremeOverlay; //Field offset: 0x198
	public GameObject extremeTopPanelCountRemaining; //Field offset: 0x1A0
	public GameObject extremeDifficultyOverlay; //Field offset: 0x1A8
	public NK_TextMeshProUGUI extremeTopPanelCountRemainingTxt; //Field offset: 0x1B0
	public Button btnPlay; //Field offset: 0x1B8
	public GameObject objPlayLock; //Field offset: 0x1C0
	public GameObject objLockedMessagePanel; //Field offset: 0x1C8
	public Material grayscaleMaterial; //Field offset: 0x1D0
	public AudioClip clickSound; //Field offset: 0x1D8
	public AudioClip popupSound; //Field offset: 0x1E0
	public AudioClip nextSound; //Field offset: 0x1E8
	public AudioClip returnSound; //Field offset: 0x1F0
	public AudioClip resetSound; //Field offset: 0x1F8
	public AudioClip chestSound; //Field offset: 0x200
	public AudioClip starSound; //Field offset: 0x208
	public AudioClip tickSound; //Field offset: 0x210
	public AudioClip selectSound; //Field offset: 0x218
	public AudioClip boatSound; //Field offset: 0x220
	public AudioClip collectLootSound; //Field offset: 0x228
	public GameObject objDebugMenu; //Field offset: 0x230
	public Button btnDebugClearSaveData; //Field offset: 0x238
	public Button btnDebugTestBoatAnimButton; //Field offset: 0x240
	public Button btnDebugTestIslandStatues; //Field offset: 0x248
	public Button btnDebugTestOdysseyVictory; //Field offset: 0x250
	public GameObject objDebugSelectMap; //Field offset: 0x258
	public PlayerContentInfoPanel playerContentInfoPanel; //Field offset: 0x260
	public AccoladesDisplayButton[] accoladesDisplays; //Field offset: 0x268
	private bool isValidatedTowerSet; //Field offset: 0x270
	private bool isValidatedPowerSet; //Field offset: 0x271
	private OdysseyShaderController odysseyShaderController; //Field offset: 0x278
	private List<GameObject> islandSlots; //Field offset: 0x280
	private List<Animator> islandStars; //Field offset: 0x288
	private List<GameObject> treasureChests; //Field offset: 0x290
	public List<Animator> islandSelectedAnimators; //Field offset: 0x298
	private Animator odysseyWorldAnimator; //Field offset: 0x2A0
	private Animator odysseyBoatAnimator; //Field offset: 0x2A8
	private Animator odysseyMonkeyAnimator; //Field offset: 0x2B0
	private bool isDisplayingCrewDetails; //Field offset: 0x2B8
	private bool isDisplayingIslandRules; //Field offset: 0x2B9
	private int difficultyArrowSelected; //Field offset: 0x2BC
	private bool isBackButtonDisabled; //Field offset: 0x2C0
	[CompilerGenerated]
	private ChallengeType <ChallengeType>k__BackingField; //Field offset: 0x2C4
	private OdysseyEvent odysseyEvent; //Field offset: 0x2C8
	[CompilerGenerated]
	private OdysseyData <OdysseyData>k__BackingField; //Field offset: 0x2D0
	private OdysseyWorldMenu odysseyWorldMenu; //Field offset: 0x2D8
	public OdysseyContentData odysseyContentData; //Field offset: 0x2E0
	private OdysseySaveData _saveData; //Field offset: 0x2E8
	[CompilerGenerated]
	private string <OdysseyId>k__BackingField; //Field offset: 0x2F0

	public EmbarkedActiveOdyssey ActiveOdysseySaveData
	{
		 get { } //Length: 30
	}

	public private ChallengeType ChallengeType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public DailyChallengeModel DCM
	{
		 get { } //Length: 250
	}

	public Rules DifficultyRules
	{
		 get { } //Length: 104
	}

	public OdysseyDifficultySaveData DifficultySaveData
	{
		 get { } //Length: 92
	}

	public OdysseyDifficulty DifficultySet
	{
		 get { } //Length: 38
	}

	public bool ExtremeMode
	{
		 get { } //Length: 114
	}

	public bool IsEditorMode
	{
		 get { } //Length: 11
	}

	public float LivesRemaining
	{
		 get { } //Length: 91
	}

	public NK_TextMeshProUGUI LivesText
	{
		 get { } //Length: 127
	}

	public private OdysseyData OdysseyData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string OdysseyId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool OdysseyVoyageStarted
	{
		 get { } //Length: 44
	}

	public OdysseyWorldMenu OdysseyWorldMenu
	{
		 get { } //Length: 8
	}

	private ProfileModel PlayerData
	{
		private get { } //Length: 68
	}

	public OdysseySaveData SaveData
	{
		 get { } //Length: 8
	}

	public OdysseyEventScreen() { }

	[CompilerGenerated]
	private void <Open>b__125_0() { }

	public bool AreAllHerosEnabled() { }

	private void CheckForInvalidSaveData() { }

	private void CheckForOdysseyCompleted() { }

	[AsyncStateMachine(typeof(<CheckOnlineThenStartNewGame>d__160))]
	private void CheckOnlineThenStartNewGame(int mapSaveId = -1) { }

	private void ClaimLootSetTrophies() { }

	public OdysseyData CloneOdysseyData(OdysseyData dataToClone) { }

	private void CompletedOdysseyForFirstTime() { }

	private void CompletedReplayOfOdyssey() { }

	private void ConfirmClearCurrentVoyageSaveData() { }

	public void ConfirmReplayMap(int mapIndex) { }

	public void DisplayMinCrewNeededMessage() { }

	public EmbarkedActiveOdyssey get_ActiveOdysseySaveData() { }

	[CompilerGenerated]
	public ChallengeType get_ChallengeType() { }

	public DailyChallengeModel get_DCM() { }

	public Rules get_DifficultyRules() { }

	public OdysseyDifficultySaveData get_DifficultySaveData() { }

	public OdysseyDifficulty get_DifficultySet() { }

	public bool get_ExtremeMode() { }

	public bool get_IsEditorMode() { }

	public float get_LivesRemaining() { }

	public NK_TextMeshProUGUI get_LivesText() { }

	[CompilerGenerated]
	public OdysseyData get_OdysseyData() { }

	[CompilerGenerated]
	public string get_OdysseyId() { }

	public bool get_OdysseyVoyageStarted() { }

	public OdysseyWorldMenu get_OdysseyWorldMenu() { }

	private ProfileModel get_PlayerData() { }

	public OdysseySaveData get_SaveData() { }

	public List<TowerData> GetAllAvailableTowers() { }

	public List<TowerData> GetAvailableHeros() { }

	public List<PowerData> GetAvailablePowers() { }

	public List<TowerData> GetAvailableTowersNonHero() { }

	private int GetChosenDifficulty(Dictionary<OdysseyDifficulty, Rules> rules) { }

	private Sprite GetDifficultyIcon() { }

	private LootSet GetLootSet() { }

	public int GetMapSaveId() { }

	public string GetOdysseyDescription() { }

	public string GetOdysseyTitle() { }

	private int GetPendingTrophies(OdysseyDifficulty currentDifficulty) { }

	public PowerData GetPowerData(string powerId) { }

	public PowerData GetPowerDataFromDifficulty(string powerId, OdysseyDifficulty difficulty) { }

	public int GetPowerUseHistoryCount(string powerId, int max) { }

	public int GetRemainingTowerCountMinusHeroPlacements(out int maxTowerCount) { }

	private OdysseySaveData GetSaveData(string odysseyId) { }

	public TowerData GetTowerData(string towerId) { }

	public TowerData GetTowerDataFromDifficulty(string towerId, OdysseyDifficulty difficulty) { }

	public int GetTowerUseHistoryCount(string towerId, bool isHero, int max) { }

	private LootSet GetTrophiesAndMm(LootSet lootSet) { }

	public bool HasCompletedAllMapsForDifficulty() { }

	public bool HasCompletedDifficulty() { }

	[AsyncStateMachine(typeof(<HideMinCrewNeededPopup>d__155))]
	private void HideMinCrewNeededPopup() { }

	public bool IsMapCompletedForCurrentDifficulty(int mapIndex) { }

	private void LoadWorld() { }

	public void OnBoatClickedByGestureSystem() { }

	private void OnClearCurrentVoyageSaveData() { }

	private void OnClickDifficultyChanged(int changedValue) { }

	public void OnClickDifficultyLeft() { }

	public void OnClickDifficultyRight() { }

	public void OnCrewDetailsClicked() { }

	public void OnEditorEditBtnClicked(int mapIndexSelected) { }

	public void OnEditorPlayBtnClicked(int mapIndexSelected) { }

	public void OnEnvironmentClickedByGestureSystem(int environmentSelcted) { }

	public void OnExtendedLootClicked() { }

	public void OnInfoButtonDown() { }

	public void OnIslandClickedByGestureSystem(int islandSelected) { }

	public void OnIslandRulesClicked() { }

	public void OnPlayBtnDown() { }

	public void OnResetBoatLoadout() { }

	public void OnResetPowersLoadout() { }

	public void OnResetTowersLoadout() { }

	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	[AsyncStateMachine(typeof(<PlayVoyageAnimationToNextIsland>d__159))]
	private void PlayVoyageAnimationToNextIsland(int mapSaveId = -1) { }

	public void PopupClosed() { }

	private void ResetSaveDataOnDifficultyChanged(OdysseyDifficulty odysseyDifficulty = 0) { }

	[CompilerGenerated]
	private void set_ChallengeType(ChallengeType value) { }

	[CompilerGenerated]
	private void set_OdysseyData(OdysseyData value) { }

	[CompilerGenerated]
	private void set_OdysseyId(string value) { }

	private void SetCameraToBoatLocation() { }

	private void SetOdysseyBoatState() { }

	private void SetRichPresence() { }

	private void SetupEditorSaveData() { }

	private void SetupNormalSaveData() { }

	private void SetupUserCreatedModeUI() { }

	private void ShowIslandRules(int islandSelected = -1) { }

	private void StartGamePreChecks(int mapSaveId = -1) { }

	private void StartReplayOfOdyssey() { }

	public void Update() { }

	public void UpdateChallengePanel() { }

	private void UpdateIslands(bool skipAnimationTransitions = false) { }

	public void UpdateSelectedIslandAnimations(int islandSelected) { }

	public void UpdateUi(bool skipAnimationTransitions = false) { }

	private void ValidatePowerSet() { }

	private void ValidateTowerSet() { }

}

