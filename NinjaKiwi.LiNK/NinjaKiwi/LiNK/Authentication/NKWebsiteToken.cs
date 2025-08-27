namespace NinjaKiwi.LiNK.Authentication;

public class NKWebsiteToken : AuthenticationProviderToken
{
	public string userID; //Field offset: 0x18
	public string token; //Field offset: 0x20

	public virtual string PrimaryIdentifier
	{
		 get { } //Length: 5
	}

	public NKWebsiteToken() { }

	protected private virtual Task<UserModel> CreateLiNKAccount(Api liNK) { }

	public virtual string get_PrimaryIdentifier() { }

	protected private virtual Task<UserModel> LinkToLiNKAccount(LiNKAccount liNKAccount) { }

	protected private virtual Task<LoginResponseModel> LoginToLiNKAccount(Api liNK) { }

}

