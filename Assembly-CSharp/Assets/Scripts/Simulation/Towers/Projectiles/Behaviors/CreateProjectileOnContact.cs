namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectileOnContact : ProjectileBehavior
{
	private CreateProjectileOnContactModel createProjectileOnContactModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private Vector3 spawnPosition; //Field offset: 0x78

	public CreateProjectileOnContact() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual bool CollideMap(MapBlocker blocker) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

