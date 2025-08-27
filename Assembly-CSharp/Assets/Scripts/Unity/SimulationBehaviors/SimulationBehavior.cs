namespace Assets.Scripts.Unity.SimulationBehaviors;

public class SimulationBehavior : Behavior
{

	[JsonIgnore]
	public override SimulationBehaviorModel Def
	{
		 get { } //Length: 3
	}

	public SimulationBehavior() { }

	public override SimulationBehaviorModel get_Def() { }

}

