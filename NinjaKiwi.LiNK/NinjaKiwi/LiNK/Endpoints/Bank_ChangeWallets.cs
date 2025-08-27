namespace NinjaKiwi.LiNK.Endpoints;

public class Bank_ChangeWallets : Endpoint<TypeA>
{
	[CompilerGenerated]
	private struct <Call>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BankWalletResponse> <>t__builder; //Field offset: 0x8
		public string accountHolderID; //Field offset: 0x20
		public Dictionary<String, IEnumerable`1<CurrencyChanges>> changes; //Field offset: 0x28
		public bool returnBalances; //Field offset: 0x30
		public Bank_ChangeWallets <>4__this; //Field offset: 0x38
		private TaskAwaiter<TypeA> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class AccountActions
	{
		private readonly Bank_ChangeWallets bank_ChangeWallets; //Field offset: 0x10
		private readonly string playerID; //Field offset: 0x18

		internal AccountActions(Bank_ChangeWallets bank_ChangeWallets, string playerID) { }

		public IWalletActions WithWallet(string walletName) { }

	}

	internal class Action
	{
		public static readonly Action SET; //Field offset: 0x0
		public static readonly Action UPDATE; //Field offset: 0x8
		public static readonly Action MAX; //Field offset: 0x10
		public static readonly Action MIN; //Field offset: 0x18
		public readonly string name; //Field offset: 0x10

		private static Action() { }

		private Action(string name) { }

	}

	internal class CurrencyChanges
	{
		public readonly Action action; //Field offset: 0x10
		[JsonProperty("currencies")]
		public readonly Dictionary<String, Int64> currencies; //Field offset: 0x18

		[JsonProperty("action")]
		public string ActionName
		{
			 get { } //Length: 27
		}

		public CurrencyChanges(Action action, Dictionary<String, Int64> currencies) { }

		public CurrencyChanges(Action action) { }

		internal CurrencyChanges(Action action, string currencyName, long currencyValue) { }

		public string get_ActionName() { }

	}

	internal interface IWalletActions
	{

		public WalletActions Add(string currencyName, long value) { }

		public WalletActions Add(Dictionary<String, Int64> currencies) { }

		public WalletActions Max(string currencyName, long value) { }

		public WalletActions Max(Dictionary<String, Int64> currencies) { }

		public WalletActions Min(string currencyName, long value) { }

		public WalletActions Min(Dictionary<String, Int64> currencies) { }

		public WalletActions Set(string currencyName, long value) { }

		public WalletActions Set(Dictionary<String, Int64> currencies) { }

	}

	internal class WalletActions : IWalletActions
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<KeyValuePair`2<String, List`1<CurrencyChanges>>, String> <>9__16_0; //Field offset: 0x8
			public static Func<KeyValuePair`2<String, List`1<CurrencyChanges>>, IEnumerable`1<CurrencyChanges>> <>9__16_1; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal string <Call>b__16_0(KeyValuePair<String, List`1<CurrencyChanges>> kvp) { }

			internal IEnumerable<CurrencyChanges> <Call>b__16_1(KeyValuePair<String, List`1<CurrencyChanges>> kvp) { }

		}

		private readonly Bank_ChangeWallets bank_ChangeWallets; //Field offset: 0x10
		private readonly string playerID; //Field offset: 0x18
		private readonly Dictionary<String, List`1<CurrencyChanges>> walletActions; //Field offset: 0x20
		private List<CurrencyChanges> currentList; //Field offset: 0x28

		internal WalletActions(Bank_ChangeWallets bank_ChangeWallets, string playerID, string walletName) { }

		public override WalletActions Add(string currencyName, long value) { }

		public override WalletActions Add(Dictionary<String, Int64> currencies) { }

		private WalletActions AddMultipleCurrencies(Action action, Dictionary<String, Int64> currencies) { }

		private WalletActions AddSingleCurrency(Action action, string currencyName, long value) { }

		public Task<BankWalletResponse> Call(bool returnBalances = false) { }

		public override WalletActions Max(string currencyName, long value) { }

		public override WalletActions Max(Dictionary<String, Int64> currencies) { }

		public override WalletActions Min(string currencyName, long value) { }

		public override WalletActions Min(Dictionary<String, Int64> currencies) { }

		public override WalletActions Set(string currencyName, long value) { }

		public override WalletActions Set(Dictionary<String, Int64> currencies) { }

		public IWalletActions WithWallet(string walletName) { }

	}


	internal Bank_ChangeWallets(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	[AsyncStateMachine(typeof(<Call>d__1))]
	public Task<BankWalletResponse> Call(string accountHolderID, Dictionary<String, IEnumerable`1<CurrencyChanges>> changes, bool returnBalances = false) { }

	public AccountActions ForPlayer(string playerID) { }

}

