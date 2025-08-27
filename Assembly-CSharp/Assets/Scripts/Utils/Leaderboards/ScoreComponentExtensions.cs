namespace Assets.Scripts.Utils.Leaderboards;

[Extension]
public static class ScoreComponentExtensions
{

	[Extension]
	public static bool ContainsFlag(ScoreComponent test, ScoreComponent flag) { }

	[Extension]
	public static byte GetBitAllowance(ScoreComponent scoreComponent) { }

	[Extension]
	public static ulong GetMaxValue(ScoreComponent scoreComponent) { }

}

