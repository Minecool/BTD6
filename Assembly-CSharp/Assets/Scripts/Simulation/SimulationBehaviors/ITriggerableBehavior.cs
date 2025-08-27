namespace Assets.Scripts.Simulation.SimulationBehaviors;

public interface ITriggerableBehavior
{

	public bool CheckForEvent(int roundArrayIndex, out int index, bool firstRound = false) { }

	public void PerformAction(int roundArrayIndex, int index) { }

}

