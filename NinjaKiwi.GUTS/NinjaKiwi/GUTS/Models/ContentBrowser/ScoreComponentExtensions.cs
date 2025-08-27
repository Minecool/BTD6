namespace NinjaKiwi.GUTS.Models.ContentBrowser;

[Extension]
public static class ScoreComponentExtensions
{

	[Extension]
	public static bool ContainsFlag(AvailabilityScoreComponent test, AvailabilityScoreComponent flag) { }

	[Extension]
	public static byte GetBitAllowance(AvailabilityScoreComponent scoreComponent) { }

	[Extension]
	public static byte GetComponentBitShift(AvailabilityScoreComponent scoreComponent) { }

	[Extension]
	public static int GetMaxValue(AvailabilityScoreComponent scoreComponent) { }

}

