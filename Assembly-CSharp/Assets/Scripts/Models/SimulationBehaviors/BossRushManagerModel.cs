namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(BossRushManager), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BossRushManagerModel : RushChallengeManagerModel
{
	public int bossCashReward; //Field offset: 0x58
	public float bossCashRewardMultiplier; //Field offset: 0x5C
	public int maxCashScalingLevel; //Field offset: 0x60
	public int milestoneTierFrequency; //Field offset: 0x64
	public BloonBehaviorModel[] rushBehaviors; //Field offset: 0x68
	public bool dontReplaceOnMilestone; //Field offset: 0x70
	public bool useTrackLengthBasedBossSpeed; //Field offset: 0x71
	public float mapLengthSpeedMultiplier; //Field offset: 0x74
	public int baseBossHealth; //Field offset: 0x78
	public int baseBossShield; //Field offset: 0x7C
	public Nullable<Int32> maxKills; //Field offset: 0x80

	public BossRushManagerModel(string targetBloonName, float badSpeedMutliplier, float badScaleMutliplier, float badHealthMutliplier, int numAllowedLeaks, int numRoundsBeforeSpawningTarget, int bossCashReward, float bossCashRewardMultiplier, int maxCashScalingLevel, int milestoneTierFrequency, BloonBehaviorModel[] rushBehaviors, bool dontReplaceOnMilestone, bool useTrackLengthBasedBossSpeed, float mapLengthSpeedMultiplier, int baseBossHealth, int baseBossShield, Nullable<Int32> maxKills) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

