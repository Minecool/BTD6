namespace Assets.Scripts.Models.Profile;

[DataContract]
public class RacePassClaim
{
	[DataMember]
	public string transactionId; //Field offset: 0x10
	[DataMember]
	public LootFrom source; //Field offset: 0x18
	private readonly KonFuze konFuzedAmount; //Field offset: 0x20

	[DataMember]
	public int Amount
	{
		 get { } //Length: 29
	}

	[JsonConstructor]
	public RacePassClaim(LootFrom source, int amount, string transactionId) { }

	public int get_Amount() { }

}

