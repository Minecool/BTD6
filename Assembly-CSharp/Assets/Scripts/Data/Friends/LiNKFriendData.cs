namespace Assets.Scripts.Data.Friends;

public class LiNKFriendData
{
	public FriendModel model; //Field offset: 0x10
	public string avatarId; //Field offset: 0x18
	public string bannerId; //Field offset: 0x20
	public bool cachedIsFriend; //Field offset: 0x28
	public bool cachedIsBlocked; //Field offset: 0x29
	public Guild_GetMemberResponse guildData; //Field offset: 0x30

	public bool IsOnline
	{
		 get { } //Length: 27
	}

	public LiNKFriendData() { }

	public bool get_IsOnline() { }

}

