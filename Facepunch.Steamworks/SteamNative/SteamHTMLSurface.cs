namespace SteamNative;

internal class SteamHTMLSurface : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamHTMLSurface(BaseSteamworks steamworks, IntPtr pointer) { }

	public void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed) { }

	public CallbackHandle CreateBrowser(string pchUserAgent, string pchUserCSS, Action<HTML_BrowserReady_t, Boolean> CallbackFunction = null) { }

	public override void Dispose() { }

	public void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript) { }

	public bool Init() { }

	public void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

	public void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

	public void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

	public void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData) { }

	public void MouseDown(HHTMLBrowser unBrowserHandle, HTMLMouseButton eMouseButton) { }

	public void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y) { }

	public void MouseUp(HHTMLBrowser unBrowserHandle, HTMLMouseButton eMouseButton) { }

	public void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta) { }

	public void Reload(HHTMLBrowser unBrowserHandle) { }

	public void RemoveBrowser(HHTMLBrowser unBrowserHandle) { }

	public void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) { }

	public void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) { }

	public bool Shutdown() { }

	public void StopLoad(HHTMLBrowser unBrowserHandle) { }

}

