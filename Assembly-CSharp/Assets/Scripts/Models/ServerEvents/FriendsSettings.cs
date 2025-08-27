namespace Assets.Scripts.Models.ServerEvents;

public class FriendsSettings : EnableFlag
{
	public TimeSpan refreshTimeout; //Field offset: 0x18
	public TimeSpan showOnlineFor; //Field offset: 0x20
	public TimeSpan mapScoreCacheLife; //Field offset: 0x28
	public int maxFriends; //Field offset: 0x30
	public bool loadOnLaunch; //Field offset: 0x34

	public FriendsSettings() { }

}

