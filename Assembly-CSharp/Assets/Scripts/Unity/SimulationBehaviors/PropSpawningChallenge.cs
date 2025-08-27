namespace Assets.Scripts.Unity.SimulationBehaviors;

public class PropSpawningChallenge : SimulationBehavior
{
	public List<Int32> propGroupLayerIds; //Field offset: 0x18
	public List<String> propSpawningSequences; //Field offset: 0x20
	public string propIdsToTrack; //Field offset: 0x28
	public bool defeatOnMaxRemoveablePropsReached; //Field offset: 0x30
	public bool victoryOnMinRemoveablePropsReached; //Field offset: 0x31
	public bool hidePropCountUi; //Field offset: 0x32
	public int maxSpawnCount; //Field offset: 0x34
	public int propRemovalCost; //Field offset: 0x38
	public string propRemovalCostLoc; //Field offset: 0x40
	public string defeatLoc; //Field offset: 0x48
	public SpriteReference hudIcon; //Field offset: 0x50

	public virtual Model Model
	{
		 get { } //Length: 1075
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public PropSpawningChallenge() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

