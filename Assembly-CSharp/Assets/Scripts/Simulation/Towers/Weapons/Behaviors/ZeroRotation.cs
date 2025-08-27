namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class ZeroRotation : WeaponBehavior
{
	private ZeroRotationModel zeroRotationModel; //Field offset: 0x68

	public ZeroRotation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

