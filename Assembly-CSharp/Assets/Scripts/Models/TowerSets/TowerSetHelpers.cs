namespace Assets.Scripts.Models.TowerSets;

[Extension]
public static class TowerSetHelpers
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <FromCommaSeparatedStringToArray>b__11_0(string s) { }

	}

	public const string kPrimary = "Primary"; //Field offset: 0x0
	public const string kMilitary = "Military"; //Field offset: 0x0
	public const string kMagic = "Magic"; //Field offset: 0x0
	public const string kSupport = "Support"; //Field offset: 0x0
	public const string kHero = "Hero"; //Field offset: 0x0
	public const string kParagon = "Paragon"; //Field offset: 0x0
	public const string kItems = "Items"; //Field offset: 0x0
	public const string kAllMonkeyTowerSets = "AllMonkeyTowerSets"; //Field offset: 0x0

	[Extension]
	public static bool ContainsFlag(TowerSet keys, TowerSet flag) { }

	[Extension]
	public static bool ContainsFlags(TowerSet[] keys, TowerSet flag) { }

	public static TowerSet FromCommaSeparatedString(string value) { }

	public static TowerSet[] FromCommaSeparatedStringToArray(string value) { }

	public static TowerSet FromString(string value) { }

}

