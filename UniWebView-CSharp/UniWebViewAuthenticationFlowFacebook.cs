//Type is in global namespace

public class UniWebViewAuthenticationFlowFacebook : UniWebViewAuthenticationCommonFlow
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public UniWebViewAuthenticationFlowFacebook <>4__this; //Field offset: 0x10
		public UniWebView webView; //Field offset: 0x18
		public Action <>9__2; //Field offset: 0x20
		public Action <>9__3; //Field offset: 0x28

		public <>c__DisplayClass13_0() { }

		internal void <StartAuthenticationFlow>b__0(UniWebView view, int status, string url) { }

		internal void <StartAuthenticationFlow>b__1(UniWebView view, int code, string message, UniWebViewNativeResultPayload payload) { }

		internal void <StartAuthenticationFlow>b__2() { }

		internal void <StartAuthenticationFlow>b__3() { }

	}

	private const string redirectUri = "https://www.facebook.com/connect/login_success.html"; //Field offset: 0x0
	private const string responseType = "token"; //Field offset: 0x0
	public string appId; //Field offset: 0x38
	public UniWebViewAuthenticationFlowFacebookOptional optional; //Field offset: 0x40
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationFacebookToken> <OnAuthenticationFinished>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<Int64, String> <OnAuthenticationErrored>k__BackingField; //Field offset: 0x50
	private readonly UniWebViewAuthenticationConfiguration config; //Field offset: 0x58

	public UnityEvent<Int64, String> OnAuthenticationErrored
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public UnityEvent<UniWebViewAuthenticationFacebookToken> OnAuthenticationFinished
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public UniWebViewAuthenticationFlowFacebook() { }

	[CompilerGenerated]
	public UnityEvent<Int64, String> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	public UnityEvent<UniWebViewAuthenticationFacebookToken> get_OnAuthenticationFinished() { }

	private Dictionary<String, String> GetAuthenticationUriArguments() { }

	private string GetAuthUrl() { }

	[CompilerGenerated]
	public void set_OnAuthenticationErrored(UnityEvent<Int64, String> value) { }

	[CompilerGenerated]
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationFacebookToken> value) { }

	public virtual void StartAuthenticationFlow() { }

	public virtual void StartRefreshTokenFlow(string refreshToken) { }

}

