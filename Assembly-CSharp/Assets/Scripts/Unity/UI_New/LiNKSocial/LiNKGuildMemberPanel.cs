namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class LiNKGuildMemberPanel : LiNKMemberPanel
{
	[CompilerGenerated]
	private struct <<UpdatePanelAsync>b__38_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMemberPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public LiNKGuildMemberPanel <>4__this; //Field offset: 0x10
		public GuildsCall guildCallType; //Field offset: 0x18

		public <>c__DisplayClass48_0() { }

		internal void <OnClickEvent>b__0() { }

	}

	[CompilerGenerated]
	private struct <AsyncLoadPanel>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMemberPanel <>4__this; //Field offset: 0x20
		public Nullable<MemberScoreType> memberScoreType; //Field offset: 0x28
		public CompetitiveModePanel competitiveModePanel; //Field offset: 0x30
		public long score; //Field offset: 0x38
		public GameMenu screen; //Field offset: 0x40
		public GuildMemberModel memberModel; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Bind>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMemberPanel <>4__this; //Field offset: 0x20
		public GameMenu screen; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExecuteEvent>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMemberPanel <>4__this; //Field offset: 0x20
		public GuildsCall callType; //Field offset: 0x28
		private bool <successful>5__2; //Field offset: 0x2C
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <KickOrUndoKick>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMemberPanel <>4__this; //Field offset: 0x20
		public GuildsCall callType; //Field offset: 0x28
		private TaskAwaiter<KickResult> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickSendFriendRequest>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMemberPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnConfirm>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GuildsCall callType; //Field offset: 0x28
		public LiNKGuildMemberPanel <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdatePanelAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMemberPanel <>4__this; //Field offset: 0x28
		private FriendModel <friendModel>5__2; //Field offset: 0x30
		private TaskAwaiter<Btd6FriendsData> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum MemberScoreType
	{
		CT = 0,
		BossRush = 1,
	}

	public ButtonWithSyncingState inviteFriendBtn; //Field offset: 0xB8
	public Button promoteButton; //Field offset: 0xC0
	public Button demoteButton; //Field offset: 0xC8
	public Button transferOwnershipButton; //Field offset: 0xD0
	public Button undoKickButton; //Field offset: 0xD8
	public GameObject mayorPanel; //Field offset: 0xE0
	public GameObject assistantMayorPanel; //Field offset: 0xE8
	public GameObject loadingPanel; //Field offset: 0xF0
	public GameObject kickPendingObj; //Field offset: 0xF8
	public GameObject ctTileInfoHoverable; //Field offset: 0x100
	public CtTeamScorePopup ctTeamScorePopup; //Field offset: 0x108
	[SerializeField]
	private LiNKGuildMemberPanelScore scorePanel; //Field offset: 0x110
	private Nullable<MemberScoreType> memberScoreType; //Field offset: 0x118
	public Image signedUpCompetitive; //Field offset: 0x120
	private TeamsScreen teamsScreen; //Field offset: 0x128
	[CompilerGenerated]
	private GuildMemberModel <ThisGuildMemberData>k__BackingField; //Field offset: 0x130
	private CompetitiveModePanel competitiveModePanel; //Field offset: 0x138

	private Button AcceptButton
	{
		private get { } //Length: 5
	}

	public bool AmIOwnerOfGuild
	{
		 get { } //Length: 32
	}

	public bool AmIOwnerOrModorator
	{
		 get { } //Length: 32
	}

	private Button DeclineButton
	{
		private get { } //Length: 5
	}

	public bool IsKickPending
	{
		 get { } //Length: 32
	}

	public bool IsThisMemberModerator
	{
		 get { } //Length: 34
	}

	public bool IsThisMemberOwner
	{
		 get { } //Length: 75
	}

	private Button KickButton
	{
		private get { } //Length: 5
	}

	public long Score
	{
		 get { } //Length: 131
	}

	public private GuildMemberModel ThisGuildMemberData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public GuildMembershipState ThisMembersPerms
	{
		 get { } //Length: 29
	}

	public LiNKGuildMemberPanel() { }

	[CompilerGenerated]
	private void <Bind>b__37_0() { }

	[AsyncStateMachine(typeof(<<UpdatePanelAsync>b__38_0>d))]
	[CompilerGenerated]
	private void <UpdatePanelAsync>b__38_0() { }

	[CompilerGenerated]
	private void <UpdatePanelAsync>b__38_1() { }

	[AsyncStateMachine(typeof(<AsyncLoadPanel>d__34))]
	public Task AsyncLoadPanel(GameMenu screen, GuildMemberModel memberModel, long score, Nullable<MemberScoreType> memberScoreType, CompetitiveModePanel competitiveModePanel) { }

	[AsyncStateMachine(typeof(<Bind>d__37))]
	protected virtual Task Bind(GameMenu screen, object data) { }

	public virtual void ClosePopups() { }

	[AsyncStateMachine(typeof(<ExecuteEvent>d__50))]
	private Task ExecuteEvent(GuildsCall callType) { }

	private Button get_AcceptButton() { }

	public bool get_AmIOwnerOfGuild() { }

	public bool get_AmIOwnerOrModorator() { }

	private Button get_DeclineButton() { }

	public bool get_IsKickPending() { }

	public bool get_IsThisMemberModerator() { }

	public bool get_IsThisMemberOwner() { }

	private Button get_KickButton() { }

	public long get_Score() { }

	[CompilerGenerated]
	public GuildMemberModel get_ThisGuildMemberData() { }

	public GuildMembershipState get_ThisMembersPerms() { }

	public virtual string GetLiNKID() { }

	[AsyncStateMachine(typeof(<KickOrUndoKick>d__51))]
	private Task KickOrUndoKick(GuildsCall callType) { }

	public void OnClickEvent(string callType) { }

	[AsyncStateMachine(typeof(<OnClickSendFriendRequest>d__52))]
	private Task OnClickSendFriendRequest() { }

	[AsyncStateMachine(typeof(<OnConfirm>d__49))]
	private void OnConfirm(GuildsCall callType) { }

	private void OnDestroy() { }

	[CompilerGenerated]
	private void set_ThisGuildMemberData(GuildMemberModel value) { }

	public void SetButtonDefaults() { }

	private void SetCompetitiveIcon() { }

	public virtual void SetInteractable(bool interactable) { }

	public void SetOnline(bool isOnline) { }

	public virtual void ToggleParentInteractable(bool interactable) { }

	[AsyncStateMachine(typeof(<UpdatePanelAsync>d__38))]
	public virtual void UpdatePanelAsync() { }

	public void UpdatePanelButtons(bool showTeamAdminButtons) { }

}

