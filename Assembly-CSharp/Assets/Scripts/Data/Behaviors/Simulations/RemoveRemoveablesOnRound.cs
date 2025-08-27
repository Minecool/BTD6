namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewRemoveRemoveablesOnRound", menuName = "BTD6/Behaviors/Simulations/RemoveRemoveablesOnRound")]
public class RemoveRemoveablesOnRound : SimulationBehavior
{
	public int round; //Field offset: 0x30
	public string removeableNames; //Field offset: 0x38
	public bool disableRemoveableEffects; //Field offset: 0x40

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 156
	}

	public RemoveRemoveablesOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

