namespace Assets.Scripts.RichPresence;

public static class RichPresenceStatus
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public RichPresencePlaying playingType; //Field offset: 0x10
		public Nullable<RichPresenceDifficulty> subtitleType; //Field offset: 0x14
		public string mapId; //Field offset: 0x20
		public string challengeCode; //Field offset: 0x28

		public <>c__DisplayClass2_0() { }

		internal void <SetPlaying>b__0(IRichPresence rpp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public RichPresenceBrowsing browsingType; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal void <SetBrowsing>b__0(IRichPresence rpp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ContentType contentType; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal void <SetCreating>b__0(IRichPresence rpp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string id; //Field offset: 0x10
		public bool isBoss; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <SetCoopLobby>b__0(IRichPresence rpp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public BossType bossType; //Field offset: 0x10
		public bool isElite; //Field offset: 0x14
		public bool isCoop; //Field offset: 0x15
		public Nullable<Byte> numPlayers; //Field offset: 0x16

		public <>c__DisplayClass6_0() { }

		internal void <SetPlayingBoss>b__0(IRichPresence rpp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string tileCode; //Field offset: 0x10
		public CtTileType ctTileType; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <SetPlayingCt>b__0(IRichPresence rpp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public BossType bossType; //Field offset: 0x10
		public int stage; //Field offset: 0x14

		public <>c__DisplayClass8_0() { }

		internal void <SetPlayingBossRush>b__0(IRichPresence rpp) { }

	}


	private static bool IsRichPresenceEnabled
	{
		private get { } //Length: 159
	}

	private static bool get_IsRichPresenceEnabled() { }

	[Conditional("DEBUG_RICH_PRESENCE")]
	private static void Log(string message) { }

	public static void SetBrowsing(RichPresenceBrowsing browsingType) { }

	public static void SetCoopLobby(string id, bool isBoss) { }

	public static void SetCreating(ContentType contentType) { }

	public static void SetPlaying(RichPresencePlaying playingType, Nullable<RichPresenceDifficulty> subtitleType, string mapId, string challengeCode = null) { }

	public static void SetPlayingBoss(BossType bossType, bool isElite, bool isCoop, Nullable<Byte> numPlayers) { }

	public static void SetPlayingBossRush(BossType bossType, int stage) { }

	public static void SetPlayingCt(string tileCode, CtTileType ctTileType) { }

}

