namespace Assets.Scripts.Unity.Player;

public class PlayerService : PlayerService<Btd6Player, ProfileModel>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<DataInvalid> <>9__37_0; //Field offset: 0x8
		public static Action<Exception> <>9__37_1; //Field offset: 0x10
		public static Action<LiNKAccount> <>9__39_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <DefaultAwake>b__37_0(DataInvalid _) { }

		internal void <DefaultAwake>b__37_1(Exception ex) { }

		internal void <RetryLogin>b__39_0(LiNKAccount account) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public int skuId; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <IsSkuIdInGroup>b__0(int id) { }

	}

	[CompilerGenerated]
	private struct <FlushSaveAndSync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerService <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerService <>4__this; //Field offset: 0x20
		public AuthenticationProviderToken authToken; //Field offset: 0x28
		private TaskAwaiter<Btd6Player> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnApplicationFocus>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public bool hasFocus; //Field offset: 0x28
		public PlayerService <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnApplicationPause>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public bool hasPaused; //Field offset: 0x28
		public PlayerService <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnApplicationQuit>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerService <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <PlayerSave>d__51 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerService <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <PlayerSave>d__51(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <RetryLogin>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerService <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateDisplayName>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerService <>4__this; //Field offset: 0x20
		public string intendedDisplayName; //Field offset: 0x28
		public int retryCount; //Field offset: 0x30
		public int retryDelayMinutes; //Field offset: 0x34
		private LiNKAccount <linkAccount>5__2; //Field offset: 0x38
		private string <accountId>5__3; //Field offset: 0x40
		private int <attempt>5__4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const int APP_ID = 11; //Field offset: 0x0
	public const byte kNoLinkIdVersion = 2; //Field offset: 0x0
	public static readonly Environments ENVIRONMENT; //Field offset: 0x0
	public const int SKU_ID = 35; //Field offset: 0x0
	private const int kSkuId_Switch = 1109; //Field offset: 0x0
	private const int kSkuId_ArcadeMacOS = 1108; //Field offset: 0x0
	private const int kSkuId_ArcadeVisionOS = 1107; //Field offset: 0x0
	private const int kSkuId_ArcadeIOS = 1104; //Field offset: 0x0
	private const int kSkuId_WindowsStore = 1101; //Field offset: 0x0
	private const int kSkuId_AppleIOS = 32; //Field offset: 0x0
	private const int kSkuId_NetflixAndroid = 1112; //Field offset: 0x0
	private const int kSkuId_NetflixIOS = 1106; //Field offset: 0x0
	private const int kSkuId_GoogleAndroid = 33; //Field offset: 0x0
	private const int kSkuId_AmazonAndroid = 34; //Field offset: 0x0
	private const int kSkuId_SteamMacOS = 1136; //Field offset: 0x0
	private const int kSkuId_SteamWindows = 35; //Field offset: 0x0
	private const int kSkuId_EpicAndroid = 1110; //Field offset: 0x0
	private const int kSkuId_EpicIOS = 1111; //Field offset: 0x0
	private const int kSkuId_EpicWindows = 1105; //Field offset: 0x0
	private const string RAW_PROVIDER_HASH = "cFGFFYdHoofaEqAlOOTHW7"; //Field offset: 0x0
	private const string PLAYER_SAVE_FILE_NAME = "Profile.Save"; //Field offset: 0x0
	private const int SAVE_PASSWORD_VERSION = 2; //Field offset: 0x0
	private const int PLAY_SESSION_CHECKS_PER_BACKUP = 0; //Field offset: 0x0
	private const int DATA_BACKUP_PERIOD_SECONDS = 180; //Field offset: 0x0
	public const string kNoLinkPrefix = "no_link"; //Field offset: 0x0
	public const string SKU_SIGNATURE = "A26308E242742374"; //Field offset: 0x0
	private static string _NoLiNKId; //Field offset: 0x8
	private static Api _NoLiNKApi; //Field offset: 0x10

	private static int DataMigrationSupportEarliestVersion
	{
		private get { } //Length: 33
	}

	public static Api NoLiNKApi
	{
		 get { } //Length: 359
	}

	public static string NoLiNKId
	{
		 get { } //Length: 279
	}

	public static string STORE_NAME
	{
		 get { } //Length: 81
	}

	private static PlayerService() { }

	public PlayerService() { }

	[CompilerGenerated]
	private string <Init>b__43_0() { }

	protected virtual void Awake() { }

	public static SkuSettingsHelper CreateSkuSettingsHelper() { }

	private void DefaultAwake() { }

	[AsyncStateMachine(typeof(<FlushSaveAndSync>d__55))]
	private Task FlushSaveAndSync() { }

	private static int get_DataMigrationSupportEarliestVersion() { }

	public static Api get_NoLiNKApi() { }

	public static string get_NoLiNKId() { }

	public static string get_STORE_NAME() { }

	private Btd6CtSettings GetCtSettings() { }

	private Task<Guild_GetMemberResponse> GetMyGuildInfo() { }

	private DateTime GetServerTime() { }

	private static string GetUniqueDeviceId() { }

	private static void GutsLog(string v) { }

	private static void GutsLogError(string v) { }

	private static void GutsLogWarning(string v) { }

	[AsyncStateMachine(typeof(<Init>d__43))]
	public Task Init(AuthenticationProviderToken authToken = null) { }

	public static bool IsSkuIdCompatible(int skuId) { }

	private static bool IsSkuIdInGroup(int skuId, Int32[] validSkus) { }

	public File<ProfileModel> LoadTempSlotFile(int slotIdx) { }

	[AsyncStateMachine(typeof(<OnApplicationFocus>d__54))]
	public void OnApplicationFocus(bool hasFocus) { }

	[AsyncStateMachine(typeof(<OnApplicationPause>d__53))]
	public void OnApplicationPause(bool hasPaused) { }

	[AsyncStateMachine(typeof(<OnApplicationQuit>d__52))]
	public void OnApplicationQuit() { }

	[IteratorStateMachine(typeof(<PlayerSave>d__51))]
	private IEnumerator PlayerSave() { }

	[AsyncStateMachine(typeof(<RetryLogin>d__39))]
	private void RetryLogin() { }

	public void SetupAutoLogin() { }

	[AsyncStateMachine(typeof(<UpdateDisplayName>d__56))]
	public Task UpdateDisplayName(string intendedDisplayName, int retryCount = 10, int retryDelayMinutes = 3) { }

}

