namespace Assets.Scripts.Unity.SimulationBehaviors;

public class BossRushManager : SimulationBehavior
{
	public int baseHealth; //Field offset: 0x18
	public int baseShield; //Field offset: 0x1C
	public float healthMultiplier; //Field offset: 0x20
	public float speedMultiplier; //Field offset: 0x24
	public string targetBloonName; //Field offset: 0x28
	public int numAllowedLeaks; //Field offset: 0x30
	public int numRoundsBeforeSpawningTarget; //Field offset: 0x34
	public int milestoneRoundFrequency; //Field offset: 0x38
	public int cashReward; //Field offset: 0x3C
	public float cashRewardMultiplier; //Field offset: 0x40
	public int maxCashScalingLevel; //Field offset: 0x44
	public bool dontReplaceOnMilestone; //Field offset: 0x48
	public bool useTrackLengthBasedBossSpeed; //Field offset: 0x49
	[SerializeReference]
	public BloonBehaviorModel[] behaviorModels; //Field offset: 0x50

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 392
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public BossRushManager() { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

