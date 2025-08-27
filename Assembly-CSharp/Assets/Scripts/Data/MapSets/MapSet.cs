namespace Assets.Scripts.Data.MapSets;

public class MapSet : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MapDetails, Boolean> <>9__3_0; //Field offset: 0x8
		public static Func<MapDetails, Boolean> <>9__5_0; //Field offset: 0x10
		public static Func<MapDetails, Boolean> <>9__7_0; //Field offset: 0x18
		public static Func<MapDetails, Boolean> <>9__9_0; //Field offset: 0x20
		public static Func<MapDetails, Boolean> <>9__11_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <get_BrowserOnlyMaps>b__9_0(MapDetails x) { }

		internal bool <get_DebugMaps>b__11_0(MapDetails x) { }

		internal bool <get_StandardAndBrowserMaps>b__7_0(MapDetails x) { }

		internal bool <get_StandardDebugAndBrowserMaps>b__3_0(MapDetails x) { }

		internal bool <get_StandardMaps>b__5_0(MapDetails x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public string mapId; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <GetMapDetails>b__0(MapDetails map) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string mapId; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <TryGetMapDetails>b__0(MapDetails map) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public MapDifficulty diff; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <GetStandardMapsForDifficulty>b__0(MapDetails x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public MapInfoManager mapInfoManager; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <GetStandardAndCompletedBrowserMaps>b__0(MapDetails x) { }

	}

	public const string kMapEditorId = "BaseEditorMap"; //Field offset: 0x0
	[ReorderableList("items", True)]
	[SerializeField]
	private MapDetailsContainer Maps; //Field offset: 0x18

	public IEnumerable<MapDetails> AllMaps
	{
		 get { } //Length: 27
	}

	public IEnumerable<MapDetails> BrowserOnlyMaps
	{
		 get { } //Length: 266
	}

	public IEnumerable<MapDetails> DebugMaps
	{
		 get { } //Length: 266
	}

	public IEnumerable<MapDetails> StandardAndBrowserMaps
	{
		 get { } //Length: 266
	}

	public IEnumerable<MapDetails> StandardDebugAndBrowserMaps
	{
		 get { } //Length: 266
	}

	public IEnumerable<MapDetails> StandardMaps
	{
		 get { } //Length: 266
	}

	public MapSet() { }

	public IEnumerable<MapDetails> get_AllMaps() { }

	public IEnumerable<MapDetails> get_BrowserOnlyMaps() { }

	public IEnumerable<MapDetails> get_DebugMaps() { }

	public IEnumerable<MapDetails> get_StandardAndBrowserMaps() { }

	public IEnumerable<MapDetails> get_StandardDebugAndBrowserMaps() { }

	public IEnumerable<MapDetails> get_StandardMaps() { }

	public CoopDivision GetCoopMapDivision(string mapId) { }

	public MapDifficulty GetDifficulty(string mapId) { }

	public MapDetails GetMapDetails(string mapId) { }

	public string GetMusicTrack(string mapId) { }

	public IEnumerable<MapDetails> GetStandardAndCompletedBrowserMaps(MapInfoManager mapInfoManager) { }

	public IEnumerable<MapDetails> GetStandardMapsForDifficulty(MapDifficulty diff) { }

	public bool TryGetMapDetails(string mapId, out MapDetails mapDetails) { }

}

