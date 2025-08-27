namespace Assets.Scripts.Data.MapSets;

[Extension]
public static class MapSetExtensions
{

	public static MapDifficulty[] AllMapDifficulties() { }

	[Extension]
	public static CoopDivision ToCoopDivision(string v) { }

	[Extension]
	public static MapDifficulty ToMapDifficulty(string v) { }

}

