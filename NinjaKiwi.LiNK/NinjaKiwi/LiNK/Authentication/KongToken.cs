namespace NinjaKiwi.LiNK.Authentication;

public class KongToken : AuthenticationProviderToken
{
	public string userID; //Field offset: 0x18
	public string gameAuthToken; //Field offset: 0x20

	public virtual string PrimaryIdentifier
	{
		 get { } //Length: 5
	}

	public KongToken() { }

	protected private virtual Task<UserModel> CreateLiNKAccount(Api liNK) { }

	public virtual string get_PrimaryIdentifier() { }

	protected private virtual Task<UserModel> LinkToLiNKAccount(LiNKAccount liNKAccount) { }

	protected private virtual Task<LiNKAccountModel> LoginToLiNKAccount(Api liNK) { }

}

