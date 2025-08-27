namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class IncreaseDamageFromType : BloonBehavior
{
	public IncreaseDamageFromTypeModel IncreaseDamageFromTypeModel; //Field offset: 0x70

	public IncreaseDamageFromType() { }

	public virtual float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile, out bool preventFurtherModification) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

