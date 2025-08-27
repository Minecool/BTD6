namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AddAcidicMixtureToProjectile : ProjectileBehavior
{
	public AddAcidicMixtureToProjectileModel addAcidicMixtureToProjectileModel; //Field offset: 0x68

	public AddAcidicMixtureToProjectile() { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

