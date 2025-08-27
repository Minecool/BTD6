//Type is in global namespace

public class UniWebView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass175_0
	{
		public Action<String> handler; //Field offset: 0x10

		public <>c__DisplayClass175_0() { }

		internal void <GetHTMLContent>b__0(UniWebViewNativeResultPayload payload) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass194_0
	{
		public UniWebView <>4__this; //Field offset: 0x10
		public Nullable<Rect> rect; //Field offset: 0x18
		public Action<Texture2D> onStarted; //Field offset: 0x30

		public <>c__DisplayClass194_0() { }

		internal void <StartSnapshotForRendering>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass198_0
	{
		public Func<UniWebViewChannelMethodHandleRequest, Boolean> handler; //Field offset: 0x10

		public <>c__DisplayClass198_0() { }

		internal object <RegisterShouldHandleRequest>g__Func|0(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass200_0
	{
		public Func<UniWebViewChannelMethodMediaCapturePermission, UniWebViewMediaCapturePermissionDecision> handler; //Field offset: 0x10

		public <>c__DisplayClass200_0() { }

		internal object <RegisterOnRequestMediaCapturePermission>g__Func|0(object obj) { }

	}

	internal sealed class CaptureSnapshotFinished : MulticastDelegate
	{

		public CaptureSnapshotFinished(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, int errorCode, string diskPath, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, int errorCode, string diskPath) { }

	}

	internal sealed class FileDownloadFinished : MulticastDelegate
	{

		public FileDownloadFinished(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, int errorCode, string remoteUrl, string diskPath, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, int errorCode, string remoteUrl, string diskPath) { }

	}

	internal sealed class FileDownloadStarted : MulticastDelegate
	{

		public FileDownloadStarted(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, string remoteUrl, string fileName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, string remoteUrl, string fileName) { }

	}

	[Obsolete("KeyCodeReceivedDelegate is deprecated. Now UniWebView never intercepts device key code events. Check `Input.GetKeyUp` instead.", False)]
	internal sealed class KeyCodeReceivedDelegate : MulticastDelegate
	{

		public KeyCodeReceivedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, int keyCode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, int keyCode) { }

	}

	internal sealed class LoadingErrorReceivedDelegate : MulticastDelegate
	{

		public LoadingErrorReceivedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, int errorCode, string errorMessage, UniWebViewNativeResultPayload payload, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, int errorCode, string errorMessage, UniWebViewNativeResultPayload payload) { }

	}

	internal sealed class MessageReceivedDelegate : MulticastDelegate
	{

		public MessageReceivedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, UniWebViewMessage message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, UniWebViewMessage message) { }

	}

	internal sealed class MultipleWindowClosedDelegate : MulticastDelegate
	{

		public MultipleWindowClosedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, string multipleWindowId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, string multipleWindowId) { }

	}

	internal sealed class MultipleWindowOpenedDelegate : MulticastDelegate
	{

		public MultipleWindowOpenedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, string multipleWindowId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, string multipleWindowId) { }

	}

	internal sealed class OnWebContentProcessTerminatedDelegate : MulticastDelegate
	{

		public OnWebContentProcessTerminatedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView) { }

	}

	internal sealed class OrientationChangedDelegate : MulticastDelegate
	{

		public OrientationChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, ScreenOrientation orientation, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, ScreenOrientation orientation) { }

	}

	[Obsolete("PageErrorReceivedDelegate is deprecated. Use `LoadingErrorReceivedDelegate` instead.", False)]
	internal sealed class PageErrorReceivedDelegate : MulticastDelegate
	{

		public PageErrorReceivedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, int errorCode, string errorMessage, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, int errorCode, string errorMessage) { }

	}

	internal sealed class PageFinishedDelegate : MulticastDelegate
	{

		public PageFinishedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, int statusCode, string url, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, int statusCode, string url) { }

	}

	internal sealed class PageProgressChangedDelegate : MulticastDelegate
	{

		public PageProgressChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, float progress, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, float progress) { }

	}

	internal sealed class PageStartedDelegate : MulticastDelegate
	{

		public PageStartedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, string url, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebView webView, string url) { }

	}

	internal sealed class ShouldCloseDelegate : MulticastDelegate
	{

		public ShouldCloseDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebView webView, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(UniWebView webView) { }

	}

	private static readonly Rect snapshotFullViewRect; //Field offset: 0x0
	[CompilerGenerated]
	private PageStartedDelegate OnPageStarted; //Field offset: 0x20
	[CompilerGenerated]
	private PageFinishedDelegate OnPageFinished; //Field offset: 0x28
	[CompilerGenerated]
	private PageErrorReceivedDelegate OnPageErrorReceived; //Field offset: 0x30
	[CompilerGenerated]
	private LoadingErrorReceivedDelegate OnLoadingErrorReceived; //Field offset: 0x38
	[CompilerGenerated]
	private PageProgressChangedDelegate OnPageProgressChanged; //Field offset: 0x40
	[CompilerGenerated]
	private MessageReceivedDelegate OnMessageReceived; //Field offset: 0x48
	[CompilerGenerated]
	private ShouldCloseDelegate OnShouldClose; //Field offset: 0x50
	[CompilerGenerated]
	private OrientationChangedDelegate OnOrientationChanged; //Field offset: 0x58
	[CompilerGenerated]
	private OnWebContentProcessTerminatedDelegate OnWebContentProcessTerminated; //Field offset: 0x60
	[CompilerGenerated]
	private FileDownloadStarted OnFileDownloadStarted; //Field offset: 0x68
	[CompilerGenerated]
	private FileDownloadFinished OnFileDownloadFinished; //Field offset: 0x70
	[CompilerGenerated]
	private CaptureSnapshotFinished OnCaptureSnapshotFinished; //Field offset: 0x78
	[CompilerGenerated]
	private MultipleWindowOpenedDelegate OnMultipleWindowOpened; //Field offset: 0x80
	[CompilerGenerated]
	private MultipleWindowClosedDelegate OnMultipleWindowClosed; //Field offset: 0x88
	private string id; //Field offset: 0x90
	private UniWebViewNativeListener listener; //Field offset: 0x98
	[CompilerGenerated]
	private UniWebViewEmbeddedToolbar <EmbeddedToolbar>k__BackingField; //Field offset: 0xA0
	private ScreenOrientation currentOrientation; //Field offset: 0xA8
	[SerializeField]
	private string urlOnStart; //Field offset: 0xB0
	[SerializeField]
	private bool showOnStart; //Field offset: 0xB8
	[SerializeField]
	private bool fullScreen; //Field offset: 0xB9
	[Obsolete("Use Toolbar is deprecated. Use the embedded toolbar instead.", False)]
	[SerializeField]
	private bool useToolbar; //Field offset: 0xBA
	[Obsolete("Use Toolbar is deprecated. Use the embedded toolbar instead.", False)]
	[SerializeField]
	private UniWebViewToolbarPosition toolbarPosition; //Field offset: 0xBC
	[SerializeField]
	private bool useEmbeddedToolbar; //Field offset: 0xC0
	[SerializeField]
	private UniWebViewToolbarPosition embeddedToolbarPosition; //Field offset: 0xC4
	private Dictionary<String, Action> actions; //Field offset: 0xC8
	private Dictionary<String, Action`1<UniWebViewNativeResultPayload>> payloadActions; //Field offset: 0xD0
	[SerializeField]
	private Rect frame; //Field offset: 0xD8
	[SerializeField]
	private RectTransform referenceRectTransform; //Field offset: 0xE8
	private bool started; //Field offset: 0xF0
	private bool backButtonEnabled; //Field offset: 0xF1
	[CompilerGenerated]
	private bool <RestoreViewHierarchyOnResume>k__BackingField; //Field offset: 0xF2
	private Color backgroundColor; //Field offset: 0xF4
	[CompilerGenerated]
	private KeyCodeReceivedDelegate OnKeyCodeReceived; //Field offset: 0x108

	public event CaptureSnapshotFinished OnCaptureSnapshotFinished
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event FileDownloadFinished OnFileDownloadFinished
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event FileDownloadStarted OnFileDownloadStarted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	[Obsolete("OnKeyCodeReceived is deprecated and never called. Now UniWebView never intercepts device key code events. Check `Input.GetKeyUp` instead.", False)]
	public event KeyCodeReceivedDelegate OnKeyCodeReceived
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

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

	public event MultipleWindowClosedDelegate OnMultipleWindowClosed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event MultipleWindowOpenedDelegate OnMultipleWindowOpened
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event OrientationChangedDelegate OnOrientationChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	[Obsolete("OnPageErrorReceived is deprecated. Use `OnLoadingErrorReceived` instead.", False)]
	public event PageErrorReceivedDelegate OnPageErrorReceived
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

	public event PageProgressChangedDelegate OnPageProgressChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event PageStartedDelegate OnPageStarted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ShouldCloseDelegate OnShouldClose
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event OnWebContentProcessTerminatedDelegate OnWebContentProcessTerminated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public float Alpha
	{
		 get { } //Length: 58
		 set { } //Length: 54
	}

	public Color BackgroundColor
	{
		 get { } //Length: 14
		 set { } //Length: 64
	}

	public bool CanGoBack
	{
		 get { } //Length: 57
	}

	public bool CanGoForward
	{
		 get { } //Length: 57
	}

	public private UniWebViewEmbeddedToolbar EmbeddedToolbar
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Rect Frame
	{
		 get { } //Length: 14
		 set { } //Length: 96
	}

	public static bool IsWebViewSupported
	{
		 get { } //Length: 3
	}

	public RectTransform ReferenceRectTransform
	{
		 get { } //Length: 8
		 set { } //Length: 93
	}

	public bool RestoreViewHierarchyOnResume
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public string Url
	{
		 get { } //Length: 90
	}

	public bool _Hide(bool fade = false, UniWebViewTransitionEdge edge = 0, float duration = 0.4, bool useAsync = false, Action completionHandler = null) { }

	public bool _Show(bool fade = false, UniWebViewTransitionEdge edge = 0, float duration = 0.4, bool useAsync = false, Action completionHandler = null) { }

	private static UniWebView() { }

	public UniWebView() { }

	[CompilerGenerated]
	public void add_OnCaptureSnapshotFinished(CaptureSnapshotFinished value) { }

	[CompilerGenerated]
	public void add_OnFileDownloadFinished(FileDownloadFinished value) { }

	[CompilerGenerated]
	public void add_OnFileDownloadStarted(FileDownloadStarted value) { }

	[CompilerGenerated]
	public void add_OnKeyCodeReceived(KeyCodeReceivedDelegate value) { }

	[CompilerGenerated]
	public void add_OnLoadingErrorReceived(LoadingErrorReceivedDelegate value) { }

	[CompilerGenerated]
	public void add_OnMessageReceived(MessageReceivedDelegate value) { }

	[CompilerGenerated]
	public void add_OnMultipleWindowClosed(MultipleWindowClosedDelegate value) { }

	[CompilerGenerated]
	public void add_OnMultipleWindowOpened(MultipleWindowOpenedDelegate value) { }

	[CompilerGenerated]
	public void add_OnOrientationChanged(OrientationChangedDelegate value) { }

	[CompilerGenerated]
	public void add_OnPageErrorReceived(PageErrorReceivedDelegate value) { }

	[CompilerGenerated]
	public void add_OnPageFinished(PageFinishedDelegate value) { }

	[CompilerGenerated]
	public void add_OnPageProgressChanged(PageProgressChangedDelegate value) { }

	[CompilerGenerated]
	public void add_OnPageStarted(PageStartedDelegate value) { }

	[CompilerGenerated]
	public void add_OnShouldClose(ShouldCloseDelegate value) { }

	[CompilerGenerated]
	public void add_OnWebContentProcessTerminated(OnWebContentProcessTerminatedDelegate value) { }

	public void AddDownloadMIMEType(string MIMEType, UniWebViewDownloadMatchingType type = 1) { }

	public void AddDownloadURL(string urlString, UniWebViewDownloadMatchingType type = 1) { }

	public void AddJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = null) { }

	[Obsolete("Deprecated. Use `RegisterOnRequestMediaCapturePermission` instead. Check https://docs.uniwebview.com/api/#registeronrequestmediacapturepermission", False)]
	public void AddPermissionTrustDomain(string domain) { }

	public void AddSslExceptionDomain(string domain) { }

	public void AddUrlScheme(string scheme) { }

	public bool AnimateTo(Rect frame, float duration, float delay = 0, Action completionHandler = null) { }

	private void Awake() { }

	public void CaptureSnapshot(string fileName) { }

	public void CleanCache() { }

	public static void ClearCookies() { }

	public static void ClearHttpAuthUsernamePassword(string host, string realm) { }

	public Texture2D CreateRenderedTexture(Nullable<Rect> rect = null) { }

	public void EvaluateJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = null) { }

	public float get_Alpha() { }

	public Color get_BackgroundColor() { }

	public bool get_CanGoBack() { }

	public bool get_CanGoForward() { }

	[CompilerGenerated]
	public UniWebViewEmbeddedToolbar get_EmbeddedToolbar() { }

	public Rect get_Frame() { }

	public static bool get_IsWebViewSupported() { }

	public RectTransform get_ReferenceRectTransform() { }

	[CompilerGenerated]
	public bool get_RestoreViewHierarchyOnResume() { }

	public string get_Url() { }

	public static string GetCookie(string url, string key, bool skipEncoding = false) { }

	public void GetHTMLContent(Action<String> handler) { }

	public Byte[] GetRenderedData(Nullable<Rect> rect = null) { }

	public string GetUserAgent() { }

	public void GoBack() { }

	public void GoForward() { }

	public bool Hide(bool fade = false, UniWebViewTransitionEdge edge = 0, float duration = 0.4, Action completionHandler = null) { }

	public void HideSpinner() { }

	internal void InternalOnAddJavaScriptFinished(UniWebViewNativeResultPayload payload) { }

	internal void InternalOnAnimateToFinished(string identifier) { }

	internal void InternalOnCaptureSnapshotFinished(UniWebViewNativeResultPayload payload) { }

	internal void InternalOnEvalJavaScriptFinished(UniWebViewNativeResultPayload payload) { }

	internal void InternalOnFileDownloadFinished(UniWebViewNativeResultPayload payload) { }

	internal void InternalOnFileDownloadStarted(UniWebViewNativeResultPayload payload) { }

	internal void InternalOnHideTransitionFinished(string identifier) { }

	internal void InternalOnMessageReceived(string result) { }

	internal void InternalOnMultipleWindowClosed(string multiWindowId) { }

	internal void InternalOnMultipleWindowOpened(string multiWindowId) { }

	internal void InternalOnPageErrorReceived(UniWebViewNativeResultPayload payload) { }

	internal void InternalOnPageFinished(UniWebViewNativeResultPayload payload) { }

	internal void InternalOnPageProgressChanged(float progress) { }

	internal void InternalOnPageStarted(string url) { }

	internal void InternalOnShouldClose() { }

	internal void InternalOnShowTransitionFinished(string identifier) { }

	internal void InternalOnSnapshotRenderingStarted(string identifier) { }

	internal void InternalOnWebContentProcessDidTerminate() { }

	public void Load(string url, bool skipEncoding = false, string readAccessURL = null) { }

	public void LoadHTMLString(string htmlString, string baseUrl, bool skipEncoding = false) { }

	private Rect NextFrameRect() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Print() { }

	public void RegisterOnRequestMediaCapturePermission(Func<UniWebViewChannelMethodMediaCapturePermission, UniWebViewMediaCapturePermissionDecision> handler) { }

	public void RegisterShouldHandleRequest(Func<UniWebViewChannelMethodHandleRequest, Boolean> handler) { }

	public void Reload() { }

	[CompilerGenerated]
	public void remove_OnCaptureSnapshotFinished(CaptureSnapshotFinished value) { }

	[CompilerGenerated]
	public void remove_OnFileDownloadFinished(FileDownloadFinished value) { }

	[CompilerGenerated]
	public void remove_OnFileDownloadStarted(FileDownloadStarted value) { }

	[CompilerGenerated]
	public void remove_OnKeyCodeReceived(KeyCodeReceivedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnLoadingErrorReceived(LoadingErrorReceivedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnMessageReceived(MessageReceivedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnMultipleWindowClosed(MultipleWindowClosedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnMultipleWindowOpened(MultipleWindowOpenedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnOrientationChanged(OrientationChangedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPageErrorReceived(PageErrorReceivedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPageFinished(PageFinishedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPageProgressChanged(PageProgressChangedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPageStarted(PageStartedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnShouldClose(ShouldCloseDelegate value) { }

	[CompilerGenerated]
	public void remove_OnWebContentProcessTerminated(OnWebContentProcessTerminatedDelegate value) { }

	public static void RemoveCooke(string url, string key, bool skipEncoding = false) { }

	public static void RemoveCookies(string url, bool skipEncoding = false) { }

	public void RemoveDownloadMIMETypes(string MIMEType, UniWebViewDownloadMatchingType type = 1) { }

	public void RemoveDownloadURL(string urlString, UniWebViewDownloadMatchingType type = 1) { }

	[Obsolete("Deprecated. Use `UnregisterOnRequestMediaCapturePermission` instead.", False)]
	public void RemovePermissionTrustDomain(string domain) { }

	public void RemoveSslExceptionDomain(string domain) { }

	public void RemoveUrlScheme(string scheme) { }

	public void ScrollTo(int x, int y, bool animated) { }

	public void set_Alpha(float value) { }

	public void set_BackgroundColor(Color value) { }

	[CompilerGenerated]
	private void set_EmbeddedToolbar(UniWebViewEmbeddedToolbar value) { }

	public void set_Frame(Rect value) { }

	public void set_ReferenceRectTransform(RectTransform value) { }

	[CompilerGenerated]
	public void set_RestoreViewHierarchyOnResume(bool value) { }

	public void SetAcceptThirdPartyCookies(bool flag) { }

	public static void SetAllowAutoPlay(bool flag) { }

	public void SetAllowBackForwardNavigationGestures(bool flag) { }

	public void SetAllowFileAccess(bool flag) { }

	public void SetAllowFileAccessFromFileURLs(bool flag) { }

	public void SetAllowHTTPAuthPopUpWindow(bool flag) { }

	public static void SetAllowInlinePlay(bool flag) { }

	public static void SetAllowJavaScriptOpenWindow(bool flag) { }

	public static void SetAllowUniversalAccessFromFileURLs(bool flag) { }

	public void SetAllowUserChooseActionAfterDownloading(bool allowed) { }

	public void SetAllowUserDismissSpinner(bool flag) { }

	public void SetAllowUserEditFileNameBeforeDownloading(bool allowed) { }

	public void SetBackButtonEnabled(bool enabled) { }

	public void SetBouncesEnabled(bool enabled) { }

	public void SetCacheMode(UniWebViewCacheMode cacheMode) { }

	public void SetCalloutEnabled(bool enabled) { }

	public void SetContentInsetAdjustmentBehavior(UniWebViewContentInsetAdjustmentBehavior behavior) { }

	public static void SetCookie(string url, string cookie, bool skipEncoding = false) { }

	public void SetDefaultFontSize(int size) { }

	public void SetDownloadEventForContextMenuEnabled(bool enabled) { }

	public void SetDragInteractionEnabled(bool enabled) { }

	public static void SetEnableKeyboardAvoidance(bool flag) { }

	public static void SetForwardWebConsoleToNativeOutput(bool flag) { }

	public void SetHeaderField(string key, string value) { }

	public void SetHorizontalScrollBarEnabled(bool enabled) { }

	[Obsolete("SetImmersiveModeEnabled is deprecated. Now UniWebView always respect navigation bar/status bar settings from Unity.", False)]
	public void SetImmersiveModeEnabled(bool enabled) { }

	public static void SetJavaScriptEnabled(bool enabled) { }

	public static void SetLimitsNavigationsToAppBoundDomains(bool enabled) { }

	public void SetLoadWithOverviewMode(bool flag) { }

	public void SetOpenLinksInExternalBrowser(bool flag) { }

	public void SetShowSpinnerWhileLoading(bool flag) { }

	[Obsolete("`SetShowToolbar` is deprecated. Use `EmbeddedToolbar.Show()` or `EmbeddedToolbar.Hide()`instead.", False)]
	public void SetShowToolbar(bool show, bool animated = false, bool onTop = true, bool adjustInset = false) { }

	[Obsolete("`SetShowToolbarNavigationButtons` is deprecated. Use `EmbeddedToolbar.ShowNavigationButtons` or `EmbeddedToolbar.HideNavigationButtons` instead.", False)]
	public void SetShowToolbarNavigationButtons(bool show) { }

	public void SetSpinnerText(string text) { }

	public void SetSupportMultipleWindows(bool enabled, bool allowJavaScriptOpening) { }

	[Obsolete("Deprecated. Use `SetSupportMultipleWindows(bool enabled, bool allowJavaScriptOpen)` to set `allowJavaScriptOpen` explicitly.")]
	public void SetSupportMultipleWindows(bool enabled) { }

	public void SetTextZoom(int textZoom) { }

	[Obsolete("`SetToolbarDoneButtonText` is deprecated. Use `EmbeddedToolbar.SetDoneButtonText` instead.", False)]
	public void SetToolbarDoneButtonText(string text) { }

	[Obsolete("`SetToolbarGoBackButtonText` is deprecated. Use `EmbeddedToolbar.SetGoBackButtonText` instead.", False)]
	public void SetToolbarGoBackButtonText(string text) { }

	[Obsolete("`SetToolbarGoForwardButtonText` is deprecated. Use `EmbeddedToolbar.SetGoForwardButtonText` instead.", False)]
	public void SetToolbarGoForwardButtonText(string text) { }

	[Obsolete("`SetToolbarTextColor` is deprecated. Use `EmbeddedToolbar.SetButtonTextColor` or `EmbeddedToolbar.SetTitleTextColor` instead.", False)]
	public void SetToolbarTextColor(Color color) { }

	[Obsolete("`SetToolbarTintColor` is deprecated. Use `EmbeddedToolbar.SetBackgroundColor` instead.", False)]
	public void SetToolbarTintColor(Color color) { }

	public void SetTransparencyClickingThroughEnabled(bool enabled) { }

	public void SetUserAgent(string agent) { }

	public void SetUserInteractionEnabled(bool enabled) { }

	public void SetUseWideViewPort(bool flag) { }

	public void SetVerticalScrollBarEnabled(bool enabled) { }

	public static void SetWebContentsDebuggingEnabled(bool enabled) { }

	public void SetWindowUserResizeEnabled(bool enabled) { }

	public void SetZoomEnabled(bool enabled) { }

	public bool Show(bool fade = false, UniWebViewTransitionEdge edge = 0, float duration = 0.4, Action completionHandler = null) { }

	public void ShowSpinner() { }

	private void Start() { }

	public void StartSnapshotForRendering(Nullable<Rect> rect = null, Action<Texture2D> onStarted = null) { }

	public void Stop() { }

	public void StopSnapshotForRendering() { }

	public void UnregisterOnRequestMediaCapturePermission() { }

	public void UnregisterShouldHandleRequest() { }

	private void Update() { }

	public void UpdateFrame() { }

}

