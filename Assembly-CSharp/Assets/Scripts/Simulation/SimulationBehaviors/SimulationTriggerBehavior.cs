namespace Assets.Scripts.Simulation.SimulationBehaviors;

public abstract class SimulationTriggerBehavior : SimulationBehavior
{

	protected SimulationTriggerBehavior() { }

	public abstract void OnTriggerActivated(String[] triggers, int round = -1) { }

	public abstract void PerformTrigger() { }

}

