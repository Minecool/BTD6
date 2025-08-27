namespace SteamNative;

internal class SteamFriends : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamFriends(BaseSteamworks steamworks, IntPtr pointer) { }

	public override void Dispose() { }

	public ulong GetFriendByIndex(int iFriend, int iFriendFlags) { }

	public int GetFriendCount(int iFriendFlags) { }

	public bool GetFriendGamePlayed(CSteamID steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	public int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

	public string GetFriendPersonaName(CSteamID steamIDFriend) { }

	public PersonaState GetFriendPersonaState(CSteamID steamIDFriend) { }

	public FriendRelationship GetFriendRelationship(CSteamID steamIDFriend) { }

	public int GetLargeFriendAvatar(CSteamID steamIDFriend) { }

	public int GetMediumFriendAvatar(CSteamID steamIDFriend) { }

	public string GetPersonaName() { }

	public int GetSmallFriendAvatar(CSteamID steamIDFriend) { }

	public void RequestFriendRichPresence(CSteamID steamIDFriend) { }

	public bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly) { }

	public bool SetRichPresence(string pchKey, string pchValue) { }

}

