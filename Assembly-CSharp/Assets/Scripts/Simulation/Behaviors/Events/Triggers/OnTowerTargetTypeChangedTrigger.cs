namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerTargetTypeChangedTrigger : EntityTrigger
{
	public OnTowerTargetTypeChangedTriggerModel behaviorModel; //Field offset: 0x70

	public OnTowerTargetTypeChangedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(Tower tower, TargetType targetType) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

