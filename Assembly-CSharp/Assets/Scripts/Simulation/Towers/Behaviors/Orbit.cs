namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class Orbit : TowerBehavior
{
	private const int speedUpRange = 40; //Field offset: 0x0
	private const float slowRotationPerFrame = 3; //Field offset: 0x0
	private const float fastRotationPerFrame = 15; //Field offset: 0x0
	private const float speedUpLerp = 0.5; //Field offset: 0x0
	private const float slowDownLerp = 0.2; //Field offset: 0x0
	public OrbitModel orbitModel; //Field offset: 0x68
	public float currentSpeed; //Field offset: 0x70
	private float angle; //Field offset: 0x74
	private readonly List<Projectile> projectiles; //Field offset: 0x78
	private Bloon bloonInRange; //Field offset: 0x80
	private bool isActive; //Field offset: 0x88
	private bool isStunned; //Field offset: 0x89

	public Orbit() { }

	private void AddProjectiles() { }

	public virtual void Attatched() { }

	private bool CanSpawnProjectiles() { }

	public static void DestroyReusables(IList<T> reusables) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public void SetActive(bool active) { }

	public void SetStunned(bool stunned) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

