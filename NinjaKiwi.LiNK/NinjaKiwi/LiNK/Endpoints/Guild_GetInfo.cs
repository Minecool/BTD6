namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_GetInfo : Endpoint<List`1<GuildModel>>
{
	[CompilerGenerated]
	private struct <Call>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildModel> <>t__builder; //Field offset: 0x8
		public Guild_GetInfo <>4__this; //Field offset: 0x20
		public string guildID; //Field offset: 0x28
		public bool errorOnMissing; //Field offset: 0x30
		private TaskAwaiter<List`1<GuildModel>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	internal Guild_GetInfo(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	[AsyncStateMachine(typeof(<Call>d__1))]
	public Task<GuildModel> Call(string guildID, bool errorOnMissing = false) { }

	public Task<List`1<GuildModel>> Call(IEnumerable<String> guildIDs, bool errorOnMissing = false) { }

	protected virtual List<GuildModel> Receive(string json) { }

}

