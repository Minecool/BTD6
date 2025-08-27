namespace Assets.Scripts.Unity.SimulationBehaviors;

public class UpgradeTowerOnRound : SimulationBehavior
{
	public UpgradeTowerOnRoundData[] upgradeOnRoundData; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 88
	}

	public virtual string Type
	{
		 get { } //Length: 79
	}

	public UpgradeTowerOnRound() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

