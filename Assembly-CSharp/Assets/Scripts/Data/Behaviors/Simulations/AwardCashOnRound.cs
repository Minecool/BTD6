namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewAwardCashOnRound", menuName = "BTD6/Behaviors/Simulations/AwardCashOnRound")]
public class AwardCashOnRound : SimulationBehavior
{
	public int round; //Field offset: 0x30
	public int cashAmount; //Field offset: 0x34

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 102
	}

	public AwardCashOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

