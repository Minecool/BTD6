namespace Facepunch.Steamworks;

public class HtmlSurface
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public FailureCallback onFailure; //Field offset: 0x10
		public HtmlSurface <>4__this; //Field offset: 0x18
		public BrowserCallback onSuccess; //Field offset: 0x20

		public <>c__DisplayClass16_0() { }

		internal void <CreateBrowser>b__0(HTML_BrowserReady_t result, bool error) { }

	}

	internal sealed class BrowserCallback : MulticastDelegate
	{

		public BrowserCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal sealed class FailureCallback : MulticastDelegate
	{

		public FailureCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal sealed class FinishedRequestCallback : MulticastDelegate
	{

		public FinishedRequestCallback(object object, IntPtr method) { }

		public override void Invoke(string url) { }

	}

	internal sealed class NeedsPaintCallback : MulticastDelegate
	{

		public NeedsPaintCallback(object object, IntPtr method) { }

		public override void Invoke(uint unWide, uint unTall, Byte[] imgBytes) { }

	}

	internal sealed class StartRequestCallback : MulticastDelegate
	{

		public StartRequestCallback(object object, IntPtr method) { }

		public override void Invoke(string pchURL) { }

	}

	internal Client client; //Field offset: 0x10
	internal HHTMLBrowser browserHandle; //Field offset: 0x18
	private Byte[] imgBytes; //Field offset: 0x20
	public NeedsPaintCallback OnNeedsPaint; //Field offset: 0x28
	public StartRequestCallback OnStartRequest; //Field offset: 0x30
	public FinishedRequestCallback OnFinishedRequest; //Field offset: 0x38

	internal HtmlSurface(Client c) { }

	public void AllowStartRequest(bool allow) { }

	public void CreateBrowser(string pchUserAgent, string pchUserCSS, BrowserCallback onSuccess, FailureCallback onFailure) { }

	public void ExecuteJavascript(string script) { }

	public bool Init() { }

	public void KeyChar(uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

	public void KeyDown(uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

	public void KeyUp(uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

	public void LoadURL(string url, uint width, uint height) { }

	public void MouseDown(HTMLMouseButton eMouseButton) { }

	public void MouseMove(int x, int y) { }

	public void MouseUp(HTMLMouseButton eMouseButton) { }

	public void MouseWheel(int delta) { }

	private void OnFileOpenDialogAPI(HTML_FileOpenDialog_t callbackdata) { }

	private void OnFinishedRequestAPI(HTML_FinishedRequest_t callbackdata) { }

	private void OnJSAlertAPI(HTML_JSAlert_t callbackdata) { }

	private void OnJSConfirmAPI(HTML_JSConfirm_t callbackdata) { }

	private void OnNeedsPaintAPI(HTML_NeedsPaint_t callbackdata) { }

	private void OnStartRequestAPI(HTML_StartRequest_t callbackdata) { }

	public void Reload() { }

	public void RemoveBrowser() { }

	public bool Shutdown() { }

	public void StopLoad() { }

}

