namespace Assets.Scripts.Simulation.Behaviors;

public class DisplayBehavior : RootBehavior
{
	public DisplayModel displayModel; //Field offset: 0x58
	public DisplayNode node; //Field offset: 0x60
	private bool processing; //Field offset: 0x68
	private TransformBehavior transformBehavior; //Field offset: 0x70
	private Vector3 positionOffset; //Field offset: 0x78
	[CompilerGenerated]
	private Vector3 <ScaleOffset>k__BackingField; //Field offset: 0x84
	public DisplayCategory DisplayCategory; //Field offset: 0x90

	public Vector3 Scale
	{
		 get { } //Length: 223
	}

	public private Vector3 ScaleOffset
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public DisplayBehavior() { }

	public virtual void Attatched() { }

	private void Connect() { }

	public Vector3 get_Scale() { }

	[CompilerGenerated]
	public Vector3 get_ScaleOffset() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	private void ResetDisplayNodeToDefaults() { }

	[CompilerGenerated]
	private void set_ScaleOffset(Vector3 value) { }

	public void SetPositionOffset(Vector3 positionOffset) { }

	public void SetScaleOffset(Vector3 scaleOffset) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

