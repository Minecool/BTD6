namespace NinjaKiwi.LiNK.Endpoints;

public class Bank_GetWalletMulti : Endpoint<MultiplePlayersWalletsModel>
{
	[CompilerGenerated]
	private struct <Call>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SingleWallet> <>t__builder; //Field offset: 0x8
		public Bank_GetWalletMulti <>4__this; //Field offset: 0x20
		public IEnumerable<String> accountHolderIDs; //Field offset: 0x28
		public string walletName; //Field offset: 0x30
		private TaskAwaiter<MultiplePlayersWalletsModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	internal Bank_GetWalletMulti(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<MultiplePlayersWalletsModel> Call(IEnumerable<String> accountHolderIDs, IEnumerable<String> walletNames) { }

	[AsyncStateMachine(typeof(<Call>d__2))]
	public Task<SingleWallet> Call(IEnumerable<String> accountHolderIDs, string walletName) { }

}

