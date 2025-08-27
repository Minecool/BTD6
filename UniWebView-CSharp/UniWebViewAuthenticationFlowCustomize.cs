//Type is in global namespace

public class UniWebViewAuthenticationFlowCustomize : UniWebViewAuthenticationCommonFlow, IUniWebViewAuthenticationFlow<UniWebViewAuthenticationStandardToken>
{
	public UniWebViewAuthenticationFlowCustomizeConfig config; //Field offset: 0x38
	public string clientId; //Field offset: 0x40
	public string redirectUri; //Field offset: 0x48
	public string scope; //Field offset: 0x50
	public UniWebViewAuthenticationFlowCustomizeOptional optional; //Field offset: 0x58
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationStandardToken> <OnAuthenticationFinished>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<Int64, String> <OnAuthenticationErrored>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationStandardToken> <OnRefreshTokenFinished>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<Int64, String> <OnRefreshTokenErrored>k__BackingField; //Field offset: 0x78

	public override UnityEvent<Int64, String> OnAuthenticationErrored
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override UnityEvent<UniWebViewAuthenticationStandardToken> OnAuthenticationFinished
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override UnityEvent<Int64, String> OnRefreshTokenErrored
	{
		[CompilerGenerated]
		 get { } //Length: 70
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override UnityEvent<UniWebViewAuthenticationStandardToken> OnRefreshTokenFinished
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public UniWebViewAuthenticationFlowCustomize() { }

	public override UniWebViewAuthenticationStandardToken GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	[CompilerGenerated]
	public override UnityEvent<Int64, String> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	public override UnityEvent<UniWebViewAuthenticationStandardToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	public override UnityEvent<Int64, String> get_OnRefreshTokenErrored() { }

	[CompilerGenerated]
	public override UnityEvent<UniWebViewAuthenticationStandardToken> get_OnRefreshTokenFinished() { }

	public override Dictionary<String, String> GetAccessTokenRequestParameters(string authResponse) { }

	public override UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	public override Dictionary<String, String> GetAuthenticationUriArguments() { }

	public override string GetCallbackUrl() { }

	public override Dictionary<String, String> GetRefreshTokenRequestParameters(string refreshToken) { }

	[CompilerGenerated]
	public void set_OnAuthenticationErrored(UnityEvent<Int64, String> value) { }

	[CompilerGenerated]
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationStandardToken> value) { }

	[CompilerGenerated]
	public void set_OnRefreshTokenErrored(UnityEvent<Int64, String> value) { }

	[CompilerGenerated]
	public void set_OnRefreshTokenFinished(UnityEvent<UniWebViewAuthenticationStandardToken> value) { }

	public virtual void StartAuthenticationFlow() { }

	public virtual void StartRefreshTokenFlow(string refreshToken) { }

}

