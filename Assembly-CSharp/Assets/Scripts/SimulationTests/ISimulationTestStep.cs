namespace Assets.Scripts.SimulationTests;

public interface ISimulationTestStep
{

	public IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

