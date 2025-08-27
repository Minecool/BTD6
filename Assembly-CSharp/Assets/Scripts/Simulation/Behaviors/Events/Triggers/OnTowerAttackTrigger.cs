namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerAttackTrigger : EntityTrigger
{
	public OnTowerAttackTriggerModel behaviorModel; //Field offset: 0x70

	public OnTowerAttackTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

