namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectileOnBlockerCollide : ProjectileBehavior
{
	private CreateProjectileOnBlockerCollideModel createProjectileOnBlockerCollideModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70

	public CreateProjectileOnBlockerCollide() { }

	public virtual bool CollideMap(MapBlocker blocker) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

