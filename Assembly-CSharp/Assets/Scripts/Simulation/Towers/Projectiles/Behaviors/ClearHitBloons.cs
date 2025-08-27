namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ClearHitBloons : ProjectileBehavior
{
	public ClearHitBloonsModel clearHitBloonsModel; //Field offset: 0x68
	private float lastClear; //Field offset: 0x70
	public int intervalFramesDeduction; //Field offset: 0x74

	public ClearHitBloons() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

