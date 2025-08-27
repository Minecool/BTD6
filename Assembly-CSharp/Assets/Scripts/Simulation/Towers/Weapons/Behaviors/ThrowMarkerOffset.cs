namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class ThrowMarkerOffset : WeaponBehavior
{
	public ThrowMarkerOffsetModel offsetOffsetModel; //Field offset: 0x68

	public ThrowMarkerOffset() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

