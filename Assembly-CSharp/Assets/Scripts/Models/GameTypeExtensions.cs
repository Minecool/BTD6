namespace Assets.Scripts.Models;

[Extension]
public static class GameTypeExtensions
{

	[Extension]
	public static bool HasCheckpointSaves(GameType gameType, SubGameType subGameType) { }

	[Extension]
	public static bool IsEditor(GameType gameType) { }

	[Extension]
	public static string Localize(SubGameType value) { }

	[Extension]
	public static SubGameType SubGameTypeBasedOnGameType(GameType gameType) { }

}

