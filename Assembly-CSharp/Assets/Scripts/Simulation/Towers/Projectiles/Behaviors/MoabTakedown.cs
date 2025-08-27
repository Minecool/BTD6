namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class MoabTakedown : ProjectileBehavior
{
	private const int lifeTime = 480; //Field offset: 0x0
	public MoabTakedownModel moabTakedownModel; //Field offset: 0x68
	private Entity bloonEffect; //Field offset: 0x70
	public bool startPullingBloonTowardsTower; //Field offset: 0x78
	private Vector2 start; //Field offset: 0x7C
	private float distance; //Field offset: 0x84
	private Vector3 effectOffset; //Field offset: 0x88
	private int blockedSpawnRound; //Field offset: 0x94
	private int lifeTimer; //Field offset: 0x98
	private List<CreateRopeEffect> ropes; //Field offset: 0xA0
	private List<Weapon> usedHooks; //Field offset: 0xA8

	public MoabTakedown() { }

	public virtual void Attatched() { }

	public virtual void Collide(Bloon bloon) { }

	private void DestroyIfReachedTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateEffectPositions() { }

}

