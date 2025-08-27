namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DesperadoMark : BloonBehavior
{
	public DesperadoMarkModel desperadoMarkModel; //Field offset: 0x70

	public DesperadoMark() { }

	public virtual float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

