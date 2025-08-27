namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class FighterMovement : TowerBehavior
{
	public FighterMovementModel fighterMovementModel; //Field offset: 0x68
	private bool flyoverEngaged; //Field offset: 0x70
	private Vector3 flyoverTarget; //Field offset: 0x74
	private Vector2[] currPath; //Field offset: 0x80
	private List<PathSupplier> pathSuppliers; //Field offset: 0x88
	private PathSupplier currentPathSupplier; //Field offset: 0x90
	private int timer; //Field offset: 0x98
	private int updatePathTime; //Field offset: 0x9C
	private TransformBehavior transform; //Field offset: 0xA0
	private Vector3 transformPosition; //Field offset: 0xA8
	private Vector3 directionToTarget; //Field offset: 0xB4
	private Vector3 rotation; //Field offset: 0xC0
	private Vector3 targetPosition; //Field offset: 0xCC
	private float lastBank; //Field offset: 0xD8
	private int lastTimeDidABarrelRoll; //Field offset: 0xDC
	private int lastTimeCheckedForABarrelRoll; //Field offset: 0xE0
	private bool doingABarrelRoll; //Field offset: 0xE4
	private int lastTimeDidALoopDeLoop; //Field offset: 0xE8
	private int lastTimeCheckedForALoopDeLoop; //Field offset: 0xEC
	private bool doingALoopDeLoop; //Field offset: 0xF0
	private Vector3 loopDeLoopCenter; //Field offset: 0xF4
	private Vector3 loopDeLoopRotationAxis; //Field offset: 0x100

	public FighterMovement() { }

	private void ApplyMovement(Vector2 targetPosition2d, int elasped) { }

	public virtual void Attatched() { }

	public void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnChangeTargetPriority(TargetType targetType) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

