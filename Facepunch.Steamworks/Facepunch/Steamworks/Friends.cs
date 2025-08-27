namespace Facepunch.Steamworks;

public class Friends
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public ulong steamid; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <Get>b__0(SteamFriend x) { }

	}

	internal enum AvatarSize
	{
		Small = 0,
		Medium = 1,
		Large = 2,
	}

	internal sealed class ChatMessageDelegate : MulticastDelegate
	{

		public ChatMessageDelegate(object object, IntPtr method) { }

		public override void Invoke(SteamFriend friend, string type, string message) { }

	}

	internal sealed class JoinRequestedDelegate : MulticastDelegate
	{

		public JoinRequestedDelegate(object object, IntPtr method) { }

		public override void Invoke(SteamFriend friend, string connect) { }

	}

	private class PersonaCallback
	{
		public ulong SteamId; //Field offset: 0x10
		public AvatarSize Size; //Field offset: 0x18
		public Action<Image> Callback; //Field offset: 0x20
		public DateTime Time; //Field offset: 0x28

		public PersonaCallback() { }

	}

	internal Client client; //Field offset: 0x10
	private Byte[] buffer; //Field offset: 0x18
	[CompilerGenerated]
	private ChatMessageDelegate OnChatMessage; //Field offset: 0x20
	private bool _listenForFriendsMessages; //Field offset: 0x28
	[CompilerGenerated]
	private JoinRequestedDelegate OnInvitedToGame; //Field offset: 0x30
	private List<SteamFriend> _allFriends; //Field offset: 0x38
	private List<PersonaCallback> PersonaCallbacks; //Field offset: 0x40

	public IEnumerable<SteamFriend> All
	{
		 get { } //Length: 120
	}

	internal Friends(Client c) { }

	internal void Cycle() { }

	public SteamFriend Get(ulong steamid) { }

	public IEnumerable<SteamFriend> get_All() { }

	public void GetAvatar(AvatarSize size, ulong steamid, Action<Image> callback) { }

	public Image GetCachedAvatar(AvatarSize size, ulong steamid) { }

	public string GetName(ulong steamid) { }

	private void LoadAvatarForSteamId(ulong Steamid) { }

	private void OnAvatarImageLoaded(AvatarImageLoaded_t data) { }

	private void OnFriendChatMessage(GameConnectedFriendChatMsg_t data) { }

	private void OnGameJoinRequested(GameRichPresenceJoinRequested_t data) { }

	private void OnPersonaStateChange(PersonaStateChange_t data) { }

	public void Refresh() { }

}

