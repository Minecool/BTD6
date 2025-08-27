namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectilesOnTrackOnExpire : ProjectileBehavior
{
	private CreateProjectilesOnTrackOnExpireModel createProjectilesOnTrackOnExpireModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70

	public CreateProjectilesOnTrackOnExpire() { }

	public virtual void Expired() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

