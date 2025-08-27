namespace NinjaKiwi.LiNK.Authentication;

public class PlaystationToken : AuthenticationProviderToken
{
	public string playstationID; //Field offset: 0x18

	public virtual string PrimaryIdentifier
	{
		 get { } //Length: 5
	}

	public PlaystationToken() { }

	protected private virtual Task<UserModel> CreateLiNKAccount(Api liNK) { }

	public virtual string get_PrimaryIdentifier() { }

	protected private virtual Task<UserModel> LinkToLiNKAccount(LiNKAccount liNKAccount) { }

	protected private virtual Task<LiNKAccountModel> LoginToLiNKAccount(Api liNK) { }

}

