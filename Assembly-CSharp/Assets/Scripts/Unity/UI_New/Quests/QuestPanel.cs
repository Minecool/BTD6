namespace Assets.Scripts.Unity.UI_New.Quests;

public class QuestPanel : MonoBehaviour
{
	public Image questImage; //Field offset: 0x20
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x28
	public NK_TextMeshProUGUI descriptionTxt; //Field offset: 0x30
	public NK_TextMeshProUGUI stageTxt; //Field offset: 0x38
	public NK_TextMeshProUGUI lockedDescriptionTxt; //Field offset: 0x40
	public Button goBtn; //Field offset: 0x48
	public Button replayBtn; //Field offset: 0x50
	public Button continueBtn; //Field offset: 0x58
	public Button claimBtn; //Field offset: 0x60
	public GameObject completedPanel; //Field offset: 0x68
	public GameObject loadingPanel; //Field offset: 0x70
	public GameObject specialQuestPanel; //Field offset: 0x78
	public GameObject standardQuestPanel; //Field offset: 0x80
	public GameObject rewardsPanel; //Field offset: 0x88
	public GameObject levelLockedPanel; //Field offset: 0x90
	public GameObject rewardPipPanel; //Field offset: 0x98
	public GameObject newQuestPanel; //Field offset: 0xA0
	public GameObject questUnlockedPanel; //Field offset: 0xA8
	public GameObject claimedTickObj; //Field offset: 0xB0
	public GameObject claimedTextObj; //Field offset: 0xB8
	public GameObject rewardsBackgroundPanel; //Field offset: 0xC0
	public LootPanel lootPanel; //Field offset: 0xC8
	[CompilerGenerated]
	private QuestDetails <QuestData>k__BackingField; //Field offset: 0xD0
	private TaskData taskData; //Field offset: 0xD8
	private int currQuestPartIndex; //Field offset: 0xE0
	private int currQuestIndex; //Field offset: 0xE4
	private bool hasSaveData; //Field offset: 0xE8
	private bool hasClaimedRewards; //Field offset: 0xE9
	private bool hasCompletedAllQuestTasks; //Field offset: 0xEA
	private bool hasAvailableHolidayEventSpecificRewards; //Field offset: 0xEB
	private bool hasClaimedHolidayRewards; //Field offset: 0xEC

	public bool HasClaimedRewards
	{
		 get { } //Length: 8
	}

	public bool IsNew
	{
		 get { } //Length: 96
	}

	public bool IsTaleQuest
	{
		 get { } //Length: 33
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	public QuestCategory QuestCategory
	{
		 get { } //Length: 29
	}

	private QuestDetails QuestData
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private QuestTrackerManager QuestTrackerManager
	{
		private get { } //Length: 68
	}

	public int UnlockLevel
	{
		 get { } //Length: 29
	}

	public QuestPanel() { }

	public bool get_HasClaimedRewards() { }

	public bool get_IsNew() { }

	public bool get_IsTaleQuest() { }

	private LocalizationManager get_Locs() { }

	public QuestCategory get_QuestCategory() { }

	[CompilerGenerated]
	private QuestDetails get_QuestData() { }

	private QuestTrackerManager get_QuestTrackerManager() { }

	public int get_UnlockLevel() { }

	public void Initialise(QuestDetails QuestData) { }

	public bool IsQuestUnlocked() { }

	public void OnGoReplayClicked() { }

	[CompilerGenerated]
	private void set_QuestData(QuestDetails value) { }

}

