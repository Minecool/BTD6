namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class SteamIapVerification
{
	[DataMember(Name = "success")]
	public bool isValid; //Field offset: 0x10
	[DataMember(Name = "orderid")]
	public string orderId; //Field offset: 0x18
	public BankPurchaseModel purchase; //Field offset: 0x20

	[DataMember(Name = "itemPurchases")]
	public BankPurchaseModel[] SetPurchaseDuringDeserialising
	{
		 set { } //Length: 93
	}

	public SteamIapVerification() { }

	public void set_SetPurchaseDuringDeserialising(BankPurchaseModel[] value) { }

}

