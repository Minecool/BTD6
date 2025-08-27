namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewRemovePropsOnRound", menuName = "BTD6/Behaviors/Simulations/RemovePropsOnRound")]
public class RemovePropsOnRound : SimulationBehavior
{
	public int round; //Field offset: 0x30
	public string propIndexs; //Field offset: 0x38
	public bool disableRemoveableEffects; //Field offset: 0x40

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 156
	}

	public RemovePropsOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

