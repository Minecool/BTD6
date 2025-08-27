namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnBloonPoppedTrigger : EntityTrigger
{
	public OnBloonPoppedTriggerModel onBloonPoppedTriggerModel; //Field offset: 0x70

	public OnBloonPoppedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDegrade(Projectile projectile, Bloon bloon, Tower poppedBy, DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

