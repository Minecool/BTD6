namespace Assets.Scripts.Unity.SimulationBehaviors;

public class UpgradeTowerOnRound : SimulationBehavior
{
	public UpgradeTowerOnRoundData[] upgradeOnRoundData; //Field offset: 0x18

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public virtual string Type
	{
		 get { } //Length: 155
	}

	public UpgradeTowerOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

