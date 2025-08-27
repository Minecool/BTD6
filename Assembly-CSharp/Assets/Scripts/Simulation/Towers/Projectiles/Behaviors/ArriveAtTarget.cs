namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ArriveAtTarget : ProjectileBehavior
{
	public ArriveAtTargetModel arriveModel; //Field offset: 0x68
	private Vector3 origPos; //Field offset: 0x70
	private Vector3 targetPos; //Field offset: 0x7C
	private int startFrame; //Field offset: 0x88
	private float perc; //Field offset: 0x8C
	private float timeToTake; //Field offset: 0x90
	public bool arrivedAtTarget; //Field offset: 0x94
	private Vector3 startPos; //Field offset: 0x98

	public ArriveAtTarget() { }

	public virtual void Attatched() { }

	public float GetPercThruMovement() { }

	public Vector3 GetTargetPosition() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDestroyEvent(RootObject obj) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	private void RotateToTarget() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void SetStartPosition(Vector3 pos) { }

	public virtual void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

