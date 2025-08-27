namespace Assets.Scripts.Unity.SimulationBehaviors;

public class SpawnPowerAtLocation : SimulationBehavior
{
	public EnableOptions enableOptions; //Field offset: 0x18
	public Vector2 location; //Field offset: 0x30
	[PowerType]
	public string power; //Field offset: 0x38

	public virtual Model Model
	{
		 get { } //Length: 193
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SpawnPowerAtLocation() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

