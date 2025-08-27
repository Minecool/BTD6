namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class EjectAnimation : WeaponBehavior
{
	public EjectAnimationModel ejectAnimationModel; //Field offset: 0x68
	public float scaleOverride; //Field offset: 0x70

	public EjectAnimation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

