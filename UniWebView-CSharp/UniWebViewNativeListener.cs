//Type is in global namespace

public class UniWebViewNativeListener : MonoBehaviour
{
	private static Dictionary<String, UniWebViewNativeListener> listeners; //Field offset: 0x0
	[HideInInspector]
	public UniWebView webView; //Field offset: 0x20
	[HideInInspector]
	public UniWebViewSafeBrowsing safeBrowsing; //Field offset: 0x28
	[HideInInspector]
	public UniWebViewAuthenticationSession session; //Field offset: 0x30

	public string Name
	{
		 get { } //Length: 35
	}

	private static UniWebViewNativeListener() { }

	public UniWebViewNativeListener() { }

	public void AddJavaScriptFinished(string result) { }

	public static void AddListener(UniWebViewNativeListener target) { }

	public void AnimateToFinished(string identifer) { }

	public void AuthErrorReceived(string result) { }

	public void AuthFinished(string result) { }

	public void CaptureSnapshotFinished(string result) { }

	public void EvalJavaScriptFinished(string result) { }

	public void FileDownloadFinished(string result) { }

	public void FileDownloadStarted(string result) { }

	public string get_Name() { }

	public static UniWebViewNativeListener GetListener(string name) { }

	public void HideTransitionFinished(string identifer) { }

	public void MessageReceived(string result) { }

	public void MultipleWindowClosed(string param) { }

	public void MultipleWindowOpened(string param) { }

	public void PageErrorReceived(string result) { }

	public void PageFinished(string result) { }

	public void PageProgressChanged(string result) { }

	public void PageStarted(string url) { }

	public static void RemoveListener(string name) { }

	public void SafeBrowsingFinished(string param) { }

	public void ShowTransitionFinished(string identifer) { }

	public void SnapshotRenderingStarted(string identifier) { }

	public void WebContentProcessDidTerminate(string param) { }

	public void WebViewDone(string param) { }

}

