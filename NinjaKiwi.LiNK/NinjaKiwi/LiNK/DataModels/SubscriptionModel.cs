namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class SubscriptionModel
{
	[DataMember(Name = "identifier")]
	public string Identifier; //Field offset: 0x10
	[DataMember(Name = "subscriptionKey")]
	public string SubscriptionKey; //Field offset: 0x18
	[DataMember(Name = "active")]
	public bool Active; //Field offset: 0x20
	[DataMember(Name = "platform")]
	public string Platform; //Field offset: 0x28
	[DataMember(Name = "expiryTime")]
	public long ExpiryTime; //Field offset: 0x30
	[DataMember(Name = "expiryTimeHuman")]
	public string ExpiryTimeHuman; //Field offset: 0x38
	[DataMember(Name = "type")]
	public string Type; //Field offset: 0x40

	public SubscriptionModel() { }

}

