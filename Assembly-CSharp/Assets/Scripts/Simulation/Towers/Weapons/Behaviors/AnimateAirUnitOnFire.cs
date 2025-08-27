namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class AnimateAirUnitOnFire : WeaponBehavior
{
	public AnimateAirUnitOnFireModel animateAirUnitOnFireModel; //Field offset: 0x68
	private AirUnit airUnit; //Field offset: 0x70

	public AnimateAirUnitOnFire() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

