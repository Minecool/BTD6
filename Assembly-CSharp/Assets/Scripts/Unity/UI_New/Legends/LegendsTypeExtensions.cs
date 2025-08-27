namespace Assets.Scripts.Unity.UI_New.Legends;

[Extension]
public static class LegendsTypeExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string iapId; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <IsLegendsIapId>b__0(KeyValuePair<LegendsType, String> x) { }

	}

	private static Dictionary<LegendsType, String> cachedIapIds; //Field offset: 0x0

	private static Dictionary<LegendsType, String> GenerateIapIdCache() { }

	[Extension]
	public static string GetIapId(LegendsType legendsType) { }

	public static Nullable<LegendsType> GetLegendsType(string iapId) { }

	public static bool IsLegendsIapId(string iapId) { }

	public static bool TryGetLegendsType(string iapId, out LegendsType legendsType) { }

}

