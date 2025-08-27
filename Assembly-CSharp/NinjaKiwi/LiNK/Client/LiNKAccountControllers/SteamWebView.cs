namespace NinjaKiwi.LiNK.Client.LiNKAccountControllers;

public class SteamWebView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <LoadAsync>d__34 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SteamWebView <>4__this; //Field offset: 0x20
		public string url; //Field offset: 0x28

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
		public <LoadAsync>d__34(int <>1__state) { }

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

	internal sealed class LoadCompleteDelegate : MulticastDelegate
	{

		public LoadCompleteDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(SteamWebView surface, bool success, string errorMessage, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(SteamWebView surface, bool success, string errorMessage) { }

	}

	internal sealed class StartRequestDelegate : MulticastDelegate
	{

		public StartRequestDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebViewMessage message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebViewMessage message) { }

	}

	private const string kLogTag = "[SteamWebView]"; //Field offset: 0x0
	[HideInInspector]
	public bool onlyShowNK; //Field offset: 0x20
	public bool browserReady; //Field offset: 0x21
	public Texture2D texture; //Field offset: 0x28
	private Vector2 lastMousePos; //Field offset: 0x30
	private uint verticalScrollMax; //Field offset: 0x38
	private uint veritcalScrollCurrent; //Field offset: 0x3C
	private uint horizontalScrollMax; //Field offset: 0x40
	private uint horizontalScrollCurrent; //Field offset: 0x44
	private bool hidden; //Field offset: 0x48
	private bool loadingUrl; //Field offset: 0x49
	[CompilerGenerated]
	private MessageReceivedDelegate OnMessageReceived; //Field offset: 0x50
	[CompilerGenerated]
	private PageFinishedDelegate OnPageFinished; //Field offset: 0x58
	[CompilerGenerated]
	private LoadingErrorReceivedDelegate OnLoadingErrorReceived; //Field offset: 0x60

	public event LoadingErrorReceivedDelegate OnLoadingErrorReceived
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event MessageReceivedDelegate OnMessageReceived
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event PageFinishedDelegate OnPageFinished
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private HtmlSurface Surface
	{
		private get { } //Length: 140
	}

	public SteamWebView() { }

	[CompilerGenerated]
	private void <Awake>b__29_0() { }

	[CompilerGenerated]
	private void <Awake>b__29_1() { }

	[CompilerGenerated]
	public void add_OnLoadingErrorReceived(LoadingErrorReceivedDelegate value) { }

	[CompilerGenerated]
	public void add_OnMessageReceived(MessageReceivedDelegate value) { }

	[CompilerGenerated]
	public void add_OnPageFinished(PageFinishedDelegate value) { }

	private void Awake() { }

	private bool ConvertSpecialKeyToVirtualKey(KeyCode keyCode, ref uint vKey) { }

	private void DebugLog(string msg) { }

	private void DebugLogTag(string tag, string msg) { }

	public void EvaluateJavaScript(string javascript) { }

	private HtmlSurface get_Surface() { }

	private HTMLKeyModifiers GetModifiers(Event e) { }

	public void Hide() { }

	public void Load(string url) { }

	[IteratorStateMachine(typeof(<LoadAsync>d__34))]
	private IEnumerator LoadAsync(string url) { }

	private void LogErrorTag(string tag, string msg) { }

	private void LogWarningTag(string tag, string msg) { }

	public static string MakeLinkUserAgentName(string gameName, RuntimePlatform platform, string appVersion) { }

	private void OnDestroy() { }

	public void OnDisable() { }

	private void OnFinishedRequest(string url) { }

	public void OnGUI() { }

	private void OnNeedsPaint(uint unWide, uint unTall, Byte[] imgBytes) { }

	private void OnStartRequest(string pchURL) { }

	public void Reload() { }

	[CompilerGenerated]
	public void remove_OnLoadingErrorReceived(LoadingErrorReceivedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnMessageReceived(MessageReceivedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPageFinished(PageFinishedDelegate value) { }

	public void SetOpenLinksInExternalBrowser(bool flag) { }

	public void Show() { }

	public void Stop() { }

}

