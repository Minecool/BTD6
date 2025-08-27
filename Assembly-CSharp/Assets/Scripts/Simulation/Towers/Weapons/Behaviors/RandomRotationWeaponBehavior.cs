namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class RandomRotationWeaponBehavior : WeaponBehavior
{
	public RandomRotationWeaponBehaviorModel randomRotationWeaponBehavior; //Field offset: 0x68

	public RandomRotationWeaponBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

