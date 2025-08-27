namespace NinjaKiwi.LiNK.Authentication;

public class GooglePlayToken : AuthenticationProviderToken
{
	public string playerID; //Field offset: 0x18

	public virtual string PrimaryIdentifier
	{
		 get { } //Length: 5
	}

	public GooglePlayToken() { }

	protected private virtual Task<UserModel> CreateLiNKAccount(Api liNK) { }

	public virtual string get_PrimaryIdentifier() { }

	protected private virtual Task<UserModel> LinkToLiNKAccount(LiNKAccount liNKAccount) { }

	protected private virtual Task<LoginResponseModel> LoginToLiNKAccount(Api liNK) { }

}

