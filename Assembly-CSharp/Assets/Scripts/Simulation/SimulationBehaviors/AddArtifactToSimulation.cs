namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class AddArtifactToSimulation : SimulationTriggerBehavior
{
	public AddArtifactToSimulationModel behaviorModel; //Field offset: 0x58
	private bool IsTriggered; //Field offset: 0x60

	public AddArtifactToSimulation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundStart(int roundArrayIndex) { }

	public virtual void OnTriggerActivated(String[] triggers, int round = -1) { }

	public virtual void PerformTrigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

