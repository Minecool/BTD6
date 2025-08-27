namespace Assets.Scripts.RichPresence;

public interface IRichPresence
{

	public void Initialize() { }

	public void Refresh() { }

	public void SetBrowsing(RichPresenceBrowsing browsingType) { }

	public void SetCoopLobby(string id, bool isBoss) { }

	public void SetCreating(ContentType contentType) { }

	public void SetPlaying(RichPresencePlaying playingType, Nullable<RichPresenceDifficulty> difficultyType, string mapId, string challengeCode) { }

	public void SetPlayingBoss(BossType bossType, bool isElite, bool isCoop, Nullable<Byte> numPlayers) { }

	public void SetPlayingBossRush(BossType bossType, int stage) { }

	public void SetPlayingCt(string tileCode, CtTileType ctTileType) { }

}

