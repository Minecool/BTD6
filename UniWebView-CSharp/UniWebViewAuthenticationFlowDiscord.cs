//Type is in global namespace

public class UniWebViewAuthenticationFlowDiscord : UniWebViewAuthenticationCommonFlow, IUniWebViewAuthenticationFlow<UniWebViewAuthenticationDiscordToken>
{
	private const string responseType = "code"; //Field offset: 0x0
	private const string grantType = "authorization_code"; //Field offset: 0x0
	public string clientId; //Field offset: 0x38
	public string clientSecret; //Field offset: 0x40
	public string redirectUri; //Field offset: 0x48
	public string scope; //Field offset: 0x50
	public UniWebViewAuthenticationFlowDiscordOptional optional; //Field offset: 0x58
	private readonly UniWebViewAuthenticationConfiguration config; //Field offset: 0x60
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationDiscordToken> <OnAuthenticationFinished>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<Int64, String> <OnAuthenticationErrored>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationDiscordToken> <OnRefreshTokenFinished>k__BackingField; //Field offset: 0x78
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

	public override UnityEvent<UniWebViewAuthenticationDiscordToken> OnAuthenticationFinished
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

	public override UnityEvent<UniWebViewAuthenticationDiscordToken> OnRefreshTokenFinished
	{
		[CompilerGenerated]
		 get { } //Length: 70
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public UniWebViewAuthenticationFlowDiscord() { }

	public override UniWebViewAuthenticationDiscordToken GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	[CompilerGenerated]
	public override UnityEvent<Int64, String> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	public override UnityEvent<UniWebViewAuthenticationDiscordToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	public override UnityEvent<Int64, String> get_OnRefreshTokenErrored() { }

	[CompilerGenerated]
	public override UnityEvent<UniWebViewAuthenticationDiscordToken> get_OnRefreshTokenFinished() { }

	public override Dictionary<String, String> GetAccessTokenRequestParameters(string authResponse) { }

	public override UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	public override Dictionary<String, String> GetAuthenticationUriArguments() { }

	public override string GetCallbackUrl() { }

	public override Dictionary<String, String> GetRefreshTokenRequestParameters(string refreshToken) { }

	[CompilerGenerated]
	public void set_OnAuthenticationErrored(UnityEvent<Int64, String> value) { }

	[CompilerGenerated]
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationDiscordToken> value) { }

	[CompilerGenerated]
	public void set_OnRefreshTokenErrored(UnityEvent<Int64, String> value) { }

	[CompilerGenerated]
	public void set_OnRefreshTokenFinished(UnityEvent<UniWebViewAuthenticationDiscordToken> value) { }

	public virtual void StartAuthenticationFlow() { }

	public virtual void StartRefreshTokenFlow(string refreshToken) { }

}

