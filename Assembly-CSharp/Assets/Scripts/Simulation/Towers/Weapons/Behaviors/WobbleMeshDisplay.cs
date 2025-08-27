namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class WobbleMeshDisplay : WeaponBehavior
{
	public WobbleMeshDisplayModel wobbleMeshDisplayModel; //Field offset: 0x68

	public WobbleMeshDisplay() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

