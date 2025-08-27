namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ChurchillBaseRotation : TowerBehavior
{
	public ChurchillBaseRotationModel churchillBaseRotationModel; //Field offset: 0x68
	private float rotationTargetAngle; //Field offset: 0x70
	private bool pausedRotation; //Field offset: 0x74
	private bool rotateToTarget; //Field offset: 0x75
	private int MAX_PAUSE_TIME; //Field offset: 0x78
	private int elapsedPaused; //Field offset: 0x7C
	private DisplayBehavior display; //Field offset: 0x80

	public ChurchillBaseRotation() { }

	private bool AnimatesWhileRotating() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

