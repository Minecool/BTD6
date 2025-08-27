namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopPlayerPanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <OnEnable>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopPlayerPanel <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public int slotNumber; //Field offset: 0x20
	public GameObject occupiedSlotObj; //Field offset: 0x28
	public GameObject emptySlotObj; //Field offset: 0x30
	public GameObject closedSlotObj; //Field offset: 0x38
	public GameObject hostIndicator; //Field offset: 0x40
	public NK_TextMeshProUGUI txtLevel; //Field offset: 0x48
	public Image rankImg; //Field offset: 0x50
	public Sprite regularRankSpr; //Field offset: 0x58
	public Sprite veteranRankSpr; //Field offset: 0x60
	public CoopDifficuiltyMedalPanel medalPanel; //Field offset: 0x68
	public Image heroIcon; //Field offset: 0x70
	public Image noHeroIcon; //Field offset: 0x78
	public PlayableAnimatorSimple heroChangeIcon; //Field offset: 0x80
	public NK_TextMeshProUGUI txtPlayerName; //Field offset: 0x88
	public GameObject bannerObject; //Field offset: 0x90
	public Image bannerImage; //Field offset: 0x98
	public Button infoBtn; //Field offset: 0xA0
	public Button inviteBtn; //Field offset: 0xA8
	public NK_TextMeshProUGUI txtLoading; //Field offset: 0xB0
	public Button closeSlotBtn; //Field offset: 0xB8
	public Button openSlotBtn; //Field offset: 0xC0
	[CompilerGenerated]
	private byte <PlayerNumber>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private SlotStatus <SlotStatus>k__BackingField; //Field offset: 0xCC
	private CoopLobbyScreen lobbyMenu; //Field offset: 0xD0
	[CompilerGenerated]
	private string <HeroSet>k__BackingField; //Field offset: 0xD8

	public private string HeroSet
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private byte PlayerNumber
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private SlotStatus SlotStatus
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public CoopPlayerPanel() { }

	private void CloseSlotClicked() { }

	public void DisableAllButtons() { }

	public void DisableOpenCloseButtons() { }

	private void GamepadCheckSelection() { }

	[CompilerGenerated]
	public string get_HeroSet() { }

	[CompilerGenerated]
	public byte get_PlayerNumber() { }

	[CompilerGenerated]
	public SlotStatus get_SlotStatus() { }

	private void InfoClicked() { }

	public void OnDisable() { }

	[AsyncStateMachine(typeof(<OnEnable>d__30))]
	public void OnEnable() { }

	public void OpenFriendsPanel() { }

	private void OpenSlotClicked() { }

	[CompilerGenerated]
	private void set_HeroSet(string value) { }

	[CompilerGenerated]
	private void set_PlayerNumber(byte value) { }

	[CompilerGenerated]
	private void set_SlotStatus(SlotStatus value) { }

	private void SetBanner(string bannerId) { }

	private void SetHero(bool heroAllowed, string hero, bool useHeroAnimation) { }

	public void SetLobbyPublic(bool isPublic) { }

	public void SetSlotClosed() { }

	public void SetSlotOccupied(byte playerNumber, string playerName, int playerLvl, bool isVeteran, int medalIndex, int medalCount, bool heroAllowed, string hero, string banner, bool animateHeroIcon, bool hasLinkAccount) { }

	public void SetSlotOpen(bool isPublic) { }

	public void ShowInviteButton(bool isEnabled) { }

	public void ShowSlotCloseButton(bool isVisible) { }

	public void ShowSlotOpenButton(bool isVisible) { }

}

