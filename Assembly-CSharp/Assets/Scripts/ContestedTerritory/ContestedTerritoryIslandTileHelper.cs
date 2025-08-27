namespace Assets.Scripts.ContestedTerritory;

[Extension]
internal static class ContestedTerritoryIslandTileHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ContestedTerritoryIslandTile, Boolean> <>9__1_0; //Field offset: 0x8
		public static Func<ContestedTerritoryIslandTile, Boolean> <>9__2_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetTilesInRangeOfTeam>b__1_0(ContestedTerritoryIslandTile x) { }

		internal bool <GetTilesWhichCanBeAttacked>b__2_0(ContestedTerritoryIslandTile x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public string teamId; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <GetAllTilesControlledByTeam>b__0(ContestedTerritoryIslandTile x) { }

	}


	[Extension]
	public static bool CanBePlayed(ContestedTerritoryIslandTile tile) { }

	public static List<ContestedTerritoryIslandTile> GetAllTilesControlledByTeam(string teamId) { }

	[Extension]
	public static ValueTuple<Single, Single> GetCoordinateForTeamIsland(ContestedTerritoryIslandTile source, float teamIslandDistance) { }

	public static List<ContestedTerritoryIslandTile> GetTilesInRangeOfTeam(string teamId) { }

	public static List<ContestedTerritoryIslandTile> GetTilesWhichCanBeAttacked(string teamId) { }

	[Extension]
	public static bool IsCoastal(ContestedTerritoryIslandTile source) { }

	[Extension]
	public static bool IsInAttackRange(ContestedTerritoryIslandTile tile) { }

}

