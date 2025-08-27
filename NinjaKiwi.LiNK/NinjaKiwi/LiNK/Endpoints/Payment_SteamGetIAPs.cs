namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_SteamGetIAPs : Endpoint<SteamIapsModel>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, ItemModel>, String> <>9__2_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, TierModel>, String> <>9__2_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, ItemModel>, KeyValuePair`2<String, TierModel>, SteamIapModel> <>9__2_2; //Field offset: 0x18
		public static Func<SteamIapModel, String> <>9__2_3; //Field offset: 0x20
		public static Func<SteamIapModel, SteamIapModel> <>9__2_4; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <Receive>b__2_0(KeyValuePair<String, ItemModel> item) { }

		internal string <Receive>b__2_1(KeyValuePair<String, TierModel> tier) { }

		internal SteamIapModel <Receive>b__2_2(KeyValuePair<String, ItemModel> item, KeyValuePair<String, TierModel> tier) { }

		internal string <Receive>b__2_3(SteamIapModel item) { }

		internal SteamIapModel <Receive>b__2_4(SteamIapModel item) { }

	}

	[DataContract]
	public class ItemModel
	{
		[DataMember]
		public string tier; //Field offset: 0x10

		public ItemModel() { }

	}

	[DataContract]
	public class TierModel
	{
		[DataMember]
		public string localized; //Field offset: 0x10
		[DataMember]
		public int raw; //Field offset: 0x18

		public TierModel() { }

	}


	internal Payment_SteamGetIAPs(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<SteamIapsModel> Call(string playerSteamID, string currency = null) { }

	protected virtual SteamIapsModel Receive(string json) { }

}

