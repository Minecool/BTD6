namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class IapVerification
{
	[DataMember(Name = "valid")]
	public bool isValid; //Field offset: 0x10
	[DataMember(Name = "state")]
	public string state; //Field offset: 0x18
	[DataMember(Name = "production")]
	public bool production; //Field offset: 0x20
	[DataMember(Name = "uuid")]
	public string uuid; //Field offset: 0x28
	public BankPurchaseModel purchase; //Field offset: 0x30

	[DataMember(Name = "itemPurchases")]
	public BankPurchaseModel[] SetPurchaseDuringDeserialising
	{
		 set { } //Length: 93
	}

	public IapVerification() { }

	public void set_SetPurchaseDuringDeserialising(BankPurchaseModel[] value) { }

}

