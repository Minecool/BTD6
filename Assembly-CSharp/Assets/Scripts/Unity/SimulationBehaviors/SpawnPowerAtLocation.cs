namespace Assets.Scripts.Unity.SimulationBehaviors;

public class SpawnPowerAtLocation : SimulationBehavior
{
	public EnableOptions enableOptions; //Field offset: 0x18
	public Vector2 location; //Field offset: 0x30
	[PowerType]
	public string power; //Field offset: 0x38

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 190
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SpawnPowerAtLocation() { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

