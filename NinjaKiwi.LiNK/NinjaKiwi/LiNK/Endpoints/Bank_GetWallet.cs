namespace NinjaKiwi.LiNK.Endpoints;

public class Bank_GetWallet : Endpoint<TypeB>
{
	[CompilerGenerated]
	private struct <Call>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BankWalletResponse> <>t__builder; //Field offset: 0x8
		public string accountHolderID; //Field offset: 0x20
		public IEnumerable<String> walletNames; //Field offset: 0x28
		public Bank_GetWallet <>4__this; //Field offset: 0x30
		private TaskAwaiter<TypeB> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, Int64>> <>t__builder; //Field offset: 0x8
		public Bank_GetWallet <>4__this; //Field offset: 0x20
		public string accountHolderID; //Field offset: 0x28
		public string walletName; //Field offset: 0x30
		private TaskAwaiter<BankWalletResponse> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	internal Bank_GetWallet(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	[AsyncStateMachine(typeof(<Call>d__1))]
	public Task<BankWalletResponse> Call(string accountHolderID, IEnumerable<String> walletNames) { }

	[AsyncStateMachine(typeof(<Call>d__2))]
	public Task<Dictionary`2<String, Int64>> Call(string accountHolderID, string walletName) { }

}

