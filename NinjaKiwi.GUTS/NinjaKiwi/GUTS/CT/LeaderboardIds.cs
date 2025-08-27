namespace NinjaKiwi.GUTS.CT;

public static class LeaderboardIds
{
	public const string kIdPrefix = "ct"; //Field offset: 0x0
	public const string kGuildIdPostfix = "guilds"; //Field offset: 0x0

	public static string GetGlobalGuilds(string eventId) { }

	public static string GetGlobalPlayers(string eventId) { }

	public static string GetGuilds(string eventId, int instanceId) { }

	public static string GetPlayers(string eventId, int instanceId) { }

}

