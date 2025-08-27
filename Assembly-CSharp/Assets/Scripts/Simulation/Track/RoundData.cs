namespace Assets.Scripts.Simulation.Track;

public class RoundData
{
	public List<BloonEmissionModel> emissions; //Field offset: 0x10
	public int roundStartTime; //Field offset: 0x18
	public float roundDuration; //Field offset: 0x1C

	public RoundData() { }

}

