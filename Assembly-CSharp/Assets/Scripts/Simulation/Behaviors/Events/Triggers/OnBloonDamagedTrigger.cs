namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnBloonDamagedTrigger : EntityTrigger
{
	public OnBloonDamagedTriggerModel onBloonDamagedTriggerModel; //Field offset: 0x70

	public OnBloonDamagedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDamaged(Projectile projectile, long damage, Bloon bloon, Tower poppedby) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

