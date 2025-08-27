namespace Facepunch.Steamworks;

public class Client : BaseSteamworks, IDisposable
{
	[CompilerGenerated]
	private static Client <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private string <Username>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private ulong <SteamId>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private ulong <OwnerSteamId>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private string <BetaName>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private int <BuildId>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private DirectoryInfo <InstallFolder>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly string <CurrentLanguage>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly String[] <AvailableLanguages>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private Voice <Voice>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private ServerList <ServerList>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private LobbyList <LobbyList>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private App <App>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private Achievements <Achievements>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private Stats <Stats>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private MicroTransactions <MicroTransactions>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private User <User>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private RemoteStorage <RemoteStorage>k__BackingField; //Field offset: 0xE8
	private Auth _auth; //Field offset: 0xF0
	private Friends _friends; //Field offset: 0xF8
	private HtmlSurface _htmlSurface; //Field offset: 0x100
	private Lobby _lobby; //Field offset: 0x108
	private Overlay _overlay; //Field offset: 0x110
	private Screenshots _screenshots; //Field offset: 0x118

	public private Achievements Achievements
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private App App
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Auth Auth
	{
		 get { } //Length: 116
	}

	private string BetaName
	{
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private int BuildId
	{
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Friends Friends
	{
		 get { } //Length: 115
	}

	public HtmlSurface HtmlSurface
	{
		 get { } //Length: 115
	}

	private DirectoryInfo InstallFolder
	{
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private static Client Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	public private LobbyList LobbyList
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private MicroTransactions MicroTransactions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Overlay Overlay
	{
		 get { } //Length: 116
	}

	private ulong OwnerSteamId
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private RemoteStorage RemoteStorage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ServerList ServerList
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Stats Stats
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ulong SteamId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private User User
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private string Username
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Voice Voice
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Client(uint appId) { }

	public virtual void Dispose() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public Achievements get_Achievements() { }

	[CompilerGenerated]
	public App get_App() { }

	public Auth get_Auth() { }

	public Friends get_Friends() { }

	public HtmlSurface get_HtmlSurface() { }

	[CompilerGenerated]
	public static Client get_Instance() { }

	[CompilerGenerated]
	public LobbyList get_LobbyList() { }

	[CompilerGenerated]
	public MicroTransactions get_MicroTransactions() { }

	public Overlay get_Overlay() { }

	[CompilerGenerated]
	public RemoteStorage get_RemoteStorage() { }

	[CompilerGenerated]
	public ServerList get_ServerList() { }

	[CompilerGenerated]
	public Stats get_Stats() { }

	[CompilerGenerated]
	public ulong get_SteamId() { }

	[CompilerGenerated]
	public User get_User() { }

	[CompilerGenerated]
	public Voice get_Voice() { }

	public void RunCallbacks() { }

	[CompilerGenerated]
	private void set_Achievements(Achievements value) { }

	[CompilerGenerated]
	private void set_App(App value) { }

	[CompilerGenerated]
	private void set_BetaName(string value) { }

	[CompilerGenerated]
	private void set_BuildId(int value) { }

	[CompilerGenerated]
	private void set_InstallFolder(DirectoryInfo value) { }

	[CompilerGenerated]
	private static void set_Instance(Client value) { }

	[CompilerGenerated]
	private void set_LobbyList(LobbyList value) { }

	[CompilerGenerated]
	private void set_MicroTransactions(MicroTransactions value) { }

	[CompilerGenerated]
	private void set_OwnerSteamId(ulong value) { }

	[CompilerGenerated]
	private void set_RemoteStorage(RemoteStorage value) { }

	[CompilerGenerated]
	private void set_ServerList(ServerList value) { }

	[CompilerGenerated]
	private void set_Stats(Stats value) { }

	[CompilerGenerated]
	private void set_SteamId(ulong value) { }

	[CompilerGenerated]
	private void set_User(User value) { }

	[CompilerGenerated]
	private void set_Username(string value) { }

	[CompilerGenerated]
	private void set_Voice(Voice value) { }

	public virtual void Update() { }

}

