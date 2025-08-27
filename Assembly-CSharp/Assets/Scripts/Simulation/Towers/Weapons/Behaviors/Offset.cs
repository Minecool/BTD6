namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class Offset : WeaponBehavior
{
	public OffsetModel offsetModel; //Field offset: 0x68

	public Offset() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

