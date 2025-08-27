namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewFastUpgradesGameMode", menuName = "BTD6/Behaviors/Simulations/FastUpgradesGameMode")]
public class FastUpgradesGameMode : SimulationBehavior
{
	public int maxTier; //Field offset: 0x30
	public FastUpgradesType fastUpgradesModeType; //Field offset: 0x34

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 102
	}

	public FastUpgradesGameMode() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

