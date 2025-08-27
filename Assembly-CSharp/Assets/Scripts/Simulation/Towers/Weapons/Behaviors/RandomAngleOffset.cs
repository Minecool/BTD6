namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class RandomAngleOffset : WeaponBehavior
{
	public RandomAngleOffsetModel randomAngleOffsetModel; //Field offset: 0x68

	public RandomAngleOffset() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

