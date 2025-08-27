namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

[Extension]
public static class LiNKGuilds
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GuildMemberModel, Boolean> <>9__76_0; //Field offset: 0x8
		public static Func<CtTileFocus, DateTime> <>9__90_1; //Field offset: 0x10
		public static Func<CtTileFocus, Int32> <>9__90_4; //Field offset: 0x18
		public static Func<CtTileFocus, Boolean> <>9__118_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal DateTime <Call_GuildSetCtTileFocus>b__90_1(CtTileFocus x) { }

		internal int <Call_GuildSetCtTileFocus>b__90_4(CtTileFocus x) { }

		internal bool <FocusMarkersForCurrentEvent>b__118_0(CtTileFocus x) { }

		internal bool <Task_GetLiNKGuildData>b__76_0(GuildMemberModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public string LiNKID; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <IsTeamMember>b__0(GuildMemberModel e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public string LiNKID; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <CanInviteToGuild>b__0(GuildMemberModel e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public String[] liNKIDs; //Field offset: 0x10

		public <>c__DisplayClass77_0() { }

		internal bool <Call>b__0(GuildMemberModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public string removedViceMayorLiNKID; //Field offset: 0x10

		public <>c__DisplayClass89_0() { }

		internal bool <Call_UpdateCtFocusMarkersOnRemovedViceMayor>b__0(CtTileFocus x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_0
	{
		public string eventId; //Field offset: 0x10
		public int tileId; //Field offset: 0x18

		public <>c__DisplayClass90_0() { }

		internal bool <Call_GuildSetCtTileFocus>b__0(CtTileFocus x) { }

		internal bool <Call_GuildSetCtTileFocus>b__2(CtTileFocus x) { }

		internal bool <Call_GuildSetCtTileFocus>b__3(CtTileFocus x) { }

	}

	[CompilerGenerated]
	private struct <Call_AcceptGuildInvite>d__98 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x20
		public string invitationToken; //Field offset: 0x28
		public string invitationId; //Field offset: 0x30
		private OnlineProfileModel <onlineData>5__2; //Field offset: 0x38
		private GuildMembershipState <membershipState>5__3; //Field offset: 0x40
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x48
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x50
		private int <>7__wrap3; //Field offset: 0x58
		private Exception <ex>5__5; //Field offset: 0x60
		private TaskAwaiter<DateTime> <>u__3; //Field offset: 0x68
		private TaskAwaiter<OnlineProfileModel> <>u__4; //Field offset: 0x70
		private TaskAwaiter<GuildMembershipState> <>u__5; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_CheckGuildName>d__103 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildNameAvailability> <>t__builder; //Field offset: 0x8
		public string guildName; //Field offset: 0x20
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x28
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GetGuildModel>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildModel> <>t__builder; //Field offset: 0x8
		public string guideId; //Field offset: 0x20
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x28
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GetGuildModels>d__92 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IEnumerable`1<GuildModel>> <>t__builder; //Field offset: 0x8
		public String[] guildIds; //Field offset: 0x20
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x28
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GetGuildSafeName>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x20
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GetPlayersGuildInfo>d__104 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Guild_GetMemberResponse> <>t__builder; //Field offset: 0x8
		public string memberLiNKId; //Field offset: 0x20
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x28
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GuildApplyTeamIslandCosmetics>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Dictionary<TeamStoreWorldSlot, List`1<String>> worldProps; //Field offset: 0x20
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x28
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GuildCreate>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildModel> <>t__builder; //Field offset: 0x8
		public string guildName; //Field offset: 0x20
		public GuildStatus status; //Field offset: 0x28
		public string tagLine; //Field offset: 0x30
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x38
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GuildEditDetails>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string newGuildName; //Field offset: 0x20
		public string guildID; //Field offset: 0x28
		public GuildStatus newStatus; //Field offset: 0x30
		public string newTagLine; //Field offset: 0x38
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x40
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GuildInfoAndMembersInfo>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Tuple`2<GuildModel, GuildMemberModel[]>> <>t__builder; //Field offset: 0x8
		public string guideId; //Field offset: 0x20
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x28
		public int limit; //Field offset: 0x30
		public int offset; //Field offset: 0x34
		private GuildModel <guildModel>5__2; //Field offset: 0x38
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x40
		private TaskAwaiter<GuildMemberModel[]> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GuildJoin>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildMembershipState> <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x20
		public bool quickJoining; //Field offset: 0x28
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x30
		private OnlineProfileModel <onlineData>5__2; //Field offset: 0x38
		private GuildServerResponse <serverResponce>5__3; //Field offset: 0x40
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x58
		private TaskAwaiter<OnlineProfileModel> <>u__2; //Field offset: 0x60
		private TaskAwaiter<GuildServerResponse> <>u__3; //Field offset: 0x68
		private TaskAwaiter<Boolean> <>u__4; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GuildLeave>d__84 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x20
		private bool <wasMember>5__2; //Field offset: 0x28
		private GuildServerResponse <serverResponse>5__3; //Field offset: 0x30
		private KickResult <isFailedResult>5__4; //Field offset: 0x48
		private KickResult <kickResult>5__5; //Field offset: 0x4C
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x50
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GuildListMembersInfo>d__93 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildMemberModel[]> <>t__builder; //Field offset: 0x8
		public string guideId; //Field offset: 0x20
		public int limit; //Field offset: 0x28
		public int offset; //Field offset: 0x2C
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x30
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GuildSetCtTileFocus>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtTileFocusResult> <>t__builder; //Field offset: 0x8
		public string eventId; //Field offset: 0x20
		public int tileId; //Field offset: 0x28
		private <>c__DisplayClass90_0 <>8__1; //Field offset: 0x30
		public string selectedMap; //Field offset: 0x38
		private CtTileFocusResult <result>5__2; //Field offset: 0x40
		private GuildMetadata <guildMetadata>5__3; //Field offset: 0x48
		private CtTileFocusResult <>7__wrap3; //Field offset: 0x50
		private CtTileFocusResult <>7__wrap4; //Field offset: 0x58
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x60
		private TaskAwaiter<GuildServerResponse> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_GuildToggleHideCode>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public bool hideCode; //Field offset: 0x20
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_KickOrUndoKick>d__107 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<KickResult> <>t__builder; //Field offset: 0x8
		public GuildsCall callType; //Field offset: 0x20
		public string guildID; //Field offset: 0x28
		public string memberLiNKID; //Field offset: 0x30
		private KickResult <kickResult>5__2; //Field offset: 0x38
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_PostPubSubGuildBossRushMessage>d__110 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string eventId; //Field offset: 0x20
		public int stage; //Field offset: 0x28
		public int scoreIncrement; //Field offset: 0x2C
		public bool isKillingBlow; //Field offset: 0x30
		public bool isIncrement; //Field offset: 0x31
		public BossType bossType; //Field offset: 0x34
		public Nullable<UInt64> scoreId; //Field offset: 0x38
		private TaskAwaiter<PubSubMessageModel> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_PostPubSubGuildContestedTerritoryMessage>d__109 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public SetScoreResponse captureEvent; //Field offset: 0x20
		public ContestedTerritoryIslandTile tile; //Field offset: 0x28
		public string eventId; //Field offset: 0x30
		private PubSubMessageModel <responce>5__2; //Field offset: 0x38
		private TaskAwaiter<PubSubMessageModel> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_PostPubSubGuildMessage>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string guildID; //Field offset: 0x20
		public GuildMessageEvent guildMessageEvent; //Field offset: 0x28
		private PubSubMessageModel <responce>5__2; //Field offset: 0x30
		private TaskAwaiter<PubSubMessageModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_SearchForGuilds>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Response> <>t__builder; //Field offset: 0x8
		public string searchQuery; //Field offset: 0x20
		public int limit; //Field offset: 0x28
		public int offset; //Field offset: 0x2C
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x30
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_SendGuildInvite>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string playerToInvite; //Field offset: 0x20
		private bool <successful>5__2; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter<GuildServerResponse> <>u__2; //Field offset: 0x38
		private TaskAwaiter<List`1<Invitation>> <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_TransferGuildOwnership>d__105 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildModel> <>t__builder; //Field offset: 0x8
		public string guildID; //Field offset: 0x20
		public string newOwnerId; //Field offset: 0x28
		public ButtonsInteractableCallback interactableCallback; //Field offset: 0x30
		private GuildServerResponse <serverResponce>5__2; //Field offset: 0x38
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x50
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_UpdateCtFocusMarkersOnRemovedViceMayor>d__89 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string removedViceMayorLiNKID; //Field offset: 0x20
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call_UpdateGuildMemberMembership>d__106 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public GuildsCall callType; //Field offset: 0x20
		public string guildID; //Field offset: 0x28
		public string memberLiNKID; //Field offset: 0x30
		public GuildMembershipState permissionsToAdd; //Field offset: 0x38
		public bool accept; //Field offset: 0x3C
		private TaskAwaiter<GuildServerResponse> <>u__1; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildServerResponse> <>t__builder; //Field offset: 0x8
		public String[] liNKIDs; //Field offset: 0x20
		public ButtonsInteractableCallback buttonsInteractableCallback; //Field offset: 0x28
		public GuildsCall callType; //Field offset: 0x30
		public string guildID; //Field offset: 0x38
		public string memberLiNKID; //Field offset: 0x40
		public bool accept; //Field offset: 0x48
		public GuildMembershipState permissionsToAdd; //Field offset: 0x4C
		public string newGuildName; //Field offset: 0x50
		public GuildStatus newStatus; //Field offset: 0x58
		public string newTagLine; //Field offset: 0x60
		public string newOwnerID; //Field offset: 0x68
		public string searchQuery; //Field offset: 0x70
		public int limit; //Field offset: 0x78
		public int offset; //Field offset: 0x7C
		public String[] guildIds; //Field offset: 0x80
		private <>c__DisplayClass77_0 <>8__1; //Field offset: 0x88
		public bool showErrors; //Field offset: 0x90
		private GuildServerResponse <data>5__2; //Field offset: 0x98
		private TaskAwaiter <>u__1; //Field offset: 0xB0
		private TaskAwaiter<KickResponse> <>u__2; //Field offset: 0xB8
		private TaskAwaiter<EmptyResponse> <>u__3; //Field offset: 0xC0
		private TaskAwaiter<GuildMembershipState> <>u__4; //Field offset: 0xC8
		private TaskAwaiter<GuildModel> <>u__5; //Field offset: 0xD0
		private TaskAwaiter<Response> <>u__6; //Field offset: 0xD8
		private TaskAwaiter<GuildNameAvailability> <>u__7; //Field offset: 0xE0
		private TaskAwaiter<String> <>u__8; //Field offset: 0xE8
		private TaskAwaiter<Guild_GetMemberResponse> <>u__9; //Field offset: 0xF0
		private TaskAwaiter<IEnumerable`1<GuildModel>> <>u__10; //Field offset: 0xF8
		private TaskAwaiter<GuildMemberModel[]> <>u__11; //Field offset: 0x100

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConvertInvitationList>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public List<Invitation> invitationResults; //Field offset: 0x20
		private Enumerator<Invitation> <>7__wrap1; //Field offset: 0x28
		private Invitation <invitation>5__3; //Field offset: 0x40
		private TaskAwaiter<List`1<Invitation>> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGuildInvites>d__99 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, Invitation>> <>t__builder; //Field offset: 0x8
		public bool showErrors; //Field offset: 0x20
		private List<Invitation> <invitationResults>5__2; //Field offset: 0x28
		private TaskAwaiter<List`1<Invitation>> <>u__1; //Field offset: 0x30
		private List<Invitation> <invitationsToRemove>5__3; //Field offset: 0x38
		private Enumerator<Invitation> <>7__wrap3; //Field offset: 0x40
		private Invitation <invitation>5__5; //Field offset: 0x58
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x60
		private TaskAwaiter <>u__3; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGuildMetadataWithId>d__116 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildMetadata> <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x20
		private GuildMetadata <metaData>5__2; //Field offset: 0x28
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLiNKGuildData>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public bool forceRefresh; //Field offset: 0x20
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RemoveGuildInvite>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string invitationId; //Field offset: 0x20
		private TaskAwaiter<List`1<Invitation>> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Task_GetLiNKGuildData>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildModel> <>t__builder; //Field offset: 0x8
		public bool forceRefresh; //Field offset: 0x20
		private Guild_GetMemberResponse <guildMemberResponse>5__2; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Invitation>> <>u__1; //Field offset: 0x30
		private TaskAwaiter<GuildServerResponse> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class ButtonsInteractableCallback : MulticastDelegate
	{

		public ButtonsInteractableCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool interactable, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool interactable) { }

	}

	internal class CtTileFocus
	{
		public string eventId; //Field offset: 0x10
		public int tileId; //Field offset: 0x18
		public string selectedMap; //Field offset: 0x20
		public string LiNKID; //Field offset: 0x28
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime createdAt; //Field offset: 0x30

		public CtTileFocus(string eventId, int tileId, string selectedMap, string LiNKID) { }

	}

	internal class CtTileFocusResult
	{
		public bool success; //Field offset: 0x10
		public List<Int32> selectedTileIds; //Field offset: 0x18

		public CtTileFocusResult() { }

	}

	internal class GuildMessageBossRushEvent : GuildMessageTeamEvent
	{
		public int score; //Field offset: 0x20
		public int stage; //Field offset: 0x24
		public bool isKillingBlow; //Field offset: 0x28
		public bool isIncrement; //Field offset: 0x29
		public BossType bossType; //Field offset: 0x2C
		public Nullable<UInt64> scoreId; //Field offset: 0x30
		public string avatar; //Field offset: 0x40

		public GuildMessageBossRushEvent() { }

	}

	internal class GuildMessageCtEvent : GuildMessageTeamEvent
	{
		public Nullable<Int32> tileType; //Field offset: 0x20
		public string selectedDifficulty; //Field offset: 0x28
		public string selectedMode; //Field offset: 0x30
		public string selectedMap; //Field offset: 0x38
		public Nullable<Int32> subGameType; //Field offset: 0x40
		public string knowledgeItemName; //Field offset: 0x48
		public bool isBossTile; //Field offset: 0x50
		public bool isCtEventFocus; //Field offset: 0x51
		public NodeStatus currentTileState; //Field offset: 0x58
		public NodeStatus previousTileState; //Field offset: 0x60
		public int tileId; //Field offset: 0x68
		public Int32[] focusedTileIds; //Field offset: 0x70

		public GuildMessageCtEvent() { }

	}

	internal class GuildMessageEvent
	{
		public GuildsCall eventType; //Field offset: 0x10
		public string guildId; //Field offset: 0x18
		public string affectedMemberLiNKId; //Field offset: 0x20
		public bool isTeamMsgFlairUnlockedEvent; //Field offset: 0x28
		public TeamStoreWorldSlot slotType; //Field offset: 0x2C
		public string cosmeticId; //Field offset: 0x30
		[JsonProperty("isCompR")]
		public bool isCompetitiveRequest; //Field offset: 0x38

		public GuildMessageEvent() { }

	}

	internal class GuildMessageTeamEvent
	{
		public string eventId; //Field offset: 0x10
		public string playerLiNKId; //Field offset: 0x18

		public GuildMessageTeamEvent() { }

	}

	internal class GuildMetadata : BaseGuildMetadata
	{
		public string iconId; //Field offset: 0x18
		public string frameId; //Field offset: 0x20
		public string bannerId; //Field offset: 0x28
		public bool hideTeamCode; //Field offset: 0x30
		public List<CtTileFocus> focusTiles; //Field offset: 0x38
		public TeamIslandCosmeticData islandCosmeticData; //Field offset: 0x40

		public GuildMetadata() { }

		public bool EqualsDisplay(GuildMetadata other) { }

	}

	[Flags]
	internal enum GuildsCall
	{
		Join = 0,
		Create = 1,
		AcceptMember = 2,
		RejectMember = 4,
		FindMembers = 8,
		ListMembers = 16,
		MemberAddPermission = 32,
		MemberRemovePermission = 64,
		RemoveMember = 128,
		Update = 256,
		UpdatePermission = 512,
		GetPlayersGuildInfo = 1024,
		GetGuildInfo = 2048,
		GetGuildInfos = 4096,
		CheckGuildName = 8192,
		SearchGuilds = 16384,
		UpdateOwner = 32768,
		GetSafeName = 65536,
		GetInviteCode = 131072,
		UndoRemoveMember = 262144,
	}

	internal struct GuildServerResponse
	{
		public bool successful; //Field offset: 0x0
		public bool errorThrown; //Field offset: 0x1
		public object response; //Field offset: 0x8
		public bool isInternetException; //Field offset: 0x10

	}

	internal class JsonGuildInvite
	{
		public string guildId; //Field offset: 0x10
		public string inviteToken; //Field offset: 0x18

		public JsonGuildInvite() { }

	}

	internal class TeamIslandCosmeticData
	{
		public string slotBuilding; //Field offset: 0x10
		public string slotFlying; //Field offset: 0x18
		public string slotWater; //Field offset: 0x20
		public string slotFlag; //Field offset: 0x28
		public string slot1; //Field offset: 0x30
		public string slot2; //Field offset: 0x38
		public string slot3; //Field offset: 0x40
		public string slot4; //Field offset: 0x48

		public TeamIslandCosmeticData() { }

		public TeamIslandCosmeticData(Dictionary<TeamStoreWorldSlot, List`1<String>> cometicData) { }

		public Dictionary<TeamStoreWorldSlot, List`1<String>> ConvertFormat() { }

	}

	[CompilerGenerated]
	private static bool <HasValidGuildKey>k__BackingField; //Field offset: 0x0
	private static TimeSpan lastRefresh; //Field offset: 0x8
	private static GuildModel _myGuildModel; //Field offset: 0x10
	[CompilerGenerated]
	private static GuildMemberModel <MyGuildMemberModel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private static GuildMemberModel[] <MyGuildMembersList>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private static Dictionary<String, Invitation> <MyGuildInvitations>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private static GuildMetadata <MyGuildMetaData>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private static Dictionary<TeamStoreWorldSlot, List`1<String>> <MyGuildSelectedWorldProps>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private static DateTime <LatestRecievedInvite>k__BackingField; //Field offset: 0x40
	private static Tuple<Boolean, Task`1<GuildModel>> guildDataTask; //Field offset: 0x48
	private static readonly GuildsCall GuildClearCacheFlag; //Field offset: 0x50
	public static Action OnGuildDataCleared; //Field offset: 0x58
	[CompilerGenerated]
	private static bool <IsLeavingGuild>k__BackingField; //Field offset: 0x60

	public static bool AreWeModeratorOfGuild
	{
		 get { } //Length: 143
	}

	public static bool AreWeOwnerOfGuild
	{
		 get { } //Length: 182
	}

	public static bool CanUseGuilds
	{
		 get { } //Length: 286
	}

	public static bool HasGuildInvites
	{
		 get { } //Length: 262
	}

	public private static bool HasValidGuildKey
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 83
	}

	public static bool IsApplingToATeam
	{
		 get { } //Length: 232
	}

	public static bool IsInTeam
	{
		 get { } //Length: 232
	}

	public private static bool IsLeavingGuild
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public private static DateTime LatestRecievedInvite
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public static Api LiNK
	{
		 get { } //Length: 91
	}

	public static LiNKAccount LiNKAccount
	{
		 get { } //Length: 91
	}

	public static string MyGuildId
	{
		 get { } //Length: 139
	}

	public private static Dictionary<String, Invitation> MyGuildInvitations
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public private static GuildMemberModel MyGuildMemberModel
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public private static GuildMemberModel[] MyGuildMembersList
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public private static GuildMetadata MyGuildMetaData
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public private static GuildModel MyGuildModel
	{
		 get { } //Length: 79
		private set { } //Length: 422
	}

	public private static Dictionary<TeamStoreWorldSlot, List`1<String>> MyGuildSelectedWorldProps
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public static Btd6Player MyPlayer
	{
		 get { } //Length: 7
	}

	public static ProfileModel MyPlayerData
	{
		 get { } //Length: 101
	}

	public static string MyPlayerID
	{
		 get { } //Length: 151
	}

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	public static bool ShowInvitationPip
	{
		 get { } //Length: 470
	}

	public static TeamSettings TeamSettingsSku
	{
		 get { } //Length: 150
	}

	public static TimeSpan Timeout
	{
		 get { } //Length: 159
	}

	private static LiNKGuilds() { }

	[AsyncStateMachine(typeof(<Call>d__77))]
	private static Task<GuildServerResponse> Call(GuildsCall callType, string guildID = "", string memberLiNKID = "", string newGuildName = "", string newOwnerID = "", string newTagLine = "", int limit = 0, int offset = 0, bool accept = false, String[] liNKIDs = null, GuildStatus newStatus = 1, GuildMembershipState permissionsToAdd = 16, string searchQuery = "", ButtonsInteractableCallback buttonsInteractableCallback = null, bool showErrors = true, String[] guildIds = null) { }

	[AsyncStateMachine(typeof(<Call_AcceptGuildInvite>d__98))]
	public static Task<Boolean> Call_AcceptGuildInvite(string guildId, string invitationId, string invitationToken) { }

	[AsyncStateMachine(typeof(<Call_CheckGuildName>d__103))]
	public static Task<GuildNameAvailability> Call_CheckGuildName(string guildName, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GetGuildModel>d__91))]
	public static Task<GuildModel> Call_GetGuildModel(string guideId, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GetGuildModels>d__92))]
	public static Task<IEnumerable`1<GuildModel>> Call_GetGuildModels(String[] guildIds, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GetGuildSafeName>d__96))]
	public static Task<String> Call_GetGuildSafeName(ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GetPlayersGuildInfo>d__104))]
	public static Task<Guild_GetMemberResponse> Call_GetPlayersGuildInfo(string memberLiNKId, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GuildApplyTeamIslandCosmetics>d__87))]
	public static Task<Boolean> Call_GuildApplyTeamIslandCosmetics(Dictionary<TeamStoreWorldSlot, List`1<String>> worldProps, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GuildCreate>d__78))]
	public static Task<GuildModel> Call_GuildCreate(string guildName, string tagLine, GuildStatus status = 1, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GuildEditDetails>d__85))]
	public static Task<Boolean> Call_GuildEditDetails(string guildID, string newGuildName, string newTagLine, GuildStatus newStatus, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GuildInfoAndMembersInfo>d__94))]
	public static Task<Tuple`2<GuildModel, GuildMemberModel[]>> Call_GuildInfoAndMembersInfo(string guideId, int limit = 20, int offset = 0, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GuildJoin>d__79))]
	public static Task<GuildMembershipState> Call_GuildJoin(string guildId, bool quickJoining = false, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GuildLeave>d__84))]
	public static Task<Boolean> Call_GuildLeave(ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GuildListMembersInfo>d__93))]
	public static Task<GuildMemberModel[]> Call_GuildListMembersInfo(string guideId, int limit = 20, int offset = 0, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_GuildSetCtTileFocus>d__90))]
	public static Task<CtTileFocusResult> Call_GuildSetCtTileFocus(string eventId, int tileId, string selectedMap) { }

	[AsyncStateMachine(typeof(<Call_GuildToggleHideCode>d__86))]
	public static Task<Boolean> Call_GuildToggleHideCode(bool hideCode) { }

	[AsyncStateMachine(typeof(<Call_KickOrUndoKick>d__107))]
	public static Task<KickResult> Call_KickOrUndoKick(GuildsCall callType, string guildID, string memberLiNKID) { }

	[AsyncStateMachine(typeof(<Call_PostPubSubGuildBossRushMessage>d__110))]
	public static Task Call_PostPubSubGuildBossRushMessage(string eventId, int scoreIncrement, bool isKillingBlow, bool isIncrement, int stage, BossType bossType, Nullable<UInt64> scoreId) { }

	[AsyncStateMachine(typeof(<Call_PostPubSubGuildContestedTerritoryMessage>d__109))]
	public static Task<Boolean> Call_PostPubSubGuildContestedTerritoryMessage(string eventId, ContestedTerritoryIslandTile tile, SetScoreResponse captureEvent) { }

	[AsyncStateMachine(typeof(<Call_PostPubSubGuildMessage>d__108))]
	public static Task<Boolean> Call_PostPubSubGuildMessage(string guildID, GuildMessageEvent guildMessageEvent) { }

	public static Task Call_PostPubSubPlayingBossRush(string eventId, int stage) { }

	[AsyncStateMachine(typeof(<Call_SearchForGuilds>d__95))]
	public static Task<Response> Call_SearchForGuilds(string searchQuery, int limit, int offset, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_SendGuildInvite>d__97))]
	public static Task<Boolean> Call_SendGuildInvite(string playerToInvite, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_TransferGuildOwnership>d__105))]
	public static Task<GuildModel> Call_TransferGuildOwnership(string guildID, string newOwnerId, ButtonsInteractableCallback interactableCallback = null) { }

	[AsyncStateMachine(typeof(<Call_UpdateCtFocusMarkersOnRemovedViceMayor>d__89))]
	public static Task<Boolean> Call_UpdateCtFocusMarkersOnRemovedViceMayor(string removedViceMayorLiNKID) { }

	[AsyncStateMachine(typeof(<Call_UpdateGuildMemberMembership>d__106))]
	public static Task<Boolean> Call_UpdateGuildMemberMembership(GuildsCall callType, string guildID, string memberLiNKID, GuildMembershipState permissionsToAdd = 48, bool accept = false) { }

	public static bool CanInviteToGuild(string LiNKID) { }

	private static void ClearGuildData() { }

	[AsyncStateMachine(typeof(<ConvertInvitationList>d__101))]
	private static Task ConvertInvitationList(List<Invitation> invitationResults) { }

	public static IEnumerable<CtTileFocus> FocusMarkersForCurrentEvent() { }

	public static bool get_AreWeModeratorOfGuild() { }

	public static bool get_AreWeOwnerOfGuild() { }

	public static bool get_CanUseGuilds() { }

	public static bool get_HasGuildInvites() { }

	[CompilerGenerated]
	public static bool get_HasValidGuildKey() { }

	public static bool get_IsApplingToATeam() { }

	public static bool get_IsInTeam() { }

	[CompilerGenerated]
	public static bool get_IsLeavingGuild() { }

	[CompilerGenerated]
	public static DateTime get_LatestRecievedInvite() { }

	public static Api get_LiNK() { }

	public static LiNKAccount get_LiNKAccount() { }

	public static string get_MyGuildId() { }

	[CompilerGenerated]
	public static Dictionary<String, Invitation> get_MyGuildInvitations() { }

	[CompilerGenerated]
	public static GuildMemberModel get_MyGuildMemberModel() { }

	[CompilerGenerated]
	public static GuildMemberModel[] get_MyGuildMembersList() { }

	[CompilerGenerated]
	public static GuildMetadata get_MyGuildMetaData() { }

	public static GuildModel get_MyGuildModel() { }

	[CompilerGenerated]
	public static Dictionary<TeamStoreWorldSlot, List`1<String>> get_MyGuildSelectedWorldProps() { }

	public static Btd6Player get_MyPlayer() { }

	public static ProfileModel get_MyPlayerData() { }

	public static string get_MyPlayerID() { }

	private static TimeSpan get_Now() { }

	public static bool get_ShowInvitationPip() { }

	public static TeamSettings get_TeamSettingsSku() { }

	public static TimeSpan get_Timeout() { }

	public static GuildsCall GetEventType(string callType) { }

	[AsyncStateMachine(typeof(<GetGuildInvites>d__99))]
	public static Task<Dictionary`2<String, Invitation>> GetGuildInvites(bool showErrors = true) { }

	[Extension]
	public static GuildMessageBossRushEvent GetGuildMessageBossRushEvent(GuildMessage message) { }

	[Extension]
	public static GuildMessageCtEvent GetGuildMessageCtEventData(GuildMessage message) { }

	[Extension]
	public static GuildMessageEvent GetGuildMessageEventData(GuildMessage message) { }

	public static GuildMetadata GetGuildMetadata(GuildModel guildModel) { }

	[AsyncStateMachine(typeof(<GetGuildMetadataWithId>d__116))]
	public static Task<GuildMetadata> GetGuildMetadataWithId(string guildId) { }

	[AsyncStateMachine(typeof(<GetLiNKGuildData>d__75))]
	public static Task<Boolean> GetLiNKGuildData(bool forceRefresh = false) { }

	public static string GetPubSubBossRushActivityChannel() { }

	public static Dictionary<TeamStoreWorldSlot, List`1<String>> GetTeamsStoreSelectedWorldProps(GuildModel guildModel) { }

	public static string GetWarningLocKey(GuildsCall callType) { }

	public static bool HasPendingInvitationToGuild(string guildId) { }

	public static bool HasSentTeamInvitationToPlayerAlready(string LiNKID) { }

	public static bool IsInternetException(Exception exception) { }

	public static bool IsTeamCtBlacklisted(string teamId) { }

	public static bool IsTeamMember(string LiNKID) { }

	public static JsonGuildInvite ParseGuildInviteCode(string invitationMetaData) { }

	[AsyncStateMachine(typeof(<RemoveGuildInvite>d__100))]
	public static Task<Boolean> RemoveGuildInvite(string invitationId) { }

	public static void Reset() { }

	[CompilerGenerated]
	private static void set_HasValidGuildKey(bool value) { }

	[CompilerGenerated]
	private static void set_IsLeavingGuild(bool value) { }

	[CompilerGenerated]
	private static void set_LatestRecievedInvite(DateTime value) { }

	[CompilerGenerated]
	private static void set_MyGuildInvitations(Dictionary<String, Invitation> value) { }

	[CompilerGenerated]
	private static void set_MyGuildMemberModel(GuildMemberModel value) { }

	[CompilerGenerated]
	private static void set_MyGuildMembersList(GuildMemberModel[] value) { }

	[CompilerGenerated]
	private static void set_MyGuildMetaData(GuildMetadata value) { }

	private static void set_MyGuildModel(GuildModel value) { }

	[CompilerGenerated]
	private static void set_MyGuildSelectedWorldProps(Dictionary<TeamStoreWorldSlot, List`1<String>> value) { }

	public static void ShowGuildErrorPopupMessage(Exception ex, string debugInfo = null, bool showErrors = true) { }

	[AsyncStateMachine(typeof(<Task_GetLiNKGuildData>d__76))]
	private static Task<GuildModel> Task_GetLiNKGuildData(bool forceRefresh) { }

	public static void TryRegisterCtInstanceToPreventTeamHopping() { }

}

