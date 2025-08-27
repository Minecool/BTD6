namespace Assets.Scripts.Unity.Gift;

public interface ILocalisedGift
{

	public GiftType GiftType
	{
		 get { } //Length: 0
	}

	public Dictionary<String, String> LocalisedMessages
	{
		 get { } //Length: 0
	}

	public GiftType get_GiftType() { }

	public Dictionary<String, String> get_LocalisedMessages() { }

}

