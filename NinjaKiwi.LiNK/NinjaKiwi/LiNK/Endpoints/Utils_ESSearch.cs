namespace NinjaKiwi.LiNK.Endpoints;

public class Utils_ESSearch : Endpoint<PagedCollection`1<ESDocument>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<JObject, ESDocument> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ESDocument <Receive>b__2_0(JObject document) { }

	}


	internal Utils_ESSearch(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<PagedCollection`1<ESDocument>> Call(string index, string query, int limit, int offset, string hint, Dictionary<String, String> options = null) { }

	protected virtual PagedCollection<ESDocument> Receive(string json) { }

}

