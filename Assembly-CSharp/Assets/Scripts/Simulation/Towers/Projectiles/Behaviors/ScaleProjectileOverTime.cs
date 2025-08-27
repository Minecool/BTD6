namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ScaleProjectileOverTime : ProjectileBehavior
{
	public ScaleProjectileOverTimeModel scaleProjectileOverTimeModel; //Field offset: 0x68
	private float timePassed; //Field offset: 0x70
	private TransformBehavior effectTransform; //Field offset: 0x78
	public Emission emission; //Field offset: 0x80
	public float baseScale; //Field offset: 0x88
	private bool hasCreatedProjectile; //Field offset: 0x8C

	public ScaleProjectileOverTime() { }

	public virtual bool CollideMap(MapBlocker blocker) { }

	private void CreateBonusProjectile(float positionOffset = 0) { }

	public virtual void Exhausted() { }

	public virtual void Expired() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

