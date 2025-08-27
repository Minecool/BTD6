namespace NinjaKiwi.GUTS.CT;

[Extension]
public static class ScoringExtensions
{

	[Extension]
	public static int GetCurrentScore(CtSettings ctSettings, int captureScore, DateTime captureTime, DateTime now, Nullable<CtTileType> ctTileType) { }

	[Extension]
	public static bool IsBetterScore(ScoringType scoringType, int scoreA, int scoreB) { }

}

