namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectileOnExhaustPierce : ProjectileBehavior
{
	private CreateProjectileOnExhaustPierceModel modl; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private float timeOfLastCreation; //Field offset: 0x78
	private int creationCount; //Field offset: 0x7C

	public CreateProjectileOnExhaustPierce() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	private void UpdateCollisionFlag() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

