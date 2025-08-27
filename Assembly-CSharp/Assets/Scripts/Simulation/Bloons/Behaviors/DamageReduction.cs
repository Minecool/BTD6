namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DamageReduction : BloonBehavior
{
	public DamageReductionModel damageReductionModel; //Field offset: 0x70

	public DamageReduction() { }

	public virtual float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile, out bool preventFurtherModification) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

