namespace NinjaKiwi.LiNK.DataModels;

[Extension]
public static class GuildMembershipStateExtensions
{

	[Extension]
	public static bool Includes(GuildMembershipState state, GuildMembershipState toTest) { }

	[Extension]
	public static GuildMembershipState Minus(GuildMembershipState state, GuildMembershipState toRemove) { }

	[Extension]
	public static GuildMembershipState Plus(GuildMembershipState state, GuildMembershipState toAdd) { }

}

