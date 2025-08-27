namespace Assets.Scripts.SimulationTests;

public class SimulationTestEnvironment : IDisposable
{
	public SimulationTest test; //Field offset: 0x10
	public GameModel gameModel; //Field offset: 0x18
	public UnityToSimulation simulation; //Field offset: 0x20
	public bool isRealTime; //Field offset: 0x28
	public int simulationSpeed; //Field offset: 0x2C
	public bool verboseLogging; //Field offset: 0x30
	public bool canDebugRender; //Field offset: 0x31

	public SimulationTestEnvironment() { }

	public override void Dispose() { }

	public void Log(string log) { }

}

