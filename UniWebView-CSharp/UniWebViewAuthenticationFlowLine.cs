//Type is in global namespace

public class UniWebViewAuthenticationFlowLine : UniWebViewAuthenticationCommonFlow, IUniWebViewAuthenticationFlow<UniWebViewAuthenticationLineToken>
{
	private const string responseType = "code"; //Field offset: 0x0
	private const string grantType = "authorization_code"; //Field offset: 0x0
	public string clientId; //Field offset: 0x38
	public string iOSBundleId; //Field offset: 0x40
	public string androidPackageName; //Field offset: 0x48
	public string scope; //Field offset: 0x50
	public UniWebViewAuthenticationFlowLineOptional optional; //Field offset: 0x58
	private readonly UniWebViewAuthenticationConfiguration config; //Field offset: 0x60
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationLineToken> <OnAuthenticationFinished>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<Int64, String> <OnAuthenticationErrored>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationLineToken> <OnRefreshTokenFinished>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<Int64, String> <OnRefreshTokenErrored>k__BackingField; //Field offset: 0x80

	public override UnityEvent<Int64, String> OnAuthenticationErrored
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override UnityEvent<UniWebViewAuthenticationLineToken> OnAuthenticationFinished
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override UnityEvent<Int64, String> OnRefreshTokenErrored
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override UnityEvent<UniWebViewAuthenticationLineToken> OnRefreshTokenFinished
	{
		[CompilerGenerated]
		 get { } //Length: 70
		[CompilerGenerated]
		 set { } //Length: 5
	}

	private string RedirectUri
	{
		private get { } //Length: 321
	}

	public UniWebViewAuthenticationFlowLine() { }

	private string GenerateReturnUri() { }

	public override UniWebViewAuthenticationLineToken GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	[CompilerGenerated]
	public override UnityEvent<Int64, String> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	public override UnityEvent<UniWebViewAuthenticationLineToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	public override UnityEvent<Int64, String> get_OnRefreshTokenErrored() { }

	[CompilerGenerated]
	public override UnityEvent<UniWebViewAuthenticationLineToken> get_OnRefreshTokenFinished() { }

	private string get_RedirectUri() { }

	public override Dictionary<String, String> GetAccessTokenRequestParameters(string authResponse) { }

	public override UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	public override Dictionary<String, String> GetAuthenticationUriArguments() { }

	public override string GetCallbackUrl() { }

	public override Dictionary<String, String> GetRefreshTokenRequestParameters(string refreshToken) { }

	[CompilerGenerated]
	public void set_OnAuthenticationErrored(UnityEvent<Int64, String> value) { }

	[CompilerGenerated]
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationLineToken> value) { }

	[CompilerGenerated]
	public void set_OnRefreshTokenErrored(UnityEvent<Int64, String> value) { }

	[CompilerGenerated]
	public void set_OnRefreshTokenFinished(UnityEvent<UniWebViewAuthenticationLineToken> value) { }

	public virtual void StartAuthenticationFlow() { }

	public virtual void StartRefreshTokenFlow(string refreshToken) { }

}

