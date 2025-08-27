//Type is in global namespace

public class UniWebViewAuthenticationSession : object
{
	internal sealed class AuthenticationFinishedDelegate : MulticastDelegate
	{

		public AuthenticationFinishedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebViewAuthenticationSession session, string url, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebViewAuthenticationSession session, string url) { }

	}

	internal sealed class AuthErrorReceivedDelegate : MulticastDelegate
	{

		public AuthErrorReceivedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UniWebViewAuthenticationSession session, int errorCode, string errorMessage, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UniWebViewAuthenticationSession session, int errorCode, string errorMessage) { }

	}

	[CompilerGenerated]
	private AuthenticationFinishedDelegate OnAuthenticationFinished; //Field offset: 0x18
	[CompilerGenerated]
	private AuthErrorReceivedDelegate OnAuthenticationErrorReceived; //Field offset: 0x20
	private readonly string id; //Field offset: 0x28
	private UniWebViewNativeListener listener; //Field offset: 0x30
	[CompilerGenerated]
	private string <Url>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <CallbackScheme>k__BackingField; //Field offset: 0x40

	public event AuthErrorReceivedDelegate OnAuthenticationErrorReceived
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event AuthenticationFinishedDelegate OnAuthenticationFinished
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private string CallbackScheme
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public static bool IsAuthenticationSupported
	{
		 get { } //Length: 18
	}

	public private string Url
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private UniWebViewAuthenticationSession() { }

	[CompilerGenerated]
	public void add_OnAuthenticationErrorReceived(AuthErrorReceivedDelegate value) { }

	[CompilerGenerated]
	public void add_OnAuthenticationFinished(AuthenticationFinishedDelegate value) { }

	public static UniWebViewAuthenticationSession Create(string url, string callbackScheme) { }

	[CompilerGenerated]
	public string get_CallbackScheme() { }

	public static bool get_IsAuthenticationSupported() { }

	[CompilerGenerated]
	public string get_Url() { }

	internal void InternalAuthenticationErrorReceived(UniWebViewNativeResultPayload payload) { }

	internal void InternalAuthenticationFinished(string url) { }

	[CompilerGenerated]
	public void remove_OnAuthenticationErrorReceived(AuthErrorReceivedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnAuthenticationFinished(AuthenticationFinishedDelegate value) { }

	[CompilerGenerated]
	private void set_CallbackScheme(string value) { }

	[CompilerGenerated]
	private void set_Url(string value) { }

	public void SetPrivateMode(bool flag) { }

	public void Start() { }

}

