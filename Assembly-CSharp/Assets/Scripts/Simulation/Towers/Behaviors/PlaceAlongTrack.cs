namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PlaceAlongTrack : TowerBehavior
{
	public PlaceAlongTrackModel placeAlongTrackModel; //Field offset: 0x68
	private List<Entity> entities; //Field offset: 0x70

	public PlaceAlongTrack() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void PlaceObjects() { }

	private void RemoveObjects() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

