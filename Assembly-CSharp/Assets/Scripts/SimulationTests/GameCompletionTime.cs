namespace Assets.Scripts.SimulationTests;

public class GameCompletionTime : ISimulationTestOutcome
{
	[SerializeField]
	private Comparator comparator; //Field offset: 0x10
	[SerializeField]
	private TimeSpan time; //Field offset: 0x18

	public GameCompletionTime(TimeSpan time, Comparator comparator = 0) { }

	public override SimulationTestOutcome Check(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

