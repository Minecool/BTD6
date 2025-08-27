namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class MoveWithAnimator : BloonBehavior
{
	public MoveWithAnimatorModel modl; //Field offset: 0x70
	private int animTimer; //Field offset: 0x78
	private float animLengthFrames; //Field offset: 0x7C
	private bool travelToPath; //Field offset: 0x80
	private AnimCurveData curveData; //Field offset: 0x88
	private Vector3 startPos; //Field offset: 0x90
	private Vector3 destPos; //Field offset: 0x9C
	private Vector3 diff; //Field offset: 0xA8

	public MoveWithAnimator() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

