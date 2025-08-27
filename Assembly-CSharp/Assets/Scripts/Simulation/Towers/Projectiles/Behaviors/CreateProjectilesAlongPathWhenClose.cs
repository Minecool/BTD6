namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectilesAlongPathWhenClose : ProjectileBehavior
{
	public CreateProjectilesAlongPathWhenCloseModel createAlongPathModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private IList<PathSegment> targetPathSegments; //Field offset: 0x78
	public float distanceTraveled; //Field offset: 0x80
	public Path path; //Field offset: 0x88
	public float distancePerProjectile; //Field offset: 0x90
	public float distanceAtLastProjectile; //Field offset: 0x94
	public float speedFrames; //Field offset: 0x98
	public bool reversed; //Field offset: 0x9C
	public int currentPoint; //Field offset: 0xA0
	private int pathOffset; //Field offset: 0xA4
	public Entity emitProjectileEffect; //Field offset: 0xA8
	public Entity projectileLandingEffect; //Field offset: 0xB0
	public bool firingProjectile; //Field offset: 0xB8
	public bool projectileLanding; //Field offset: 0xB9
	public bool projectileInQueue; //Field offset: 0xBA
	private int firingProjectileEffectEndsAt; //Field offset: 0xBC
	private int projectileLandingEffectEndsAt; //Field offset: 0xC0
	public List<Target> queuedProjectileTargetList; //Field offset: 0xC8
	private Target currentTarget; //Field offset: 0xD0
	private List<Projectile> emittedProjectiles; //Field offset: 0x118

	public CreateProjectilesAlongPathWhenClose() { }

	private void CreateQueuedProjectile(Target projectileTarget) { }

	private void GeneratePoints() { }

	private Target GetTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void LandProjectile() { }

	protected virtual void OnDestroy() { }

	private void PlayProjectileSound() { }

	public void Process(int elapsed) { }

	private void QueueProjectile() { }

	private void StartProjectileLaunch() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

