namespace NinjaKiwi.LiNK.Client.LiNKAccountControllers;

public class MobileWebviewLiNKAccountController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <MonitorWebviewEvents>b__24_0() { }

	}

	[CompilerGenerated]
	private struct <CreateEverything>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MobileWebviewLiNKAccountController <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenAccountPanel>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MobileWebviewLiNKAccountController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PerformAccountTask>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MobileWebviewLiNKAccountController <>4__this; //Field offset: 0x28
		public Task accountTask; //Field offset: 0x30
		public string taskName; //Field offset: 0x38
		public AuthProviderType provider; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PerformLoadTask>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MobileWebviewLiNKAccountController <>4__this; //Field offset: 0x20
		public Task task; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string PLATFORM = "steam"; //Field offset: 0x0
	private const string kWebviewSigningKey = "BDR0989A2FF13CBC"; //Field offset: 0x0
	private readonly LiNKAccountController liNKAccountController; //Field offset: 0x10
	private GameObject viewGameObject; //Field offset: 0x18
	private WebviewFromPlugin webview; //Field offset: 0x20
	private WebviewBackground background; //Field offset: 0x28
	private AsyncOperationHandle<SceneInstance> loadOperation; //Field offset: 0x30
	private bool destroyed; //Field offset: 0x48
	private readonly int webviewVersion; //Field offset: 0x4C
	private readonly Action logoutAction; //Field offset: 0x50

	private static string UnityMode
	{
		private get { } //Length: 44
	}

	public MobileWebviewLiNKAccountController(LiNKAccountController liNKAccountController, int webviewVersion, Action logoutAction) { }

	[CompilerGenerated]
	private void <DestroyEverything>b__21_0(AsyncOperationHandle<SceneInstance> _) { }

	[CompilerGenerated]
	private void <MonitorWebviewEvents>b__24_1(AuthProviderType authProviderType) { }

	[CompilerGenerated]
	private void <MonitorWebviewEvents>b__24_2(LoginResponseModel loginResponseModel) { }

	[CompilerGenerated]
	private void <MonitorWebviewEvents>b__24_3(AuthProviderType authProviderType) { }

	[CompilerGenerated]
	private void <MonitorWebviewEvents>b__24_4() { }

	private void AddIfNotNull(List<String> values, object check, string value) { }

	[AsyncStateMachine(typeof(<CreateEverything>d__20))]
	private Task CreateEverything() { }

	private void DestroyEverything() { }

	private static string get_UnityMode() { }

	private static string GetLocale() { }

	private string GetProviders(AuthenticationProvidersCollection auth) { }

	private Uri GetUri() { }

	private Uri GetUriV1() { }

	private Uri GetUriV2() { }

	private void MonitorWebviewEvents(WebviewFromPlugin webview) { }

	[AsyncStateMachine(typeof(<OpenAccountPanel>d__11))]
	public Task OpenAccountPanel() { }

	[AsyncStateMachine(typeof(<PerformAccountTask>d__23))]
	private void PerformAccountTask(Task accountTask, AuthProviderType provider, string taskName) { }

	[AsyncStateMachine(typeof(<PerformLoadTask>d__22))]
	private Task PerformLoadTask(Task task) { }

	private void RunJavascript() { }

}

