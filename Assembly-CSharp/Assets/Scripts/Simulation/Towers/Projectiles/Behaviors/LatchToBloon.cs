namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class LatchToBloon : ProjectileBehavior
{
	private LatchToBloonModel latchToBloonModel; //Field offset: 0x68
	private Bloon bloon; //Field offset: 0x70
	private Vector2 offsetFromBloon; //Field offset: 0x78
	private float startingBloonRotation; //Field offset: 0x80
	private float startingProjectileRotation; //Field offset: 0x84
	private ObjectId layerId; //Field offset: 0x88
	private int destroyProjectileAt; //Field offset: 0x8C
	private Tower emittedByTower; //Field offset: 0x90

	public LatchToBloon() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	private void SetBeastHandlerIntoCooldown() { }

	public virtual void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

