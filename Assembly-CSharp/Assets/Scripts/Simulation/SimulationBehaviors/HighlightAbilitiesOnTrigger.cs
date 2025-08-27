namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class HighlightAbilitiesOnTrigger : SimulationTriggerBehavior
{
	private HighlightAbilitiesOnTriggerModel behaviorModel; //Field offset: 0x58

	public HighlightAbilitiesOnTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTriggerActivated(String[] triggers, int round = -1) { }

	public virtual void PerformTrigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

