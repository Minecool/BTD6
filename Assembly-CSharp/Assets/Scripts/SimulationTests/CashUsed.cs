namespace Assets.Scripts.SimulationTests;

public class CashUsed : ISimulationTestOutcome
{
	[SerializeField]
	private int cash; //Field offset: 0x10

	public CashUsed(int cash) { }

	public override SimulationTestOutcome Check(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

