namespace Assets.Scripts.SimulationTests;

public interface ISimulationTestOutcome
{

	public SimulationTestOutcome Check(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

