namespace Assets.Scripts.Simulation.Bloons;

public class BloonArmour
{
	public string id; //Field offset: 0x10
	public String[] tags; //Field offset: 0x18
	public int amount; //Field offset: 0x20
	public int original; //Field offset: 0x24
	public BloonProperties properties; //Field offset: 0x28

	[JsonIgnore]
	public float Proportion
	{
		 get { } //Length: 29
	}

	public BloonArmour() { }

	public float get_Proportion() { }

}

