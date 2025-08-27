namespace Assets.Scripts.Models.Profile;

public class MapDifficultyInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, MapModeInfo>, Boolean> <>9__7_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, MapModeInfo>, String> <>9__7_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, MapModeInfo>, MapModeInfo> <>9__7_2; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, MapModeInfo>, Boolean> <>9__7_3; //Field offset: 0x20
		public static Func<KeyValuePair`2<String, MapModeInfo>, String> <>9__7_4; //Field offset: 0x28
		public static Func<KeyValuePair`2<String, MapModeInfo>, MapModeInfo> <>9__7_5; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <OnDeserializedMethod>b__7_0(KeyValuePair<String, MapModeInfo> kvp) { }

		internal string <OnDeserializedMethod>b__7_1(KeyValuePair<String, MapModeInfo> kvp) { }

		internal MapModeInfo <OnDeserializedMethod>b__7_2(KeyValuePair<String, MapModeInfo> kvp) { }

		internal bool <OnDeserializedMethod>b__7_3(KeyValuePair<String, MapModeInfo> kvp) { }

		internal string <OnDeserializedMethod>b__7_4(KeyValuePair<String, MapModeInfo> kvp) { }

		internal MapModeInfo <OnDeserializedMethod>b__7_5(KeyValuePair<String, MapModeInfo> kvp) { }

	}

	public const string EasyKey = "Easy"; //Field offset: 0x0
	public const string MediumKey = "Medium"; //Field offset: 0x0
	public const string HardKey = "Hard"; //Field offset: 0x0
	public const string ImpoppableKey = "Impoppable"; //Field offset: 0x0
	private static readonly MapModeInfo kEmptyMapModeInfo; //Field offset: 0x0
	[JsonProperty(ItemConverterType = typeof(CustomJsonConverter))]
	public Dictionary<String, MapModeInfo> modes; //Field offset: 0x10
	[JsonProperty(ItemConverterType = typeof(CustomJsonConverter))]
	public Dictionary<String, MapModeInfo> coopModes; //Field offset: 0x18

	private static MapDifficultyInfo() { }

	public MapDifficultyInfo() { }

	public int GetBestSocialRound(out bool isImpoppable) { }

	public MapModeInfo GetMode(string modeName, bool coopMode) { }

	public MapModeInfo GetOrCreateMode(string modeName, bool coopMode) { }

	public int GetTotalCompletedCount() { }

	public int GetTotalCompletedCountCoop() { }

	[OnDeserialized]
	internal void OnDeserializedMethod(StreamingContext context) { }

}

