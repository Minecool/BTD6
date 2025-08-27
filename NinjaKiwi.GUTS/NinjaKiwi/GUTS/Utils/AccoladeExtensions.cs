namespace NinjaKiwi.GUTS.Utils;

[Extension]
public static class AccoladeExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Accolade, Int32> <>9__2_0; //Field offset: 0x8
		public static Func<Accolade, Int64> <>9__3_0; //Field offset: 0x10
		public static Func<Accolade, Boolean> <>9__4_0; //Field offset: 0x18
		public static Func<Accolade, Int32> <>9__6_0; //Field offset: 0x20
		public static Func<Accolade, Int64> <>9__6_1; //Field offset: 0x28
		public static Func<Accolade, Int64> <>9__8_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <Any>b__4_0(Accolade x) { }

		internal int <GetMostPopular>b__6_0(Accolade x) { }

		internal long <GetMostPopular>b__6_1(Accolade x) { }

		internal long <MostRecentlyPurchased>b__3_0(Accolade x) { }

		internal long <ParseAccolades>b__8_0(Accolade x) { }

		internal int <Sum>b__2_0(Accolade x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string accoladeId; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <GetQuantity>b__0(Accolade x) { }

	}

	public const string kQuantityPostFix = "_qt"; //Field offset: 0x0
	public const string kTimestampPostFix = "_ts"; //Field offset: 0x0

	[Extension]
	public static bool Any(Accolade[] accolades) { }

	[Extension]
	public static Accolade[] GetAccolades(PlayerContentInfo playerContentInfo) { }

	[Extension]
	public static Nullable<Accolade> GetMostPopular(Accolade[] accolades) { }

	[Extension]
	public static int GetQuantity(Accolade[] accolades, string accoladeId) { }

	[Extension]
	public static List<TopContributor> GetTopContributors(PlayerContentInfo playerContentInfo, int maxContributors, string excludeUserId = null) { }

	[Extension]
	public static Nullable<Accolade> MostRecentlyPurchased(Accolade[] accolades) { }

	[Extension]
	public static Accolade[] ParseAccolades(Dictionary<String, Int64> rawAccolades) { }

	[Extension]
	public static int Sum(Accolade[] accolades) { }

}

