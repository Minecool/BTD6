namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class SpawnPropOnRoundOrTrigger : SimulationTriggerBehavior
{
	private SpawnPropOnRoundOrTriggerModel behaviorModel; //Field offset: 0x58

	public SpawnPropOnRoundOrTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void OnTriggerActivated(String[] triggers, int round = -1) { }

	public void PerformAction(int index) { }

	public virtual void PerformTrigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

