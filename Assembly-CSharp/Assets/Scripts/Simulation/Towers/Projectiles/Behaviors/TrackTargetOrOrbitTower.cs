namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TrackTargetOrOrbitTower : ProjectileBehaviorOnEmit
{
	private enum ProjectileState
	{
		NotSet = 0,
		TrackingBloon = 1,
		TrackingToOrbit = 2,
		OrbitingTower = 3,
	}

	internal class ProjectileTrackingAbility : TrackingAbility<Projectile>
	{

		public ProjectileTrackingAbility() { }

		public virtual bool IsTargetValid(Projectile target) { }

	}

	internal class TowerTrackingAbility : TrackingAbility<Tower>
	{

		public TowerTrackingAbility() { }

		public virtual bool IsTargetValid(Tower target) { }

	}

	internal abstract class TrackingAbility
	{

		protected TrackingAbility`1() { }

		public abstract bool IsTargetValid(T target) { }

	}

	public TrackTargetOrOrbitTowerModel trackOrOrbitModel; //Field offset: 0x68
	public int lastTargetSearchElapsed; //Field offset: 0x70
	private ProjectileState projectileState; //Field offset: 0x74
	private float currentVelocity; //Field offset: 0x78
	private float maxSpeed; //Field offset: 0x7C
	private bool accelerating; //Field offset: 0x80
	private Vector2 movementDirection; //Field offset: 0x84
	private Vector2 trackingToOrbitPosition; //Field offset: 0x8C
	private float orbitAngle; //Field offset: 0x94

	public TrackTargetOrOrbitTower() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual bool FilterCollision(Bloon bloon) { }

	private bool FilterOutBloonTarget(Bloon bloon) { }

	private bool GetAccelerationState(float angleBetween) { }

	private ProjectileState GetProjectileState() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected bool IsBloonValid(Bloon bloon) { }

	public virtual void OnEmit() { }

	private void OrbitTower() { }

	private void Process(int elapsed) { }

	private void SetTowerOrbitDestination() { }

	private void TrackTowards(Vector2 target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

