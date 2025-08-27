namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Accelerate : ProjectileBehavior
{
	public AccelerateModel accModel; //Field offset: 0x68
	private TravelStrait travel; //Field offset: 0x70
	private TrackTarget track; //Field offset: 0x78

	public Accelerate() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

