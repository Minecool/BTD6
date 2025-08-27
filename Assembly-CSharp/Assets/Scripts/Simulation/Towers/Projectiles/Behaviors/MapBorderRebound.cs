namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class MapBorderRebound : ProjectileBehavior
{
	public MapBorderReboundModel reboundModel; //Field offset: 0x68
	private Nullable<Vector3> lastPosition; //Field offset: 0x70

	public MapBorderRebound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

