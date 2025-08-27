//Type is in global namespace

public class UniWebViewAuthenticationStandardToken
{
	[SerializeField]
	private string access_token; //Field offset: 0x10
	[SerializeField]
	private string scope; //Field offset: 0x18
	[SerializeField]
	private string token_type; //Field offset: 0x20
	[SerializeField]
	private string refresh_token; //Field offset: 0x28
	[SerializeField]
	private long expires_in; //Field offset: 0x30
	[SerializeField]
	private string id_token; //Field offset: 0x38
	[CompilerGenerated]
	private string <RawValue>k__BackingField; //Field offset: 0x40

	public string AccessToken
	{
		 get { } //Length: 5
	}

	public long ExpiresIn
	{
		 get { } //Length: 5
	}

	public string IdToken
	{
		 get { } //Length: 5
	}

	public string RawValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string RefreshToken
	{
		 get { } //Length: 5
	}

	public string Scope
	{
		 get { } //Length: 5
	}

	public string TokenType
	{
		 get { } //Length: 5
	}

	public UniWebViewAuthenticationStandardToken() { }

	public string get_AccessToken() { }

	public long get_ExpiresIn() { }

	public string get_IdToken() { }

	[CompilerGenerated]
	public string get_RawValue() { }

	public string get_RefreshToken() { }

	public string get_Scope() { }

	public string get_TokenType() { }

	[CompilerGenerated]
	public void set_RawValue(string value) { }

}

