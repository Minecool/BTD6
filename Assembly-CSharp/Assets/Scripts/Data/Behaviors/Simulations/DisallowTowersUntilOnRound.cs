namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewDisallowTowersUntilOnRound", menuName = "BTD6/Behaviors/Simulations/DisallowTowersUntilOnRound")]
public class DisallowTowersUntilOnRound : SimulationBehavior
{
	public int round; //Field offset: 0x30
	public bool disallowTowerPurchasing; //Field offset: 0x34
	public bool disallowHeroPurchasing; //Field offset: 0x35

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public DisallowTowersUntilOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

