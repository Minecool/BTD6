namespace Assets.Scripts.Unity.UI_New.Quests;

public class QuestTrackerManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public TrophyStoreItem trophyItem; //Field offset: 0x10
		public Func<LootData, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass45_0() { }

		internal bool <CanShowTrophyItemAsObtainableThroughQuest>b__0(LootData x) { }

	}

	[CompilerGenerated]
	private struct <InGameTriggeredDialogue>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DialogueData dialogue; //Field offset: 0x28
		public QuestTrackerManager <>4__this; //Field offset: 0x30
		public bool saveSeen; //Field offset: 0x38
		private QuestGameData <questData>5__2; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static QuestTrackerManager instance; //Field offset: 0x0
	public Action<String[]> DialogueTriggerSimAction; //Field offset: 0x10
	public Action DialoguePopupClosedAction; //Field offset: 0x18

	public bool AreAvailableQuestsLevelLocked
	{
		 get { } //Length: 221
	}

	public bool HasQuestsAvailable
	{
		 get { } //Length: 133
	}

	public int LowestLockedQuestRequiredLevel
	{
		 get { } //Length: 7
	}

	public string MapSaveName
	{
		 get { } //Length: 78
	}

	private QuestData QuestData
	{
		private get { } //Length: 71
	}

	public QuestTrackerManager() { }

	public bool CanShowTrophyItemAsObtainableThroughQuest(TrophyStoreItem trophyItem, out bool limitedTimeItem, out HolidayEvent eventData, out bool hasCompletedQuest, out QuestDetails questDetails) { }

	public bool CanShowTrophyItemAsObtainableThroughQuest(string trophyItemId, out bool limitedTimeItem, out HolidayEvent eventData, out bool hasCompletedQuest, out QuestDetails questDetails) { }

	private bool CheckIfQuestsAvailable() { }

	private int FindLowestQuestLevelLock() { }

	public bool get_AreAvailableQuestsLevelLocked() { }

	public bool get_HasQuestsAvailable() { }

	public int get_LowestLockedQuestRequiredLevel() { }

	public string get_MapSaveName() { }

	private QuestData get_QuestData() { }

	public int GetLastSelectedQuestTaskIndex(QuestDetails questDetails, int partIndex) { }

	public int GetPartIndexForNextUncompletedPartOrLastPart(QuestDetails questDetails) { }

	public int GetPreviouslySelectedPartIndex(QuestDetails questDetails) { }

	public string GetQuestProgressXOutOfXTxt(QuestDetails questDetails) { }

	public QuestSaveData GetQuestSaveData(string questId) { }

	public int GetTowerQuestUnlockLevelCheckSkuOverrides(string towerId) { }

	public bool HasAvailableHolidayEventSpecificAwardForQuest(QuestDetails questDetails, int partIndex, out bool hasClaimedHolidayRewards, out LootSet rewardMetaData) { }

	public bool HasCompletedAllQuestParts(QuestDetails questDetails, int partIndex) { }

	public bool HasCompletedAllQuestPartTasks(QuestDetails questDetails, int partIndex) { }

	public bool HasCompletedAnyQuest() { }

	public bool HasCompletedQuestTasks(QuestDetails questDetails, int partIndex, int taskIndex) { }

	public bool HasDisabledQuestDialogue(QuestDetails questDetails, int partIndex) { }

	private bool HasMapSaveDataForThisQuest(QuestDetails questDetails) { }

	public bool HasSaveDataForThisQuest(QuestDetails questDetails, TaskData taskData, int questPartIndex) { }

	public bool HasSeenQuest(QuestDetails questDetails) { }

	public void InGameDestroyed() { }

	public void InGameInitialised() { }

	[AsyncStateMachine(typeof(<InGameTriggeredDialogue>d__49))]
	public void InGameTriggeredDialogue(DialogueData dialogue, bool saveSeen) { }

	public bool IsNewQuestAvailable() { }

	public bool IsTowerLockedByQuest(string towerId) { }

	private void OnCompleteAnimatedDialogueCallback() { }

	public void OpenQuestScene(QuestUiData questUiData) { }

	public void SaveHasSeenQuest(QuestDetails questDetails) { }

	private void SetCallbacks() { }

	public void SetDisabledQuestDialogue(QuestDetails questDetails, int questPartIndex, bool value) { }

	public void SetPreviouslySelectedPartIndex(QuestDetails questDetails, int index) { }

	public LootSet SetQuestLootPanel(LootPanel lootPanel, QuestDetails questDetails, bool hasHolidayEventSpecificRewards, bool hasClaimedHolidayRewards, LootSet holidayBonusLootSet, int partIndex) { }

	public void SetSelectedQuestTaskIndex(QuestDetails questDetails, int partIndex, int taskIndex) { }

	public bool ShowNewQuestPip(QuestDetails questDetails) { }

	public bool TryGetCurrentQuestTaskInfo(QuestDetails questDetails, out TaskData taskData, out int partIndex, out int taskIndex) { }

	public bool TryGetNextAvailableQuest(out T questDetails) { }

	public bool TryGetQuestData(string questId, out QuestDetails questDetails) { }

	public bool TryGetSkuOverridesIsQuestDisabled(string questId) { }

	public bool TryGetTaskIndex(QuestDetails questDetails, TaskData taskData, int partIndex, out int taskIndex) { }

	public bool TryGetTowerTrialQuest(string towerId, out QuestDetails questDeails) { }

}

