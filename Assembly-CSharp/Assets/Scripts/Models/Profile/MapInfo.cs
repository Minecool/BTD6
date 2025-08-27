namespace Assets.Scripts.Models.Profile;

public class MapInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, MapDifficultyInfo>, Boolean> <>9__5_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, MapDifficultyInfo>, String> <>9__5_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, MapDifficultyInfo>, MapDifficultyInfo> <>9__5_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <OnDeserializedMethod>b__5_0(KeyValuePair<String, MapDifficultyInfo> kvp) { }

		internal string <OnDeserializedMethod>b__5_1(KeyValuePair<String, MapDifficultyInfo> kvp) { }

		internal MapDifficultyInfo <OnDeserializedMethod>b__5_2(KeyValuePair<String, MapDifficultyInfo> kvp) { }

	}

	public bool seen; //Field offset: 0x10
	public bool seenNew; //Field offset: 0x11
	public bool seenNewDifficulty; //Field offset: 0x12
	public bool completed; //Field offset: 0x13
	public Dictionary<String, MapDifficultyInfo> difficult; //Field offset: 0x18

	public MapInfo() { }

	public bool GetBestSocialRound(out string bestDifficulty, out int bestRound) { }

	public MapDifficultyInfo GetDifficulty(string difficultyName) { }

	public int GetMedalCount(bool isCoop) { }

	public MapDifficultyInfo GetOrCreateDifficulty(string difficultyName) { }

	[OnDeserialized]
	internal void OnDeserializedMethod(StreamingContext context) { }

	public void RemoveAllMedals() { }

}

