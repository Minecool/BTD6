namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewSpawnPropOnRoundOrTrigger", menuName = "BTD6/Behaviors/Simulations/SpawnPropOnRoundOrTrigger")]
public class SpawnPropOnRoundOrTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x30
	public String[] prePlacePropIndexs; //Field offset: 0x38
	public Int32[] round; //Field offset: 0x40

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public SpawnPropOnRoundOrTrigger() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

