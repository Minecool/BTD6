namespace NinjaKiwi.GUTS;

public static class Constants
{
	internal static class TeamTrophies
	{
		public const string WalletName = "teamTrophyStore"; //Field offset: 0x0
		public const string CurrencyName = "teamTrophies"; //Field offset: 0x0
		public const string DailyPowerIdPrefix = "DailyTeamPower"; //Field offset: 0x0
		public const string TeamRelicIdPrefix = "EventTeamRelic"; //Field offset: 0x0

	}

	public const string LinkCtFolder = "ct"; //Field offset: 0x0
	public const string LinkBossRushFolder = "bossRush"; //Field offset: 0x0
	public const string FailedGuildKey = "ERROR"; //Field offset: 0x0
	public static readonly TimeSpan GuildTokenLife; //Field offset: 0x0
	public const string CtBadgesWalletName = "CtBadges"; //Field offset: 0x0

	private static Constants() { }

	public static string GetGuildEventWalletId(string guildId, string eventId) { }

	public static string GetGuildWalletId(string guildId) { }

}

