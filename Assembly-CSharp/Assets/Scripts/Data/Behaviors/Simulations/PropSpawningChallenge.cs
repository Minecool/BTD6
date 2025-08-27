namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewPropSpawningChallenge", menuName = "BTD6/Behaviors/Simulations/PropSpawningChallenge")]
public class PropSpawningChallenge : SimulationBehavior
{
	public List<Int32> propGroupLayerIds; //Field offset: 0x30
	public List<String> propSpawningSequences; //Field offset: 0x38
	public string propIdsToTrack; //Field offset: 0x40
	public bool defeatOnMaxRemoveablePropsReached; //Field offset: 0x48
	public bool victoryOnMinRemoveablePropsReached; //Field offset: 0x49
	public bool hidePropCountUi; //Field offset: 0x4A
	public int maxSpawnCount; //Field offset: 0x4C
	public int propRemovalCost; //Field offset: 0x50
	public string propRemovalCostLoc; //Field offset: 0x58
	public string defeatLoc; //Field offset: 0x60
	public SpriteReference hudIcon; //Field offset: 0x68

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 1075
	}

	public PropSpawningChallenge() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

