namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class HeightOffsetProjectile : ProjectileBehavior
{
	public HeightOffsetProjectileModel hModel; //Field offset: 0x68
	private bool init; //Field offset: 0x70
	private ArriveAtTarget arriveAtTarget; //Field offset: 0x78
	private bool arrived; //Field offset: 0x80

	public HeightOffsetProjectile() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

