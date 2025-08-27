namespace NinjaKiwi.LiNK;

public class Api
{
	[CompilerGenerated]
	private struct <GetIdentity>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Identity> <>t__builder; //Field offset: 0x8
		public AuthenticationProviderToken authenticationProviderToken; //Field offset: 0x20
		public Api <>4__this; //Field offset: 0x28
		private TaskAwaiter<UserModel> <>u__1; //Field offset: 0x30
		private TaskAwaiter<Identity> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoginToIdentity>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Identity> <>t__builder; //Field offset: 0x8
		public AuthenticationProviderToken authenticationProviderToken; //Field offset: 0x20
		public Api <>4__this; //Field offset: 0x28
		private TaskAwaiter<LoginResponseModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshServerTime>d__104 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DateTime> <>t__builder; //Field offset: 0x8
		public Api <>4__this; //Field offset: 0x20
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct Matchmaking_LobbySystem
	{
		[CompilerGenerated]
		private Matchmaking_Create <Create>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Matchmaking_Find <Find>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Matchmaking_FindLocal <FindLocal>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Matchmaking_Join <Join>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private Matchmaking_Leave <Leave>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private Matchmaking_Purge <Purge>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private Matchmaking_Migrate <Migrate>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private Matchmaking_Region <Region>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private Matchmaking_Delete <Delete>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private Matchmaking_GetInfo <GetInfo>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private Matchmaking_GetGroups <GetGroups>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private Matchmaking_JoinGroup <JoinGroup>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private Matchmaking_SendInvites <SendInvites>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private Matchmaking_GetInvites <GetInvites>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private Matchmaking_RemoveInvites <RemoveInvites>k__BackingField; //Field offset: 0x70
		[CompilerGenerated]
		private Matchmaking_Swarm_Find <SwarmFind>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private Matchmaking_UpdateMetadata <UpdateMetadata>k__BackingField; //Field offset: 0x80

		public internal Matchmaking_Create Create
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			internal set { } //Length: 4
		}

		public internal Matchmaking_Delete Delete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_Find Find
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_FindLocal FindLocal
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_GetGroups GetGroups
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_GetInfo GetInfo
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_GetInvites GetInvites
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_Join Join
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_JoinGroup JoinGroup
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_Leave Leave
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_Migrate Migrate
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_Purge Purge
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_Region Region
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_RemoveInvites RemoveInvites
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_SendInvites SendInvites
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_Swarm_Find SwarmFind
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 70
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_UpdateMetadata UpdateMetadata
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			internal set { } //Length: 8
		}

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Create get_Create() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Delete get_Delete() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Find get_Find() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_FindLocal get_FindLocal() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_GetGroups get_GetGroups() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_GetInfo get_GetInfo() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_GetInvites get_GetInvites() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Join get_Join() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_JoinGroup get_JoinGroup() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Leave get_Leave() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Migrate get_Migrate() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Purge get_Purge() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Region get_Region() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_RemoveInvites get_RemoveInvites() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_SendInvites get_SendInvites() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Swarm_Find get_SwarmFind() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_UpdateMetadata get_UpdateMetadata() { }

		[CompilerGenerated]
		internal void set_Create(Matchmaking_Create value) { }

		[CompilerGenerated]
		internal void set_Delete(Matchmaking_Delete value) { }

		[CompilerGenerated]
		internal void set_Find(Matchmaking_Find value) { }

		[CompilerGenerated]
		internal void set_FindLocal(Matchmaking_FindLocal value) { }

		[CompilerGenerated]
		internal void set_GetGroups(Matchmaking_GetGroups value) { }

		[CompilerGenerated]
		internal void set_GetInfo(Matchmaking_GetInfo value) { }

		[CompilerGenerated]
		internal void set_GetInvites(Matchmaking_GetInvites value) { }

		[CompilerGenerated]
		internal void set_Join(Matchmaking_Join value) { }

		[CompilerGenerated]
		internal void set_JoinGroup(Matchmaking_JoinGroup value) { }

		[CompilerGenerated]
		internal void set_Leave(Matchmaking_Leave value) { }

		[CompilerGenerated]
		internal void set_Migrate(Matchmaking_Migrate value) { }

		[CompilerGenerated]
		internal void set_Purge(Matchmaking_Purge value) { }

		[CompilerGenerated]
		internal void set_Region(Matchmaking_Region value) { }

		[CompilerGenerated]
		internal void set_RemoveInvites(Matchmaking_RemoveInvites value) { }

		[CompilerGenerated]
		internal void set_SendInvites(Matchmaking_SendInvites value) { }

		[CompilerGenerated]
		internal void set_SwarmFind(Matchmaking_Swarm_Find value) { }

		[CompilerGenerated]
		internal void set_UpdateMetadata(Matchmaking_UpdateMetadata value) { }

	}

	internal struct Matchmaking_QuickMatchSystem
	{
		[CompilerGenerated]
		private Matchmaking_Play <Play>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Matchmaking_Cancel <Cancel>k__BackingField; //Field offset: 0x8

		public internal Matchmaking_Cancel Cancel
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Matchmaking_Play Play
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			internal set { } //Length: 4
		}

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Cancel get_Cancel() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Matchmaking_Play get_Play() { }

		[CompilerGenerated]
		internal void set_Cancel(Matchmaking_Cancel value) { }

		[CompilerGenerated]
		internal void set_Play(Matchmaking_Play value) { }

	}

	[IsReadOnly]
	internal struct Parameters
	{
		public readonly int appID; //Field offset: 0x0
		public readonly int skuID; //Field offset: 0x4
		public readonly string skuSignature; //Field offset: 0x8

		public Parameters(int appID, int skuID, string skuSignature) { }

	}

	public static readonly Version VERSION; //Field offset: 0x0
	public readonly Environments environment; //Field offset: 0x10
	public readonly ApiOptions options; //Field offset: 0x18
	public readonly Parameters apiParameters; //Field offset: 0x20
	public readonly GenericEndpoint genericEndpoint; //Field offset: 0x30
	public readonly Utils_GetTime utils_GetTime; //Field offset: 0x38
	public readonly Utils_ESSearch utils_ESSearch; //Field offset: 0x40
	public readonly Utils_ESFullSearch utils_ESFullSearch; //Field offset: 0x48
	public readonly Guild_GetInfo guild_GetInfo; //Field offset: 0x50
	public readonly Guild_ListAll guild_ListAll; //Field offset: 0x58
	public readonly Guild_GetInfoByName guild_GetInfoByName; //Field offset: 0x60
	public readonly Guild_Search guild_Search; //Field offset: 0x68
	public readonly Guild_CheckName guild_CheckName; //Field offset: 0x70
	public readonly Guild_GetMember guild_GetMember; //Field offset: 0x78
	public readonly Guild_GenerateName guild_GenerateName; //Field offset: 0x80
	public readonly User_Find user_Find; //Field offset: 0x88
	public readonly User_CreateChild user_CreateChild; //Field offset: 0x90
	public readonly User_CreateLiNK user_CreateLiNK; //Field offset: 0x98
	public readonly User_CreateMyNK user_CreateMyNK; //Field offset: 0xA0
	public readonly User_CreateKong user_CreateKong; //Field offset: 0xA8
	public readonly User_CreateFacebook user_CreateFacebook; //Field offset: 0xB0
	public readonly User_CreateGooglePlay user_CreateGooglePlay; //Field offset: 0xB8
	public readonly User_CreateGameCentre user_CreateGameCentre; //Field offset: 0xC0
	public readonly User_CreateSteam user_CreateSteam; //Field offset: 0xC8
	public readonly User_CreateXbox user_CreateXbox; //Field offset: 0xD0
	public readonly User_CreatePlaystation user_CreatePlaystation; //Field offset: 0xD8
	public readonly User_CreateApple user_CreateApple; //Field offset: 0xE0
	public readonly User_CreateAppleArcade user_CreateAppleArcade; //Field offset: 0xE8
	public readonly User_CreateEpic user_CreateEpic; //Field offset: 0xF0
	public readonly User_CreateNetflix user_CreateNetflix; //Field offset: 0xF8
	public readonly User_CreateNintendo user_CreateNintendo; //Field offset: 0x100
	public readonly User_LoginLiNK user_LoginLiNK; //Field offset: 0x108
	public readonly User_LoginMyNK user_LoginMyNK; //Field offset: 0x110
	public readonly User_LoginKong user_LoginKong; //Field offset: 0x118
	public readonly User_LoginFacebook user_LoginFacebook; //Field offset: 0x120
	public readonly User_LoginGooglePlay user_LoginGooglePlay; //Field offset: 0x128
	public readonly User_LoginGameCentre user_LoginGameCentre; //Field offset: 0x130
	public readonly User_LoginSteam user_LoginSteam; //Field offset: 0x138
	public readonly User_LoginXbox user_LoginXbox; //Field offset: 0x140
	public readonly User_LoginPlaystation user_LoginPlaystation; //Field offset: 0x148
	public readonly User_LoginApple user_LoginApple; //Field offset: 0x150
	public readonly User_LoginAppleArcade user_LoginAppleArcade; //Field offset: 0x158
	public readonly User_LoginEpic user_LoginEpic; //Field offset: 0x160
	public readonly User_LoginNetflix user_LoginNetflix; //Field offset: 0x168
	public readonly User_LoginLiNKCode user_LoginLiNKCode; //Field offset: 0x170
	public readonly User_SteamTicket user_SteamTicket; //Field offset: 0x178
	public readonly User_LoginNintendo user_LoginNintendo; //Field offset: 0x180
	public readonly Payment_AppleAttribution payment_AppleAttribution; //Field offset: 0x188
	public readonly Payment_VerifyAndroid payment_VerifyAndroid; //Field offset: 0x190
	public readonly Payment_VerifyIos payment_VerifyIos; //Field offset: 0x198
	public readonly Payment_VerifyEpic payment_VerifyEpic; //Field offset: 0x1A0
	public readonly Payment_NexusCreator payment_NexusCreator; //Field offset: 0x1A8
	public readonly Payment_NexusPlayerStatus payment_NexusPlayerStatus; //Field offset: 0x1B0
	public readonly Payment_SteamGetIAPs payment_SteamGetIAPs; //Field offset: 0x1B8
	public readonly Payment_SteamStart payment_SteamStart; //Field offset: 0x1C0
	public readonly Payment_SteamEnd payment_SteamEnd; //Field offset: 0x1C8
	public readonly Payment_GetSubscriptions payment_GetSubscriptions; //Field offset: 0x1D0
	public readonly Payment_MigrateSubscriptions payment_MigrateSubscriptions; //Field offset: 0x1D8
	public readonly MyNK_GetGameStore myNK_GetGameStore; //Field offset: 0x1E0
	public readonly MyNK_GetUserInfo myNK_GetUserInfo; //Field offset: 0x1E8
	public readonly MyNK_GetUserInventory myNK_GetUserInventory; //Field offset: 0x1F0
	public readonly MyNK_ItemBuy myNK_ItemBuy; //Field offset: 0x1F8
	public readonly MyNK_ItemConsume myNK_ItemConsume; //Field offset: 0x200
	public readonly MyNK_SetAchievement myNK_SetAchievement; //Field offset: 0x208
	public readonly Bank_GetWallet bank_GetWallet; //Field offset: 0x210
	public readonly Bank_GetWalletMulti bank_GetWalletMulti; //Field offset: 0x218
	public readonly Bank_SetWallet bank_SetWallet; //Field offset: 0x220
	public readonly Bank_AddToWallet bank_AddToWallet; //Field offset: 0x228
	public readonly Bank_PurchaseItem bank_PurchaseItem; //Field offset: 0x230
	public readonly Bank_ChangeWallets bank_ChangeWallets; //Field offset: 0x238
	public readonly Storage_SaveTemp storage_SaveTemp; //Field offset: 0x240
	public readonly Scores_GetNeighbours scores_GetNeighbours; //Field offset: 0x248
	public readonly Scores_GetRank scores_GetRank; //Field offset: 0x250
	public readonly Scores_GetRanks scores_GetRanks; //Field offset: 0x258
	public readonly Scores_GetScores scores_GetScores; //Field offset: 0x260
	public readonly Scores_GetTopX scores_GetTopX; //Field offset: 0x268
	public readonly Scores_Set scores_Set; //Field offset: 0x270
	public readonly Matchmaking_QuickMatchSystem matchmaking_Quick; //Field offset: 0x278
	public readonly Matchmaking_LobbySystem matchmaking; //Field offset: 0x288
	private readonly HttpRequestFactory requestFactory; //Field offset: 0x310
	private readonly Authority masterAuthority; //Field offset: 0x318
	private readonly OnlineUtility onlineUtility; //Field offset: 0x320
	[CompilerGenerated]
	private Nullable<DateTime> <ServerTime>k__BackingField; //Field offset: 0x328

	public event Action BackOnlineEvent
	{
		 add { } //Length: 180
		 remove { } //Length: 180
	}

	public bool DataTransferIsDisabled
	{
		 set { } //Length: 29
	}

	public string NoLiNKID
	{
		 get { } //Length: 30
	}

	public private Nullable<DateTime> ServerTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public TimeSpan TimeoutForNextRequest
	{
		 get { } //Length: 95
		 set { } //Length: 106
	}

	public TimeSpan TimeSinceLastOnline
	{
		 get { } //Length: 300
	}

	private static Api() { }

	public Api(string noLiNKID, int appID, int skuID, string skuSignature, Environments environment, ApiOptions apiOptions = null) { }

	public void add_BackOnlineEvent(Action value) { }

	public LiNKAccount CreateLiNKAccount(Identity identity) { }

	public string get_NoLiNKID() { }

	[CompilerGenerated]
	public Nullable<DateTime> get_ServerTime() { }

	public TimeSpan get_TimeoutForNextRequest() { }

	public TimeSpan get_TimeSinceLastOnline() { }

	[AsyncStateMachine(typeof(<GetIdentity>d__94))]
	public Task<Identity> GetIdentity(AuthenticationProviderToken authenticationProviderToken) { }

	private static Version GetVersion() { }

	public Task<Boolean> IsOnline(TimeSpan checkIfNotCheckedWithin) { }

	[AsyncStateMachine(typeof(<LoginToIdentity>d__95))]
	public Task<Identity> LoginToIdentity(AuthenticationProviderToken authenticationProviderToken) { }

	[AsyncStateMachine(typeof(<RefreshServerTime>d__104))]
	public Task<DateTime> RefreshServerTime() { }

	public void remove_BackOnlineEvent(Action value) { }

	public void set_DataTransferIsDisabled(bool value) { }

	[CompilerGenerated]
	private void set_ServerTime(Nullable<DateTime> value) { }

	public void set_TimeoutForNextRequest(TimeSpan value) { }

}

