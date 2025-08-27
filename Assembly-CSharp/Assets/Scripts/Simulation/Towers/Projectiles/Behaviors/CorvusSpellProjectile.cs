namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CorvusSpellProjectile : ProjectileBehavior
{
	public CorvusSpellProjectileModel spellProjectileModel; //Field offset: 0x68

	public CorvusSpellProjectile() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

