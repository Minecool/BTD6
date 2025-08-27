namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class TangentNode : DraggableNode
{
	private SplineNode parentNode; //Field offset: 0x60
	[CompilerGenerated]
	private bool <IsLeftTangent>k__BackingField; //Field offset: 0x68

	private bool IsLeftTangent
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private Vector3 Position
	{
		private get { } //Length: 153
	}

	public Vector2 TransformToSplinePosition
	{
		 get { } //Length: 113
	}

	public TangentNode() { }

	private Vector3 ClampMinMaxTagentDistance(Vector3 position) { }

	public virtual void ForceResetIndex(int index) { }

	[CompilerGenerated]
	private bool get_IsLeftTangent() { }

	private Vector3 get_Position() { }

	public Vector2 get_TransformToSplinePosition() { }

	protected virtual int GetDraggingPriority() { }

	public void Initialise(SplineNode parentNode, MapEditorSpriteShapeController spriteShapeController, bool isLeftTangent) { }

	public void LoadSaveData(Vector2 savedPosition) { }

	protected virtual void OnDraggingTriggered() { }

	protected virtual void OnDraggingUpdateEvent(Ray ray, float enter) { }

	protected virtual void PostUpdateChecks() { }

	protected virtual bool PreUpdateOverrideChecks() { }

	[CompilerGenerated]
	private void set_IsLeftTangent(bool value) { }

	public void SetPosition(Vector3 position) { }

	public void UpdatePosition() { }

}

