namespace NinjaKiwi.LiNK.Authentication;

public class LiNKCodeToken : AuthenticationProviderToken
{
	public string liNKCode; //Field offset: 0x18

	public virtual string PrimaryIdentifier
	{
		 get { } //Length: 5
	}

	public LiNKCodeToken() { }

	protected private virtual Task<UserModel> CreateLiNKAccount(Api liNK) { }

	public virtual string get_PrimaryIdentifier() { }

	protected private virtual Task<UserModel> LinkToLiNKAccount(LiNKAccount liNKAccount) { }

	protected private virtual Task<LiNKAccountModel> LoginToLiNKAccount(Api liNK) { }

}

