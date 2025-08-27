namespace NinjaKiwi.LiNK.Client.LiNKAccountControllers;

public class WebviewFromPlugin : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ShouldCloseDelegate <>9__43_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <monitorEvents>b__43_0(UniWebView _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public WebviewFromPlugin <>4__this; //Field offset: 0x10
		public PageFinishedDelegate OnPageFinished; //Field offset: 0x18
		public LoadingErrorReceivedDelegate OnLoadingErrorReceived; //Field offset: 0x20
		public ObjectWasDestroyed OnObjectWasDestroyed; //Field offset: 0x28
		public CancellationTokenSource timeoutCanceller; //Field offset: 0x30
		public TaskCompletionSource<Boolean> taskCompletionSource; //Field offset: 0x38
		public string url; //Field offset: 0x40

		public <>c__DisplayClass34_0() { }

		internal void <ShowPage>b__0(UniWebView _dontUseWebView, int statusCode, string finishedUrl) { }

		internal void <ShowPage>b__1(UniWebView _dontUseWebView, int errorCode, string errorMessage, UniWebViewNativeResultPayload payload) { }

		internal void <ShowPage>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <ShowInSeconds>d__38 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float seconds; //Field offset: 0x20
		public WebviewFromPlugin <>4__this; //Field offset: 0x28

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
		public <ShowInSeconds>d__38(int <>1__state) { }

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
	private sealed class <startTimeout>d__35 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CancellationToken canceller; //Field offset: 0x20
		public WebviewFromPlugin <>4__this; //Field offset: 0x28
		public TaskCompletionSource<Boolean> taskCompletionSource; //Field offset: 0x30
		public string url; //Field offset: 0x38
		private DateTime <timeoutEnd>5__2; //Field offset: 0x40

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
		public <startTimeout>d__35(int <>1__state) { }

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

	private sealed class ObjectWasDestroyed : MulticastDelegate
	{

		public ObjectWasDestroyed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private class Response
	{
		public InvalidRequestException error; //Field offset: 0x10
		public string sig; //Field offset: 0x18
		public string data; //Field offset: 0x20

		public Response() { }

	}

	public static float TIMEOUT_SECONDS; //Field offset: 0x0
	private const string PROVIDER_APPLE = "apple"; //Field offset: 0x0
	private const string PROVIDER_GOOGLEPLAY = "googleplay"; //Field offset: 0x0
	private const string PROVIDER_FACEBOOK = "facebook"; //Field offset: 0x0
	private const string KEY_TEXT = "text"; //Field offset: 0x0
	private const string KEY_TARGET = "target"; //Field offset: 0x0
	private const string KEY_DATA = "data"; //Field offset: 0x0
	private const string KEY_PROVIDER = "provider"; //Field offset: 0x0
	private const string MESSAGE_COPY = "copytext"; //Field offset: 0x0
	private const string MESSAGE_EXTERNALBROWSER = "externalBrowser"; //Field offset: 0x0
	private const string MESSAGE_CLOSE = "close"; //Field offset: 0x0
	private const string MESSAGE_ONLYLOGIN = "onlylogin"; //Field offset: 0x0
	private const string MESSAGE_LOGOUT = "logout"; //Field offset: 0x0
	private const string MESSAGE_LOGIN = "login"; //Field offset: 0x0
	private const string MESSAGE_LINKING = "linking"; //Field offset: 0x0
	private const string PROVIDER_GAMECENTER = "gamecenter"; //Field offset: 0x0
	private const string MESSAGE_LINKED = "linked"; //Field offset: 0x0
	private const string MESSAGE_RESTORED = "restored"; //Field offset: 0x0
	private const string MESSAGE_LOADED = "loaded"; //Field offset: 0x0
	private const string MESSAGE_UPDATE = "user/update"; //Field offset: 0x0
	private const string PROVIDER_STEAM = "steam"; //Field offset: 0x0
	[CompilerGenerated]
	private Action LoadedEvent; //Field offset: 0x20
	[CompilerGenerated]
	private Action RestoredEvent; //Field offset: 0x28
	[CompilerGenerated]
	private Action<UserModel> UpdatedEvent; //Field offset: 0x30
	[CompilerGenerated]
	private Action<UserModel> LinkedEvent; //Field offset: 0x38
	[CompilerGenerated]
	private Action<AuthProviderType> LinkingEvent; //Field offset: 0x40
	[CompilerGenerated]
	private Action<AuthProviderType> LoginToAuthProviderEvent; //Field offset: 0x48
	[CompilerGenerated]
	private Action<LoginResponseModel> LoggedInEvent; //Field offset: 0x50
	[CompilerGenerated]
	private Action LogoutEvent; //Field offset: 0x58
	[CompilerGenerated]
	private Action CloseEvent; //Field offset: 0x60
	private SteamWebView uniWebview; //Field offset: 0x68
	private string loadUrl; //Field offset: 0x70
	[CompilerGenerated]
	private ObjectWasDestroyed OnObjectWasDestroyed; //Field offset: 0x78

	public event Action CloseEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<UserModel> LinkedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<AuthProviderType> LinkingEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action LoadedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<LoginResponseModel> LoggedInEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<AuthProviderType> LoginToAuthProviderEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action LogoutEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private event ObjectWasDestroyed OnObjectWasDestroyed
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public event Action RestoredEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<UserModel> UpdatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	private void _receivedMessageHandler(UniWebView webview, UniWebViewMessage message) { }

	private static WebviewFromPlugin() { }

	public WebviewFromPlugin() { }

	[CompilerGenerated]
	public void add_CloseEvent(Action value) { }

	[CompilerGenerated]
	public void add_LinkedEvent(Action<UserModel> value) { }

	[CompilerGenerated]
	public void add_LinkingEvent(Action<AuthProviderType> value) { }

	[CompilerGenerated]
	public void add_LoadedEvent(Action value) { }

	[CompilerGenerated]
	public void add_LoggedInEvent(Action<LoginResponseModel> value) { }

	[CompilerGenerated]
	public void add_LoginToAuthProviderEvent(Action<AuthProviderType> value) { }

	[CompilerGenerated]
	public void add_LogoutEvent(Action value) { }

	[CompilerGenerated]
	private void add_OnObjectWasDestroyed(ObjectWasDestroyed value) { }

	[CompilerGenerated]
	public void add_RestoredEvent(Action value) { }

	[CompilerGenerated]
	public void add_UpdatedEvent(Action<UserModel> value) { }

	private void Awake() { }

	private static T deserialise(string encoded) { }

	public void Destroy() { }

	private AuthProviderType getAuthProviderType(string providerName) { }

	public void Hide() { }

	private void monitorEvents(UniWebView uniWebview) { }

	private void receivedMessageHandler(UniWebView webview, UniWebViewMessage message) { }

	[CompilerGenerated]
	public void remove_CloseEvent(Action value) { }

	[CompilerGenerated]
	public void remove_LinkedEvent(Action<UserModel> value) { }

	[CompilerGenerated]
	public void remove_LinkingEvent(Action<AuthProviderType> value) { }

	[CompilerGenerated]
	public void remove_LoadedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_LoggedInEvent(Action<LoginResponseModel> value) { }

	[CompilerGenerated]
	public void remove_LoginToAuthProviderEvent(Action<AuthProviderType> value) { }

	[CompilerGenerated]
	public void remove_LogoutEvent(Action value) { }

	[CompilerGenerated]
	private void remove_OnObjectWasDestroyed(ObjectWasDestroyed value) { }

	[CompilerGenerated]
	public void remove_RestoredEvent(Action value) { }

	[CompilerGenerated]
	public void remove_UpdatedEvent(Action<UserModel> value) { }

	public void RunJavascript(string javascript) { }

	public void Show() { }

	[IteratorStateMachine(typeof(<ShowInSeconds>d__38))]
	private IEnumerator ShowInSeconds(float seconds) { }

	public Task ShowPage(string url) { }

	[IteratorStateMachine(typeof(<startTimeout>d__35))]
	private IEnumerator startTimeout(string url, CancellationToken canceller, TaskCompletionSource<Boolean> taskCompletionSource) { }

	private void triggerEvent(Action<T> eventToTrigger, T argument, string eventName) { }

	private void triggerEvent(Action eventToTrigger, string eventName) { }

	public void TryShowErrorToolTip(AuthProviderType provider) { }

	private void Update() { }

}

