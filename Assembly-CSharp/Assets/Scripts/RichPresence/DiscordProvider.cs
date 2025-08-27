namespace Assets.Scripts.RichPresence;

public class DiscordProvider : IRichPresence
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UpdateActivityHandler <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SendActivity>b__21_0(Result result) { }

	}

	[CompilerGenerated]
	private static Discord <Client>k__BackingField; //Field offset: 0x0
	private DiscordUpdate update; //Field offset: 0x10

	public private static Discord Client
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	private bool IsInitialized
	{
		private get { } //Length: 58
	}

	private bool IsRichPresenceEnabled
	{
		private get { } //Length: 159
	}

	public DiscordProvider() { }

	private void Destroy() { }

	[CompilerGenerated]
	public static Discord get_Client() { }

	private bool get_IsInitialized() { }

	private bool get_IsRichPresenceEnabled() { }

	private Activity GetActivity(string message, string subtitle, string smallIcon) { }

	private string GetBossIcon(bool isElite, bool isCoop) { }

	private string GetSmallIcon(RichPresencePlaying playingType, Nullable<RichPresenceDifficulty> difficultyType) { }

	public override void Initialize() { }

	public override void Refresh() { }

	private void SendActivity(Activity activity) { }

	private void SendActivity(string message) { }

	[CompilerGenerated]
	private static void set_Client(Discord value) { }

	public override void SetBrowsing(RichPresenceBrowsing browsingType) { }

	public override void SetCoopLobby(string id, bool isBoss) { }

	public override void SetCreating(ContentType contentType) { }

	public override void SetPlaying(RichPresencePlaying playingType, Nullable<RichPresenceDifficulty> difficultyType, string mapId, string challengeCode) { }

	public override void SetPlayingBoss(BossType bossType, bool isElite, bool isCoop, Nullable<Byte> numPlayers) { }

	public override void SetPlayingBossRush(BossType bossType, int stage) { }

	public override void SetPlayingCt(string tileCode, CtTileType ctTileType) { }

}

