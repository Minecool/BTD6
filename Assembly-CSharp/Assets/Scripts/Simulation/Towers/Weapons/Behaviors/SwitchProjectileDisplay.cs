namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class SwitchProjectileDisplay : WeaponBehavior
{
	public SwitchProjectileDisplayModel switchProjectileDisplayModel; //Field offset: 0x68
	private int effectIndex; //Field offset: 0x70

	public SwitchProjectileDisplay() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

