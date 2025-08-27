namespace Assets.Scripts.Simulation.Track;

public class AreaIndicator
{
	public Vector3 positionSim; //Field offset: 0x10
	public int playerNumber; //Field offset: 0x1C
	public int areaIndex; //Field offset: 0x20
	public bool isFreeForAll; //Field offset: 0x24

	public AreaIndicator() { }

}

