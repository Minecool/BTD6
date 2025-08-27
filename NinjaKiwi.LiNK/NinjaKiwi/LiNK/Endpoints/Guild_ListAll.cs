namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_ListAll : Endpoint<List`1<GuildAndScore>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GuildStatus, String> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Call>b__1_0(GuildStatus guildStatus) { }

	}


	internal Guild_ListAll(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<GuildAndScore>> Call(List<GuildStatus> statusFilter, bool includeFullGuilds, int maxResults) { }

	protected virtual List<GuildAndScore> Receive(string json) { }

}

