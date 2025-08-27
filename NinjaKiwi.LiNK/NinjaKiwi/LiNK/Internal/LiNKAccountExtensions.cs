namespace NinjaKiwi.LiNK.Internal;

[Extension]
public static class LiNKAccountExtensions
{

	[Extension]
	public static LiNKAccountModel GetModel(LiNKAccount liNKAccount) { }

	[Extension]
	public static bool HasPreviouslyUsedSessionID(LiNKAccount liNKAccount, string sessionID) { }

}

