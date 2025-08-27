namespace NinjaKiwi.LiNK;

public class LiNKAccount
{
	[CompilerGenerated]
	private struct <UpdateDisplayName>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccount <>4__this; //Field offset: 0x20
		public string newDisplayName; //Field offset: 0x28
		private TaskAwaiter<UserModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class AccountInfo
	{
		public string safeName; //Field offset: 0x10
		public string shortCode; //Field offset: 0x18
		public string email; //Field offset: 0x20
		public int age; //Field offset: 0x28
		public int clan; //Field offset: 0x2C
		public string country; //Field offset: 0x30
		public string continent; //Field offset: 0x38
		public int avatar; //Field offset: 0x40
		public bool online; //Field offset: 0x44
		public int onlineApp; //Field offset: 0x48
		public String[] providersAvailable; //Field offset: 0x50

		public AccountInfo() { }

	}

	internal struct Matchmaking_QuickMatchSystem
	{
		[CompilerGenerated]
		private Matchmaking_Play_LoggedIn <Play>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Matchmaking_Cancel_LoggedIn <Cancel>k__BackingField; //Field offset: 0x8

		public internal Matchmaking_Cancel_LoggedIn Cancel
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_Play_LoggedIn Play
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			internal set { } //Length: 4
		}

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Cancel_LoggedIn get_Cancel() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Play_LoggedIn get_Play() { }

		[CompilerGenerated]
		internal void set_Cancel(Matchmaking_Cancel_LoggedIn value) { }

		[CompilerGenerated]
		internal void set_Play(Matchmaking_Play_LoggedIn value) { }

	}

	public readonly string id; //Field offset: 0x10
	public readonly AccountInfo info; //Field offset: 0x18
	[CompilerGenerated]
	private string <SessionID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <DisplayName>k__BackingField; //Field offset: 0x28
	public readonly Matchmaking_QuickMatchSystem matchmaking_Quick; //Field offset: 0x30
	public readonly PubSub_Read pubSub_Read; //Field offset: 0x40
	public readonly PubSub_Send pubSub_Send; //Field offset: 0x48
	public readonly PubSub_Remove pubSub_Remove; //Field offset: 0x50
	public readonly PubSub_Global_Read pubSub_Global_Read; //Field offset: 0x58
	public readonly PubSub_Global_Send pubSub_Global_Send; //Field offset: 0x60
	public readonly PubSub_Global_Wipe pubSub_Global_Wipe; //Field offset: 0x68
	public readonly PubSub_Global_Remove pubSub_Global_Remove; //Field offset: 0x70
	public readonly Storage_Save storage_Save; //Field offset: 0x78
	public readonly Storage_Load storage_Load; //Field offset: 0x80
	public readonly Storage_SaveTransient storage_SaveTransient; //Field offset: 0x88
	public readonly Guild_Create guild_Create; //Field offset: 0x90
	public readonly Guild_AcceptMember guild_AcceptMember; //Field offset: 0x98
	public readonly Guild_FindMembers guild_FindMembers; //Field offset: 0xA0
	public readonly Guild_Join guild_Join; //Field offset: 0xA8
	public readonly Guild_ListMembers guild_ListMembers; //Field offset: 0xB0
	public readonly Guild_RemoveMember guild_RemoveMember; //Field offset: 0xB8
	public readonly Guild_Update guild_Update; //Field offset: 0xC0
	public readonly Guild_UpdatePermissions guild_UpdatePermissions; //Field offset: 0xC8
	public readonly Guild_Member_AddPermissions guild_Member_AddPermissions; //Field offset: 0xD0
	public readonly Guild_Member_RemovePermissions guild_Member_RemovePermissions; //Field offset: 0xD8
	public readonly Guild_UpdateOwner guild_UpdateOwner; //Field offset: 0xE0
	public readonly Guild_GetInvitationCode guild_GetInvitationCode; //Field offset: 0xE8
	public readonly User_SetOnline user_SetOnline; //Field offset: 0xF0
	public readonly User_GetOnline user_GetOnline; //Field offset: 0xF8
	public readonly User_CheckAndSetPlaySession user_CheckAndSetPlaySession; //Field offset: 0x100
	public readonly User_GetGamestates user_GetGamestates; //Field offset: 0x108
	public readonly User_Current user_Current; //Field offset: 0x110
	public readonly User_DisplayNameCheck user_DisplayNameCheck; //Field offset: 0x118
	public readonly User_Update user_Update; //Field offset: 0x120
	public readonly User_LinkFacebook user_LinkFacebook; //Field offset: 0x128
	public readonly User_LinkEpic user_LinkEpic; //Field offset: 0x130
	public readonly User_LinkEmail user_LinkEmail; //Field offset: 0x138
	public readonly User_LinkPlatform user_LinkPlatform; //Field offset: 0x140
	public readonly User_LinkGameCenterPlayerIDs user_LinkGameCenterPlayerIDs; //Field offset: 0x148
	public readonly User_GetLiNKCode user_GetLiNKCode; //Field offset: 0x150
	public readonly User_Delete user_Delete; //Field offset: 0x158
	public readonly User_CancelDelete user_CancelDelete; //Field offset: 0x160
	public readonly User_WebAuthToken user_WebAuthToken; //Field offset: 0x168
	public readonly User_AnonSendRecovery user_AnonSendRecovery; //Field offset: 0x170
	public readonly Social_Status social_Status; //Field offset: 0x178
	public readonly Social_Reconnect social_Reconnect; //Field offset: 0x180
	public readonly Social_GetLeaderboard social_GetLeaderboard; //Field offset: 0x188
	public readonly Friends_Request friends_Request; //Field offset: 0x190
	public readonly Friends_Accept friends_Accept; //Field offset: 0x198
	public readonly Friends_Remove friends_Remove; //Field offset: 0x1A0
	public readonly Friends_Block friends_Block; //Field offset: 0x1A8
	public readonly Friends_List friends_List; //Field offset: 0x1B0
	public readonly Friends_Update friends_Update; //Field offset: 0x1B8
	public readonly Friends_SetGameState friends_SetGameState; //Field offset: 0x1C0
	public readonly Friends_Settings friends_Settings; //Field offset: 0x1C8
	public readonly Invitation_Send invitation_Send; //Field offset: 0x1D0
	public readonly Invitation_Get invitation_Get; //Field offset: 0x1D8
	public readonly Invitation_Remove invitation_Remove; //Field offset: 0x1E0
	public readonly Utils_ESCreate utils_ESCreate; //Field offset: 0x1E8
	public readonly Utils_ESUpdate utils_ESUpdate; //Field offset: 0x1F0
	public readonly Support_GiftCodeRedeem support_GiftCodeRedeem; //Field offset: 0x1F8

	public private string DisplayName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public bool IsPersonalAccount
	{
		 get { } //Length: 30
	}

	public private string SessionID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal LiNKAccount(HttpRequestFactory requestFactory, Authority authority, Identity identity, ApiOptions options) { }

	[CompilerGenerated]
	public string get_DisplayName() { }

	public bool get_IsPersonalAccount() { }

	[CompilerGenerated]
	public string get_SessionID() { }

	public Task<UserModel> LinkNewAuthProvider(AuthenticationProviderToken token) { }

	[CompilerGenerated]
	private void set_DisplayName(string value) { }

	[CompilerGenerated]
	private void set_SessionID(string value) { }

	[AsyncStateMachine(typeof(<UpdateDisplayName>d__70))]
	public Task UpdateDisplayName(string newDisplayName) { }

	public void UpdateIdentity(Identity newIdentity) { }

}

