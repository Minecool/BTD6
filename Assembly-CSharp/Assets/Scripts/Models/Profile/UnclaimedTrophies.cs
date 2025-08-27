namespace Assets.Scripts.Models.Profile;

[DataContract]
public class UnclaimedTrophies
{
	[DataMember]
	public string transactionId; //Field offset: 0x10
	private KonFuze konFuzedAmount; //Field offset: 0x18

	[DataMember]
	public int amount
	{
		 get { } //Length: 29
	}

	[JsonConstructor]
	public UnclaimedTrophies(int amount, string transactionId) { }

	public int get_amount() { }

}

