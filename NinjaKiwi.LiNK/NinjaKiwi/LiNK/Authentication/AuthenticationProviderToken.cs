namespace NinjaKiwi.LiNK.Authentication;

public abstract class AuthenticationProviderToken
{
	internal static string rawSaltForV2Hash; //Field offset: 0x0
	public string displayName; //Field offset: 0x10

	public abstract string PrimaryIdentifier
	{
		 get { } //Length: 0
	}

	protected AuthenticationProviderToken() { }

	protected private abstract Task<UserModel> CreateLiNKAccount(Api liNK) { }

	public abstract string get_PrimaryIdentifier() { }

	protected static string Hash(string input) { }

	protected static string HashV2(string input) { }

	protected private abstract Task<UserModel> LinkToLiNKAccount(LiNKAccount liNKAccount) { }

	protected private abstract Task<LiNKAccountModel> LoginToLiNKAccount(Api liNK) { }

}

