namespace NinjaKiwi.LiNK.Authentication;

public class EmailToken : AuthenticationProviderToken
{
	public string email; //Field offset: 0x18
	public string password; //Field offset: 0x20

	public virtual string PrimaryIdentifier
	{
		 get { } //Length: 5
	}

	public EmailToken() { }

	protected private virtual Task<UserModel> CreateLiNKAccount(Api liNK) { }

	public virtual string get_PrimaryIdentifier() { }

	protected private virtual Task<UserModel> LinkToLiNKAccount(LiNKAccount liNKAccount) { }

	protected private virtual Task<LoginResponseModel> LoginToLiNKAccount(Api liNK) { }

}

