namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ProjectileZeroRotation : ProjectileBehaviorOnEmit
{
	public ProjectileZeroRotationModel projectileZeroRotation; //Field offset: 0x68

	public ProjectileZeroRotation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnEmit() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

