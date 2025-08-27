namespace Assets.Scripts.SimulationTests;

public class BossCompletionTime : ISimulationTestOutcome
{
	[SerializeField]
	private Comparator comparator; //Field offset: 0x10
	[SerializeField]
	private TimeSpan time; //Field offset: 0x18
	[SerializeField]
	private bool highAccuracy; //Field offset: 0x20

	public BossCompletionTime(TimeSpan time, bool highAccuracy, Comparator comparator = 0) { }

	public override SimulationTestOutcome Check(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

