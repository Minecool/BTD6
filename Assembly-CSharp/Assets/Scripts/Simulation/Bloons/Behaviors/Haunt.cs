namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class Haunt : BloonBehavior
{
	public HauntModel hauntModel; //Field offset: 0x70
	private Emission emission; //Field offset: 0x78

	public Haunt() { }

	public virtual void Attatched() { }

	public void EmitProjectile() { }

	public virtual float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile, out bool preventFurtherModification) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

