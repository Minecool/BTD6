//Type is in global namespace

public class Btd6FriendsData
{
	public readonly string avatarId; //Field offset: 0x10
	public readonly string bannerId; //Field offset: 0x18
	public readonly bool isOnlineStatusEnabled; //Field offset: 0x20

	public static Btd6FriendsData Default
	{
		 get { } //Length: 81
	}

	public Btd6FriendsData(string avatar, string banner, bool isOnlineStatusEnabled) { }

	public static Btd6FriendsData get_Default() { }

}

