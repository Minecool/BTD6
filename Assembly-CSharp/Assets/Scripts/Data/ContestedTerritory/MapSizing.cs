namespace Assets.Scripts.Data.ContestedTerritory;

public class MapSizing
{
	public Vector3 mapCenter; //Field offset: 0x10
	public float horizontalSpacing; //Field offset: 0x1C
	public float verticalSpacing; //Field offset: 0x20
	public float teamIslandDistance; //Field offset: 0x24

	public MapSizing() { }

}

