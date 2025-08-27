namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class SteamOrderModel
{
	[DataMember(Name = "itemid")]
	public string itemID; //Field offset: 0x10
	[DataMember(Name = "orderid")]
	public string orderID; //Field offset: 0x18
	[DataMember(Name = "success")]
	internal bool success; //Field offset: 0x20

	public SteamOrderModel() { }

}

