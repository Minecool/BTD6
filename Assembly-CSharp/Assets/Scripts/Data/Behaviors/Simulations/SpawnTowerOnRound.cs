namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewSpawnTowerOnRound", menuName = "BTD6/Behaviors/Simulations/SpawnTowerOnRound")]
public class SpawnTowerOnRound : SimulationBehavior
{
	public string triggerId; //Field offset: 0x30
	public String[] prePlaceTowerIndexs; //Field offset: 0x38
	public Int32[] round; //Field offset: 0x40

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public SpawnTowerOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

