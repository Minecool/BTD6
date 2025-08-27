namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_GetGroups : Endpoint<Dictionary`2<String, String[]>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<<>f__AnonymousType52`2<String, String[]>, String> <>9__2_0; //Field offset: 0x8
		public static Func<<>f__AnonymousType52`2<String, String[]>, String[]> <>9__2_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Receive>b__2_0(<>f__AnonymousType52<String, String[]> group) { }

		internal String[] <Receive>b__2_1(<>f__AnonymousType52<String, String[]> group) { }

	}


	internal Matchmaking_GetGroups(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Dictionary`2<String, String[]>> Call(IEnumerable<String> groupIDs = null, IEnumerable<String> eventIDs = null) { }

	protected virtual Dictionary<String, String[]> Receive(string json) { }

}

