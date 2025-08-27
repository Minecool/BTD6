//Type is in global namespace

public interface IUniWebViewAuthenticationFlow
{

	public UnityEvent<Int64, String> OnAuthenticationErrored
	{
		 get { } //Length: 0
	}

	public UnityEvent<TTokenType> OnAuthenticationFinished
	{
		 get { } //Length: 0
	}

	public UnityEvent<Int64, String> OnRefreshTokenErrored
	{
		 get { } //Length: 0
	}

	public UnityEvent<TTokenType> OnRefreshTokenFinished
	{
		 get { } //Length: 0
	}

	public TTokenType GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	public UnityEvent<Int64, String> get_OnAuthenticationErrored() { }

	public UnityEvent<TTokenType> get_OnAuthenticationFinished() { }

	public UnityEvent<Int64, String> get_OnRefreshTokenErrored() { }

	public UnityEvent<TTokenType> get_OnRefreshTokenFinished() { }

	public Dictionary<String, String> GetAccessTokenRequestParameters(string authResponse) { }

	public UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	public Dictionary<String, String> GetAuthenticationUriArguments() { }

	public string GetCallbackUrl() { }

	public Dictionary<String, String> GetRefreshTokenRequestParameters(string refreshToken) { }

}

