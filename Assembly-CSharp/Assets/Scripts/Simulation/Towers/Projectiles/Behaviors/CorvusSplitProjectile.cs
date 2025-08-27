namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CorvusSplitProjectile : ProjectileBehavior
{
	public CorvusSplitProjectileModel splitProjectileModel; //Field offset: 0x68

	public CorvusSplitProjectile() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

