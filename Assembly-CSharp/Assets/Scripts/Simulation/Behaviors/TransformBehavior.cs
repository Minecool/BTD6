namespace Assets.Scripts.Simulation.Behaviors;

public class TransformBehavior : RootBehavior
{
	public Vector3Boxed position; //Field offset: 0x58
	public FloatBoxed rotation; //Field offset: 0x60
	public Vector3Boxed scale; //Field offset: 0x68
	private TransformBehavior parentTransform; //Field offset: 0x70
	public Vector3 parentPositionOffset; //Field offset: 0x78
	public float parentRotationOffset; //Field offset: 0x84
	private ProcessDelegate updatePositionFromParent; //Field offset: 0x88
	public bool ignoreParentRotation; //Field offset: 0x90
	public bool ignoreParentRotationalPosition; //Field offset: 0x91

	public TransformBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Set(TransformBehavior transform) { }

	public void SetParent(TransformBehavior transform) { }

	public void UpdatePositionFromParent(int elapsed) { }

	public Zoned<T> Zone(GetRangeDelegate range, ForEachDelegate<T> enter, ForEachDelegate<T> exit, ViewFilter filter = null) { }

}

