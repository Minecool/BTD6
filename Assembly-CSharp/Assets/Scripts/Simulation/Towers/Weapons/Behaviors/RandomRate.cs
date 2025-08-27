namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class RandomRate : WeaponBehavior
{
	public RandomRateModel randomRateModel; //Field offset: 0x68

	public RandomRate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

