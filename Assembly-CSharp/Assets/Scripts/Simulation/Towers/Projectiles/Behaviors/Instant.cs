namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Instant : ProjectileBehavior
{
	public InstantModel instantModel; //Field offset: 0x68
	private ObjectId lastBloonId; //Field offset: 0x70
	private Vector3 lastBloonPosition; //Field offset: 0x74
	private bool positionSet; //Field offset: 0x80

	public Instant() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

