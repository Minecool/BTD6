namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class EnduranceRaceMode : SimulationBehavior
{
	public EnduranceRaceModeModel behaviorModel; //Field offset: 0x58

	public EnduranceRaceMode() { }

	private void CheckForVictory() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

