namespace NinjaKiwi.GUTS;

[Extension]
public static class ContentBrowserWebRequests
{
	[CompilerGenerated]
	private struct <_CB_GetReceivedAccolades>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public Nullable<TimeSpan> cacheLife; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		private AccoladeTransactionRequestResponse<AccoladeTransaction> <accoladeTransactionsResponse>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private AccoladeTransactionRequestResponse<AccoladeTransaction> <>7__wrap2; //Field offset: 0x0
		private AccoladeTransactionRequestResponse<AccoladeTransaction> <>7__wrap3; //Field offset: 0x0
		private TaskAwaiter<AccoladeTransaction[]> <>u__2; //Field offset: 0x0
		private AccoladeTransactionRequest <>7__wrap4; //Field offset: 0x0
		private AccoladeTransactionRequest <>7__wrap5; //Field offset: 0x0
		private TaskAwaiter<Int64> <>u__3; //Field offset: 0x0
		private TaskAwaiter<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> <>u__4; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CB_BuyAccolades>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AccoladePurchaseRequestResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public string contentId; //Field offset: 0x0
		public string contentOwnerId; //Field offset: 0x0
		public ContentType contentType; //Field offset: 0x0
		public string accoladeId; //Field offset: 0x0
		public int accoladeQuantityIndex; //Field offset: 0x0
		public bool forceIapValidation; //Field offset: 0x0
		public string playerSession; //Field offset: 0x0
		public bool hasPlayedContent; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		private TaskAwaiter<AccoladePurchaseRequestResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CB_CurationSearch>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ContentCurationListResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public string searchValue; //Field offset: 0x0
		public ContentType contentType; //Field offset: 0x0
		public int limit; //Field offset: 0x0
		public int offset; //Field offset: 0x0
		public HashSet<String> ignorableIds; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		private TaskAwaiter<ContentCurationListResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CB_GetCurationList>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ContentCurationListResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public ContentType contentType; //Field offset: 0x0
		public int limit; //Field offset: 0x0
		public int offset; //Field offset: 0x0
		public HashSet<String> ignorableIds; //Field offset: 0x0
		private TaskAwaiter<ContentCurationListResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CB_GetInfo>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CurationInfoResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<CurationInfoResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CB_GetReceivedAccolades>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public Nullable<TimeSpan> cacheLife; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		private TaskAwaiter<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string kEmptyPayload = "{}"; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"playerId", "curationInfoResponse"}])]
	private static ValueTuple<String, CurationInfoResponse> curationInfoCache; //Field offset: 0x0
	private static Task<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> receivedAccoladesTask; //Field offset: 0x10

	[AsyncStateMachine(typeof(<_CB_GetReceivedAccolades>d__13`1))]
	[Extension]
	private static Task<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> _CB_GetReceivedAccolades(Player<T> player, Nullable<TimeSpan> cacheLife, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<CB_BuyAccolades>d__10`1))]
	[Extension]
	public static Task<AccoladePurchaseRequestResponse> CB_BuyAccolades(Player<T> player, ContentType contentType, string contentId, string contentOwnerId, string accoladeId, int accoladeQuantityIndex, string playerSession, bool hasPlayedContent, bool forceIapValidation = true, CancellationToken cancellationToken = null) { }

	[AsyncStateMachine(typeof(<CB_CurationSearch>d__7`1))]
	[Extension]
	public static Task<ContentCurationListResponse> CB_CurationSearch(Player<T> player, ContentType contentType, int limit, int offset, HashSet<String> ignorableIds, string searchValue, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<CB_GetCurationList>d__6`1))]
	[Extension]
	public static Task<ContentCurationListResponse> CB_GetCurationList(Player<T> player, ContentType contentType, int limit, int offset, HashSet<String> ignorableIds) { }

	[AsyncStateMachine(typeof(<CB_GetInfo>d__9`1))]
	[Extension]
	public static Task<CurationInfoResponse> CB_GetInfo(Player<T> player) { }

	[AsyncStateMachine(typeof(<CB_GetReceivedAccolades>d__11`1))]
	[Extension]
	public static Task<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> CB_GetReceivedAccolades(Player<T> player, Nullable<TimeSpan> cacheLife = null, CancellationToken cancellationToken = null) { }

	[Extension]
	public static Task CB_Reject(Player<T> player, ContentType contentType, string contentId, string contentOwnerId, RejectionReason rejectionReason) { }

	[Extension]
	public static Task CB_ReportContent(Player<T> player, ContentType contentType, string contentId, string contentOwnerId, RejectionReason reportReason) { }

	[Extension]
	public static Task<ContentSubmissionResponse> CB_SubmitNewContent(Player<T> player, ContentType contentType, PlayerContentInfo playerContentInfo, string encodedContentData, string replayId) { }

	[Extension]
	private static Task CB_Update(Player<T> player, ContentType contentType, string contentId, string contentOwnerId, bool isValidVote, RejectionReason rejectionReason, Nullable<Boolean> isCool = null) { }

	[Extension]
	public static Task CB_Validate(Player<T> player, ContentType contentType, string contentId, string contentOwnerId, bool isCool) { }

}

