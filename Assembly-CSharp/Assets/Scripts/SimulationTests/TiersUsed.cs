namespace Assets.Scripts.SimulationTests;

public class TiersUsed : ISimulationTestOutcome
{
	[SerializeField]
	private int tiers; //Field offset: 0x10

	public TiersUsed(int tiers) { }

	public override SimulationTestOutcome Check(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

