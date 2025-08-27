namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AddBerserkerBrewToProjectile : ProjectileBehavior
{
	public AddBerserkerBrewToProjectileModel addBerserkerBrewToProjectileModel; //Field offset: 0x68

	public AddBerserkerBrewToProjectile() { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

