namespace SteamNative;

internal static class Platform
{
	public interface Interface : IDisposable
	{

		public bool IsValid
		{
			 get { } //Length: 0
		}

		public bool get_IsValid() { }

		public int ISteamApps_GetAppBuildId() { }

		public uint ISteamApps_GetAppInstallDir(uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

		public CSteamID ISteamApps_GetAppOwner() { }

		public IntPtr ISteamApps_GetAvailableGameLanguages() { }

		public bool ISteamApps_GetCurrentBetaName(StringBuilder pchName, int cchNameBufferSize) { }

		public IntPtr ISteamApps_GetCurrentGameLanguage() { }

		public IntPtr ISteamClient_GetISteamAppList(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamApps(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamFriends(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamGameServer(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamGameServerStats(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamHTMLSurface(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamHTTP(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamInventory(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamMatchmaking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamMatchmakingServers(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamNetworking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamRemoteStorage(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamScreenshots(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamUGC(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamUser(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamUserStats(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public IntPtr ISteamClient_GetISteamUtils(int hSteamPipe, string pchVersion) { }

		public CSteamID ISteamFriends_GetFriendByIndex(int iFriend, int iFriendFlags) { }

		public int ISteamFriends_GetFriendCount(int iFriendFlags) { }

		public bool ISteamFriends_GetFriendGamePlayed(ulong steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

		public int ISteamFriends_GetFriendMessage(ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

		public IntPtr ISteamFriends_GetFriendPersonaName(ulong steamIDFriend) { }

		public PersonaState ISteamFriends_GetFriendPersonaState(ulong steamIDFriend) { }

		public FriendRelationship ISteamFriends_GetFriendRelationship(ulong steamIDFriend) { }

		public int ISteamFriends_GetLargeFriendAvatar(ulong steamIDFriend) { }

		public int ISteamFriends_GetMediumFriendAvatar(ulong steamIDFriend) { }

		public IntPtr ISteamFriends_GetPersonaName() { }

		public int ISteamFriends_GetSmallFriendAvatar(ulong steamIDFriend) { }

		public void ISteamFriends_RequestFriendRichPresence(ulong steamIDFriend) { }

		public bool ISteamFriends_RequestUserInformation(ulong steamIDUser, bool bRequireNameOnly) { }

		public bool ISteamFriends_SetRichPresence(string pchKey, string pchValue) { }

		public void ISteamHTMLSurface_AllowStartRequest(uint unBrowserHandle, bool bAllowed) { }

		public SteamAPICall_t ISteamHTMLSurface_CreateBrowser(string pchUserAgent, string pchUserCSS) { }

		public void ISteamHTMLSurface_ExecuteJavascript(uint unBrowserHandle, string pchScript) { }

		public bool ISteamHTMLSurface_Init() { }

		public void ISteamHTMLSurface_KeyChar(uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public void ISteamHTMLSurface_KeyDown(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public void ISteamHTMLSurface_KeyUp(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public void ISteamHTMLSurface_LoadURL(uint unBrowserHandle, string pchURL, string pchPostData) { }

		public void ISteamHTMLSurface_MouseDown(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public void ISteamHTMLSurface_MouseMove(uint unBrowserHandle, int x, int y) { }

		public void ISteamHTMLSurface_MouseUp(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public void ISteamHTMLSurface_MouseWheel(uint unBrowserHandle, int nDelta) { }

		public void ISteamHTMLSurface_Reload(uint unBrowserHandle) { }

		public void ISteamHTMLSurface_RemoveBrowser(uint unBrowserHandle) { }

		public void ISteamHTMLSurface_SetKeyFocus(uint unBrowserHandle, bool bHasKeyFocus) { }

		public void ISteamHTMLSurface_SetSize(uint unBrowserHandle, uint unWidth, uint unHeight) { }

		public bool ISteamHTMLSurface_Shutdown() { }

		public void ISteamHTMLSurface_StopLoad(uint unBrowserHandle) { }

		public void ISteamInventory_DestroyResult(int resultHandle) { }

		public bool ISteamInventory_GetAllItems(ref int pResultHandle) { }

		public bool ISteamInventory_GetItemDefinitionIDs(IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

		public bool ISteamInventory_GetItemDefinitionProperty(int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public bool ISteamInventory_GetItemPrice(int iDefinition, out ulong pPrice) { }

		public bool ISteamInventory_GetResultItemProperty(int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public bool ISteamInventory_GetResultItems(int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

		public Result ISteamInventory_GetResultStatus(int resultHandle) { }

		public uint ISteamInventory_GetResultTimestamp(int resultHandle) { }

		public bool ISteamInventory_LoadItemDefinitions() { }

		public SteamAPICall_t ISteamInventory_RequestPrices() { }

		public bool ISteamInventory_SerializeResult(int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

		public SteamAPICall_t ISteamInventory_StartPurchase(Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

		public bool ISteamMatchmaking_GetFavoriteGame(int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

		public int ISteamMatchmaking_GetFavoriteGameCount() { }

		public bool ISteamNetworking_AcceptP2PSessionWithUser(ulong steamIDRemote) { }

		public bool ISteamNetworking_CloseP2PSessionWithUser(ulong steamIDRemote) { }

		public bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel) { }

		public bool ISteamNetworking_ReadP2PPacket(IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

		public void ISteamUser_CancelAuthTicket(uint hAuthTicket) { }

		public HAuthTicket ISteamUser_GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

		public VoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public CSteamID ISteamUser_GetSteamID() { }

		public bool ISteamUser_GetUserDataFolder(StringBuilder pchBuffer, int cubBuffer) { }

		public VoiceResult ISteamUser_GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public uint ISteamUser_GetVoiceOptimalSampleRate() { }

		public bool ISteamUserStats_GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

		public IntPtr ISteamUserStats_GetAchievementDisplayAttribute(string pchName, string pchKey) { }

		public int ISteamUserStats_GetAchievementIcon(string pchName) { }

		public IntPtr ISteamUserStats_GetAchievementName(uint iAchievement) { }

		public uint ISteamUserStats_GetNumAchievements() { }

		public bool ISteamUserStats_RequestCurrentStats() { }

		public bool ISteamUserStats_SetAchievement(string pchName) { }

		public bool ISteamUserStats_SetStat(string pchName, int nData) { }

		public bool ISteamUserStats_StoreStats() { }

		public bool ISteamUtils_GetAPICallResult(ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

		public bool ISteamUtils_GetImageRGBA(int iImage, IntPtr pubDest, int nDestBufferSize) { }

		public bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

		public bool ISteamUtils_IsAPICallCompleted(ulong hSteamAPICall, ref bool pbFailed) { }

		public bool ISteamUtils_IsOverlayEnabled() { }

		public HSteamPipe SteamApi_SteamAPI_GetHSteamPipe() { }

		public HSteamUser SteamApi_SteamAPI_GetHSteamUser() { }

		public bool SteamApi_SteamAPI_Init() { }

		public void SteamApi_SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

		public void SteamApi_SteamAPI_RunCallbacks() { }

		public void SteamApi_SteamAPI_Shutdown() { }

		public void SteamApi_SteamAPI_UnregisterCallback(IntPtr pCallback) { }

		public void SteamApi_SteamGameServer_Shutdown() { }

		public IntPtr SteamApi_SteamInternal_CreateInterface(string version) { }

	}

	public class Linux32 : Interface, IDisposable
	{
		public static class Native
		{

			internal static HSteamPipe SteamAPI_GetHSteamPipe() { }

			internal static HSteamUser SteamAPI_GetHSteamUser() { }

			internal static bool SteamAPI_Init() { }

			internal static int SteamAPI_ISteamApps_GetAppBuildId(IntPtr ISteamApps) { }

			internal static uint SteamAPI_ISteamApps_GetAppInstallDir(IntPtr ISteamApps, uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

			internal static CSteamID SteamAPI_ISteamApps_GetAppOwner(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamApps_GetAvailableGameLanguages(IntPtr ISteamApps) { }

			internal static bool SteamAPI_ISteamApps_GetCurrentBetaName(IntPtr ISteamApps, StringBuilder pchName, int cchNameBufferSize) { }

			internal static IntPtr SteamAPI_ISteamApps_GetCurrentGameLanguage(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamAppList(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamApps(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamFriends(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServer(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServerStats(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTMLSurface(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTTP(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamInventory(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmaking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmakingServers(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamNetworking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamRemoteStorage(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamScreenshots(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUGC(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUser(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUserStats(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUtils(IntPtr ISteamClient, int hSteamPipe, string pchVersion) { }

			internal static CSteamID SteamAPI_ISteamFriends_GetFriendByIndex(IntPtr ISteamFriends, int iFriend, int iFriendFlags) { }

			internal static int SteamAPI_ISteamFriends_GetFriendCount(IntPtr ISteamFriends, int iFriendFlags) { }

			internal static bool SteamAPI_ISteamFriends_GetFriendGamePlayed(IntPtr ISteamFriends, ulong steamIDFriend, ref PackSmall pFriendGameInfo) { }

			internal static int SteamAPI_ISteamFriends_GetFriendMessage(IntPtr ISteamFriends, ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetFriendPersonaName(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static PersonaState SteamAPI_ISteamFriends_GetFriendPersonaState(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static FriendRelationship SteamAPI_ISteamFriends_GetFriendRelationship(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetLargeFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetMediumFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetPersonaName(IntPtr ISteamFriends) { }

			internal static int SteamAPI_ISteamFriends_GetSmallFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static void SteamAPI_ISteamFriends_RequestFriendRichPresence(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static bool SteamAPI_ISteamFriends_RequestUserInformation(IntPtr ISteamFriends, ulong steamIDUser, bool bRequireNameOnly) { }

			internal static bool SteamAPI_ISteamFriends_SetRichPresence(IntPtr ISteamFriends, string pchKey, string pchValue) { }

			internal static void SteamAPI_ISteamHTMLSurface_AllowStartRequest(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bAllowed) { }

			internal static SteamAPICall_t SteamAPI_ISteamHTMLSurface_CreateBrowser(IntPtr ISteamHTMLSurface, string pchUserAgent, string pchUserCSS) { }

			internal static void SteamAPI_ISteamHTMLSurface_ExecuteJavascript(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchScript) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Init(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyChar(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_LoadURL(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchURL, string pchPostData) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseMove(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int x, int y) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseWheel(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int nDelta) { }

			internal static void SteamAPI_ISteamHTMLSurface_Reload(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_RemoveBrowser(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetKeyFocus(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bHasKeyFocus) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetSize(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint unWidth, uint unHeight) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Shutdown(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_StopLoad(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamInventory_DestroyResult(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetAllItems(IntPtr ISteamInventory, ref int pResultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionIDs(IntPtr ISteamInventory, IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionProperty(IntPtr ISteamInventory, int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetItemPrice(IntPtr ISteamInventory, int iDefinition, out ulong pPrice) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItemProperty(IntPtr ISteamInventory, int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItems(IntPtr ISteamInventory, int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

			internal static Result SteamAPI_ISteamInventory_GetResultStatus(IntPtr ISteamInventory, int resultHandle) { }

			internal static uint SteamAPI_ISteamInventory_GetResultTimestamp(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_LoadItemDefinitions(IntPtr ISteamInventory) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_RequestPrices(IntPtr ISteamInventory) { }

			internal static bool SteamAPI_ISteamInventory_SerializeResult(IntPtr ISteamInventory, int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_StartPurchase(IntPtr ISteamInventory, Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

			internal static bool SteamAPI_ISteamMatchmaking_GetFavoriteGame(IntPtr ISteamMatchmaking, int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

			internal static int SteamAPI_ISteamMatchmaking_GetFavoriteGameCount(IntPtr ISteamMatchmaking) { }

			internal static bool SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_CloseP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_IsP2PPacketAvailable(IntPtr ISteamNetworking, out uint pcubMsgSize, int nChannel) { }

			internal static bool SteamAPI_ISteamNetworking_ReadP2PPacket(IntPtr ISteamNetworking, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

			internal static void SteamAPI_ISteamUser_CancelAuthTicket(IntPtr ISteamUser, uint hAuthTicket) { }

			internal static HAuthTicket SteamAPI_ISteamUser_GetAuthSessionTicket(IntPtr ISteamUser, IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetAvailableVoice(IntPtr ISteamUser, out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static CSteamID SteamAPI_ISteamUser_GetSteamID(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUser_GetUserDataFolder(IntPtr ISteamUser, StringBuilder pchBuffer, int cubBuffer) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetVoice(IntPtr ISteamUser, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static uint SteamAPI_ISteamUser_GetVoiceOptimalSampleRate(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime(IntPtr ISteamUserStats, string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute(IntPtr ISteamUserStats, string pchName, string pchKey) { }

			internal static int SteamAPI_ISteamUserStats_GetAchievementIcon(IntPtr ISteamUserStats, string pchName) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementName(IntPtr ISteamUserStats, uint iAchievement) { }

			internal static uint SteamAPI_ISteamUserStats_GetNumAchievements(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_RequestCurrentStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_SetAchievement(IntPtr ISteamUserStats, string pchName) { }

			internal static bool SteamAPI_ISteamUserStats_SetStat(IntPtr ISteamUserStats, string pchName, int nData) { }

			internal static bool SteamAPI_ISteamUserStats_StoreStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUtils_GetAPICallResult(IntPtr ISteamUtils, ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_GetImageRGBA(IntPtr ISteamUtils, int iImage, IntPtr pubDest, int nDestBufferSize) { }

			internal static bool SteamAPI_ISteamUtils_GetImageSize(IntPtr ISteamUtils, int iImage, out uint pnWidth, out uint pnHeight) { }

			internal static bool SteamAPI_ISteamUtils_IsAPICallCompleted(IntPtr ISteamUtils, ulong hSteamAPICall, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_IsOverlayEnabled(IntPtr ISteamUtils) { }

			internal static void SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

			internal static void SteamAPI_RunCallbacks() { }

			internal static void SteamAPI_Shutdown() { }

			internal static void SteamAPI_UnregisterCallback(IntPtr pCallback) { }

			internal static void SteamGameServer_Shutdown() { }

			internal static IntPtr SteamInternal_CreateInterface(string version) { }

		}

		internal IntPtr _ptr; //Field offset: 0x10

		public override bool IsValid
		{
			 get { } //Length: 9
		}

		internal Linux32(IntPtr pointer) { }

		public override void Dispose() { }

		public override bool get_IsValid() { }

		public override int ISteamApps_GetAppBuildId() { }

		public override uint ISteamApps_GetAppInstallDir(uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

		public override CSteamID ISteamApps_GetAppOwner() { }

		public override IntPtr ISteamApps_GetAvailableGameLanguages() { }

		public override bool ISteamApps_GetCurrentBetaName(StringBuilder pchName, int cchNameBufferSize) { }

		public override IntPtr ISteamApps_GetCurrentGameLanguage() { }

		public override IntPtr ISteamClient_GetISteamAppList(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamApps(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamFriends(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServer(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServerStats(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTMLSurface(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTTP(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamInventory(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmaking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmakingServers(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamNetworking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamRemoteStorage(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamScreenshots(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUGC(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUser(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUserStats(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUtils(int hSteamPipe, string pchVersion) { }

		public override CSteamID ISteamFriends_GetFriendByIndex(int iFriend, int iFriendFlags) { }

		public override int ISteamFriends_GetFriendCount(int iFriendFlags) { }

		public override bool ISteamFriends_GetFriendGamePlayed(ulong steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

		public override int ISteamFriends_GetFriendMessage(ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

		public override IntPtr ISteamFriends_GetFriendPersonaName(ulong steamIDFriend) { }

		public override PersonaState ISteamFriends_GetFriendPersonaState(ulong steamIDFriend) { }

		public override FriendRelationship ISteamFriends_GetFriendRelationship(ulong steamIDFriend) { }

		public override int ISteamFriends_GetLargeFriendAvatar(ulong steamIDFriend) { }

		public override int ISteamFriends_GetMediumFriendAvatar(ulong steamIDFriend) { }

		public override IntPtr ISteamFriends_GetPersonaName() { }

		public override int ISteamFriends_GetSmallFriendAvatar(ulong steamIDFriend) { }

		public override void ISteamFriends_RequestFriendRichPresence(ulong steamIDFriend) { }

		public override bool ISteamFriends_RequestUserInformation(ulong steamIDUser, bool bRequireNameOnly) { }

		public override bool ISteamFriends_SetRichPresence(string pchKey, string pchValue) { }

		public override void ISteamHTMLSurface_AllowStartRequest(uint unBrowserHandle, bool bAllowed) { }

		public override SteamAPICall_t ISteamHTMLSurface_CreateBrowser(string pchUserAgent, string pchUserCSS) { }

		public override void ISteamHTMLSurface_ExecuteJavascript(uint unBrowserHandle, string pchScript) { }

		public override bool ISteamHTMLSurface_Init() { }

		public override void ISteamHTMLSurface_KeyChar(uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyDown(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyUp(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_LoadURL(uint unBrowserHandle, string pchURL, string pchPostData) { }

		public override void ISteamHTMLSurface_MouseDown(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseMove(uint unBrowserHandle, int x, int y) { }

		public override void ISteamHTMLSurface_MouseUp(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseWheel(uint unBrowserHandle, int nDelta) { }

		public override void ISteamHTMLSurface_Reload(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_RemoveBrowser(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_SetKeyFocus(uint unBrowserHandle, bool bHasKeyFocus) { }

		public override void ISteamHTMLSurface_SetSize(uint unBrowserHandle, uint unWidth, uint unHeight) { }

		public override bool ISteamHTMLSurface_Shutdown() { }

		public override void ISteamHTMLSurface_StopLoad(uint unBrowserHandle) { }

		public override void ISteamInventory_DestroyResult(int resultHandle) { }

		public override bool ISteamInventory_GetAllItems(ref int pResultHandle) { }

		public override bool ISteamInventory_GetItemDefinitionIDs(IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

		public override bool ISteamInventory_GetItemDefinitionProperty(int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetItemPrice(int iDefinition, out ulong pPrice) { }

		public override bool ISteamInventory_GetResultItemProperty(int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetResultItems(int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

		public override Result ISteamInventory_GetResultStatus(int resultHandle) { }

		public override uint ISteamInventory_GetResultTimestamp(int resultHandle) { }

		public override bool ISteamInventory_LoadItemDefinitions() { }

		public override SteamAPICall_t ISteamInventory_RequestPrices() { }

		public override bool ISteamInventory_SerializeResult(int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

		public override SteamAPICall_t ISteamInventory_StartPurchase(Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

		public override bool ISteamMatchmaking_GetFavoriteGame(int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

		public override int ISteamMatchmaking_GetFavoriteGameCount() { }

		public override bool ISteamNetworking_AcceptP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_CloseP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel) { }

		public override bool ISteamNetworking_ReadP2PPacket(IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

		public override void ISteamUser_CancelAuthTicket(uint hAuthTicket) { }

		public override HAuthTicket ISteamUser_GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

		public override VoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override CSteamID ISteamUser_GetSteamID() { }

		public override bool ISteamUser_GetUserDataFolder(StringBuilder pchBuffer, int cubBuffer) { }

		public override VoiceResult ISteamUser_GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override uint ISteamUser_GetVoiceOptimalSampleRate() { }

		public override bool ISteamUserStats_GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

		public override IntPtr ISteamUserStats_GetAchievementDisplayAttribute(string pchName, string pchKey) { }

		public override int ISteamUserStats_GetAchievementIcon(string pchName) { }

		public override IntPtr ISteamUserStats_GetAchievementName(uint iAchievement) { }

		public override uint ISteamUserStats_GetNumAchievements() { }

		public override bool ISteamUserStats_RequestCurrentStats() { }

		public override bool ISteamUserStats_SetAchievement(string pchName) { }

		public override bool ISteamUserStats_SetStat(string pchName, int nData) { }

		public override bool ISteamUserStats_StoreStats() { }

		public override bool ISteamUtils_GetAPICallResult(ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

		public override bool ISteamUtils_GetImageRGBA(int iImage, IntPtr pubDest, int nDestBufferSize) { }

		public override bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

		public override bool ISteamUtils_IsAPICallCompleted(ulong hSteamAPICall, ref bool pbFailed) { }

		public override bool ISteamUtils_IsOverlayEnabled() { }

		public override HSteamPipe SteamApi_SteamAPI_GetHSteamPipe() { }

		public override HSteamUser SteamApi_SteamAPI_GetHSteamUser() { }

		public override bool SteamApi_SteamAPI_Init() { }

		public override void SteamApi_SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

		public override void SteamApi_SteamAPI_RunCallbacks() { }

		public override void SteamApi_SteamAPI_Shutdown() { }

		public override void SteamApi_SteamAPI_UnregisterCallback(IntPtr pCallback) { }

		public override void SteamApi_SteamGameServer_Shutdown() { }

		public override IntPtr SteamApi_SteamInternal_CreateInterface(string version) { }

	}

	public class Linux64 : Interface, IDisposable
	{
		public static class Native
		{

			internal static HSteamPipe SteamAPI_GetHSteamPipe() { }

			internal static HSteamUser SteamAPI_GetHSteamUser() { }

			internal static bool SteamAPI_Init() { }

			internal static int SteamAPI_ISteamApps_GetAppBuildId(IntPtr ISteamApps) { }

			internal static uint SteamAPI_ISteamApps_GetAppInstallDir(IntPtr ISteamApps, uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

			internal static CSteamID SteamAPI_ISteamApps_GetAppOwner(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamApps_GetAvailableGameLanguages(IntPtr ISteamApps) { }

			internal static bool SteamAPI_ISteamApps_GetCurrentBetaName(IntPtr ISteamApps, StringBuilder pchName, int cchNameBufferSize) { }

			internal static IntPtr SteamAPI_ISteamApps_GetCurrentGameLanguage(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamAppList(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamApps(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamFriends(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServer(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServerStats(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTMLSurface(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTTP(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamInventory(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmaking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmakingServers(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamNetworking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamRemoteStorage(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamScreenshots(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUGC(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUser(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUserStats(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUtils(IntPtr ISteamClient, int hSteamPipe, string pchVersion) { }

			internal static CSteamID SteamAPI_ISteamFriends_GetFriendByIndex(IntPtr ISteamFriends, int iFriend, int iFriendFlags) { }

			internal static int SteamAPI_ISteamFriends_GetFriendCount(IntPtr ISteamFriends, int iFriendFlags) { }

			internal static bool SteamAPI_ISteamFriends_GetFriendGamePlayed(IntPtr ISteamFriends, ulong steamIDFriend, ref PackSmall pFriendGameInfo) { }

			internal static int SteamAPI_ISteamFriends_GetFriendMessage(IntPtr ISteamFriends, ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetFriendPersonaName(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static PersonaState SteamAPI_ISteamFriends_GetFriendPersonaState(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static FriendRelationship SteamAPI_ISteamFriends_GetFriendRelationship(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetLargeFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetMediumFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetPersonaName(IntPtr ISteamFriends) { }

			internal static int SteamAPI_ISteamFriends_GetSmallFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static void SteamAPI_ISteamFriends_RequestFriendRichPresence(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static bool SteamAPI_ISteamFriends_RequestUserInformation(IntPtr ISteamFriends, ulong steamIDUser, bool bRequireNameOnly) { }

			internal static bool SteamAPI_ISteamFriends_SetRichPresence(IntPtr ISteamFriends, string pchKey, string pchValue) { }

			internal static void SteamAPI_ISteamHTMLSurface_AllowStartRequest(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bAllowed) { }

			internal static SteamAPICall_t SteamAPI_ISteamHTMLSurface_CreateBrowser(IntPtr ISteamHTMLSurface, string pchUserAgent, string pchUserCSS) { }

			internal static void SteamAPI_ISteamHTMLSurface_ExecuteJavascript(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchScript) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Init(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyChar(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_LoadURL(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchURL, string pchPostData) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseMove(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int x, int y) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseWheel(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int nDelta) { }

			internal static void SteamAPI_ISteamHTMLSurface_Reload(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_RemoveBrowser(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetKeyFocus(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bHasKeyFocus) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetSize(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint unWidth, uint unHeight) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Shutdown(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_StopLoad(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamInventory_DestroyResult(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetAllItems(IntPtr ISteamInventory, ref int pResultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionIDs(IntPtr ISteamInventory, IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionProperty(IntPtr ISteamInventory, int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetItemPrice(IntPtr ISteamInventory, int iDefinition, out ulong pPrice) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItemProperty(IntPtr ISteamInventory, int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItems(IntPtr ISteamInventory, int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

			internal static Result SteamAPI_ISteamInventory_GetResultStatus(IntPtr ISteamInventory, int resultHandle) { }

			internal static uint SteamAPI_ISteamInventory_GetResultTimestamp(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_LoadItemDefinitions(IntPtr ISteamInventory) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_RequestPrices(IntPtr ISteamInventory) { }

			internal static bool SteamAPI_ISteamInventory_SerializeResult(IntPtr ISteamInventory, int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_StartPurchase(IntPtr ISteamInventory, Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

			internal static bool SteamAPI_ISteamMatchmaking_GetFavoriteGame(IntPtr ISteamMatchmaking, int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

			internal static int SteamAPI_ISteamMatchmaking_GetFavoriteGameCount(IntPtr ISteamMatchmaking) { }

			internal static bool SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_CloseP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_IsP2PPacketAvailable(IntPtr ISteamNetworking, out uint pcubMsgSize, int nChannel) { }

			internal static bool SteamAPI_ISteamNetworking_ReadP2PPacket(IntPtr ISteamNetworking, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

			internal static void SteamAPI_ISteamUser_CancelAuthTicket(IntPtr ISteamUser, uint hAuthTicket) { }

			internal static HAuthTicket SteamAPI_ISteamUser_GetAuthSessionTicket(IntPtr ISteamUser, IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetAvailableVoice(IntPtr ISteamUser, out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static CSteamID SteamAPI_ISteamUser_GetSteamID(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUser_GetUserDataFolder(IntPtr ISteamUser, StringBuilder pchBuffer, int cubBuffer) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetVoice(IntPtr ISteamUser, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static uint SteamAPI_ISteamUser_GetVoiceOptimalSampleRate(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime(IntPtr ISteamUserStats, string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute(IntPtr ISteamUserStats, string pchName, string pchKey) { }

			internal static int SteamAPI_ISteamUserStats_GetAchievementIcon(IntPtr ISteamUserStats, string pchName) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementName(IntPtr ISteamUserStats, uint iAchievement) { }

			internal static uint SteamAPI_ISteamUserStats_GetNumAchievements(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_RequestCurrentStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_SetAchievement(IntPtr ISteamUserStats, string pchName) { }

			internal static bool SteamAPI_ISteamUserStats_SetStat(IntPtr ISteamUserStats, string pchName, int nData) { }

			internal static bool SteamAPI_ISteamUserStats_StoreStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUtils_GetAPICallResult(IntPtr ISteamUtils, ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_GetImageRGBA(IntPtr ISteamUtils, int iImage, IntPtr pubDest, int nDestBufferSize) { }

			internal static bool SteamAPI_ISteamUtils_GetImageSize(IntPtr ISteamUtils, int iImage, out uint pnWidth, out uint pnHeight) { }

			internal static bool SteamAPI_ISteamUtils_IsAPICallCompleted(IntPtr ISteamUtils, ulong hSteamAPICall, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_IsOverlayEnabled(IntPtr ISteamUtils) { }

			internal static void SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

			internal static void SteamAPI_RunCallbacks() { }

			internal static void SteamAPI_Shutdown() { }

			internal static void SteamAPI_UnregisterCallback(IntPtr pCallback) { }

			internal static void SteamGameServer_Shutdown() { }

			internal static IntPtr SteamInternal_CreateInterface(string version) { }

		}

		internal IntPtr _ptr; //Field offset: 0x10

		public override bool IsValid
		{
			 get { } //Length: 9
		}

		internal Linux64(IntPtr pointer) { }

		public override void Dispose() { }

		public override bool get_IsValid() { }

		public override int ISteamApps_GetAppBuildId() { }

		public override uint ISteamApps_GetAppInstallDir(uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

		public override CSteamID ISteamApps_GetAppOwner() { }

		public override IntPtr ISteamApps_GetAvailableGameLanguages() { }

		public override bool ISteamApps_GetCurrentBetaName(StringBuilder pchName, int cchNameBufferSize) { }

		public override IntPtr ISteamApps_GetCurrentGameLanguage() { }

		public override IntPtr ISteamClient_GetISteamAppList(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamApps(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamFriends(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServer(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServerStats(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTMLSurface(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTTP(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamInventory(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmaking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmakingServers(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamNetworking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamRemoteStorage(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamScreenshots(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUGC(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUser(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUserStats(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUtils(int hSteamPipe, string pchVersion) { }

		public override CSteamID ISteamFriends_GetFriendByIndex(int iFriend, int iFriendFlags) { }

		public override int ISteamFriends_GetFriendCount(int iFriendFlags) { }

		public override bool ISteamFriends_GetFriendGamePlayed(ulong steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

		public override int ISteamFriends_GetFriendMessage(ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

		public override IntPtr ISteamFriends_GetFriendPersonaName(ulong steamIDFriend) { }

		public override PersonaState ISteamFriends_GetFriendPersonaState(ulong steamIDFriend) { }

		public override FriendRelationship ISteamFriends_GetFriendRelationship(ulong steamIDFriend) { }

		public override int ISteamFriends_GetLargeFriendAvatar(ulong steamIDFriend) { }

		public override int ISteamFriends_GetMediumFriendAvatar(ulong steamIDFriend) { }

		public override IntPtr ISteamFriends_GetPersonaName() { }

		public override int ISteamFriends_GetSmallFriendAvatar(ulong steamIDFriend) { }

		public override void ISteamFriends_RequestFriendRichPresence(ulong steamIDFriend) { }

		public override bool ISteamFriends_RequestUserInformation(ulong steamIDUser, bool bRequireNameOnly) { }

		public override bool ISteamFriends_SetRichPresence(string pchKey, string pchValue) { }

		public override void ISteamHTMLSurface_AllowStartRequest(uint unBrowserHandle, bool bAllowed) { }

		public override SteamAPICall_t ISteamHTMLSurface_CreateBrowser(string pchUserAgent, string pchUserCSS) { }

		public override void ISteamHTMLSurface_ExecuteJavascript(uint unBrowserHandle, string pchScript) { }

		public override bool ISteamHTMLSurface_Init() { }

		public override void ISteamHTMLSurface_KeyChar(uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyDown(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyUp(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_LoadURL(uint unBrowserHandle, string pchURL, string pchPostData) { }

		public override void ISteamHTMLSurface_MouseDown(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseMove(uint unBrowserHandle, int x, int y) { }

		public override void ISteamHTMLSurface_MouseUp(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseWheel(uint unBrowserHandle, int nDelta) { }

		public override void ISteamHTMLSurface_Reload(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_RemoveBrowser(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_SetKeyFocus(uint unBrowserHandle, bool bHasKeyFocus) { }

		public override void ISteamHTMLSurface_SetSize(uint unBrowserHandle, uint unWidth, uint unHeight) { }

		public override bool ISteamHTMLSurface_Shutdown() { }

		public override void ISteamHTMLSurface_StopLoad(uint unBrowserHandle) { }

		public override void ISteamInventory_DestroyResult(int resultHandle) { }

		public override bool ISteamInventory_GetAllItems(ref int pResultHandle) { }

		public override bool ISteamInventory_GetItemDefinitionIDs(IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

		public override bool ISteamInventory_GetItemDefinitionProperty(int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetItemPrice(int iDefinition, out ulong pPrice) { }

		public override bool ISteamInventory_GetResultItemProperty(int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetResultItems(int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

		public override Result ISteamInventory_GetResultStatus(int resultHandle) { }

		public override uint ISteamInventory_GetResultTimestamp(int resultHandle) { }

		public override bool ISteamInventory_LoadItemDefinitions() { }

		public override SteamAPICall_t ISteamInventory_RequestPrices() { }

		public override bool ISteamInventory_SerializeResult(int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

		public override SteamAPICall_t ISteamInventory_StartPurchase(Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

		public override bool ISteamMatchmaking_GetFavoriteGame(int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

		public override int ISteamMatchmaking_GetFavoriteGameCount() { }

		public override bool ISteamNetworking_AcceptP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_CloseP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel) { }

		public override bool ISteamNetworking_ReadP2PPacket(IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

		public override void ISteamUser_CancelAuthTicket(uint hAuthTicket) { }

		public override HAuthTicket ISteamUser_GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

		public override VoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override CSteamID ISteamUser_GetSteamID() { }

		public override bool ISteamUser_GetUserDataFolder(StringBuilder pchBuffer, int cubBuffer) { }

		public override VoiceResult ISteamUser_GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override uint ISteamUser_GetVoiceOptimalSampleRate() { }

		public override bool ISteamUserStats_GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

		public override IntPtr ISteamUserStats_GetAchievementDisplayAttribute(string pchName, string pchKey) { }

		public override int ISteamUserStats_GetAchievementIcon(string pchName) { }

		public override IntPtr ISteamUserStats_GetAchievementName(uint iAchievement) { }

		public override uint ISteamUserStats_GetNumAchievements() { }

		public override bool ISteamUserStats_RequestCurrentStats() { }

		public override bool ISteamUserStats_SetAchievement(string pchName) { }

		public override bool ISteamUserStats_SetStat(string pchName, int nData) { }

		public override bool ISteamUserStats_StoreStats() { }

		public override bool ISteamUtils_GetAPICallResult(ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

		public override bool ISteamUtils_GetImageRGBA(int iImage, IntPtr pubDest, int nDestBufferSize) { }

		public override bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

		public override bool ISteamUtils_IsAPICallCompleted(ulong hSteamAPICall, ref bool pbFailed) { }

		public override bool ISteamUtils_IsOverlayEnabled() { }

		public override HSteamPipe SteamApi_SteamAPI_GetHSteamPipe() { }

		public override HSteamUser SteamApi_SteamAPI_GetHSteamUser() { }

		public override bool SteamApi_SteamAPI_Init() { }

		public override void SteamApi_SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

		public override void SteamApi_SteamAPI_RunCallbacks() { }

		public override void SteamApi_SteamAPI_Shutdown() { }

		public override void SteamApi_SteamAPI_UnregisterCallback(IntPtr pCallback) { }

		public override void SteamApi_SteamGameServer_Shutdown() { }

		public override IntPtr SteamApi_SteamInternal_CreateInterface(string version) { }

	}

	public class Mac : Interface, IDisposable
	{
		public static class Native
		{

			internal static HSteamPipe SteamAPI_GetHSteamPipe() { }

			internal static HSteamUser SteamAPI_GetHSteamUser() { }

			internal static bool SteamAPI_Init() { }

			internal static int SteamAPI_ISteamApps_GetAppBuildId(IntPtr ISteamApps) { }

			internal static uint SteamAPI_ISteamApps_GetAppInstallDir(IntPtr ISteamApps, uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

			internal static CSteamID SteamAPI_ISteamApps_GetAppOwner(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamApps_GetAvailableGameLanguages(IntPtr ISteamApps) { }

			internal static bool SteamAPI_ISteamApps_GetCurrentBetaName(IntPtr ISteamApps, StringBuilder pchName, int cchNameBufferSize) { }

			internal static IntPtr SteamAPI_ISteamApps_GetCurrentGameLanguage(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamAppList(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamApps(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamFriends(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServer(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServerStats(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTMLSurface(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTTP(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamInventory(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmaking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmakingServers(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamNetworking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamRemoteStorage(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamScreenshots(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUGC(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUser(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUserStats(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUtils(IntPtr ISteamClient, int hSteamPipe, string pchVersion) { }

			internal static CSteamID SteamAPI_ISteamFriends_GetFriendByIndex(IntPtr ISteamFriends, int iFriend, int iFriendFlags) { }

			internal static int SteamAPI_ISteamFriends_GetFriendCount(IntPtr ISteamFriends, int iFriendFlags) { }

			internal static bool SteamAPI_ISteamFriends_GetFriendGamePlayed(IntPtr ISteamFriends, ulong steamIDFriend, ref PackSmall pFriendGameInfo) { }

			internal static int SteamAPI_ISteamFriends_GetFriendMessage(IntPtr ISteamFriends, ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetFriendPersonaName(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static PersonaState SteamAPI_ISteamFriends_GetFriendPersonaState(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static FriendRelationship SteamAPI_ISteamFriends_GetFriendRelationship(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetLargeFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetMediumFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetPersonaName(IntPtr ISteamFriends) { }

			internal static int SteamAPI_ISteamFriends_GetSmallFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static void SteamAPI_ISteamFriends_RequestFriendRichPresence(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static bool SteamAPI_ISteamFriends_RequestUserInformation(IntPtr ISteamFriends, ulong steamIDUser, bool bRequireNameOnly) { }

			internal static bool SteamAPI_ISteamFriends_SetRichPresence(IntPtr ISteamFriends, string pchKey, string pchValue) { }

			internal static void SteamAPI_ISteamHTMLSurface_AllowStartRequest(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bAllowed) { }

			internal static SteamAPICall_t SteamAPI_ISteamHTMLSurface_CreateBrowser(IntPtr ISteamHTMLSurface, string pchUserAgent, string pchUserCSS) { }

			internal static void SteamAPI_ISteamHTMLSurface_ExecuteJavascript(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchScript) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Init(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyChar(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_LoadURL(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchURL, string pchPostData) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseMove(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int x, int y) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseWheel(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int nDelta) { }

			internal static void SteamAPI_ISteamHTMLSurface_Reload(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_RemoveBrowser(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetKeyFocus(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bHasKeyFocus) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetSize(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint unWidth, uint unHeight) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Shutdown(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_StopLoad(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamInventory_DestroyResult(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetAllItems(IntPtr ISteamInventory, ref int pResultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionIDs(IntPtr ISteamInventory, IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionProperty(IntPtr ISteamInventory, int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetItemPrice(IntPtr ISteamInventory, int iDefinition, out ulong pPrice) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItemProperty(IntPtr ISteamInventory, int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItems(IntPtr ISteamInventory, int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

			internal static Result SteamAPI_ISteamInventory_GetResultStatus(IntPtr ISteamInventory, int resultHandle) { }

			internal static uint SteamAPI_ISteamInventory_GetResultTimestamp(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_LoadItemDefinitions(IntPtr ISteamInventory) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_RequestPrices(IntPtr ISteamInventory) { }

			internal static bool SteamAPI_ISteamInventory_SerializeResult(IntPtr ISteamInventory, int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_StartPurchase(IntPtr ISteamInventory, Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

			internal static bool SteamAPI_ISteamMatchmaking_GetFavoriteGame(IntPtr ISteamMatchmaking, int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

			internal static int SteamAPI_ISteamMatchmaking_GetFavoriteGameCount(IntPtr ISteamMatchmaking) { }

			internal static bool SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_CloseP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_IsP2PPacketAvailable(IntPtr ISteamNetworking, out uint pcubMsgSize, int nChannel) { }

			internal static bool SteamAPI_ISteamNetworking_ReadP2PPacket(IntPtr ISteamNetworking, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

			internal static void SteamAPI_ISteamUser_CancelAuthTicket(IntPtr ISteamUser, uint hAuthTicket) { }

			internal static HAuthTicket SteamAPI_ISteamUser_GetAuthSessionTicket(IntPtr ISteamUser, IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetAvailableVoice(IntPtr ISteamUser, out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static CSteamID SteamAPI_ISteamUser_GetSteamID(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUser_GetUserDataFolder(IntPtr ISteamUser, StringBuilder pchBuffer, int cubBuffer) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetVoice(IntPtr ISteamUser, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static uint SteamAPI_ISteamUser_GetVoiceOptimalSampleRate(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime(IntPtr ISteamUserStats, string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute(IntPtr ISteamUserStats, string pchName, string pchKey) { }

			internal static int SteamAPI_ISteamUserStats_GetAchievementIcon(IntPtr ISteamUserStats, string pchName) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementName(IntPtr ISteamUserStats, uint iAchievement) { }

			internal static uint SteamAPI_ISteamUserStats_GetNumAchievements(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_RequestCurrentStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_SetAchievement(IntPtr ISteamUserStats, string pchName) { }

			internal static bool SteamAPI_ISteamUserStats_SetStat(IntPtr ISteamUserStats, string pchName, int nData) { }

			internal static bool SteamAPI_ISteamUserStats_StoreStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUtils_GetAPICallResult(IntPtr ISteamUtils, ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_GetImageRGBA(IntPtr ISteamUtils, int iImage, IntPtr pubDest, int nDestBufferSize) { }

			internal static bool SteamAPI_ISteamUtils_GetImageSize(IntPtr ISteamUtils, int iImage, out uint pnWidth, out uint pnHeight) { }

			internal static bool SteamAPI_ISteamUtils_IsAPICallCompleted(IntPtr ISteamUtils, ulong hSteamAPICall, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_IsOverlayEnabled(IntPtr ISteamUtils) { }

			internal static void SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

			internal static void SteamAPI_RunCallbacks() { }

			internal static void SteamAPI_Shutdown() { }

			internal static void SteamAPI_UnregisterCallback(IntPtr pCallback) { }

			internal static void SteamGameServer_Shutdown() { }

			internal static IntPtr SteamInternal_CreateInterface(string version) { }

		}

		internal IntPtr _ptr; //Field offset: 0x10

		public override bool IsValid
		{
			 get { } //Length: 9
		}

		internal Mac(IntPtr pointer) { }

		public override void Dispose() { }

		public override bool get_IsValid() { }

		public override int ISteamApps_GetAppBuildId() { }

		public override uint ISteamApps_GetAppInstallDir(uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

		public override CSteamID ISteamApps_GetAppOwner() { }

		public override IntPtr ISteamApps_GetAvailableGameLanguages() { }

		public override bool ISteamApps_GetCurrentBetaName(StringBuilder pchName, int cchNameBufferSize) { }

		public override IntPtr ISteamApps_GetCurrentGameLanguage() { }

		public override IntPtr ISteamClient_GetISteamAppList(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamApps(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamFriends(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServer(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServerStats(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTMLSurface(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTTP(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamInventory(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmaking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmakingServers(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamNetworking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamRemoteStorage(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamScreenshots(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUGC(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUser(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUserStats(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUtils(int hSteamPipe, string pchVersion) { }

		public override CSteamID ISteamFriends_GetFriendByIndex(int iFriend, int iFriendFlags) { }

		public override int ISteamFriends_GetFriendCount(int iFriendFlags) { }

		public override bool ISteamFriends_GetFriendGamePlayed(ulong steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

		public override int ISteamFriends_GetFriendMessage(ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

		public override IntPtr ISteamFriends_GetFriendPersonaName(ulong steamIDFriend) { }

		public override PersonaState ISteamFriends_GetFriendPersonaState(ulong steamIDFriend) { }

		public override FriendRelationship ISteamFriends_GetFriendRelationship(ulong steamIDFriend) { }

		public override int ISteamFriends_GetLargeFriendAvatar(ulong steamIDFriend) { }

		public override int ISteamFriends_GetMediumFriendAvatar(ulong steamIDFriend) { }

		public override IntPtr ISteamFriends_GetPersonaName() { }

		public override int ISteamFriends_GetSmallFriendAvatar(ulong steamIDFriend) { }

		public override void ISteamFriends_RequestFriendRichPresence(ulong steamIDFriend) { }

		public override bool ISteamFriends_RequestUserInformation(ulong steamIDUser, bool bRequireNameOnly) { }

		public override bool ISteamFriends_SetRichPresence(string pchKey, string pchValue) { }

		public override void ISteamHTMLSurface_AllowStartRequest(uint unBrowserHandle, bool bAllowed) { }

		public override SteamAPICall_t ISteamHTMLSurface_CreateBrowser(string pchUserAgent, string pchUserCSS) { }

		public override void ISteamHTMLSurface_ExecuteJavascript(uint unBrowserHandle, string pchScript) { }

		public override bool ISteamHTMLSurface_Init() { }

		public override void ISteamHTMLSurface_KeyChar(uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyDown(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyUp(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_LoadURL(uint unBrowserHandle, string pchURL, string pchPostData) { }

		public override void ISteamHTMLSurface_MouseDown(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseMove(uint unBrowserHandle, int x, int y) { }

		public override void ISteamHTMLSurface_MouseUp(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseWheel(uint unBrowserHandle, int nDelta) { }

		public override void ISteamHTMLSurface_Reload(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_RemoveBrowser(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_SetKeyFocus(uint unBrowserHandle, bool bHasKeyFocus) { }

		public override void ISteamHTMLSurface_SetSize(uint unBrowserHandle, uint unWidth, uint unHeight) { }

		public override bool ISteamHTMLSurface_Shutdown() { }

		public override void ISteamHTMLSurface_StopLoad(uint unBrowserHandle) { }

		public override void ISteamInventory_DestroyResult(int resultHandle) { }

		public override bool ISteamInventory_GetAllItems(ref int pResultHandle) { }

		public override bool ISteamInventory_GetItemDefinitionIDs(IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

		public override bool ISteamInventory_GetItemDefinitionProperty(int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetItemPrice(int iDefinition, out ulong pPrice) { }

		public override bool ISteamInventory_GetResultItemProperty(int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetResultItems(int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

		public override Result ISteamInventory_GetResultStatus(int resultHandle) { }

		public override uint ISteamInventory_GetResultTimestamp(int resultHandle) { }

		public override bool ISteamInventory_LoadItemDefinitions() { }

		public override SteamAPICall_t ISteamInventory_RequestPrices() { }

		public override bool ISteamInventory_SerializeResult(int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

		public override SteamAPICall_t ISteamInventory_StartPurchase(Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

		public override bool ISteamMatchmaking_GetFavoriteGame(int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

		public override int ISteamMatchmaking_GetFavoriteGameCount() { }

		public override bool ISteamNetworking_AcceptP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_CloseP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel) { }

		public override bool ISteamNetworking_ReadP2PPacket(IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

		public override void ISteamUser_CancelAuthTicket(uint hAuthTicket) { }

		public override HAuthTicket ISteamUser_GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

		public override VoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override CSteamID ISteamUser_GetSteamID() { }

		public override bool ISteamUser_GetUserDataFolder(StringBuilder pchBuffer, int cubBuffer) { }

		public override VoiceResult ISteamUser_GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override uint ISteamUser_GetVoiceOptimalSampleRate() { }

		public override bool ISteamUserStats_GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

		public override IntPtr ISteamUserStats_GetAchievementDisplayAttribute(string pchName, string pchKey) { }

		public override int ISteamUserStats_GetAchievementIcon(string pchName) { }

		public override IntPtr ISteamUserStats_GetAchievementName(uint iAchievement) { }

		public override uint ISteamUserStats_GetNumAchievements() { }

		public override bool ISteamUserStats_RequestCurrentStats() { }

		public override bool ISteamUserStats_SetAchievement(string pchName) { }

		public override bool ISteamUserStats_SetStat(string pchName, int nData) { }

		public override bool ISteamUserStats_StoreStats() { }

		public override bool ISteamUtils_GetAPICallResult(ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

		public override bool ISteamUtils_GetImageRGBA(int iImage, IntPtr pubDest, int nDestBufferSize) { }

		public override bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

		public override bool ISteamUtils_IsAPICallCompleted(ulong hSteamAPICall, ref bool pbFailed) { }

		public override bool ISteamUtils_IsOverlayEnabled() { }

		public override HSteamPipe SteamApi_SteamAPI_GetHSteamPipe() { }

		public override HSteamUser SteamApi_SteamAPI_GetHSteamUser() { }

		public override bool SteamApi_SteamAPI_Init() { }

		public override void SteamApi_SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

		public override void SteamApi_SteamAPI_RunCallbacks() { }

		public override void SteamApi_SteamAPI_Shutdown() { }

		public override void SteamApi_SteamAPI_UnregisterCallback(IntPtr pCallback) { }

		public override void SteamApi_SteamGameServer_Shutdown() { }

		public override IntPtr SteamApi_SteamInternal_CreateInterface(string version) { }

	}

	public class Win32 : Interface, IDisposable
	{
		public static class Native
		{

			internal static HSteamPipe SteamAPI_GetHSteamPipe() { }

			internal static HSteamUser SteamAPI_GetHSteamUser() { }

			internal static bool SteamAPI_Init() { }

			internal static int SteamAPI_ISteamApps_GetAppBuildId(IntPtr ISteamApps) { }

			internal static uint SteamAPI_ISteamApps_GetAppInstallDir(IntPtr ISteamApps, uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

			internal static CSteamID SteamAPI_ISteamApps_GetAppOwner(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamApps_GetAvailableGameLanguages(IntPtr ISteamApps) { }

			internal static bool SteamAPI_ISteamApps_GetCurrentBetaName(IntPtr ISteamApps, StringBuilder pchName, int cchNameBufferSize) { }

			internal static IntPtr SteamAPI_ISteamApps_GetCurrentGameLanguage(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamAppList(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamApps(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamFriends(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServer(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServerStats(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTMLSurface(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTTP(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamInventory(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmaking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmakingServers(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamNetworking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamRemoteStorage(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamScreenshots(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUGC(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUser(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUserStats(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUtils(IntPtr ISteamClient, int hSteamPipe, string pchVersion) { }

			internal static CSteamID SteamAPI_ISteamFriends_GetFriendByIndex(IntPtr ISteamFriends, int iFriend, int iFriendFlags) { }

			internal static int SteamAPI_ISteamFriends_GetFriendCount(IntPtr ISteamFriends, int iFriendFlags) { }

			internal static bool SteamAPI_ISteamFriends_GetFriendGamePlayed(IntPtr ISteamFriends, ulong steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

			internal static int SteamAPI_ISteamFriends_GetFriendMessage(IntPtr ISteamFriends, ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetFriendPersonaName(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static PersonaState SteamAPI_ISteamFriends_GetFriendPersonaState(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static FriendRelationship SteamAPI_ISteamFriends_GetFriendRelationship(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetLargeFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetMediumFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetPersonaName(IntPtr ISteamFriends) { }

			internal static int SteamAPI_ISteamFriends_GetSmallFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static void SteamAPI_ISteamFriends_RequestFriendRichPresence(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static bool SteamAPI_ISteamFriends_RequestUserInformation(IntPtr ISteamFriends, ulong steamIDUser, bool bRequireNameOnly) { }

			internal static bool SteamAPI_ISteamFriends_SetRichPresence(IntPtr ISteamFriends, string pchKey, string pchValue) { }

			internal static void SteamAPI_ISteamHTMLSurface_AllowStartRequest(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bAllowed) { }

			internal static SteamAPICall_t SteamAPI_ISteamHTMLSurface_CreateBrowser(IntPtr ISteamHTMLSurface, string pchUserAgent, string pchUserCSS) { }

			internal static void SteamAPI_ISteamHTMLSurface_ExecuteJavascript(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchScript) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Init(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyChar(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_LoadURL(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchURL, string pchPostData) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseMove(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int x, int y) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseWheel(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int nDelta) { }

			internal static void SteamAPI_ISteamHTMLSurface_Reload(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_RemoveBrowser(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetKeyFocus(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bHasKeyFocus) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetSize(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint unWidth, uint unHeight) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Shutdown(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_StopLoad(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamInventory_DestroyResult(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetAllItems(IntPtr ISteamInventory, ref int pResultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionIDs(IntPtr ISteamInventory, IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionProperty(IntPtr ISteamInventory, int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetItemPrice(IntPtr ISteamInventory, int iDefinition, out ulong pPrice) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItemProperty(IntPtr ISteamInventory, int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItems(IntPtr ISteamInventory, int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

			internal static Result SteamAPI_ISteamInventory_GetResultStatus(IntPtr ISteamInventory, int resultHandle) { }

			internal static uint SteamAPI_ISteamInventory_GetResultTimestamp(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_LoadItemDefinitions(IntPtr ISteamInventory) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_RequestPrices(IntPtr ISteamInventory) { }

			internal static bool SteamAPI_ISteamInventory_SerializeResult(IntPtr ISteamInventory, int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_StartPurchase(IntPtr ISteamInventory, Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

			internal static bool SteamAPI_ISteamMatchmaking_GetFavoriteGame(IntPtr ISteamMatchmaking, int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

			internal static int SteamAPI_ISteamMatchmaking_GetFavoriteGameCount(IntPtr ISteamMatchmaking) { }

			internal static bool SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_CloseP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_IsP2PPacketAvailable(IntPtr ISteamNetworking, out uint pcubMsgSize, int nChannel) { }

			internal static bool SteamAPI_ISteamNetworking_ReadP2PPacket(IntPtr ISteamNetworking, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

			internal static void SteamAPI_ISteamUser_CancelAuthTicket(IntPtr ISteamUser, uint hAuthTicket) { }

			internal static HAuthTicket SteamAPI_ISteamUser_GetAuthSessionTicket(IntPtr ISteamUser, IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetAvailableVoice(IntPtr ISteamUser, out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static CSteamID SteamAPI_ISteamUser_GetSteamID(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUser_GetUserDataFolder(IntPtr ISteamUser, StringBuilder pchBuffer, int cubBuffer) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetVoice(IntPtr ISteamUser, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static uint SteamAPI_ISteamUser_GetVoiceOptimalSampleRate(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime(IntPtr ISteamUserStats, string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute(IntPtr ISteamUserStats, string pchName, string pchKey) { }

			internal static int SteamAPI_ISteamUserStats_GetAchievementIcon(IntPtr ISteamUserStats, string pchName) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementName(IntPtr ISteamUserStats, uint iAchievement) { }

			internal static uint SteamAPI_ISteamUserStats_GetNumAchievements(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_RequestCurrentStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_SetAchievement(IntPtr ISteamUserStats, string pchName) { }

			internal static bool SteamAPI_ISteamUserStats_SetStat(IntPtr ISteamUserStats, string pchName, int nData) { }

			internal static bool SteamAPI_ISteamUserStats_StoreStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUtils_GetAPICallResult(IntPtr ISteamUtils, ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_GetImageRGBA(IntPtr ISteamUtils, int iImage, IntPtr pubDest, int nDestBufferSize) { }

			internal static bool SteamAPI_ISteamUtils_GetImageSize(IntPtr ISteamUtils, int iImage, out uint pnWidth, out uint pnHeight) { }

			internal static bool SteamAPI_ISteamUtils_IsAPICallCompleted(IntPtr ISteamUtils, ulong hSteamAPICall, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_IsOverlayEnabled(IntPtr ISteamUtils) { }

			internal static void SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

			internal static void SteamAPI_RunCallbacks() { }

			internal static void SteamAPI_Shutdown() { }

			internal static void SteamAPI_UnregisterCallback(IntPtr pCallback) { }

			internal static void SteamGameServer_Shutdown() { }

			internal static IntPtr SteamInternal_CreateInterface(string version) { }

		}

		internal IntPtr _ptr; //Field offset: 0x10

		public override bool IsValid
		{
			 get { } //Length: 9
		}

		internal Win32(IntPtr pointer) { }

		public override void Dispose() { }

		public override bool get_IsValid() { }

		public override int ISteamApps_GetAppBuildId() { }

		public override uint ISteamApps_GetAppInstallDir(uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

		public override CSteamID ISteamApps_GetAppOwner() { }

		public override IntPtr ISteamApps_GetAvailableGameLanguages() { }

		public override bool ISteamApps_GetCurrentBetaName(StringBuilder pchName, int cchNameBufferSize) { }

		public override IntPtr ISteamApps_GetCurrentGameLanguage() { }

		public override IntPtr ISteamClient_GetISteamAppList(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamApps(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamFriends(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServer(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServerStats(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTMLSurface(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTTP(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamInventory(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmaking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmakingServers(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamNetworking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamRemoteStorage(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamScreenshots(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUGC(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUser(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUserStats(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUtils(int hSteamPipe, string pchVersion) { }

		public override CSteamID ISteamFriends_GetFriendByIndex(int iFriend, int iFriendFlags) { }

		public override int ISteamFriends_GetFriendCount(int iFriendFlags) { }

		public override bool ISteamFriends_GetFriendGamePlayed(ulong steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

		public override int ISteamFriends_GetFriendMessage(ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

		public override IntPtr ISteamFriends_GetFriendPersonaName(ulong steamIDFriend) { }

		public override PersonaState ISteamFriends_GetFriendPersonaState(ulong steamIDFriend) { }

		public override FriendRelationship ISteamFriends_GetFriendRelationship(ulong steamIDFriend) { }

		public override int ISteamFriends_GetLargeFriendAvatar(ulong steamIDFriend) { }

		public override int ISteamFriends_GetMediumFriendAvatar(ulong steamIDFriend) { }

		public override IntPtr ISteamFriends_GetPersonaName() { }

		public override int ISteamFriends_GetSmallFriendAvatar(ulong steamIDFriend) { }

		public override void ISteamFriends_RequestFriendRichPresence(ulong steamIDFriend) { }

		public override bool ISteamFriends_RequestUserInformation(ulong steamIDUser, bool bRequireNameOnly) { }

		public override bool ISteamFriends_SetRichPresence(string pchKey, string pchValue) { }

		public override void ISteamHTMLSurface_AllowStartRequest(uint unBrowserHandle, bool bAllowed) { }

		public override SteamAPICall_t ISteamHTMLSurface_CreateBrowser(string pchUserAgent, string pchUserCSS) { }

		public override void ISteamHTMLSurface_ExecuteJavascript(uint unBrowserHandle, string pchScript) { }

		public override bool ISteamHTMLSurface_Init() { }

		public override void ISteamHTMLSurface_KeyChar(uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyDown(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyUp(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_LoadURL(uint unBrowserHandle, string pchURL, string pchPostData) { }

		public override void ISteamHTMLSurface_MouseDown(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseMove(uint unBrowserHandle, int x, int y) { }

		public override void ISteamHTMLSurface_MouseUp(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseWheel(uint unBrowserHandle, int nDelta) { }

		public override void ISteamHTMLSurface_Reload(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_RemoveBrowser(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_SetKeyFocus(uint unBrowserHandle, bool bHasKeyFocus) { }

		public override void ISteamHTMLSurface_SetSize(uint unBrowserHandle, uint unWidth, uint unHeight) { }

		public override bool ISteamHTMLSurface_Shutdown() { }

		public override void ISteamHTMLSurface_StopLoad(uint unBrowserHandle) { }

		public override void ISteamInventory_DestroyResult(int resultHandle) { }

		public override bool ISteamInventory_GetAllItems(ref int pResultHandle) { }

		public override bool ISteamInventory_GetItemDefinitionIDs(IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

		public override bool ISteamInventory_GetItemDefinitionProperty(int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetItemPrice(int iDefinition, out ulong pPrice) { }

		public override bool ISteamInventory_GetResultItemProperty(int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetResultItems(int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

		public override Result ISteamInventory_GetResultStatus(int resultHandle) { }

		public override uint ISteamInventory_GetResultTimestamp(int resultHandle) { }

		public override bool ISteamInventory_LoadItemDefinitions() { }

		public override SteamAPICall_t ISteamInventory_RequestPrices() { }

		public override bool ISteamInventory_SerializeResult(int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

		public override SteamAPICall_t ISteamInventory_StartPurchase(Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

		public override bool ISteamMatchmaking_GetFavoriteGame(int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

		public override int ISteamMatchmaking_GetFavoriteGameCount() { }

		public override bool ISteamNetworking_AcceptP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_CloseP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel) { }

		public override bool ISteamNetworking_ReadP2PPacket(IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

		public override void ISteamUser_CancelAuthTicket(uint hAuthTicket) { }

		public override HAuthTicket ISteamUser_GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

		public override VoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override CSteamID ISteamUser_GetSteamID() { }

		public override bool ISteamUser_GetUserDataFolder(StringBuilder pchBuffer, int cubBuffer) { }

		public override VoiceResult ISteamUser_GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override uint ISteamUser_GetVoiceOptimalSampleRate() { }

		public override bool ISteamUserStats_GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

		public override IntPtr ISteamUserStats_GetAchievementDisplayAttribute(string pchName, string pchKey) { }

		public override int ISteamUserStats_GetAchievementIcon(string pchName) { }

		public override IntPtr ISteamUserStats_GetAchievementName(uint iAchievement) { }

		public override uint ISteamUserStats_GetNumAchievements() { }

		public override bool ISteamUserStats_RequestCurrentStats() { }

		public override bool ISteamUserStats_SetAchievement(string pchName) { }

		public override bool ISteamUserStats_SetStat(string pchName, int nData) { }

		public override bool ISteamUserStats_StoreStats() { }

		public override bool ISteamUtils_GetAPICallResult(ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

		public override bool ISteamUtils_GetImageRGBA(int iImage, IntPtr pubDest, int nDestBufferSize) { }

		public override bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

		public override bool ISteamUtils_IsAPICallCompleted(ulong hSteamAPICall, ref bool pbFailed) { }

		public override bool ISteamUtils_IsOverlayEnabled() { }

		public override HSteamPipe SteamApi_SteamAPI_GetHSteamPipe() { }

		public override HSteamUser SteamApi_SteamAPI_GetHSteamUser() { }

		public override bool SteamApi_SteamAPI_Init() { }

		public override void SteamApi_SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

		public override void SteamApi_SteamAPI_RunCallbacks() { }

		public override void SteamApi_SteamAPI_Shutdown() { }

		public override void SteamApi_SteamAPI_UnregisterCallback(IntPtr pCallback) { }

		public override void SteamApi_SteamGameServer_Shutdown() { }

		public override IntPtr SteamApi_SteamInternal_CreateInterface(string version) { }

	}

	public class Win64 : Interface, IDisposable
	{
		public static class Native
		{

			internal static HSteamPipe SteamAPI_GetHSteamPipe() { }

			internal static HSteamUser SteamAPI_GetHSteamUser() { }

			internal static bool SteamAPI_Init() { }

			internal static int SteamAPI_ISteamApps_GetAppBuildId(IntPtr ISteamApps) { }

			internal static uint SteamAPI_ISteamApps_GetAppInstallDir(IntPtr ISteamApps, uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

			internal static CSteamID SteamAPI_ISteamApps_GetAppOwner(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamApps_GetAvailableGameLanguages(IntPtr ISteamApps) { }

			internal static bool SteamAPI_ISteamApps_GetCurrentBetaName(IntPtr ISteamApps, StringBuilder pchName, int cchNameBufferSize) { }

			internal static IntPtr SteamAPI_ISteamApps_GetCurrentGameLanguage(IntPtr ISteamApps) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamAppList(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamApps(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamFriends(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServer(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamGameServerStats(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTMLSurface(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamHTTP(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamInventory(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmaking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamMatchmakingServers(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamNetworking(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamRemoteStorage(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamScreenshots(IntPtr ISteamClient, int hSteamuser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUGC(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUser(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUserStats(IntPtr ISteamClient, int hSteamUser, int hSteamPipe, string pchVersion) { }

			internal static IntPtr SteamAPI_ISteamClient_GetISteamUtils(IntPtr ISteamClient, int hSteamPipe, string pchVersion) { }

			internal static CSteamID SteamAPI_ISteamFriends_GetFriendByIndex(IntPtr ISteamFriends, int iFriend, int iFriendFlags) { }

			internal static int SteamAPI_ISteamFriends_GetFriendCount(IntPtr ISteamFriends, int iFriendFlags) { }

			internal static bool SteamAPI_ISteamFriends_GetFriendGamePlayed(IntPtr ISteamFriends, ulong steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

			internal static int SteamAPI_ISteamFriends_GetFriendMessage(IntPtr ISteamFriends, ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetFriendPersonaName(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static PersonaState SteamAPI_ISteamFriends_GetFriendPersonaState(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static FriendRelationship SteamAPI_ISteamFriends_GetFriendRelationship(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetLargeFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static int SteamAPI_ISteamFriends_GetMediumFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static IntPtr SteamAPI_ISteamFriends_GetPersonaName(IntPtr ISteamFriends) { }

			internal static int SteamAPI_ISteamFriends_GetSmallFriendAvatar(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static void SteamAPI_ISteamFriends_RequestFriendRichPresence(IntPtr ISteamFriends, ulong steamIDFriend) { }

			internal static bool SteamAPI_ISteamFriends_RequestUserInformation(IntPtr ISteamFriends, ulong steamIDUser, bool bRequireNameOnly) { }

			internal static bool SteamAPI_ISteamFriends_SetRichPresence(IntPtr ISteamFriends, string pchKey, string pchValue) { }

			internal static void SteamAPI_ISteamHTMLSurface_AllowStartRequest(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bAllowed) { }

			internal static SteamAPICall_t SteamAPI_ISteamHTMLSurface_CreateBrowser(IntPtr ISteamHTMLSurface, string pchUserAgent, string pchUserCSS) { }

			internal static void SteamAPI_ISteamHTMLSurface_ExecuteJavascript(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchScript) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Init(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyChar(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_KeyUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

			internal static void SteamAPI_ISteamHTMLSurface_LoadURL(IntPtr ISteamHTMLSurface, uint unBrowserHandle, string pchURL, string pchPostData) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseDown(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseMove(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int x, int y) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseUp(IntPtr ISteamHTMLSurface, uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

			internal static void SteamAPI_ISteamHTMLSurface_MouseWheel(IntPtr ISteamHTMLSurface, uint unBrowserHandle, int nDelta) { }

			internal static void SteamAPI_ISteamHTMLSurface_Reload(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_RemoveBrowser(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetKeyFocus(IntPtr ISteamHTMLSurface, uint unBrowserHandle, bool bHasKeyFocus) { }

			internal static void SteamAPI_ISteamHTMLSurface_SetSize(IntPtr ISteamHTMLSurface, uint unBrowserHandle, uint unWidth, uint unHeight) { }

			internal static bool SteamAPI_ISteamHTMLSurface_Shutdown(IntPtr ISteamHTMLSurface) { }

			internal static void SteamAPI_ISteamHTMLSurface_StopLoad(IntPtr ISteamHTMLSurface, uint unBrowserHandle) { }

			internal static void SteamAPI_ISteamInventory_DestroyResult(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetAllItems(IntPtr ISteamInventory, ref int pResultHandle) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionIDs(IntPtr ISteamInventory, IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

			internal static bool SteamAPI_ISteamInventory_GetItemDefinitionProperty(IntPtr ISteamInventory, int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetItemPrice(IntPtr ISteamInventory, int iDefinition, out ulong pPrice) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItemProperty(IntPtr ISteamInventory, int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

			internal static bool SteamAPI_ISteamInventory_GetResultItems(IntPtr ISteamInventory, int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

			internal static Result SteamAPI_ISteamInventory_GetResultStatus(IntPtr ISteamInventory, int resultHandle) { }

			internal static uint SteamAPI_ISteamInventory_GetResultTimestamp(IntPtr ISteamInventory, int resultHandle) { }

			internal static bool SteamAPI_ISteamInventory_LoadItemDefinitions(IntPtr ISteamInventory) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_RequestPrices(IntPtr ISteamInventory) { }

			internal static bool SteamAPI_ISteamInventory_SerializeResult(IntPtr ISteamInventory, int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

			internal static SteamAPICall_t SteamAPI_ISteamInventory_StartPurchase(IntPtr ISteamInventory, Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

			internal static bool SteamAPI_ISteamMatchmaking_GetFavoriteGame(IntPtr ISteamMatchmaking, int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

			internal static int SteamAPI_ISteamMatchmaking_GetFavoriteGameCount(IntPtr ISteamMatchmaking) { }

			internal static bool SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_CloseP2PSessionWithUser(IntPtr ISteamNetworking, ulong steamIDRemote) { }

			internal static bool SteamAPI_ISteamNetworking_IsP2PPacketAvailable(IntPtr ISteamNetworking, out uint pcubMsgSize, int nChannel) { }

			internal static bool SteamAPI_ISteamNetworking_ReadP2PPacket(IntPtr ISteamNetworking, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

			internal static void SteamAPI_ISteamUser_CancelAuthTicket(IntPtr ISteamUser, uint hAuthTicket) { }

			internal static HAuthTicket SteamAPI_ISteamUser_GetAuthSessionTicket(IntPtr ISteamUser, IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetAvailableVoice(IntPtr ISteamUser, out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static CSteamID SteamAPI_ISteamUser_GetSteamID(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUser_GetUserDataFolder(IntPtr ISteamUser, StringBuilder pchBuffer, int cubBuffer) { }

			internal static VoiceResult SteamAPI_ISteamUser_GetVoice(IntPtr ISteamUser, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

			internal static uint SteamAPI_ISteamUser_GetVoiceOptimalSampleRate(IntPtr ISteamUser) { }

			internal static bool SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime(IntPtr ISteamUserStats, string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute(IntPtr ISteamUserStats, string pchName, string pchKey) { }

			internal static int SteamAPI_ISteamUserStats_GetAchievementIcon(IntPtr ISteamUserStats, string pchName) { }

			internal static IntPtr SteamAPI_ISteamUserStats_GetAchievementName(IntPtr ISteamUserStats, uint iAchievement) { }

			internal static uint SteamAPI_ISteamUserStats_GetNumAchievements(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_RequestCurrentStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUserStats_SetAchievement(IntPtr ISteamUserStats, string pchName) { }

			internal static bool SteamAPI_ISteamUserStats_SetStat(IntPtr ISteamUserStats, string pchName, int nData) { }

			internal static bool SteamAPI_ISteamUserStats_StoreStats(IntPtr ISteamUserStats) { }

			internal static bool SteamAPI_ISteamUtils_GetAPICallResult(IntPtr ISteamUtils, ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_GetImageRGBA(IntPtr ISteamUtils, int iImage, IntPtr pubDest, int nDestBufferSize) { }

			internal static bool SteamAPI_ISteamUtils_GetImageSize(IntPtr ISteamUtils, int iImage, out uint pnWidth, out uint pnHeight) { }

			internal static bool SteamAPI_ISteamUtils_IsAPICallCompleted(IntPtr ISteamUtils, ulong hSteamAPICall, ref bool pbFailed) { }

			internal static bool SteamAPI_ISteamUtils_IsOverlayEnabled(IntPtr ISteamUtils) { }

			internal static void SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

			internal static void SteamAPI_RunCallbacks() { }

			internal static void SteamAPI_Shutdown() { }

			internal static void SteamAPI_UnregisterCallback(IntPtr pCallback) { }

			internal static void SteamGameServer_Shutdown() { }

			internal static IntPtr SteamInternal_CreateInterface(string version) { }

		}

		internal IntPtr _ptr; //Field offset: 0x10

		public override bool IsValid
		{
			 get { } //Length: 9
		}

		internal Win64(IntPtr pointer) { }

		public override void Dispose() { }

		public override bool get_IsValid() { }

		public override int ISteamApps_GetAppBuildId() { }

		public override uint ISteamApps_GetAppInstallDir(uint appID, StringBuilder pchFolder, uint cchFolderBufferSize) { }

		public override CSteamID ISteamApps_GetAppOwner() { }

		public override IntPtr ISteamApps_GetAvailableGameLanguages() { }

		public override bool ISteamApps_GetCurrentBetaName(StringBuilder pchName, int cchNameBufferSize) { }

		public override IntPtr ISteamApps_GetCurrentGameLanguage() { }

		public override IntPtr ISteamClient_GetISteamAppList(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamApps(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamFriends(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServer(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamGameServerStats(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTMLSurface(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamHTTP(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamInventory(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmaking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamMatchmakingServers(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamNetworking(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamRemoteStorage(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamScreenshots(int hSteamuser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUGC(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUser(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUserStats(int hSteamUser, int hSteamPipe, string pchVersion) { }

		public override IntPtr ISteamClient_GetISteamUtils(int hSteamPipe, string pchVersion) { }

		public override CSteamID ISteamFriends_GetFriendByIndex(int iFriend, int iFriendFlags) { }

		public override int ISteamFriends_GetFriendCount(int iFriendFlags) { }

		public override bool ISteamFriends_GetFriendGamePlayed(ulong steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

		public override int ISteamFriends_GetFriendMessage(ulong steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out ChatEntryType peChatEntryType) { }

		public override IntPtr ISteamFriends_GetFriendPersonaName(ulong steamIDFriend) { }

		public override PersonaState ISteamFriends_GetFriendPersonaState(ulong steamIDFriend) { }

		public override FriendRelationship ISteamFriends_GetFriendRelationship(ulong steamIDFriend) { }

		public override int ISteamFriends_GetLargeFriendAvatar(ulong steamIDFriend) { }

		public override int ISteamFriends_GetMediumFriendAvatar(ulong steamIDFriend) { }

		public override IntPtr ISteamFriends_GetPersonaName() { }

		public override int ISteamFriends_GetSmallFriendAvatar(ulong steamIDFriend) { }

		public override void ISteamFriends_RequestFriendRichPresence(ulong steamIDFriend) { }

		public override bool ISteamFriends_RequestUserInformation(ulong steamIDUser, bool bRequireNameOnly) { }

		public override bool ISteamFriends_SetRichPresence(string pchKey, string pchValue) { }

		public override void ISteamHTMLSurface_AllowStartRequest(uint unBrowserHandle, bool bAllowed) { }

		public override SteamAPICall_t ISteamHTMLSurface_CreateBrowser(string pchUserAgent, string pchUserCSS) { }

		public override void ISteamHTMLSurface_ExecuteJavascript(uint unBrowserHandle, string pchScript) { }

		public override bool ISteamHTMLSurface_Init() { }

		public override void ISteamHTMLSurface_KeyChar(uint unBrowserHandle, uint cUnicodeChar, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyDown(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_KeyUp(uint unBrowserHandle, uint nNativeKeyCode, HTMLKeyModifiers eHTMLKeyModifiers) { }

		public override void ISteamHTMLSurface_LoadURL(uint unBrowserHandle, string pchURL, string pchPostData) { }

		public override void ISteamHTMLSurface_MouseDown(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseMove(uint unBrowserHandle, int x, int y) { }

		public override void ISteamHTMLSurface_MouseUp(uint unBrowserHandle, HTMLMouseButton eMouseButton) { }

		public override void ISteamHTMLSurface_MouseWheel(uint unBrowserHandle, int nDelta) { }

		public override void ISteamHTMLSurface_Reload(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_RemoveBrowser(uint unBrowserHandle) { }

		public override void ISteamHTMLSurface_SetKeyFocus(uint unBrowserHandle, bool bHasKeyFocus) { }

		public override void ISteamHTMLSurface_SetSize(uint unBrowserHandle, uint unWidth, uint unHeight) { }

		public override bool ISteamHTMLSurface_Shutdown() { }

		public override void ISteamHTMLSurface_StopLoad(uint unBrowserHandle) { }

		public override void ISteamInventory_DestroyResult(int resultHandle) { }

		public override bool ISteamInventory_GetAllItems(ref int pResultHandle) { }

		public override bool ISteamInventory_GetItemDefinitionIDs(IntPtr pItemDefIDs, out uint punItemDefIDsArraySize) { }

		public override bool ISteamInventory_GetItemDefinitionProperty(int iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetItemPrice(int iDefinition, out ulong pPrice) { }

		public override bool ISteamInventory_GetResultItemProperty(int resultHandle, uint unItemIndex, string pchPropertyName, StringBuilder pchValueBuffer, out uint punValueBufferSizeOut) { }

		public override bool ISteamInventory_GetResultItems(int resultHandle, IntPtr pOutItemsArray, out uint punOutItemsArraySize) { }

		public override Result ISteamInventory_GetResultStatus(int resultHandle) { }

		public override uint ISteamInventory_GetResultTimestamp(int resultHandle) { }

		public override bool ISteamInventory_LoadItemDefinitions() { }

		public override SteamAPICall_t ISteamInventory_RequestPrices() { }

		public override bool ISteamInventory_SerializeResult(int resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

		public override SteamAPICall_t ISteamInventory_StartPurchase(Int32[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

		public override bool ISteamMatchmaking_GetFavoriteGame(int iGame, ref uint pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

		public override int ISteamMatchmaking_GetFavoriteGameCount() { }

		public override bool ISteamNetworking_AcceptP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_CloseP2PSessionWithUser(ulong steamIDRemote) { }

		public override bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel) { }

		public override bool ISteamNetworking_ReadP2PPacket(IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote, int nChannel) { }

		public override void ISteamUser_CancelAuthTicket(uint hAuthTicket) { }

		public override HAuthTicket ISteamUser_GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

		public override VoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override CSteamID ISteamUser_GetSteamID() { }

		public override bool ISteamUser_GetUserDataFolder(StringBuilder pchBuffer, int cubBuffer) { }

		public override VoiceResult ISteamUser_GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

		public override uint ISteamUser_GetVoiceOptimalSampleRate() { }

		public override bool ISteamUserStats_GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

		public override IntPtr ISteamUserStats_GetAchievementDisplayAttribute(string pchName, string pchKey) { }

		public override int ISteamUserStats_GetAchievementIcon(string pchName) { }

		public override IntPtr ISteamUserStats_GetAchievementName(uint iAchievement) { }

		public override uint ISteamUserStats_GetNumAchievements() { }

		public override bool ISteamUserStats_RequestCurrentStats() { }

		public override bool ISteamUserStats_SetAchievement(string pchName) { }

		public override bool ISteamUserStats_SetStat(string pchName, int nData) { }

		public override bool ISteamUserStats_StoreStats() { }

		public override bool ISteamUtils_GetAPICallResult(ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

		public override bool ISteamUtils_GetImageRGBA(int iImage, IntPtr pubDest, int nDestBufferSize) { }

		public override bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

		public override bool ISteamUtils_IsAPICallCompleted(ulong hSteamAPICall, ref bool pbFailed) { }

		public override bool ISteamUtils_IsOverlayEnabled() { }

		public override HSteamPipe SteamApi_SteamAPI_GetHSteamPipe() { }

		public override HSteamUser SteamApi_SteamAPI_GetHSteamUser() { }

		public override bool SteamApi_SteamAPI_Init() { }

		public override void SteamApi_SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

		public override void SteamApi_SteamAPI_RunCallbacks() { }

		public override void SteamApi_SteamAPI_Shutdown() { }

		public override void SteamApi_SteamAPI_UnregisterCallback(IntPtr pCallback) { }

		public override void SteamApi_SteamGameServer_Shutdown() { }

		public override IntPtr SteamApi_SteamInternal_CreateInterface(string version) { }

	}

	private static OperatingSystem _os; //Field offset: 0x0
	private static Architecture _arch; //Field offset: 0x4

	internal static Architecture Arch
	{
		internal get { } //Length: 224
		internal set { } //Length: 59
	}

	public static bool IsLinux32
	{
		 get { } //Length: 101
	}

	public static bool IsLinux64
	{
		 get { } //Length: 101
	}

	public static bool IsOsx
	{
		 get { } //Length: 82
	}

	public static bool IsWindows
	{
		 get { } //Length: 82
	}

	public static bool IsWindows32
	{
		 get { } //Length: 101
	}

	public static bool IsWindows64
	{
		 get { } //Length: 101
	}

	internal static OperatingSystem Os
	{
		internal get { } //Length: 85
		internal set { } //Length: 58
	}

	public static bool PackSmall
	{
		 get { } //Length: 82
	}

	internal static Architecture get_Arch() { }

	public static bool get_IsLinux32() { }

	public static bool get_IsLinux64() { }

	public static bool get_IsOsx() { }

	public static bool get_IsWindows() { }

	public static bool get_IsWindows32() { }

	public static bool get_IsWindows64() { }

	internal static OperatingSystem get_Os() { }

	public static bool get_PackSmall() { }

	internal static void set_Arch(Architecture value) { }

	internal static void set_Os(OperatingSystem value) { }

}

