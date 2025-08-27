namespace NinjaKiwi.LiNK.DataModels;

public class MultiplePlayersWalletsModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, BankModel>, String> <>9__2_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, WalletModel>, String> <>9__2_2; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, WalletModel>, Dictionary`2<String, Int64>> <>9__2_3; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, BankModel>, Dictionary`2<String, Dictionary`2<String, Int64>>> <>9__2_1; //Field offset: 0x20
		public static Func<KeyValuePair`2<String, Dictionary`2<String, Dictionary`2<String, Int64>>>, String> <>9__7_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__2_0(KeyValuePair<String, BankModel> kvp) { }

		internal Dictionary<String, Dictionary`2<String, Int64>> <.ctor>b__2_1(KeyValuePair<String, BankModel> kvp) { }

		internal string <.ctor>b__2_2(KeyValuePair<String, WalletModel> kvp) { }

		internal Dictionary<String, Int64> <.ctor>b__2_3(KeyValuePair<String, WalletModel> kvp) { }

		internal string <ToSingleWallet>b__7_0(KeyValuePair<String, Dictionary`2<String, Dictionary`2<String, Int64>>> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public MultiplePlayersWalletsModel <>4__this; //Field offset: 0x10
		public string walletName; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal Dictionary<String, Int64> <ToSingleWallet>b__1(KeyValuePair<String, Dictionary`2<String, Dictionary`2<String, Int64>>> kvp) { }

	}

	internal class SingleWallet
	{
		public readonly Dictionary<String, Dictionary`2<String, Int64>> playerWallets; //Field offset: 0x10
		public readonly Dictionary<String, String> failedPlayers; //Field offset: 0x18

		internal SingleWallet(Dictionary<String, Dictionary`2<String, Int64>> playerWallets, Dictionary<String, String> failedPlayers) { }

		public bool DidRequestFailForPlayer(string playerID, out string reason) { }

		public bool TryGetCurrency(string playerID, string currencyName, out long currencyValue) { }

		public bool TryGetWallet(string playerID, out Dictionary<String, Int64>& wallet) { }

	}

	public readonly Dictionary<String, Dictionary`2<String, Dictionary`2<String, Int64>>> playersWallets; //Field offset: 0x10
	public readonly Dictionary<String, String> failedPlayers; //Field offset: 0x18

	[JsonConstructor]
	internal MultiplePlayersWalletsModel(Dictionary<String, BankModel> accountHolders, Dictionary<String, String> failed) { }

	public bool DidRequestFailForPlayer(string playerID, out string reason) { }

	internal SingleWallet ToSingleWallet(string walletName) { }

	public bool TryGetCurrency(string playerID, string walletName, string currencyName, out long currencyValue) { }

	public bool TryGetWallet(string playerID, string walletName, out Dictionary<String, Int64>& wallet) { }

	public bool TryGetWallets(string playerID, out Dictionary<String, Dictionary`2<String, Int64>>& playerWallets) { }

}

