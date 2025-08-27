namespace Assets.Scripts.Unity.Player;

public class PublicProfileModel
{
	public int version; //Field offset: 0x10
	public Dictionary<String, Int32> highestRound; //Field offset: 0x18
	public string avatar; //Field offset: 0x20
	public string banner; //Field offset: 0x28
	public bool isOnlineStatusEnabled; //Field offset: 0x30

	public PublicProfileModel() { }

	public Btd6FriendsData GetFriendsData() { }

}

