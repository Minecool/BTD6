namespace Assets.Scripts.Unity.SimulationBehaviors;

public class FastUpgradesGameMode : SimulationBehavior
{
	public int maxTier; //Field offset: 0x18
	public FastUpgradesType fastUpgradesModeType; //Field offset: 0x1C

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 102
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public FastUpgradesGameMode() { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

