namespace NinjaKiwi.LiNK.Client.LiNKAccountControllers;

public class MobileWebviewLiNKAccountController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"parameterName", "parameterValue"}])]
		public static Func<ValueTuple`2<String, String>, Boolean> <>9__16_0; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"parameterName", "parameterValue"}])]
		public static Func<ValueTuple`2<String, String>, String> <>9__16_1; //Field offset: 0x10
		public static Action <>9__26_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <GetFlattenedParameters>b__16_0(ValueTuple<String, String> x) { }

		internal string <GetFlattenedParameters>b__16_1(ValueTuple<String, String> x) { }

		internal void <MonitorWebviewEvents>b__26_0() { }

	}

	[CompilerGenerated]
	private struct <CreateEverything>d__22 : IAsyncStateMachine
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
	private struct <OpenAccountPanel>d__12 : IAsyncStateMachine
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
	private struct <PerformAccountTask>d__25 : IAsyncStateMachine
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
	private struct <PerformLoadTask>d__24 : IAsyncStateMachine
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
	private readonly Action logoutAction; //Field offset: 0x50

	private static string UnityMode
	{
		private get { } //Length: 44
	}

	private int WebviewVersion
	{
		private get { } //Length: 149
	}

	public MobileWebviewLiNKAccountController(LiNKAccountController liNKAccountController, Action logoutAction) { }

	[CompilerGenerated]
	private void <DestroyEverything>b__23_0(AsyncOperationHandle<SceneInstance> _) { }

	[CompilerGenerated]
	private void <MonitorWebviewEvents>b__26_1(AuthProviderType authProviderType) { }

	[CompilerGenerated]
	private void <MonitorWebviewEvents>b__26_2(LiNKAccountModel loginResponseModel) { }

	[CompilerGenerated]
	private void <MonitorWebviewEvents>b__26_3(AuthProviderType authProviderType) { }

	[CompilerGenerated]
	private void <MonitorWebviewEvents>b__26_4() { }

	private void AddIfNotNull(List<String> values, object check, string value) { }

	[AsyncStateMachine(typeof(<CreateEverything>d__22))]
	private Task CreateEverything() { }

	private void DestroyEverything() { }

	private static string get_UnityMode() { }

	private int get_WebviewVersion() { }

	private string GetFlattenedParameters(List<ValueTuple`2<String, String>> parameters) { }

	private static string GetLocale() { }

	private string GetPageUrl() { }

	private string GetProviders(AuthenticationProvidersCollection auth) { }

	private string GetUrlV1() { }

	private string GetUrlV2() { }

	private void MonitorWebviewEvents(WebviewFromPlugin webview) { }

	[AsyncStateMachine(typeof(<OpenAccountPanel>d__12))]
	public Task OpenAccountPanel() { }

	[AsyncStateMachine(typeof(<PerformAccountTask>d__25))]
	private void PerformAccountTask(Task accountTask, AuthProviderType provider, string taskName) { }

	[AsyncStateMachine(typeof(<PerformLoadTask>d__24))]
	private Task PerformLoadTask(Task task) { }

	private void RunJavascript() { }

}

