namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewUpgradeTowerOnRound", menuName = "BTD6/Behaviors/Simulations/UpgradeTowerOnRound")]
public class UpgradeTowerOnRound : SimulationBehavior
{
	public UpgradeTowerOnRoundData[] upgradeOnRoundData; //Field offset: 0x30

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public UpgradeTowerOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

