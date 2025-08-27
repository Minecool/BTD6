namespace NinjaKiwi.LiNK.DataModels;

public class BankWalletResponse
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, WalletModel>, String> <>9__2_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, WalletModel>, Dictionary`2<String, Int64>> <>9__2_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__2_0(KeyValuePair<String, WalletModel> kvp) { }

		internal Dictionary<String, Int64> <.ctor>b__2_1(KeyValuePair<String, WalletModel> kvp) { }

	}

	internal class TypeA : BankWalletResponse
	{

		[JsonConstructor]
		internal TypeA(Nullable<Boolean> success, BankModel values) { }

	}

	internal class TypeB : BankWalletResponse
	{

		[JsonConstructor]
		internal TypeB(BankModel wallets) { }

	}

	public readonly bool success; //Field offset: 0x10
	public readonly Dictionary<String, Dictionary`2<String, Int64>> newBalances; //Field offset: 0x18

	[JsonConstructor]
	internal BankWalletResponse(Nullable<Boolean> success, BankModel bankModel) { }

	public bool TryGetCurrency(string walletName, string currencyName, out long currencyValue) { }

	public bool TryGetWallet(string walletName, out Dictionary<String, Int64>& wallet) { }

}

