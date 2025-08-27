namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyEditor : GameMenu
{
	[CompilerGenerated]
	private struct <<InitializeUi>b__109_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public OdysseyEditor <>4__this; //Field offset: 0x28
		public string userInput; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<InitializeUi>b__109_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public OdysseyEditor <>4__this; //Field offset: 0x28
		public string userInput; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<OdysseyDifficulty, Rules>, Boolean> <>9__74_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<OdysseyDifficulty, Rules>, Boolean> <>9__201_0; //Field offset: 0x10
		public static Func<DailyChallengeModel, Int32> <>9__201_2; //Field offset: 0x18
		public static Func<DailyChallengeModel, Int32> <>9__201_3; //Field offset: 0x20
		public static Func<MapDetails, String> <>9__203_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <ConfirmedSetupOrResetDefaultOdyssey>b__203_0(MapDetails x) { }

		internal bool <get_DifficultySelected>b__74_0(KeyValuePair<OdysseyDifficulty, Rules> x) { }

		internal bool <ShareOdysseyConfirmed>b__201_0(KeyValuePair<OdysseyDifficulty, Rules> x) { }

		internal int <ShareOdysseyConfirmed>b__201_2(DailyChallengeModel x) { }

		internal int <ShareOdysseyConfirmed>b__201_3(DailyChallengeModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass155_0
	{
		public OdysseyEditorMap component; //Field offset: 0x10
		public OdysseyEditor <>4__this; //Field offset: 0x18

		public <>c__DisplayClass155_0() { }

		internal void <PopulateMaps>b__0() { }

		internal void <PopulateMaps>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass161_0
	{
		public OdysseyEditor <>4__this; //Field offset: 0x10
		public string map; //Field offset: 0x18

		public <>c__DisplayClass161_0() { }

		internal void <MapChangedRequest>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass181_0
	{
		public DCModTowerDisplay dcd; //Field offset: 0x10
		public OdysseyEditor <>4__this; //Field offset: 0x18

		public <>c__DisplayClass181_0() { }

		internal void <ShowTowerSelect>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass183_0
	{
		public DCModPowerDisplay dpd; //Field offset: 0x10
		public OdysseyEditor <>4__this; //Field offset: 0x18

		public <>c__DisplayClass183_0() { }

		internal void <ShowPowerSelect>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass198_0
	{
		public string str; //Field offset: 0x10

		public <>c__DisplayClass198_0() { }

		internal Task<Boolean> <ContainsProfanity>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass208_0
	{
		public RectTransform parentRT; //Field offset: 0x10
		public OdysseyEditor <>4__this; //Field offset: 0x18
		public Vector2 origScrollRectPlusMaskOffsetMin; //Field offset: 0x20
		public Vector2 origParentRTOffsetMin; //Field offset: 0x28

		public <>c__DisplayClass208_0() { }

		internal void <GamepadSetup>b__0(InputSystemMode x) { }

		internal void <GamepadSetup>b__1(GameObject x) { }

		internal void <GamepadSetup>b__2() { }

		internal void <GamepadSetup>b__3() { }

		internal void <GamepadSetup>b__4() { }

	}

	[CompilerGenerated]
	private struct <ShareOdysseyConfirmed>d__201 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public OdysseyEditor <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateInput>d__151 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public NK_TextMeshProInputField inputField; //Field offset: 0x20
		public string userInput; //Field offset: 0x28
		public OdysseyEditor <>4__this; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum DataType
	{
		SetExtreme = 0,
		SetLives = 1,
		SetTowerSlots = 2,
		SetPowerSlots = 3,
		SetTowerMax = 4,
		SetPowerMax = 5,
	}

	public NK_TextMeshProInputField odysseyName; //Field offset: 0x48
	public NK_TextMeshProInputField odysseyDescription; //Field offset: 0x50
	public TMP_InputField odysseyId; //Field offset: 0x58
	public TMP_Dropdown odysseyLocsKey; //Field offset: 0x60
	public TMP_Dropdown odysseyDifficultySelect; //Field offset: 0x68
	public TMP_InputField rewardsTrophiesEasy; //Field offset: 0x70
	public TMP_InputField rewardsTrophiesMedium; //Field offset: 0x78
	public TMP_InputField rewardsTrophiesHard; //Field offset: 0x80
	public TMP_InputField rewardsMmEasy; //Field offset: 0x88
	public TMP_InputField rewardsMmMedium; //Field offset: 0x90
	public TMP_InputField rewardsMmHard; //Field offset: 0x98
	public TMP_Dropdown rewardsEasyType; //Field offset: 0xA0
	public TMP_Dropdown rewardsEasyPathTypes; //Field offset: 0xA8
	public GameObject rewardsEasyBlocker; //Field offset: 0xB0
	public GameObject rewardsEasyPowersIcon; //Field offset: 0xB8
	public GameObject rewardsEasyInstasIcon; //Field offset: 0xC0
	public TMP_Dropdown rewardsMedType; //Field offset: 0xC8
	public TMP_Dropdown rewardsMedPathTypes; //Field offset: 0xD0
	public GameObject rewardsMedBlocker; //Field offset: 0xD8
	public GameObject rewardsMedPowersIcon; //Field offset: 0xE0
	public GameObject rewardsMedInstasIcon; //Field offset: 0xE8
	public TMP_Dropdown rewardsHardType; //Field offset: 0xF0
	public TMP_Dropdown rewardsHardPathTypes; //Field offset: 0xF8
	public GameObject rewardsHardBlocker; //Field offset: 0x100
	public GameObject rewardsHardPowersIcon; //Field offset: 0x108
	public GameObject rewardsHardInstasIcon; //Field offset: 0x110
	public Button resetBtn; //Field offset: 0x118
	public Button playBtn; //Field offset: 0x120
	public Button shareBtn; //Field offset: 0x128
	public Button shareBoatLoadoutScreenBtn; //Field offset: 0x130
	public Toggle DEBUGIgnoreCompletionCheck; //Field offset: 0x138
	public GameObject shareLockObj; //Field offset: 0x140
	public GameObject shareLockInfoPopupObj; //Field offset: 0x148
	public NK_TextMeshProUGUI shareLockInfoPopupTxt; //Field offset: 0x150
	public TMP_InputField lives; //Field offset: 0x158
	public Toggle extremeModeTgl; //Field offset: 0x160
	public GameObject boatLoadoutPanel; //Field offset: 0x168
	public GameObject contentMaps; //Field offset: 0x170
	public GameObject prefabMapObj; //Field offset: 0x178
	public GameObject challengeEditorObj; //Field offset: 0x180
	public OdysseyChallengeEditor challengeEditor; //Field offset: 0x188
	public TMP_InputField maxTowerSlots; //Field offset: 0x190
	public TMP_InputField maxPowerSlots; //Field offset: 0x198
	public TMP_InputField maxBoatTowers; //Field offset: 0x1A0
	public TMP_InputField maxBoatPowers; //Field offset: 0x1A8
	public GameObject prefabPowersObj; //Field offset: 0x1B0
	public GameObject prefabTowerObj; //Field offset: 0x1B8
	public GameObject prefabHeroObj; //Field offset: 0x1C0
	public Transform powersContainer; //Field offset: 0x1C8
	public Transform towersContainer; //Field offset: 0x1D0
	public Button addMonkeyButton; //Field offset: 0x1D8
	public Button addPowersButton; //Field offset: 0x1E0
	public MapSelectPanel mapSelectPanel; //Field offset: 0x1E8
	public Material grayscaleMaterial; //Field offset: 0x1F0
	public TMP_InputField maxObjects; //Field offset: 0x1F8
	public Transform excludedObjects; //Field offset: 0x200
	public Transform includedObjects; //Field offset: 0x208
	public Transform excludedObjectsSlots; //Field offset: 0x210
	public Transform includedObjectsSlots; //Field offset: 0x218
	public NK_TextMeshProUGUI excludedTitleTxt; //Field offset: 0x220
	public NK_TextMeshProUGUI includedTitleTxt; //Field offset: 0x228
	public GameObject listSelectObject; //Field offset: 0x230
	public Lightbox towerSelectBGBackBtn; //Field offset: 0x238
	public Button towerRestrictionBtn; //Field offset: 0x240
	public GameObject towerRestrictionMenu; //Field offset: 0x248
	private OdysseyBoatLoadoutEditor boatLoadout; //Field offset: 0x250
	private bool sharingInProgress; //Field offset: 0x258
	private bool towersSelectedClicked; //Field offset: 0x259
	private bool powersSelectedClicked; //Field offset: 0x25A
	private ChallengeType odysseyDataType; //Field offset: 0x25C
	private Nullable<OdysseyDifficulty> difficultySelected; //Field offset: 0x260
	private readonly List<String> rewardTypes; //Field offset: 0x268
	private readonly List<String> rewardTypesLocs; //Field offset: 0x270
	private readonly List<String> instaTowerPathTypes; //Field offset: 0x278
	private readonly String[] difficultiesLocs; //Field offset: 0x280
	private List<DCModTowerDisplay> allTowerDisplays; //Field offset: 0x288
	private List<DCModPowerDisplay> allPowerDisplays; //Field offset: 0x290
	private readonly List<OdysseyEditorMap> dcmMapEditors; //Field offset: 0x298
	public TMP_InputField importTxt; //Field offset: 0x2A0
	public Button importBtn; //Field offset: 0x2A8
	public Button exportBtn; //Field offset: 0x2B0
	private object storedData; //Field offset: 0x2B8
	private DataType storedDataType; //Field offset: 0x2C0
	private OdysseyContentData odysseyContentData; //Field offset: 0x2C8
	private bool sharingAllowed; //Field offset: 0x2D0
	public GamepadContext gamepadContext; //Field offset: 0x2D8
	public GamepadContext mapGamepadContext; //Field offset: 0x2E0
	public GamepadContext towerSelectGamepadContext; //Field offset: 0x2E8
	public Button toggleAddRemoveBtn; //Field offset: 0x2F0
	public Button towerIncBtn; //Field offset: 0x2F8
	public Button towerDecBtn; //Field offset: 0x300
	public RectTransform scrollRectPlusMask; //Field offset: 0x308

	public OdysseyDifficulty DifficultySelected
	{
		 get { } //Length: 679
	}

	private OdysseyData EmbarkedOdysseyEditorDcm
	{
		private get { } //Length: 81
		private set { } //Length: 87
	}

	private OdysseyData OdysseyEditorDcm
	{
		private get { } //Length: 81
		private set { } //Length: 87
	}

	public Rules OdysseyEditorDifficultyRules
	{
		 get { } //Length: 165
	}

	private ProfileModel PlayerData
	{
		private get { } //Length: 68
	}

	public OdysseySaveData SaveData
	{
		 get { } //Length: 81
		 set { } //Length: 87
	}

	public bool SharingInProgress
	{
		 get { } //Length: 8
	}

	public OdysseyEditor() { }

	[CompilerGenerated]
	private void <AddValueChangedListeners>b__112_0(string x) { }

	[CompilerGenerated]
	private void <AddValueChangedListeners>b__112_1(bool x) { }

	[CompilerGenerated]
	private void <AddValueChangedListeners>b__112_2(string x) { }

	[CompilerGenerated]
	private void <AddValueChangedListeners>b__112_3(string x) { }

	[CompilerGenerated]
	private void <AddValueChangedListeners>b__112_4(string x) { }

	[CompilerGenerated]
	private void <AddValueChangedListeners>b__112_5(string x) { }

	[CompilerGenerated]
	private void <AddValueChangedListeners>b__112_6(int val) { }

	[CompilerGenerated]
	private void <DifficultyChangedClicked>b__163_0() { }

	[CompilerGenerated]
	private void <DifficultyChangedClicked>b__163_1() { }

	[AsyncStateMachine(typeof(<<InitializeUi>b__109_0>d))]
	[CompilerGenerated]
	private void <InitializeUi>b__109_0(string userInput) { }

	[AsyncStateMachine(typeof(<<InitializeUi>b__109_1>d))]
	[CompilerGenerated]
	private void <InitializeUi>b__109_1(string userInput) { }

	[CompilerGenerated]
	private void <OverritePopupMessage>b__119_0() { }

	[CompilerGenerated]
	private void <OverritePopupMessage>b__119_1() { }

	[CompilerGenerated]
	private void <ResetExtremeMode>b__128_0(bool x) { }

	[CompilerGenerated]
	private void <SetupOrResetDefaultOdyssey>b__202_0() { }

	[CompilerGenerated]
	private void <ShareOdysseyConfirmed>b__201_1(RequestResult result, string challengeId, Exception exception) { }

	[CompilerGenerated]
	private void <TowerRestrictionClicked>b__194_0() { }

	[CompilerGenerated]
	private void <TowerSelectClicked>b__180_0() { }

	private void AddRemovePower(DCModPowerDisplay dcPowerDisp) { }

	private void AddRemoveTower(DCModTowerDisplay dcTowerDisp) { }

	public void AddValueChangedListeners() { }

	private void ChangeDifficulty(OdysseyDifficulty difficultySelected, bool clearSave = true) { }

	public void CheckForOverwrittenBoatLoadout() { }

	private bool CheckForResetTowersMaxRequired(int value) { }

	private bool CheckForResetTowersSlotsRequired(int value) { }

	private void CheckForSaveData() { }

	private void CheckSetExtremeMode(object val) { }

	private void CheckSetLives(object val) { }

	private void CheckSetPowerMax(object val) { }

	private void CheckSetPowerSlots(object val) { }

	private void CheckSetTowerMax(object val) { }

	private void CheckSetTowerSlots(object val) { }

	private void ClearAllSavedData() { }

	private void ClearSave(OdysseyDifficulty previousDifficulty) { }

	private void ClearUI() { }

	public OdysseyData CloneOdysseyData(OdysseyData dataToClone) { }

	public DailyChallengeModel CloneOdysseyDcmData(DailyChallengeModel dataToClone) { }

	public void CloseChallengeEditor() { }

	private void CloseMapSelect() { }

	private void ClosePowerSelect() { }

	private void CloseTowerSelect() { }

	public bool CompletedAllMapsForDifficulty() { }

	private void ConfirmedSetupOrResetDefaultOdyssey(bool resetDifficultySelected = true) { }

	private bool ContainsProfanity(string str) { }

	private void CopyDifficultyDCM(OdysseyDifficulty previousDiff, bool cmOverride = false) { }

	private void DifficultyChangedClicked(bool attemptClearSave = true) { }

	private void DisplayPowers() { }

	public void DisplayTowers() { }

	private void EditMapDcm(OdysseyEditorMap odyMapData) { }

	private void GamepadSelectFirst() { }

	private void GamepadSetup() { }

	public OdysseyDifficulty get_DifficultySelected() { }

	private OdysseyData get_EmbarkedOdysseyEditorDcm() { }

	private OdysseyData get_OdysseyEditorDcm() { }

	public Rules get_OdysseyEditorDifficultyRules() { }

	private ProfileModel get_PlayerData() { }

	public OdysseySaveData get_SaveData() { }

	public bool get_SharingInProgress() { }

	public List<PowerData> GetAllAvailablePowers() { }

	public List<TowerData> GetAllAvailableTowers() { }

	public List<PowerData> GetAllPowers() { }

	public List<TowerData> GetAllTowers() { }

	public List<TowerData> GetAvailableHeros() { }

	public List<TowerData> GetAvailableTowersNonHero() { }

	private OdysseyDifficulty[] GetDifficulties() { }

	public Rules GetEmbarkedDifficultyRules() { }

	private static int GetOdysseyRbe(DailyChallengeModel[] challenges) { }

	public PowerData GetPowerData(string powerId) { }

	private int GetRewardIndex(OdysseyDifficulty difficulty) { }

	private int GetRewardPathIndex(OdysseyDifficulty difficulty) { }

	public TowerData GetTowerData(string towerId) { }

	private void InitializeUi() { }

	private bool IsRewardTypeInstaTowers(int val) { }

	public void MapChangedConfirmed(string map) { }

	public void MapChangedRequest(string map) { }

	public void MapSelectClicked(OdysseyEditorMap odyMapData) { }

	public virtual void Open(object data) { }

	private void OpenDcmEditor() { }

	public void OpenMapSelect() { }

	public virtual bool OverrideClose() { }

	private void OverritePopupMessage() { }

	private int ParseValue(string v, int defaultValue = -1) { }

	private void PlayOdysseyClicked() { }

	private void PopulateMaps() { }

	private void PopulateVisuals() { }

	private void PowerSelectClicked() { }

	public void RemoveValueChangedListeners() { }

	private void ResetDcmVariable(DataType dataType) { }

	private void ResetExtremeMode() { }

	private void ResetLives() { }

	private void ResetMapSave() { }

	public void ResetOdysseySaveData() { }

	private void ResetPowerMax() { }

	private void ResetPowerSlots() { }

	public void ResetProceedingMapSaveData() { }

	private void ResetTowerMax() { }

	private void ResetTowerSlots() { }

	private void set_EmbarkedOdysseyEditorDcm(OdysseyData value) { }

	private void set_OdysseyEditorDcm(OdysseyData value) { }

	public void set_SaveData(OdysseySaveData value) { }

	private void SetData(DataType dataType, object data) { }

	private void SetLocsKey(int val) { }

	private void SetRewards(int index, int tierIndex, OdysseyDifficulty difficulty, TMP_Dropdown rewardsPath, GameObject rewardsBlockerPath, GameObject rewardsPowersIcon, GameObject rewardsInstasIcon) { }

	private void SetRewardsEasy(int val) { }

	private void SetRewardsHard(int val) { }

	private void SetRewardsInstaEasy(int val) { }

	private void SetRewardsInstaHard(int val) { }

	private void SetRewardsInstaMedium(int val) { }

	private void SetRewardsMedium(int val) { }

	private void SetTowerSelectNav() { }

	private void SetTrophies(string val, OdysseyDifficulty odysseyDifficulty) { }

	private void SetTrophiesMm(string val, OdysseyDifficulty odysseyDifficulty, TMP_InputField inputField) { }

	private void SetupOrResetDefaultOdyssey() { }

	public void ShareOdysseyClicked() { }

	[AsyncStateMachine(typeof(<ShareOdysseyConfirmed>d__201))]
	public void ShareOdysseyConfirmed() { }

	private void ShareOdysseyDown(BaseEventData eventData) { }

	private void ShareOdysseyEdit() { }

	private void ShareOdysseyUp(BaseEventData eventData) { }

	private void ShowPowerSelect() { }

	private void ShowProfanityPopUp() { }

	private void ShowTowerSelect() { }

	private void SortPowersInOrder() { }

	private void SortTowersInOrder() { }

	private void TowerRestrictionClicked() { }

	private void TowerSelectClicked() { }

	private void TowersSelectClosed() { }

	private bool TryGetSelectedDCModPowerDisplay(out DCModPowerDisplay comp) { }

	private bool TryGetSelectedDCModTowerDisplay(out DCModTowerDisplay comp) { }

	private void Update() { }

	private void UpdateInputFieldVisuals() { }

	private void UpdateNavLinks() { }

	[AsyncStateMachine(typeof(<ValidateInput>d__151))]
	private Task<Boolean> ValidateInput(NK_TextMeshProInputField inputField, string userInput) { }

}

