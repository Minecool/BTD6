namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class TriggerGameModeBehaviors : SimulationBehavior
{
	public TriggerGameModeBehaviorsModel behaviorModel; //Field offset: 0x58

	public TriggerGameModeBehaviors() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

