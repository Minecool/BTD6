namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewBossRushManager", menuName = "BTD6/Behaviors/Simulations/BossRushManager")]
public class BossRushManager : SimulationBehavior
{
	public int baseHealth; //Field offset: 0x30
	public int baseShield; //Field offset: 0x34
	public float healthMultiplier; //Field offset: 0x38
	public float speedMultiplier; //Field offset: 0x3C
	public string targetBloonName; //Field offset: 0x40
	public int numAllowedLeaks; //Field offset: 0x48
	public int numRoundsBeforeSpawningTarget; //Field offset: 0x4C
	public int milestoneRoundFrequency; //Field offset: 0x50
	public int cashReward; //Field offset: 0x54
	public float cashRewardMultiplier; //Field offset: 0x58
	public int maxCashScalingLevel; //Field offset: 0x5C
	public bool dontReplaceOnMilestone; //Field offset: 0x60
	public bool useTrackLengthBasedBossSpeed; //Field offset: 0x61
	public BloonBehavior[] behaviorModels; //Field offset: 0x68
	public float mapLengthSpeedMultiplier; //Field offset: 0x70
	public Nullable<Int32> maxKills; //Field offset: 0x74

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 409
	}

	public BossRushManager() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

