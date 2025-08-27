namespace Assets.Scripts.Unity.UI_New.PlayerStats;

public class ProfileItem : MonoBehaviour
{
	public Image img; //Field offset: 0x20
	public GameObject limitedTimeObj; //Field offset: 0x28
	public GameObject questLockObj; //Field offset: 0x30
	public GameObject lockedPanelObj; //Field offset: 0x38
	public GameObject equippedTickObj; //Field offset: 0x40
	public GameObject customUnlockObj; //Field offset: 0x48
	public NK_TextMeshProUGUI costTxt; //Field offset: 0x50
	public Toggle activeTgl; //Field offset: 0x58
	public NK_TextMeshProUGUI questBannerTxt; //Field offset: 0x60
	public GameObject questLockedImage; //Field offset: 0x68
	public GameObject questGlowPanel; //Field offset: 0x70
	public Color unavailable; //Field offset: 0x78
	public Color available; //Field offset: 0x88
	public GameObject iapStoreIconObj; //Field offset: 0x98
	protected QuestDetails questDetails; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <IsLocked>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <ExternalToggleOverride>k__BackingField; //Field offset: 0xA9
	[CompilerGenerated]
	private bool <HasClaimedBaseQuestRewards>k__BackingField; //Field offset: 0xAA
	[CompilerGenerated]
	private bool <IsNexusItemOwned>k__BackingField; //Field offset: 0xAB
	[CompilerGenerated]
	private bool <IsLimitedTimeTrophyItem>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private bool <IsIAPItem>k__BackingField; //Field offset: 0xAD

	public bool ExternalToggleOverride
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool HasClaimedBaseQuestRewards
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsIAPItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsLimitedTimeTrophyItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsLocked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsNexusItemOwned
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsQuestItem
	{
		 get { } //Length: 83
	}

	public bool IsQuestLocked
	{
		 get { } //Length: 22
	}

	public QuestDetails QuestDetails
	{
		 get { } //Length: 8
	}

	public ProfileItem() { }

	[CompilerGenerated]
	private void <Awake>b__45_0(bool isOn) { }

	public void Awake() { }

	public void DisplayTxt(string text) { }

	[CompilerGenerated]
	public bool get_ExternalToggleOverride() { }

	[CompilerGenerated]
	public bool get_HasClaimedBaseQuestRewards() { }

	[CompilerGenerated]
	public bool get_IsIAPItem() { }

	[CompilerGenerated]
	public bool get_IsLimitedTimeTrophyItem() { }

	[CompilerGenerated]
	public bool get_IsLocked() { }

	[CompilerGenerated]
	public bool get_IsNexusItemOwned() { }

	public bool get_IsQuestItem() { }

	public bool get_IsQuestLocked() { }

	public QuestDetails get_QuestDetails() { }

	public string GetQuestText(string defualtTextLoc) { }

	public void OnValueChanged(bool isOn) { }

	public void RefreshPanel() { }

	[CompilerGenerated]
	public void set_ExternalToggleOverride(bool value) { }

	[CompilerGenerated]
	public void set_HasClaimedBaseQuestRewards(bool value) { }

	[CompilerGenerated]
	public void set_IsIAPItem(bool value) { }

	[CompilerGenerated]
	public void set_IsLimitedTimeTrophyItem(bool value) { }

	[CompilerGenerated]
	public void set_IsLocked(bool value) { }

	[CompilerGenerated]
	public void set_IsNexusItemOwned(bool value) { }

	public void ShowIapLocked(bool isOn) { }

	public void ShowLimited(bool limited) { }

	public void ShowQuestLocked(bool isQuestBanner) { }

}

