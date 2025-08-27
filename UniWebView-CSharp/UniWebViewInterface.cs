//Type is in global namespace

public class UniWebViewInterface
{
	private static bool alreadyLoggedWarning; //Field offset: 0x0

	public UniWebViewInterface() { }

	public static void AddJavaScript(string name, string jsString, string identifier) { }

	public static void AddSslExceptionDomain(string name, string domain) { }

	public static void AddUrlScheme(string name, string scheme) { }

	public static bool AnimateTo(string name, int x, int y, int width, int height, float duration, float delay, string identifier) { }

	public static void AuthenticationInit(string name, string url, string scheme) { }

	public static void AuthenticationSetPrivateMode(string name, bool enabled) { }

	public static void AuthenticationStart(string name) { }

	public static bool CanGoBack(string name) { }

	public static bool CanGoForward(string name) { }

	public static void CaptureSnapshot(string name, string filename) { }

	public static void CheckPlatform() { }

	public static void CleanCache(string name) { }

	public static void ClearCookies() { }

	public static void ClearHttpAuthUsernamePassword(string host, string realm) { }

	public static void Destroy(string name) { }

	public static void EvaluateJavaScript(string name, string jsString, string identifier) { }

	public static string GetCookie(string url, string key, bool skipEncoding) { }

	public static Byte[] GetRenderedData(string name, int x, int y, int width, int height) { }

	public static string GetUrl(string name) { }

	public static string GetUserAgent(string name) { }

	public static float GetWebViewAlpha(string name) { }

	public static void GoBack(string name) { }

	public static void GoForward(string name) { }

	public static bool Hide(string name, bool fade, int edge, float duration, bool useAsync, string identifier) { }

	public static void HideSpinner(string name) { }

	public static void Init(string name, int x, int y, int width, int height) { }

	public static bool IsAuthenticationIsSupported() { }

	public static void Load(string name, string url, bool skipEncoding, string readAccessURL) { }

	public static void LoadHTMLString(string name, string html, string baseUrl, bool skipEncoding) { }

	public static float NativeScreenHeight() { }

	public static float NativeScreenWidth() { }

	public static void Print(string name) { }

	public static void Reload(string name) { }

	public static void RemoveCookie(string url, string key, bool skipEncoding) { }

	public static void RemoveCookies(string url, bool skipEncoding) { }

	public static void RemoveSslExceptionDomain(string name, string domain) { }

	public static void RemoveUrlScheme(string name, string scheme) { }

	public static void SafeBrowsingInit(string name, string url) { }

	public static void SafeBrowsingSetToolbarColor(string name, float r, float g, float b) { }

	public static void SafeBrowsingShow(string name) { }

	public static void ScrollTo(string name, int x, int y, bool animated) { }

	public static void SetAllowAutoPlay(bool flag) { }

	public static void SetAllowFileAccess(string name, bool flag) { }

	public static void SetAllowFileAccessFromFileURLs(string name, bool flag) { }

	public static void SetAllowHTTPAuthPopUpWindow(string name, bool flag) { }

	public static void SetAllowInlinePlay(bool flag) { }

	public static void SetAllowJavaScriptOpenWindow(bool flag) { }

	public static void SetAllowUniversalAccessFromFileURLs(bool flag) { }

	public static void SetAllowUserDismissSpinnerByGesture(string name, bool flag) { }

	public static void SetAllowUserEditFileNameBeforeDownloading(string name, bool allowed) { }

	public static void SetBackgroundColor(string name, float r, float g, float b, float a) { }

	public static void SetBouncesEnabled(string name, bool enabled) { }

	public static void SetCacheMode(string name, int mode) { }

	public static void SetCalloutEnabled(string name, bool flag) { }

	public static void SetCookie(string url, string cookie, bool skipEncoding) { }

	public static void SetDragInteractionEnabled(string name, bool flag) { }

	public static void SetEmbeddedToolbarBackgroundColor(string name, Color color) { }

	public static void SetEmbeddedToolbarButtonTextColor(string name, Color color) { }

	public static void SetEmbeddedToolbarDoneButtonText(string name, string text) { }

	public static void SetEmbeddedToolbarGoBackButtonText(string name, string text) { }

	public static void SetEmbeddedToolbarGoForwardButtonText(string name, string text) { }

	public static void SetEmbeddedToolbarOnTop(string name, bool top) { }

	public static void SetEmbeddedToolbarTitleText(string name, string text) { }

	public static void SetEmbeddedToolbarTitleTextColor(string name, Color color) { }

	public static void SetEmeddedToolbarNavigationButtonsShow(string name, bool show) { }

	public static void SetForwardWebConsoleToNativeOutput(bool flag) { }

	public static void SetFrame(string name, int x, int y, int width, int height) { }

	public static void SetHeaderField(string name, string key, string value) { }

	public static void SetHorizontalScrollBarEnabled(string name, bool enabled) { }

	public static void SetJavaScriptEnabled(bool flag) { }

	public static void SetLimitsNavigationsToAppBoundDomains(bool enabled) { }

	public static void SetLogLevel(int level) { }

	public static void SetOpenLinksInExternalBrowser(string name, bool flag) { }

	public static void SetPosition(string name, int x, int y) { }

	public static void SetShowEmbeddedToolbar(string name, bool show) { }

	public static void SetShowSpinnerWhileLoading(string name, bool show) { }

	public static void SetShowToolbar(string name, bool show, bool animated, bool onTop, bool adjustInset) { }

	public static void SetSize(string name, int width, int height) { }

	public static void SetSpinnerText(string name, string text) { }

	public static void SetSupportMultipleWindows(string name, bool enabled, bool allowJavaScriptOpening) { }

	public static void SetToolbarDoneButtonText(string name, string text) { }

	public static void SetToolbarGoBackButtonText(string name, string text) { }

	public static void SetToolbarGoForwardButtonText(string name, string text) { }

	public static void SetToolbarTextColor(string name, float r, float g, float b) { }

	public static void SetToolbarTintColor(string name, float r, float g, float b) { }

	public static void SetTransparencyClickingThroughEnabled(string name, bool enabled) { }

	public static void SetUserAgent(string name, string userAgent) { }

	public static void SetUserInteractionEnabled(string name, bool enabled) { }

	public static void SetVerticalScrollBarEnabled(string name, bool enabled) { }

	public static void SetWebContentsDebuggingEnabled(bool enabled) { }

	public static void SetWebViewAlpha(string name, float alpha) { }

	public static void SetZoomEnabled(string name, bool enabled) { }

	public static bool Show(string name, bool fade, int edge, float duration, bool useAsync, string identifier) { }

	public static void ShowSpinner(string name) { }

	public static void StartSnapshotForRendering(string name, string identifier) { }

	public static void Stop(string name) { }

	public static void StopSnapshotForRendering(string name) { }

}

