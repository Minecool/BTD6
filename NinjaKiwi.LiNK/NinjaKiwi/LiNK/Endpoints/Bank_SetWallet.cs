namespace NinjaKiwi.LiNK.Endpoints;

public class Bank_SetWallet : Endpoint<TypeA>
{
	[CompilerGenerated]
	private struct <Call>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BankWalletResponse> <>t__builder; //Field offset: 0x8
		public string accountHolderID; //Field offset: 0x20
		public Dictionary<String, Dictionary`2<String, Int64>> wallets; //Field offset: 0x28
		public bool returnBalances; //Field offset: 0x30
		public Bank_SetWallet <>4__this; //Field offset: 0x38
		private TaskAwaiter<TypeA> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Call>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, Int64>> <>t__builder; //Field offset: 0x8
		public Bank_SetWallet <>4__this; //Field offset: 0x20
		public string accountHolderID; //Field offset: 0x28
		public string walletName; //Field offset: 0x30
		public Dictionary<String, Int64> currencies; //Field offset: 0x38
		public bool returnBalances; //Field offset: 0x40
		private TaskAwaiter<BankWalletResponse> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	internal Bank_SetWallet(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	[AsyncStateMachine(typeof(<Call>d__1))]
	public Task<BankWalletResponse> Call(string accountHolderID, Dictionary<String, Dictionary`2<String, Int64>> wallets, bool returnBalances = false) { }

	[AsyncStateMachine(typeof(<Call>d__2))]
	public Task<Dictionary`2<String, Int64>> Call(string accountHolderID, string walletName, Dictionary<String, Int64> currencies, bool returnBalances = false) { }

	public Task<Dictionary`2<String, Int64>> Call(string accountHolderID, string walletName, string currencyName, long currencyValue, bool returnBalances = false) { }

}

