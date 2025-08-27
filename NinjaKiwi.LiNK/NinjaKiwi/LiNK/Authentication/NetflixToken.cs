namespace NinjaKiwi.LiNK.Authentication;

public class NetflixToken : AuthenticationProviderToken
{
	public string id; //Field offset: 0x18

	public virtual string PrimaryIdentifier
	{
		 get { } //Length: 5
	}

	public NetflixToken() { }

	protected private virtual Task<UserModel> CreateLiNKAccount(Api liNK) { }

	public virtual string get_PrimaryIdentifier() { }

	protected private virtual Task<UserModel> LinkToLiNKAccount(LiNKAccount liNKAccount) { }

	protected private virtual Task<LiNKAccountModel> LoginToLiNKAccount(Api liNK) { }

}

