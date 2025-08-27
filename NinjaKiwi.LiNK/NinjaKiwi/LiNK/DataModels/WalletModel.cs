namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
internal class WalletModel
{
	[DataMember(Name = "nkapiID")]
	public string nkapiID; //Field offset: 0x10
	[DataMember(Name = "walletName")]
	public string walletName; //Field offset: 0x18
	[DataMember(Name = "appID")]
	public int appID; //Field offset: 0x20
	[DataMember(Name = "currencies")]
	public Dictionary<String, Int64> currencies; //Field offset: 0x28

	public WalletModel() { }

}

