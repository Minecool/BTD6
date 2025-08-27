namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CTMapScorePanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <ShowTeamCosmeticsAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CTMapScorePanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject yourTeamObj; //Field offset: 0x20
	public Image bannerImg; //Field offset: 0x28
	public Image teamIconImg; //Field offset: 0x30
	public Image teamFrameImg; //Field offset: 0x38
	public Image colorBlindIconImg; //Field offset: 0x40
	public TMP_Text positionTxt; //Field offset: 0x48
	public TMP_Text nameTxt; //Field offset: 0x50
	public TMP_Text scoreTxt; //Field offset: 0x58
	public Button teamBtn; //Field offset: 0x60
	public NK_TextMeshProUGUI totalIncome; //Field offset: 0x68
	public Button scoreDetailsBtn; //Field offset: 0x70
	public GameObject scoreDetailsPopup; //Field offset: 0x78
	[CompilerGenerated]
	private EventHandler DetailsOpened; //Field offset: 0x80
	private GuildModel guildModel; //Field offset: 0x88
	[CompilerGenerated]
	private string <GuildId>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private long <Score>k__BackingField; //Field offset: 0x98

	public event EventHandler DetailsOpened
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public private string GuildId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private long Score
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public CTMapScorePanel() { }

	[CompilerGenerated]
	public void add_DetailsOpened(EventHandler value) { }

	protected void Awake() { }

	public void CloseDetailedScorePanel() { }

	[CompilerGenerated]
	public string get_GuildId() { }

	[CompilerGenerated]
	public long get_Score() { }

	public void Init(string guildId, int teamIndex, bool colorBlindOn) { }

	protected void OnDestroy() { }

	private void RefreshIncome() { }

	[CompilerGenerated]
	public void remove_DetailsOpened(EventHandler value) { }

	public void ScoreDetailsClicked() { }

	[CompilerGenerated]
	private void set_GuildId(string value) { }

	[CompilerGenerated]
	private void set_Score(long value) { }

	public void SetColorBlindMode(bool on) { }

	private void SetDetailedTeamIncome() { }

	public void SetPosition(int position) { }

	public void SetScore(long score) { }

	private void SetTotalTeamIncome() { }

	[AsyncStateMachine(typeof(<ShowTeamCosmeticsAsync>d__30))]
	public void ShowTeamCosmeticsAsync() { }

	public void TeamClicked() { }

}

