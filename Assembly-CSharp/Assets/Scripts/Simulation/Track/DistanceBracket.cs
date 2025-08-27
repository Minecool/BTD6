namespace Assets.Scripts.Simulation.Track;

public class DistanceBracket
{
	public float max; //Field offset: 0x10
	public float min; //Field offset: 0x14
	public Path path; //Field offset: 0x18

	public float Centre
	{
		 get { } //Length: 24
	}

	public float Length
	{
		 get { } //Length: 11
	}

	public DistanceBracket(float min = 0, float max = 0, Path path = null) { }

	public float get_Centre() { }

	public float get_Length() { }

}

