namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

[Extension]
public static class PlayerContentManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32> <>9__54_0; //Field offset: 0x8
		public static Func<Int32, Int32> <>9__55_0; //Field offset: 0x10
		public static Func<String, Boolean> <>9__103_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <CanReport>b__103_0(string storeName) { }

		internal int <GetHighestCompatibleVersionNumber>b__54_0(int x) { }

		internal int <GetLowestCompatibleVersionNumber>b__55_0(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass108_0
	{
		public PlayerContentInfo playerContentInfo; //Field offset: 0x10

		public <>c__DisplayClass108_0() { }

		internal bool <GetAccolades>b__0(AccoladeCache x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass109_0
	{
		public PlayerContentInfo playerContentInfo; //Field offset: 0x10

		public <>c__DisplayClass109_0() { }

		internal bool <CacheAccoladePurchase>b__0(AccoladeCache x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public string owner; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal bool <IsVerifiedAccount>b__0(String[] x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public string playerContentId; //Field offset: 0x10

		public <>c__DisplayClass57_0() { }

		internal bool <CleanupContentId>b__0(BaseSaveDataModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public string playerContentId; //Field offset: 0x10

		public <>c__DisplayClass71_0() { }

		internal bool <GetPlayerContentSaveData>b__0(BaseSaveDataModel o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public BaseSaveDataModel contentBrowserSaveData; //Field offset: 0x10

		public <>c__DisplayClass73_0() { }

		internal bool <Save>b__0(BaseSaveDataModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public string contentId; //Field offset: 0x10

		public <>c__DisplayClass77_0() { }

		internal bool <ClearMapSave>b__0(BaseSaveDataModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public string contentId; //Field offset: 0x10

		public <>c__DisplayClass78_0() { }

		internal bool <DeleteSave>b__0(BaseSaveDataModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public MapSaveDataModel mapSave; //Field offset: 0x10

		public <>c__DisplayClass79_0() { }

		internal bool <UpdatePlayerContentMapSave>b__0(BaseSaveDataModel x) { }

	}

	[CompilerGenerated]
	private struct <CheckProfanity>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string str; //Field offset: 0x20
		public string defaultValue; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CompletedPlayerContent>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentType contentType; //Field offset: 0x20
		public string playerContentId; //Field offset: 0x28
		public bool isVictory; //Field offset: 0x30
		public bool hasDoubleCash; //Field offset: 0x31
		private PlayerContentInfo <contentInfo>5__2; //Field offset: 0x38
		private TaskAwaiter<PlayerContentInfo> <>u__1; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteContent>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentType contentType; //Field offset: 0x20
		public string id; //Field offset: 0x28
		private TaskAwaiter<ElasticSearchUpdateStatus> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadContentData>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IContentBrowserData> <>t__builder; //Field offset: 0x8
		public bool canUseCache; //Field offset: 0x20
		public ContentType contentType; //Field offset: 0x21
		public string contentId; //Field offset: 0x28
		private IContentBrowserData <challengeData>5__2; //Field offset: 0x30
		private TaskAwaiter<MapEditorModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter<GameEditorModel> <>u__2; //Field offset: 0x40
		private TaskAwaiter<HttpResponse> <>u__3; //Field offset: 0x48
		private TaskAwaiter <>u__4; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadPlayerContentInfo>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string id; //Field offset: 0x0
		public ContentType contentType; //Field offset: 0x0
		public RequestCompleted callOnFinish; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAuthorName>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public PlayerContentInfo info; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetContentInfo>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public bool useCache; //Field offset: 0x0
		public string playerContentId; //Field offset: 0x0
		public ContentType contentType; //Field offset: 0x0
		private TaskAwaiter<PagedCollection`1<ESDocument>> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetContentName>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public PlayerContentInfo contentInfo; //Field offset: 0x20
		public ContentType contentType; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30
		private string <challengeKey>5__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetContentStats>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PlayerContentStats> <>t__builder; //Field offset: 0x8
		public ContentType contentType; //Field offset: 0x20
		public string playerContentId; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<PagedCollection`1<ESDocument>> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetPlayerContentSearchResult>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PlayerContentSearchResult> <>t__builder; //Field offset: 0x8
		public bool canShowDeletedContent; //Field offset: 0x20
		public ContentBrowserQuery query; //Field offset: 0x28
		public ElasticQueryOptions options; //Field offset: 0x30
		public int limit; //Field offset: 0x38
		public int offset; //Field offset: 0x3C
		public string hint; //Field offset: 0x40
		private TaskAwaiter<PagedCollection`1<ESDocument>> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetSafeChallengeName>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string owner; //Field offset: 0x20
		public ContentType contentType; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <IsOwnContent>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string playerContentId; //Field offset: 0x20
		public ContentType contentType; //Field offset: 0x28
		private TaskAwaiter<PlayerContentInfo> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RejectContent>d__102 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerContentInfo playerContentInfo; //Field offset: 0x20
		public RejectionReason rejectionReason; //Field offset: 0x28
		public Action onSucces; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReportContent>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerContentInfo playerContentInfo; //Field offset: 0x20
		public RejectionReason rejectionReasons; //Field offset: 0x28
		public Action onSucces; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReStartedPlayerContent>d__92 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string playerContentId; //Field offset: 0x20
		public ContentType contentType; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter<ElasticSearchUpdateStatus> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShareContent>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerContentInfo playerContentInfo; //Field offset: 0x20
		public ContentType contentType; //Field offset: 0x28
		public Replay replay; //Field offset: 0x30
		public IContentBrowserData contentData; //Field offset: 0x38
		public string creationId; //Field offset: 0x40
		public ShareFinish callOnFinish; //Field offset: 0x48
		private string <versionString>5__2; //Field offset: 0x50
		private int <gameVersionNumber>5__3; //Field offset: 0x58
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x60
		private string <replayId>5__4; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70
		private TaskAwaiter<ContentSubmissionResponse> <>u__3; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartedPlayerContent>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string playerContentId; //Field offset: 0x20
		public ContentType contentType; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter<ElasticSearchUpdateStatus> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateContent>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerContentInfo playerContentInfo; //Field offset: 0x20
		public bool isCool; //Field offset: 0x28
		public Action onSucces; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class AccoladeCache
	{
		[CompilerGenerated]
		private readonly ContentType <ContentType>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly string <ContentId>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private DateTime <CacheTime>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private Accolade[] <Accolades>k__BackingField; //Field offset: 0x28

		public Accolade[] Accolades
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public DateTime CacheTime
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string ContentId
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public ContentType ContentType
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public bool IsRecent
		{
			 get { } //Length: 216
		}

		public AccoladeCache(ContentType contentType, string contentId, Accolade[] accolades) { }

		[CompilerGenerated]
		public Accolade[] get_Accolades() { }

		[CompilerGenerated]
		public DateTime get_CacheTime() { }

		[CompilerGenerated]
		public string get_ContentId() { }

		[CompilerGenerated]
		public ContentType get_ContentType() { }

		public bool get_IsRecent() { }

		[CompilerGenerated]
		public void set_Accolades(Accolade[] value) { }

		[CompilerGenerated]
		public void set_CacheTime(DateTime value) { }

	}

	internal sealed class AccoladesCacheUpdated : MulticastDelegate
	{

		public AccoladesCacheUpdated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ContentType contentType, string contentId, Accolade[] accolades, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ContentType contentType, string contentId, Accolade[] accolades) { }

	}

	internal sealed class OnFavoriteToggled : MulticastDelegate
	{

		public OnFavoriteToggled(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ContentType contentType, string contentId, bool isFavorite, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ContentType contentType, string contentId, bool isFavorite) { }

	}

	private struct PlayerContentInfoCache
	{
		public PlayerContentInfo contentInfo; //Field offset: 0x0
		public DateTime creationTime; //Field offset: 0x8

		public bool IsCurrent
		{
			[IsReadOnly]
			 get { } //Length: 165
		}

		public PlayerContentInfoCache(PlayerContentInfo contentInfo) { }

		[IsReadOnly]
		public bool get_IsCurrent() { }

		[IsReadOnly]
		public bool IsValid(string playerContentId) { }

	}

	internal sealed class ShareFinish : MulticastDelegate
	{

		public ShareFinish(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RequestResult result, string playerContentId, Exception exception, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RequestResult result, string playerContentId, Exception exception = null) { }

	}

	public const int CODELENGTH = 7; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly Dictionary<String, Int32> <ContentUpvotes>k__BackingField; //Field offset: 0x0
	public const string kInappropriateContentName = "InappropriateName"; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly Dictionary<String, Task`1<Btd6PlayerStats>> <ContentStatsCache>k__BackingField; //Field offset: 0x8
	public static readonly Dictionary<String, String> safeContentNameCache; //Field offset: 0x10
	public static readonly Dictionary<String, Task`1<String>> safeContentNameCacheTasks; //Field offset: 0x18
	[CompilerGenerated]
	private static readonly Dictionary<String, List`1<DirtyStatus>> <DirtyChallengeIds>k__BackingField; //Field offset: 0x20
	private static readonly StorageManagerLimitedCapacity mapDataStorage; //Field offset: 0x28
	private static readonly StorageManagerLimitedCapacity gameDataStorage; //Field offset: 0x30
	private static DateTime latestStatsLoad; //Field offset: 0x38
	private static PlayerContentInfoCache playerContentInfoCache; //Field offset: 0x40
	public static Action OnContentSaveRemoved; //Field offset: 0x50
	private static readonly List<AccoladeCache> accoladeCache; //Field offset: 0x58

	private static ContentBrowserServerSettings BrowserServerSettings
	{
		private get { } //Length: 138
	}

	private static ContentBrowserSettings BrowserSettings
	{
		private get { } //Length: 150
	}

	public static bool CanLike
	{
		 get { } //Length: 141
	}

	public static String[] CompatibleVersions
	{
		 get { } //Length: 156
	}

	private static ContentBrowserAnalytics ContentBrowserAnalytics
	{
		private get { } //Length: 80
	}

	public static Dictionary<String, Task`1<Btd6PlayerStats>> ContentStatsCache
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public static Dictionary<String, Int32> ContentUpvotes
	{
		[CompilerGenerated]
		 get { } //Length: 78
	}

	public static Dictionary<String, List`1<DirtyStatus>> DirtyChallengeIds
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	private static Btd6Player Player
	{
		private get { } //Length: 7
	}

	private static PlayerContentManager() { }

	private static void AddId(List<String> list, string id) { }

	public static void CacheAccoladePurchase(PlayerContentInfo playerContentInfo, Accolade[] accolades) { }

	public static void CacheContentOwnerStats(PlayerContentInfo playerContentInfo) { }

	public static bool CanReadCustomName(PlayerContentInfo contentInfo) { }

	[Extension]
	public static bool CanReport(PlayerContentInfo playerContentInfo) { }

	public static bool CanWriteCustomNames() { }

	[AsyncStateMachine(typeof(<CheckProfanity>d__35))]
	public static Task<String> CheckProfanity(string str, string defaultValue) { }

	private static void CleanupContentId(string playerContentId, ContentType contentType) { }

	private static void CleanupMapModel(CustomMapModel customMapModel) { }

	public static void ClearMapSave(string contentId, ContentType contentType) { }

	[AsyncStateMachine(typeof(<CompletedPlayerContent>d__85))]
	public static Task CompletedPlayerContent(string playerContentId, ContentType contentType, bool isVictory, bool hasDoubleCash) { }

	private static Byte[] CompressString(string value) { }

	private static IContentBrowserData DecompressAndDeserialise(Byte[] input, ContentType contentType) { }

	private static string DecompressString(Byte[] bytes) { }

	[AsyncStateMachine(typeof(<DeleteContent>d__56))]
	public static Task DeleteContent(string id, ContentType contentType) { }

	public static bool DeleteSave(string contentId, ContentType contentType) { }

	private static GameEditorModel DeserializeAndCleanupGame(JsonSerializer serialiser, JsonTextReader jsonReader) { }

	private static MapEditorModel DeserializeAndCleanupMap(JsonSerializer serialiser, JsonTextReader jsonReader) { }

	[AsyncStateMachine(typeof(<DownloadContentData>d__49))]
	public static Task<IContentBrowserData> DownloadContentData(string contentId, ContentType contentType, bool canUseCache = true) { }

	[AsyncStateMachine(typeof(<DownloadPlayerContentInfo>d__22`1))]
	public static Task<T> DownloadPlayerContentInfo(string id, ContentType contentType, RequestCompleted callOnFinish) { }

	public static void FavouriteToggled(string id, ContentType contentType, bool isFavorite, bool forceSave = false, bool requiresPanelRefresh = false) { }

	private static ContentBrowserServerSettings get_BrowserServerSettings() { }

	private static ContentBrowserSettings get_BrowserSettings() { }

	public static bool get_CanLike() { }

	public static String[] get_CompatibleVersions() { }

	private static ContentBrowserAnalytics get_ContentBrowserAnalytics() { }

	[CompilerGenerated]
	public static Dictionary<String, Task`1<Btd6PlayerStats>> get_ContentStatsCache() { }

	[CompilerGenerated]
	public static Dictionary<String, Int32> get_ContentUpvotes() { }

	[CompilerGenerated]
	public static Dictionary<String, List`1<DirtyStatus>> get_DirtyChallengeIds() { }

	private static Btd6Player get_Player() { }

	public static Accolade[] GetAccolades(PlayerContentInfo playerContentInfo) { }

	[AsyncStateMachine(typeof(<GetAuthorName>d__23))]
	public static Task<String> GetAuthorName(PlayerContentInfo info) { }

	public static string GetChallengeName(string ownerId, string rawChallengeName, Nullable<ContentType> contentType) { }

	private static List<Int32> GetCompatibleVersionNumbers() { }

	[AsyncStateMachine(typeof(<GetContentInfo>d__61`1))]
	public static Task<T> GetContentInfo(string playerContentId, ContentType contentType, bool useCache = true) { }

	[AsyncStateMachine(typeof(<GetContentName>d__26))]
	[Extension]
	public static Task<String> GetContentName(PlayerContentInfo contentInfo, ContentType contentType) { }

	[Extension]
	private static string GetContentNameLocsKey(ContentType contentType) { }

	[AsyncStateMachine(typeof(<GetContentStats>d__59))]
	public static Task<PlayerContentStats> GetContentStats(string playerContentId, ContentType contentType) { }

	[Extension]
	public static CurationStatus GetCurationStatus(PlayerContentInfo playerContentInfo) { }

	[Extension]
	public static DeepLinkType GetDeepLinkType(ContentType contentType) { }

	public static string GetDisplayUpvotes(string playerContentId, Nullable<Int32> upvotes = null) { }

	public static int GetGameVersionNumber(string versionName) { }

	public static int GetHighestCompatibleVersionNumber() { }

	public static int GetLowestCompatibleVersionNumber() { }

	public static string GetMostRecentPlayerContentId(ContentType contentType) { }

	public static string GetMyDefaultContentName(ContentType contentType) { }

	private static T GetPlayerContentInfo(PagedCollection<ESDocument> esDoc, ContentType contentType) { }

	public static BaseSaveDataModel GetPlayerContentSaveData(string playerContentId, ContentType contentType) { }

	[AsyncStateMachine(typeof(<GetPlayerContentSearchResult>d__65))]
	public static Task<PlayerContentSearchResult> GetPlayerContentSearchResult(ContentBrowserQuery query, ElasticQueryOptions options, int limit, int offset, string hint, bool canShowDeletedContent) { }

	public static string GetPlayerIdFromWinnerStat(string winnerStatValue) { }

	private static int GetQueryLimit(int defaultValue = 1) { }

	[AsyncStateMachine(typeof(<GetSafeChallengeName>d__28))]
	private static Task<String> GetSafeChallengeName(string owner, ContentType contentType) { }

	private static string GetSafeContentNameCacheKey(ContentType contentType, string ownerId) { }

	public static string GetWinnerStatValue(string playerId) { }

	public static bool HasFreePlayerContentMapSaveSlots(ContentType contentType) { }

	[Extension]
	public static bool HasValidCuration(PlayerContentInfo playerContentInfo, ContentTypeSettings contentTypeSettings) { }

	private static Task<ElasticSearchUpdateStatus> IncrementValue(string playerContentId, ContentType contentType, string property, int value) { }

	public static bool IsCompatible(string chalVersionStr) { }

	public static bool IsOldContent(PlayerContentInfo contentInfo) { }

	private static bool IsOwnChallenge(PlayerContentInfo contentInfo) { }

	[AsyncStateMachine(typeof(<IsOwnContent>d__94))]
	private static Task<Boolean> IsOwnContent(string playerContentId, ContentType contentType) { }

	public static bool IsVerifiedAccount(string owner) { }

	public static void LikeToggled(string id, ContentType contentType, bool isLike, bool forceSave = false) { }

	[AsyncStateMachine(typeof(<RejectContent>d__102))]
	public static Task RejectContent(PlayerContentInfo playerContentInfo, RejectionReason rejectionReason, Action onSucces) { }

	public static void RemoveOldestSave(ContentType contentType) { }

	[AsyncStateMachine(typeof(<ReportContent>d__100))]
	public static Task ReportContent(PlayerContentInfo playerContentInfo, RejectionReason rejectionReasons, Action onSucces) { }

	[AsyncStateMachine(typeof(<ReStartedPlayerContent>d__92))]
	public static Task ReStartedPlayerContent(string playerContentId, ContentType contentType) { }

	public static Task<String> SanitizeName(string challengeName) { }

	public static string SanitizeNameHacky(string challengeName) { }

	public static void Save(ContentType contentType, BaseSaveDataModel contentBrowserSaveData) { }

	private static void SendSubmitionAnalytics(PlayerContentInfo contentInfo, string id, ContentType contentType, IContentBrowserData challengeData, string creationId) { }

	private static string SerialiseAndCompress(IContentBrowserData contentBrowserData) { }

	public static void SetAvatarBanner(string bannerId, Image bannerImg, bool useSmall = false) { }

	public static void SetAvatarSprite(string avatarId, Image avatarImg) { }

	public static void SetDirtyId(string id, DirtyStatus dirtyStatus) { }

	[AsyncStateMachine(typeof(<ShareContent>d__50))]
	public static Task ShareContent(PlayerContentInfo playerContentInfo, ContentType contentType, IContentBrowserData contentData, Replay replay, ShareFinish callOnFinish, string creationId) { }

	[AsyncStateMachine(typeof(<StartedPlayerContent>d__90))]
	public static Task StartedPlayerContent(string playerContentId, ContentType contentType) { }

	private static void UpdateLatestBeatableVersion(ElasticSearchUpdater challengeUpdater, PlayerContentInfo contentInfo) { }

	public static void UpdatePlayerContentMapSave(MapSaveDataModel mapSave) { }

	private static void UpdateSaveAndMoveToTop(List<BaseSaveDataModel> saves, BaseSaveDataModel save) { }

	private static void UpdateWinnerInfo(ElasticSearchUpdater challengeUpdater, PlayerContentInfo contentInfo) { }

	[AsyncStateMachine(typeof(<ValidateContent>d__101))]
	public static Task ValidateContent(PlayerContentInfo playerContentInfo, Action onSucces, bool isCool) { }

	public static string ValidateDescription(string description) { }

	public static string ValidateTitle(string title) { }

}

