namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class LinkFriendPanel : LiNKMemberPanel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public LinkFriendPanel <>4__this; //Field offset: 0x10
		public FriendsCall friendCallType; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <OnClickEvent>b__0() { }

	}

	[CompilerGenerated]
	private struct <AsyncLoadPanel>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendPanel <>4__this; //Field offset: 0x20
		public GameMenu screen; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Bind>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendPanel <>4__this; //Field offset: 0x20
		public GameMenu screen; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExecuteEvent>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendPanel <>4__this; //Field offset: 0x20
		public FriendsCall callType; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickInviteToGuild>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<Guild_GetMemberResponse> <>u__1; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnConfirm>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendPanel <>4__this; //Field offset: 0x28
		public FriendsCall callType; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private LinkFriendsScreen linkFriendsScreen; //Field offset: 0xB8
	private LiNKFriendData friendData; //Field offset: 0xC0
	public ButtonWithSyncingState inviteToTeamButton; //Field offset: 0xC8
	public Button gameInviteButton; //Field offset: 0xD0
	public NK_TextMeshProUGUI gameInviteBtnTxt; //Field offset: 0xD8

	public bool CanInviteToGuild
	{
		 get { } //Length: 258
	}

	public FriendStatus FriendStatus
	{
		 get { } //Length: 38
	}

	public bool HasSentInvitationToPlayerAlready
	{
		 get { } //Length: 143
	}

	public bool IsTeamMember
	{
		 get { } //Length: 296
	}

	public bool ShowRemoveOptions
	{
		 get { } //Length: 73
	}

	public LinkFriendPanel() { }

	[AsyncStateMachine(typeof(<AsyncLoadPanel>d__15))]
	public Task AsyncLoadPanel(GameMenu screen, object data) { }

	[AsyncStateMachine(typeof(<Bind>d__16))]
	protected virtual Task Bind(GameMenu screen, object data) { }

	[AsyncStateMachine(typeof(<ExecuteEvent>d__20))]
	private Task ExecuteEvent(FriendsCall callType) { }

	public bool get_CanInviteToGuild() { }

	public FriendStatus get_FriendStatus() { }

	public bool get_HasSentInvitationToPlayerAlready() { }

	public bool get_IsTeamMember() { }

	public bool get_ShowRemoveOptions() { }

	public virtual string GetLiNKID() { }

	public void OnClickEvent(string callType) { }

	[AsyncStateMachine(typeof(<OnClickInviteToGuild>d__21))]
	private void OnClickInviteToGuild() { }

	[AsyncStateMachine(typeof(<OnConfirm>d__19))]
	private void OnConfirm(FriendsCall callType) { }

	public virtual void ToggleParentInteractable(bool interactable) { }

	public virtual void UpdatePanelAsync() { }

}

