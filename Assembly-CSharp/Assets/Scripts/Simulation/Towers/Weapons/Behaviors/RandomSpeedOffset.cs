namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class RandomSpeedOffset : WeaponBehavior
{
	public RandomSpeedOffsetModel randomSpeedOffsetModel; //Field offset: 0x68

	public RandomSpeedOffset() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

