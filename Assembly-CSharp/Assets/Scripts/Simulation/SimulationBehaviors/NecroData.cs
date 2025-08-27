namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class NecroData
{
	public Tower tower; //Field offset: 0x10
	public NecromancerEmission emission; //Field offset: 0x18
	public Int32[] rbeDecayByRoundsRemaining; //Field offset: 0x20

	public NecroData() { }

	public int DeductFromPool(int amount) { }

	public int RbePool() { }

}

