namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

[Extension]
public static class LiNKFriends
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FriendModel, Boolean> <>9__15_0; //Field offset: 0x8
		public static Func<FriendModel, String> <>9__15_1; //Field offset: 0x10
		public static Func<String, String> <>9__15_2; //Field offset: 0x18
		public static Func<FriendModel, Boolean> <>9__26_0; //Field offset: 0x20
		public static Func<FriendModel, Boolean> <>9__30_0; //Field offset: 0x28
		public static Func<Task, Boolean> <>9__44_0; //Field offset: 0x30
		public static Func<FriendModel, Boolean> <>9__45_0; //Field offset: 0x38
		public static Func<FriendModel, String> <>9__45_1; //Field offset: 0x40
		public static Func<Task, Boolean> <>9__45_2; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal bool <CacheFriendsMetaData>b__45_0(FriendModel x) { }

		internal string <CacheFriendsMetaData>b__45_1(FriendModel x) { }

		internal bool <CacheFriendsMetaData>b__45_2(Task x) { }

		internal bool <get_HasFriendRequests>b__26_0(FriendModel x) { }

		internal bool <get_HasFriends>b__30_0(FriendModel x) { }

		internal bool <set_ServerData>b__15_0(FriendModel x) { }

		internal string <set_ServerData>b__15_1(FriendModel x) { }

		internal string <set_ServerData>b__15_2(string LiNKID) { }

		internal bool <Task_GetLiNKFriendData>b__44_0(Task x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public string LiNKID; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal bool <TryGetFriend>b__0(FriendModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public string linkID; //Field offset: 0x10

		public <>c__DisplayClass52_0() { }

		internal bool <GetFriendStatus>b__0(FriendModel x) { }

	}

	[CompilerGenerated]
	private struct <AttemptSendingFriendRequest>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		private TaskAwaiter<List`1<LiNKFriendData>> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CacheFriendsMetaData>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public List<FriendModel> friends; //Field offset: 0x20
		private List<Task> <concurrentTasks>5__2; //Field offset: 0x28
		private IEnumerator<String> <>7__wrap2; //Field offset: 0x30
		private string <friendId>5__4; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public FriendsCall callType; //Field offset: 0x20
		public string id; //Field offset: 0x28
		private bool <successful>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40
		private TaskAwaiter<List`1<LobbyInviteModel>> <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FriendsSettings>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string settingName; //Field offset: 0x20
		public bool on; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFriendMetaData>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Btd6FriendsData> <>t__builder; //Field offset: 0x8
		public string linkId; //Field offset: 0x20
		private TaskAwaiter<PublicProfileModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLiNKFriendData>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<LiNKFriendData>> <>t__builder; //Field offset: 0x8
		public bool forceRefresh; //Field offset: 0x20
		public bool showErrors; //Field offset: 0x21
		public bool throwExceptions; //Field offset: 0x22
		private TaskAwaiter<List`1<LiNKFriendData>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Task_GetLiNKFriendData>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<LiNKFriendData>> <>t__builder; //Field offset: 0x8
		public bool forceRefresh; //Field offset: 0x20
		public bool throwExceptions; //Field offset: 0x21
		public bool showErrors; //Field offset: 0x22
		private List<Task> <playerStatsUpdateTasks>5__2; //Field offset: 0x28
		private List<LiNKFriendData> <linkFriendsData>5__3; //Field offset: 0x30
		private FriendsListResponse <friendsData>5__4; //Field offset: 0x38
		private TaskAwaiter<FriendsListResponse> <>u__1; //Field offset: 0x40
		private Enumerator<FriendModel> <>7__wrap4; //Field offset: 0x48
		private LiNKFriendData <friendData>5__6; //Field offset: 0x60
		private YieldAwaiter <>u__2; //Field offset: 0x68
		private TaskAwaiter <>u__3; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ToggleTeamRequestsAllowed>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public bool toggleOn; //Field offset: 0x20
		private bool <successful>5__2; //Field offset: 0x21
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateStats>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKFriendData friendData; //Field offset: 0x20
		private string <userId>5__2; //Field offset: 0x28
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x30
		private TaskAwaiter<String> <>u__2; //Field offset: 0x38
		private LiNKFriendData <>7__wrap2; //Field offset: 0x40
		private TaskAwaiter<Guild_GetMemberResponse> <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum FriendsCall
	{
		Accept = 0,
		Decline = 1,
		Unblock = 2,
		Remove = 3,
		Block = 4,
		Cancel = 5,
		Request = 6,
		LobbyInvite = 7,
	}

	public static Action OnFriendsLoaded; //Field offset: 0x0
	private const string kStoredDataKey = "StoredData"; //Field offset: 0x0
	private static FriendsListResponse _serverData; //Field offset: 0x8
	[CompilerGenerated]
	private static String[] <FriendIds>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static bool <IsFriendsLoaded>k__BackingField; //Field offset: 0x18
	private static TimeSpan lastRefresh; //Field offset: 0x20
	private static List<LiNKFriendData> linkFriendsDataCache; //Field offset: 0x28
	private static Task<List`1<LiNKFriendData>> friendsDataTask; //Field offset: 0x30

	public static bool CanUseFriends
	{
		 get { } //Length: 286
	}

	public private static String[] FriendIds
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	private static FriendsSettings FriendsSkuSettings
	{
		private get { } //Length: 150
	}

	public static bool HasFriendRequests
	{
		 get { } //Length: 501
	}

	public static bool HasFriends
	{
		 get { } //Length: 402
	}

	public private static bool IsFriendsLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public static bool IsRestrictedAccount
	{
		 get { } //Length: 53
	}

	public static Api LiNK
	{
		 get { } //Length: 91
	}

	public static LiNKAccount LiNKAccount
	{
		 get { } //Length: 91
	}

	public static Btd6Player MyPlayerData
	{
		 get { } //Length: 7
	}

	public static string MyPlayerID
	{
		 get { } //Length: 151
	}

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	public private static FriendsListResponse ServerData
	{
		 get { } //Length: 118
		private set { } //Length: 842
	}

	private static LiNKFriends() { }

	[AsyncStateMachine(typeof(<AttemptSendingFriendRequest>d__51))]
	private static Task<Boolean> AttemptSendingFriendRequest(string id) { }

	[AsyncStateMachine(typeof(<CacheFriendsMetaData>d__45))]
	private static Task CacheFriendsMetaData(List<FriendModel> friends) { }

	[AsyncStateMachine(typeof(<Call>d__46))]
	public static Task<Boolean> Call(FriendsCall callType, string id) { }

	public static void ClearCache() { }

	[AsyncStateMachine(typeof(<FriendsSettings>d__47))]
	public static Task<Boolean> FriendsSettings(string settingName, bool on) { }

	public static bool get_CanUseFriends() { }

	[CompilerGenerated]
	public static String[] get_FriendIds() { }

	private static FriendsSettings get_FriendsSkuSettings() { }

	public static bool get_HasFriendRequests() { }

	public static bool get_HasFriends() { }

	[CompilerGenerated]
	public static bool get_IsFriendsLoaded() { }

	public static bool get_IsRestrictedAccount() { }

	public static Api get_LiNK() { }

	public static LiNKAccount get_LiNKAccount() { }

	public static Btd6Player get_MyPlayerData() { }

	public static string get_MyPlayerID() { }

	private static TimeSpan get_Now() { }

	public static FriendsListResponse get_ServerData() { }

	public static FriendsCall GetEventType(string callType) { }

	[AsyncStateMachine(typeof(<GetFriendMetaData>d__49))]
	public static Task<Btd6FriendsData> GetFriendMetaData(string linkId) { }

	public static ValueTuple<Boolean, Nullable`1<FriendStatus>, Boolean> GetFriendStatus(string linkID) { }

	[AsyncStateMachine(typeof(<GetLiNKFriendData>d__43))]
	public static Task<List`1<LiNKFriendData>> GetLiNKFriendData(bool forceRefresh = false, bool showErrors = true, bool throwExceptions = false) { }

	public static string GetMyFriendCode() { }

	public static string GetWarningLocKey(FriendsCall callType) { }

	public static bool HasSentFriendRequest(string LiNKID) { }

	public static bool IsFriendOnline(string LiNKID) { }

	public static bool IsFriends(string LiNKID) { }

	[CompilerGenerated]
	private static void set_FriendIds(String[] value) { }

	[CompilerGenerated]
	private static void set_IsFriendsLoaded(bool value) { }

	private static void set_ServerData(FriendsListResponse value) { }

	[AsyncStateMachine(typeof(<Task_GetLiNKFriendData>d__44))]
	private static Task<List`1<LiNKFriendData>> Task_GetLiNKFriendData(bool forceRefresh, bool showErrors, bool throwExceptions) { }

	public static void ThrowFriendPopupMessage(Exception ex, string titleLocKeyOverride = null, string bodyLocKeyOverride = null) { }

	[AsyncStateMachine(typeof(<ToggleTeamRequestsAllowed>d__50))]
	public static Task<Boolean> ToggleTeamRequestsAllowed(bool toggleOn) { }

	public static FriendModel TryGetFriend(string LiNKID) { }

	[AsyncStateMachine(typeof(<UpdateStats>d__48))]
	[Extension]
	private static Task UpdateStats(LiNKFriendData friendData) { }

}

