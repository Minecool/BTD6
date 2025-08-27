namespace Assets.Scripts.Unity.UI_New.InGame;

public class BossRushGameData
{
	public readonly BossType bossType; //Field offset: 0x10
	public readonly int tileIndex; //Field offset: 0x14
	public readonly BossRushEvent bossRushEvent; //Field offset: 0x18
	public readonly float mapLengthSpeedMultiplier; //Field offset: 0x20
	public readonly int cashReward; //Field offset: 0x24
	public readonly float cashRewardMultiplier; //Field offset: 0x28
	public readonly int maxCashScalingLevel; //Field offset: 0x2C
	public readonly int bossBaseHealth; //Field offset: 0x30
	public readonly float bossHealthMultiplier; //Field offset: 0x34
	public readonly float bossSpeedMultiplier; //Field offset: 0x38
	public readonly int baseBossShield; //Field offset: 0x3C
	public readonly Nullable<Int32> maxKills; //Field offset: 0x40
	public Nullable<UInt64> latestTeamScoreId; //Field offset: 0x48
	public int hpLeft; //Field offset: 0x58
	public String[] bannedHeros; //Field offset: 0x60
	public readonly bool isReplay; //Field offset: 0x68

	public BossRushGameData(BossType bossType, int tileIndex, BossRushEvent bossRushEvent, float mapLengthSpeedMultiplier, int cashReward, float cashRewardMultiplier, int maxCashScalingLevel, int bossBaseHealth, float bossHealthMultiplier, float bossSpeedMultiplier, int baseBossShield, Nullable<Int32> maxKills, bool isReplay, Nullable<UInt64> latestTeamScoreId, int hpLeft, String[] bannedHeros) { }

	public BossRushGameData Clone() { }

}

