namespace Assets.Scripts.SimulationTests;

public class Health : ISimulationTestOutcome
{
	[SerializeField]
	private Comparator comparator; //Field offset: 0x10
	[SerializeField]
	private int health; //Field offset: 0x14

	public Health(int health, Comparator comparator = 0) { }

	public override SimulationTestOutcome Check(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

