namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class OnDamagedTrigger : BloonBehaviorTrigger
{
	public OnDamagedTriggerModel triggerModel; //Field offset: 0x70
	private int lastActivatedAt; //Field offset: 0x78

	public OnDamagedTrigger() { }

	public virtual float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	private void Trigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

