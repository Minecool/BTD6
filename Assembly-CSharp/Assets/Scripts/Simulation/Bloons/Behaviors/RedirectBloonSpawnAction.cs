namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class RedirectBloonSpawnAction : BloonBehaviorAction
{
	public RedirectBloonSpawnActionModel redirectBloonSpawnActionModel; //Field offset: 0x78
	private RedirectBloonSpawning simBehavior; //Field offset: 0x80
	private Nullable<Vector2> lastSpawningPosition; //Field offset: 0x88

	public RedirectBloonSpawnAction() { }

	private void ChangeBloonSpawn(int roundsRemaining, Vector2 position, bool findPathSegment) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

