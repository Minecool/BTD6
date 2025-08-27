//Type is in global namespace

public class PlacementZone
{
	public AreaType towerAreaType; //Field offset: 0x10
	public AreaType canPlaceOnMapAreaType; //Field offset: 0x14
	public Vector3 position; //Field offset: 0x18
	public float radius; //Field offset: 0x24
	public BehaviorMutator mutator; //Field offset: 0x28

	public PlacementZone(AreaType towerAreaType, AreaType canPlaceOnMapAreaType, Vector3 position, float radius, BehaviorMutator mutator) { }

}

