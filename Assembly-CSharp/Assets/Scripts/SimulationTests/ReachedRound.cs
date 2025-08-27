namespace Assets.Scripts.SimulationTests;

public class ReachedRound : ISimulationTestOutcome
{
	[SerializeField]
	private int round; //Field offset: 0x10

	public ReachedRound(int round) { }

	public override SimulationTestOutcome Check(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

