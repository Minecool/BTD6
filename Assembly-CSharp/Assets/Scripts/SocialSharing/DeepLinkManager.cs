namespace Assets.Scripts.SocialSharing;

public class DeepLinkManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ReturnCallback <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnDeepLinkActivated>b__15_0() { }

	}

	[CompilerGenerated]
	private struct <CanOpenChallengeDeepLink>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"canOpen", "playerContent"}])]
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, PlayerContent>> <>t__builder; //Field offset: 0x8
		public ContentType contentType; //Field offset: 0x20
		private PlayerContentInfo <playerContentInfo>5__2; //Field offset: 0x28
		private PlayerContent <playerContent>5__3; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private TaskAwaiter<PlayerContentInfo> <>u__2; //Field offset: 0x40
		private TaskAwaiter<String> <>u__3; //Field offset: 0x48
		private TaskAwaiter<IContentBrowserData> <>u__4; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CanOpenSweepstakesDeepLink>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GoToMainMenu>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private MenuManager <menuManager>5__2; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDeepLinkActivated>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x28
		public DeepLinkManager <>4__this; //Field offset: 0x30
		private string <linkCode>5__2; //Field offset: 0x38
		private DeepLinkType <linkType>5__3; //Field offset: 0x40
		private LocalizationManager <locs>5__4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenChallengeDeepLink>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public ContentType contentType; //Field offset: 0x20
		private PlayerContent <playerContent>5__2; //Field offset: 0x28
		private MenuManager <menuManager>5__3; //Field offset: 0x30
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"canOpen", "playerContent"}])]
		private TaskAwaiter<ValueTuple`2<Boolean, PlayerContent>> <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenCoopDeepLink>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private CoopDeepLinkData <coopDeepLinkData>5__2; //Field offset: 0x20
		private MenuManager <menuManager>5__3; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private YieldAwaiter <>u__2; //Field offset: 0x38
		private TaskAwaiter <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenDeepLinkMenu>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private bool <hasLoadedDeeplink>5__2; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenSweepstakesDeepLink>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string linkCode; //Field offset: 0x20
		private SweepstakesEvent <sweepstakesEvent>5__2; //Field offset: 0x28
		private MenuManager <menuManager>5__3; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static DeepLinkManager <Instance>k__BackingField; //Field offset: 0x0
	private static readonly String[] validBaseUrls; //Field offset: 0x8
	private static readonly Regex AlphaOrDashRegex; //Field offset: 0x10
	private static readonly Regex AlphaNumericRegex; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable<DeepLinkType> <LinkType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <LinkCode>k__BackingField; //Field offset: 0x28

	public static bool CanPlayChallenge
	{
		 get { } //Length: 99
	}

	public static bool CanPlayCoop
	{
		 get { } //Length: 289
	}

	private static int CoopUnlockLvl
	{
		private get { } //Length: 155
	}

	public static bool HasPendingDeepLink
	{
		 get { } //Length: 323
	}

	public private static DeepLinkManager Instance
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public private string LinkCode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Nullable<DeepLinkType> LinkType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private static DeepLinkManager() { }

	public DeepLinkManager() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<CanOpenChallengeDeepLink>d__21))]
	public static Task<ValueTuple`2<Boolean, PlayerContent>> CanOpenChallengeDeepLink(ContentType contentType) { }

	[AsyncStateMachine(typeof(<CanOpenSweepstakesDeepLink>d__23))]
	public static Task<Boolean> CanOpenSweepstakesDeepLink() { }

	public static void DisableLoadingSpinner() { }

	public static void EnableLoadingSpinner() { }

	private void Failed(string url) { }

	public static bool get_CanPlayChallenge() { }

	public static bool get_CanPlayCoop() { }

	private static int get_CoopUnlockLvl() { }

	public static bool get_HasPendingDeepLink() { }

	[CompilerGenerated]
	public static DeepLinkManager get_Instance() { }

	[CompilerGenerated]
	public string get_LinkCode() { }

	[CompilerGenerated]
	public Nullable<DeepLinkType> get_LinkType() { }

	public static ContentType GetContentType(DeepLinkType deepLinkType) { }

	private string GetDeepLinkFromArgs(String[] commandLineArgs) { }

	private DeepLinkType[] GetDeepLinkTypes() { }

	private string GetDescriptionLocKey(DeepLinkType linkType) { }

	private static object GetPlaySceneData(ContentType contentType, PlayerContent playerContent) { }

	private string GetUrlPath(string url) { }

	private Nullable<Int32> GetValidCodeLength(DeepLinkType linkType) { }

	[AsyncStateMachine(typeof(<GoToMainMenu>d__25))]
	private static Task GoToMainMenu() { }

	public static bool IsAlphaNumericOrDash(string v) { }

	private static bool IsAlphaOrDash(string v) { }

	private bool IsValidCode(DeepLinkType linkType, string code) { }

	public static bool IsValidSweepstakesCode(string code) { }

	[AsyncStateMachine(typeof(<OnDeepLinkActivated>d__15))]
	public void OnDeepLinkActivated(string url) { }

	[AsyncStateMachine(typeof(<OpenChallengeDeepLink>d__22))]
	private static Task<Boolean> OpenChallengeDeepLink(ContentType contentType) { }

	[AsyncStateMachine(typeof(<OpenCoopDeepLink>d__27))]
	private static Task<Boolean> OpenCoopDeepLink() { }

	[AsyncStateMachine(typeof(<OpenDeepLinkMenu>d__19))]
	public static Task<Boolean> OpenDeepLinkMenu() { }

	[AsyncStateMachine(typeof(<OpenSweepstakesDeepLink>d__24))]
	private static Task<Boolean> OpenSweepstakesDeepLink(string linkCode) { }

	public void Reset() { }

	[CompilerGenerated]
	private static void set_Instance(DeepLinkManager value) { }

	[CompilerGenerated]
	private void set_LinkCode(string value) { }

	[CompilerGenerated]
	private void set_LinkType(Nullable<DeepLinkType> value) { }

	private static void ShowCoopErrorPopup() { }

}

