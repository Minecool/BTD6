namespace Assets.Scripts.Simulation;

public struct PlacementQuery
{
	public Vector3 position; //Field offset: 0x0
	public float rotation; //Field offset: 0xC
	public List<Mesh> meshes; //Field offset: 0x10
	public bool positionValid; //Field offset: 0x18
	public bool coopZonePlaceValid; //Field offset: 0x19
	public List<BuffQuery> supportBuffs; //Field offset: 0x20

}

