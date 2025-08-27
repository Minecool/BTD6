namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class AcidicMixture : WeaponBehavior
{
	public AcidicMixtureModel acidicMixtureModel; //Field offset: 0x68

	public AcidicMixture() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

