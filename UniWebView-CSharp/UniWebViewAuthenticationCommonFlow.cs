//Type is in global namespace

public abstract class UniWebViewAuthenticationCommonFlow : MonoBehaviour
{
	public bool authorizeOnStart; //Field offset: 0x20
	public bool privateMode; //Field offset: 0x21
	private string state; //Field offset: 0x28
	[CompilerGenerated]
	private string <CodeVerify>k__BackingField; //Field offset: 0x30

	protected private string CodeVerify
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	protected UniWebViewAuthenticationCommonFlow() { }

	protected string GenerateAndStoreState() { }

	protected string GenerateCodeChallengeAndStoreCodeVerify(UniWebViewAuthenticationPKCE method) { }

	[CompilerGenerated]
	protected string get_CodeVerify() { }

	[CompilerGenerated]
	private void set_CodeVerify(string value) { }

	public void Start() { }

	public abstract void StartAuthenticationFlow() { }

	public abstract void StartRefreshTokenFlow(string refreshToken) { }

	protected void VerifyState(Dictionary<String, String> parameters, string key = "state") { }

}

