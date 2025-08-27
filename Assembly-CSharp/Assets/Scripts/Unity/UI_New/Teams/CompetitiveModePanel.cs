namespace Assets.Scripts.Unity.UI_New.Teams;

public class CompetitiveModePanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__15_0; //Field offset: 0x8
		public static Func<GuildMemberModel, Boolean> <>9__16_0; //Field offset: 0x10
		public static Func<GuildMemberModel, String> <>9__16_1; //Field offset: 0x18
		public static Func<GuildMessage, Boolean> <>9__27_0; //Field offset: 0x20
		public static Func<GuildMessage, TeamMessage> <>9__27_1; //Field offset: 0x28
		public static Func<TeamMessage, Boolean> <>9__27_2; //Field offset: 0x30
		public static Func<TeamMessage, DateTime> <>9__27_3; //Field offset: 0x38
		public static Func<GuildMemberModel, Boolean> <>9__31_0; //Field offset: 0x40
		public static Func<GuildMemberModel, String> <>9__31_1; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal bool <CanSendCompetitiveRequest>b__27_0(GuildMessage x) { }

		internal TeamMessage <CanSendCompetitiveRequest>b__27_1(GuildMessage x) { }

		internal bool <CanSendCompetitiveRequest>b__27_2(TeamMessage x) { }

		internal DateTime <CanSendCompetitiveRequest>b__27_3(TeamMessage x) { }

		internal bool <HasEnoughPlayersForCompetitive>b__16_0(GuildMemberModel x) { }

		internal string <HasEnoughPlayersForCompetitive>b__16_1(GuildMemberModel x) { }

		internal bool <set_SignedUpIds>b__15_0(string playerId) { }

		internal bool <SetSignedUpCount>b__31_0(GuildMemberModel x) { }

		internal string <SetSignedUpCount>b__31_1(GuildMemberModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public string playerId; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <set_SignedUpIds>b__1(GuildMemberModel z) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public String[] playerIds; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <HasEnoughPlayersForCompetitive>b__2(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public CompetitiveModePanel <>4__this; //Field offset: 0x10
		public CtEvent currentOrNextCtEvent; //Field offset: 0x18
		public Btd6CtSettings ctSettings; //Field offset: 0x20

		public <>c__DisplayClass25_0() { }

		internal void <Load>b__0() { }

		internal void <Load>b__1() { }

	}

	[CompilerGenerated]
	private struct <CanSendCompetitiveRequest>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<IEnumerable`1<GuildMessage>> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCompetitiveStatus>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CompetitiveResponse> <>t__builder; //Field offset: 0x8
		public string eventId; //Field offset: 0x20
		public CompetitiveModePanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<CompetitiveResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GuildHasCompetitiveStance>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Load>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CompetitiveModePanel <>4__this; //Field offset: 0x20
		public bool forceShowCompetitivePanel; //Field offset: 0x28
		public TeamsScreen teamsScreen; //Field offset: 0x30
		private <>c__DisplayClass25_0 <>8__1; //Field offset: 0x38
		private bool <isCurrentEvent>5__2; //Field offset: 0x40
		private bool <guildHasCompetitiveStance>5__3; //Field offset: 0x41
		private TaskAwaiter<CtEvent> <>u__1; //Field offset: 0x48
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x50
		private CompetitiveStatus <competitiveStatus>5__4; //Field offset: 0x58
		private TaskAwaiter<CompetitiveResponse> <>u__3; //Field offset: 0x60
		private TaskAwaiter<Btd6CtSettings> <>u__4; //Field offset: 0x68
		private TaskAwaiter<CtEventStatus> <>u__5; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendCompetitiveRequestMessageAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CompetitiveModePanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetCompetitiveStanceAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CtEvent currentOrNextCtEvent; //Field offset: 0x20
		public CompetitiveModePanel <>4__this; //Field offset: 0x28
		public bool isCompetitive; //Field offset: 0x30
		public Btd6CtSettings ctSettings; //Field offset: 0x38
		private TaskAwaiter<CtEventStatus> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private TaskAwaiter<CompetitiveResponse> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateCountdownAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DateTime signUpEndTime; //Field offset: 0x28
		public CompetitiveModePanel <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct TeamMessage
	{
		public DateTime createdAt; //Field offset: 0x0
		public GuildMessageEvent guildMessageEvent; //Field offset: 0x8

	}

	[SerializeField]
	private GameObject signUpObj; //Field offset: 0x20
	[SerializeField]
	private GameObject signedUpObj; //Field offset: 0x28
	[SerializeField]
	private GameObject notSignedUpObj; //Field offset: 0x30
	[SerializeField]
	private GameObject loadingObj; //Field offset: 0x38
	[SerializeField]
	private GameObject requestCompObj; //Field offset: 0x40
	[SerializeField]
	private GameObject setCompObj; //Field offset: 0x48
	[SerializeField]
	private Button signUpBtn; //Field offset: 0x50
	[SerializeField]
	private Button signOutBtn; //Field offset: 0x58
	[SerializeField]
	private Button requestCompBtn; //Field offset: 0x60
	[SerializeField]
	private Button editTeamBtn; //Field offset: 0x68
	[SerializeField]
	private NK_TextMeshProUGUI requiredMembersTxt; //Field offset: 0x70
	[SerializeField]
	private NK_TextMeshProUGUI eventStartsInTxt; //Field offset: 0x78
	private String[] _signedUpIds; //Field offset: 0x80
	public Action CompetitivePlayersChanged; //Field offset: 0x88
	public Action EditTeamClicked; //Field offset: 0x90
	private bool forceShowCompetitivePanel; //Field offset: 0x98
	private TeamsScreen teamsScreen; //Field offset: 0xA0
	private bool isDestroyed; //Field offset: 0xA8

	private static LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	public private String[] SignedUpIds
	{
		 get { } //Length: 8
		private set { } //Length: 358
	}

	public CompetitiveModePanel() { }

	[CompilerGenerated]
	private void <Awake>b__17_0() { }

	[CompilerGenerated]
	private bool <SetSignedUpCount>b__31_2(string x) { }

	private void Awake() { }

	private void ButtonsInteractable(bool isInteractable) { }

	[AsyncStateMachine(typeof(<CanSendCompetitiveRequest>d__27))]
	private Task<Boolean> CanSendCompetitiveRequest() { }

	private static LocalizationManager get_Locs() { }

	public String[] get_SignedUpIds() { }

	[AsyncStateMachine(typeof(<GetCompetitiveStatus>d__37))]
	private Task<CompetitiveResponse> GetCompetitiveStatus(string eventId) { }

	[AsyncStateMachine(typeof(<GuildHasCompetitiveStance>d__34))]
	private static Task<Boolean> GuildHasCompetitiveStance() { }

	public static bool HasEnoughPlayersForCompetitive(String[] playerIds, int requiredForCompetitive) { }

	[AsyncStateMachine(typeof(<Load>d__25))]
	public Task Load(bool forceShowCompetitivePanel, TeamsScreen teamsScreen) { }

	private void OnDestroy() { }

	public void ResetComponents() { }

	[AsyncStateMachine(typeof(<SendCompetitiveRequestMessageAsync>d__28))]
	private void SendCompetitiveRequestMessageAsync() { }

	private void set_SignedUpIds(String[] value) { }

	[AsyncStateMachine(typeof(<SetCompetitiveStanceAsync>d__35))]
	private Task SetCompetitiveStanceAsync(CtEvent currentOrNextCtEvent, Btd6CtSettings ctSettings, bool isCompetitive) { }

	private void SetSignedUpCount(int requiredForCompetitive) { }

	private void SetSingupButtons() { }

	[AsyncStateMachine(typeof(<UpdateCountdownAsync>d__29))]
	private void UpdateCountdownAsync(DateTime signUpEndTime) { }

}

