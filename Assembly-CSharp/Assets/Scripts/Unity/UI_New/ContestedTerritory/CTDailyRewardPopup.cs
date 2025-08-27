namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CTDailyRewardPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GuildInfo, Boolean> <>9__37_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <LoadVisuals>b__37_0(GuildInfo x) { }

	}

	[CompilerGenerated]
	private struct <OnClaimClickedAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CTDailyRewardPopup <>4__this; //Field offset: 0x20
		private TaskAwaiter<BonusRewardClaimResponse> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Animator animator; //Field offset: 0x20
	[SerializeField]
	private Button claimBtn; //Field offset: 0x28
	[SerializeField]
	private Button okBtn; //Field offset: 0x30
	[SerializeField]
	private Lightbox closeBtn; //Field offset: 0x38
	[SerializeField]
	private GameObject loadingSpinner; //Field offset: 0x40
	[SerializeField]
	private NK_TextMeshProUGUI ticketRefillCountTxt; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI personalTicketMmBonusTxt; //Field offset: 0x50
	[SerializeField]
	private CTDailyRewardTrophyPanel teamTrophyPanelFirst; //Field offset: 0x58
	[SerializeField]
	private CTDailyRewardTrophyPanel teamTrophyPanelPrefab; //Field offset: 0x60
	[SerializeField]
	private CTDailyRewardTrophyPanel teamTrophyPanelLast; //Field offset: 0x68
	[SerializeField]
	private GameObject teamTrophyPanelContainer; //Field offset: 0x70
	[SerializeField]
	private Image teamEmblemImg; //Field offset: 0x78
	[SerializeField]
	private Image teamFrameImg; //Field offset: 0x80
	[SerializeField]
	private Image teamColorImg; //Field offset: 0x88
	[SerializeField]
	private GameObject timerGroup; //Field offset: 0x90
	[SerializeField]
	private NK_TextMeshProUGUI nextRewardsTimerTxt; //Field offset: 0x98
	[SerializeField]
	private AudioClip closeSound; //Field offset: 0xA0
	[SerializeField]
	private GameObject backgroundBar; //Field offset: 0xA8
	public AudioClip openSound; //Field offset: 0xB0
	[CompilerGenerated]
	private bool <HasTeamTrophyLoot>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private EventHandler OnClosed; //Field offset: 0xC0
	[CompilerGenerated]
	private List<CTDailyRewardTrophyPanel> <TeamTrophyPanels>k__BackingField; //Field offset: 0xC8
	private TimeSpan timeRemaining; //Field offset: 0xD0

	public event EventHandler OnClosed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private CtEvent CtEvent
	{
		private get { } //Length: 138
	}

	private Btd6CtSettings CtSettings
	{
		private get { } //Length: 138
	}

	private StatusResponse CtStatus
	{
		private get { } //Length: 138
	}

	private bool HasTeamTrophyLoot
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private List<CTDailyRewardTrophyPanel> TeamTrophyPanels
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public CTDailyRewardPopup() { }

	[CompilerGenerated]
	private void <Awake>b__36_0() { }

	[CompilerGenerated]
	private void <LoadVisuals>b__37_1() { }

	[CompilerGenerated]
	public void add_OnClosed(EventHandler value) { }

	private void Awake() { }

	public void ClosePopup(bool playSound) { }

	private CtEvent get_CtEvent() { }

	private Btd6CtSettings get_CtSettings() { }

	private StatusResponse get_CtStatus() { }

	[CompilerGenerated]
	private bool get_HasTeamTrophyLoot() { }

	[CompilerGenerated]
	private List<CTDailyRewardTrophyPanel> get_TeamTrophyPanels() { }

	public void HidePopup() { }

	public void LoadVisuals() { }

	private void OnClaimClicked() { }

	[AsyncStateMachine(typeof(<OnClaimClickedAsync>d__40))]
	private Task OnClaimClickedAsync() { }

	public void RefreshTeamTrophyPanels() { }

	[CompilerGenerated]
	public void remove_OnClosed(EventHandler value) { }

	[CompilerGenerated]
	private void set_HasTeamTrophyLoot(bool value) { }

	[CompilerGenerated]
	private void set_TeamTrophyPanels(List<CTDailyRewardTrophyPanel> value) { }

	private void Update() { }

}

