namespace Assets.Scripts.Models.ServerEvents;

public class OdysseyData : IContentBrowserData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<OdysseyDifficulty, Rules>, OdysseyDifficulty> <>9__5_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<OdysseyDifficulty, Rules>, Rules> <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal OdysseyDifficulty <Clone>b__5_0(KeyValuePair<OdysseyDifficulty, Rules> x) { }

		internal Rules <Clone>b__5_1(KeyValuePair<OdysseyDifficulty, Rules> x) { }

	}

	public Dictionary<OdysseyDifficulty, Rules> rules; //Field offset: 0x10
	public string name; //Field offset: 0x18
	public string description; //Field offset: 0x20
	public string descriptionLoc; //Field offset: 0x28
	public string descriptionFlavorLoc; //Field offset: 0x30

	public OdysseyData() { }

	public OdysseyData Clone() { }

}

