namespace NinjaKiwi.LiNK.DataModels;

[Extension]
internal static class LobbyInviteTypeExtensions
{
	public const string PRIVATE = "private"; //Field offset: 0x0
	public const string PUBLIC = "public"; //Field offset: 0x0

	[Extension]
	public static InviteType ToLobbyInviteType(string rawString) { }

	[Extension]
	public static string ToStringOverride(InviteType type) { }

}

