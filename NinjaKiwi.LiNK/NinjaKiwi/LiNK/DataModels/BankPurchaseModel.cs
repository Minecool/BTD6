namespace NinjaKiwi.LiNK.DataModels;

public class BankPurchaseModel : BankWalletResponse
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Int64>, String> <>9__2_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, Int64>, Int64> <>9__2_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <GetMergedWalletRewards>b__2_0(KeyValuePair<String, Int64> x) { }

		internal long <GetMergedWalletRewards>b__2_1(KeyValuePair<String, Int64> z) { }

	}

	[DataContract]
	internal class Reward
	{
		[DataMember(Name = "name")]
		public string name; //Field offset: 0x10
		[DataMember(Name = "purchaseType")]
		public string purchaseType; //Field offset: 0x18
		[DataMember(Name = "rewardCount")]
		public string rewardCount; //Field offset: 0x20
		[DataMember(Name = "overMaximumRewardCount")]
		public string overMaximumRewardCount; //Field offset: 0x28
		[DataMember(Name = "finalRewards")]
		public Dictionary<String, Dictionary`2<String, Int64>> finalRewards; //Field offset: 0x30

		public Reward() { }

	}

	public readonly Reward[] rewards; //Field offset: 0x20

	[JsonConstructor]
	internal BankPurchaseModel(bool purchaseSuccess, BankModel wallets, Reward[] wholePurchaseRewardList) { }

	public Dictionary<String, Dictionary`2<String, Int64>> GetMergedWalletRewards() { }

}

