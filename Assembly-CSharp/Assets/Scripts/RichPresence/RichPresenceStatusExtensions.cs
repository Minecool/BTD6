namespace Assets.Scripts.RichPresence;

[Extension]
public static class RichPresenceStatusExtensions
{

	[Extension]
	public static RichPresenceDifficulty GetRichPresenceDifficulty(string difficultyName) { }

	[Extension]
	public static string ToLocsKey(RichPresenceBrowsing richPresenceBrowsing) { }

	[Extension]
	public static string ToLocsKey(RichPresencePlaying richPresencePlaying) { }

	[Extension]
	public static string ToLocsKey(RichPresenceDifficulty richPresenceDifficulty) { }

}

