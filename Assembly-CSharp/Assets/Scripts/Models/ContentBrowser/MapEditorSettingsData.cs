namespace Assets.Scripts.Models.ContentBrowser;

public class MapEditorSettingsData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MapEditorPathData, Boolean> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GeneratePathPatternModel>b__1_0(MapEditorPathData x) { }

	}

	public int totalPathPatternSequences; //Field offset: 0x10

	public MapEditorSettingsData() { }

	public MapEditorSettingsData Clone() { }

	public ValueTuple<List`1<String>, List`1<Int32>, Boolean> GeneratePathPatternModel(List<MapEditorPathData> paths) { }

	public bool IsEqual(MapEditorSettingsData com) { }

	public bool IsValid() { }

}

