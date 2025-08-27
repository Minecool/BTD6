namespace Assets.Scripts.RichPresence;

public class RichPresenceText
{

	private static ILocProvider Locs
	{
		private get { } //Length: 48
	}

	public RichPresenceText() { }

	private static ILocProvider get_Locs() { }

	public static string GetBossMessage(BossType bossType, bool isElite) { }

	public static string GetBossRushSubtitle(BossType bossType, int stage) { }

	public static string GetBossSubtitle(bool isCoop, Nullable<Byte> numPlayers) { }

	public static string GetBrowsingMessage(RichPresenceBrowsing browsingType) { }

	public static string GetCoopLobbyMessage(string id, bool isBoss) { }

	public static string GetCreatingMessage(ContentType contentType) { }

	public static string GetCtMessage() { }

	public static string GetCtSubtitle(string tileCode, CtTileType ctTileType) { }

	public static string GetMessage(RichPresencePlaying playingType, string challengeCode) { }

	public static string GetSubtitle(RichPresencePlaying playingType, RichPresenceDifficulty difficultyType, string mapId) { }

}

