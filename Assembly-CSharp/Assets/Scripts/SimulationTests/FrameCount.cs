namespace Assets.Scripts.SimulationTests;

public class FrameCount : ISimulationTestOutcome
{
	[SerializeField]
	private Comparator comparator; //Field offset: 0x10
	[SerializeField]
	private int count; //Field offset: 0x14

	public FrameCount(int count, Comparator comparator = 0) { }

	public override SimulationTestOutcome Check(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

