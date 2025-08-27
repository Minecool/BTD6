namespace Assets.Scripts.Unity.UI_New.Main.Debugging;

public class MainMenuDebugPanel : MonoBehaviour
{
	public GameObject debugMenuObj; //Field offset: 0x20
	public Button fullScreenCloseBtn; //Field offset: 0x28
	public TMP_InputField changeTimeDaysInput; //Field offset: 0x30
	public TMP_InputField changeTimeHoursInput; //Field offset: 0x38
	public TMP_InputField changeTimeMinsInput; //Field offset: 0x40
	public TMP_InputField changeTimeSecsInput; //Field offset: 0x48
	public Button changeTimeAdd; //Field offset: 0x50
	public Button changeTimeRemove; //Field offset: 0x58
	public Button changeTimeAddDay; //Field offset: 0x60
	public Button changeTimeAddHour; //Field offset: 0x68
	public Button changeTimeAddMin; //Field offset: 0x70
	public Button changeTimeAddSec; //Field offset: 0x78
	public Text debugTimeOffsetTxt; //Field offset: 0x80
	public Text onlineTimeTxt; //Field offset: 0x88
	public Text offlineTimeTxt; //Field offset: 0x90
	public Button setTimeToNowBtn; //Field offset: 0x98
	public Button clearOfflineTime; //Field offset: 0xA0
	public Button resetGiftbox; //Field offset: 0xA8
	public Button resetDailyChest; //Field offset: 0xB0
	public Button triggerRankUp; //Field offset: 0xB8
	public TMP_InputField playerLevelInput; //Field offset: 0xC0
	public Button setPlayerLevel; //Field offset: 0xC8
	public TMP_InputField playerVeteranLevelInput; //Field offset: 0xD0
	public Button setPlayerVeteranLevel; //Field offset: 0xD8
	public TMP_InputField playerXPInput; //Field offset: 0xE0
	public Button setPlayerXP; //Field offset: 0xE8
	public TMP_InputField paidUserLocalInput; //Field offset: 0xF0
	public Button paidUserLocalSetBtn; //Field offset: 0xF8
	public TMP_InputField paidUserServerInput; //Field offset: 0x100
	public Button paidUserServerSetBtn; //Field offset: 0x108
	public Button forceException1; //Field offset: 0x110
	public Button forceException2; //Field offset: 0x118
	public Button forceException3; //Field offset: 0x120
	public Button forceException4; //Field offset: 0x128
	public Toggle toggleDiskFull; //Field offset: 0x130
	public Image diskFullEnabled; //Field offset: 0x138
	public Image diskFullDisabled; //Field offset: 0x140
	public Text deviceOSInfo; //Field offset: 0x148
	public Text deviceOSVersionInfo; //Field offset: 0x150
	public Text deviceModelInfo; //Field offset: 0x158
	public Text assetScale; //Field offset: 0x160
	public Text renderQuality; //Field offset: 0x168
	public Button testRaceRewardScreen; //Field offset: 0x170
	public Button testBossRewardScreen; //Field offset: 0x178
	public Button testBossRushRewardScreen; //Field offset: 0x180
	public Button testCTRewardScreen; //Field offset: 0x188
	public Button testVetPopupBtn; //Field offset: 0x190
	public Toggle toggleLocsDebug; //Field offset: 0x198
	public Image locDebugEnabled; //Field offset: 0x1A0
	public Image locDebugDisabled; //Field offset: 0x1A8
	public Button setEvent; //Field offset: 0x1B0
	public TMP_Dropdown eventType; //Field offset: 0x1B8
	public Button openSpecificUiScene; //Field offset: 0x1C0
	public TMP_Dropdown scenesToOpen; //Field offset: 0x1C8
	public Button openMapEditorMode; //Field offset: 0x1D0
	public Button clearQuestData; //Field offset: 0x1D8
	public Button clearActorData; //Field offset: 0x1E0
	public Button copyInstasButton; //Field offset: 0x1E8
	[SerializeField]
	private Button startV50QuestTutorialBtn; //Field offset: 0x1F0
	[SerializeField]
	private Button startOriginalTutorialBtn; //Field offset: 0x1F8

	public MainMenuDebugPanel() { }

}

