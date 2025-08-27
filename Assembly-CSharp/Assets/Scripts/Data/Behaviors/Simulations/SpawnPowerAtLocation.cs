namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewAwardCashOnRound", menuName = "BTD6/Behaviors/Simulations/AwardCashOnRound")]
public class SpawnPowerAtLocation : SimulationBehavior
{
	public EnableOptions enableOptions; //Field offset: 0x30
	public Vector2 location; //Field offset: 0x48
	public string powerId; //Field offset: 0x50

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 193
	}

	public SpawnPowerAtLocation() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

