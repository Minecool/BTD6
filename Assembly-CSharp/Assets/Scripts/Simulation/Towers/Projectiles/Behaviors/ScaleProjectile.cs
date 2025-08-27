namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ScaleProjectile : ProjectileBehavior
{
	public ScaleProjectileModel scaleModel; //Field offset: 0x68
	private bool init; //Field offset: 0x70
	private FollowPath followPath; //Field offset: 0x78
	private ArriveAtTarget arriveAtTarget; //Field offset: 0x80
	private bool arrived; //Field offset: 0x88
	private float baseScale; //Field offset: 0x8C

	public ScaleProjectile() { }

	public void Complete() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

