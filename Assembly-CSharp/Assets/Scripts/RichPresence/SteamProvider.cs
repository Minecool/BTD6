namespace Assets.Scripts.RichPresence;

public class SteamProvider : IRichPresence
{
	private const string kSteamDisplay = "steam_display"; //Field offset: 0x0
	private const string kPlayType = "playtype"; //Field offset: 0x0
	private const string kBrowsedMenu = "browsedmenu"; //Field offset: 0x0
	private const string kStatusPlaying = "#Status_Playing"; //Field offset: 0x0
	private const string kStatusBrowsing = "#Status_Browsing"; //Field offset: 0x0

	private User SteamUser
	{
		private get { } //Length: 141
	}

	public SteamProvider() { }

	private User get_SteamUser() { }

	public override void Initialize() { }

	public override void Refresh() { }

	public override void SetBrowsing(RichPresenceBrowsing browsingType) { }

	private void SetBrowsing(string message) { }

	public override void SetCoopLobby(string id, bool isBoss) { }

	public override void SetCreating(ContentType contentType) { }

	public override void SetPlaying(RichPresencePlaying playingType, Nullable<RichPresenceDifficulty> difficultyType, string mapId, string challengeCode) { }

	private void SetPlaying(string message) { }

	public override void SetPlayingBoss(BossType bossType, bool isElite, bool isCoop, Nullable<Byte> numPlayers) { }

	public override void SetPlayingBossRush(BossType bossType, int stage) { }

	public override void SetPlayingCt(string tileCode, CtTileType ctTileType) { }

}

