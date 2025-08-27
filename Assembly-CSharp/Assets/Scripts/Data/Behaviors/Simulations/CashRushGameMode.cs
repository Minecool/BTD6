namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewCashRushGameMode", menuName = "BTD6/Behaviors/Simulations/CashRushGameMode")]
public class CashRushGameMode : SimulationBehavior
{
	public int cashGoal; //Field offset: 0x30

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 86
	}

	public CashRushGameMode() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

