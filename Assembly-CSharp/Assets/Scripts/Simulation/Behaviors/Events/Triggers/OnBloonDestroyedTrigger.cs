namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnBloonDestroyedTrigger : EntityTrigger
{
	public OnBloonDestroyedTriggerModel onBloonDestroyedTriggerModel; //Field offset: 0x70

	public OnBloonDestroyedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDestroyed(Projectile projectile, Bloon bloon, Tower poppedby, DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

