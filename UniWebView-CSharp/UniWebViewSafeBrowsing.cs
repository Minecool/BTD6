//Type is in global namespace

public class UniWebViewSafeBrowsing : object
{
	internal sealed class OnSafeBrowsingFinishedDelegate : MulticastDelegate
	{

		public OnSafeBrowsingFinishedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebViewSafeBrowsing browsing, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebViewSafeBrowsing browsing) { }

	}

	[CompilerGenerated]
	private OnSafeBrowsingFinishedDelegate OnSafeBrowsingFinished; //Field offset: 0x18
	private string id; //Field offset: 0x20
	private UniWebViewNativeListener listener; //Field offset: 0x28
	private string url; //Field offset: 0x30

	public event OnSafeBrowsingFinishedDelegate OnSafeBrowsingFinished
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public static bool IsSafeBrowsingSupported
	{
		 get { } //Length: 3
	}

	private UniWebViewSafeBrowsing() { }

	[CompilerGenerated]
	public void add_OnSafeBrowsingFinished(OnSafeBrowsingFinishedDelegate value) { }

	public static UniWebViewSafeBrowsing Create(string url) { }

	public void Dismiss() { }

	public static bool get_IsSafeBrowsingSupported() { }

	private void Init(string url) { }

	internal void InternalSafeBrowsingFinished() { }

	[CompilerGenerated]
	public void remove_OnSafeBrowsingFinished(OnSafeBrowsingFinishedDelegate value) { }

	public void SetToolbarColor(Color color) { }

	public void SetToolbarItemColor(Color color) { }

	public void Show() { }

}

