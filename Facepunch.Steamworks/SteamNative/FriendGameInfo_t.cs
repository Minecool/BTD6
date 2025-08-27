namespace SteamNative;

internal struct FriendGameInfo_t
{
	public struct PackSmall
	{
		internal ulong GameID; //Field offset: 0x0
		internal uint GameIP; //Field offset: 0x8
		internal ushort GamePort; //Field offset: 0xC
		internal ushort QueryPort; //Field offset: 0xE
		internal ulong SteamIDLobby; //Field offset: 0x10

		public static FriendGameInfo_t op_Implicit(PackSmall d) { }

	}

	internal ulong GameID; //Field offset: 0x0
	internal uint GameIP; //Field offset: 0x8
	internal ushort GamePort; //Field offset: 0xC
	internal ushort QueryPort; //Field offset: 0xE
	internal ulong SteamIDLobby; //Field offset: 0x10

}

