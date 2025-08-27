namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectileOnInterval : ProjectileBehaviorOnEmit
{
	private CreateProjectileOnIntervalModel createProjectileOnIntervalModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private int createNextProjAt; //Field offset: 0x78
	private int intervalFrames; //Field offset: 0x7C
	private bool hasEmitted; //Field offset: 0x80

	public CreateProjectileOnInterval() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnEmit() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

