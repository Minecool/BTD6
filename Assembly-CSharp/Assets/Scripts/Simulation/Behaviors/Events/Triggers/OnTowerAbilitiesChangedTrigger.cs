namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerAbilitiesChangedTrigger : EntityTrigger
{
	public OnTowerAbilitiesChangedTriggerModel behaviorModel; //Field offset: 0x70

	public OnTowerAbilitiesChangedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

