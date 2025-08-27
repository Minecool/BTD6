namespace NinjaKiwi.GUTS.Extensions;

[Extension]
public static class CtRandomExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<ContestedTerritoryGameType, ContestedTerritoryGameSettings>, KeyValuePair`2<ContestedTerritoryGameType, Single>> <>9__0_0; //Field offset: 0x8
		public static Func<CTGameSettingRangeLimitProportion, KeyValuePair`2<CTGameSettingRangeLimitProportion, Single>> <>9__1_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal KeyValuePair<ContestedTerritoryGameType, Single> <GetRandomGameType>b__0_0(KeyValuePair<ContestedTerritoryGameType, ContestedTerritoryGameSettings> kvp) { }

		internal KeyValuePair<CTGameSettingRangeLimitProportion, Single> <GetRandomRange>b__1_0(CTGameSettingRangeLimitProportion item) { }

	}


	[Extension]
	public static ValueTuple<ContestedTerritoryGameType, ContestedTerritoryGameSettings> GetRandomGameType(Random random, Dictionary<ContestedTerritoryGameType, ContestedTerritoryGameSettings> gameSettings) { }

	[Extension]
	public static ContestedTerritoryMapMode GetRandomMapMode(Random random, Dictionary<ContestedTerritoryMapMode, Single> mapModeProportions) { }

	[Extension]
	public static CTGameSettingRangeLimit GetRandomRange(Random random, IEnumerable<CTGameSettingRangeLimitProportion> ranges) { }

}

