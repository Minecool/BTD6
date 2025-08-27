namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class SplineNode : DraggableNode, ISplineNode
{
	[CompilerGenerated]
	private int <Index>k__BackingField; //Field offset: 0x60
	public TangentNode leftTangent; //Field offset: 0x68
	public TangentNode rightTangent; //Field offset: 0x70
	public MeshRenderer meshRenderer; //Field offset: 0x78
	private LineRenderer lineRenderer; //Field offset: 0x80
	public GameObject startNode; //Field offset: 0x88
	public GameObject normalNode; //Field offset: 0x90
	public GameObject selectedIcon; //Field offset: 0x98

	public override bool CanDeleteNode
	{
		 get { } //Length: 36
	}

	public int Index
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public override Vector3 LeftTangentPosition
	{
		 get { } //Length: 74
	}

	[JsonIgnore]
	public override Vector3 Position
	{
		 get { } //Length: 71
	}

	[JsonIgnore]
	public override Vector3 RightTangentPosition
	{
		 get { } //Length: 74
	}

	public Vector2 TransformToSplinePosition
	{
		 get { } //Length: 116
	}

	public SplineNode() { }

	public void Awake() { }

	public virtual void ForceResetIndex(int index) { }

	public override bool get_CanDeleteNode() { }

	[CompilerGenerated]
	public int get_Index() { }

	public override Vector3 get_LeftTangentPosition() { }

	public override Vector3 get_Position() { }

	public override Vector3 get_RightTangentPosition() { }

	public Vector2 get_TransformToSplinePosition() { }

	public override void Initialise(MapEditorSpriteShapeController splineController, int index, PathNode saveData = null) { }

	public void OnDestroy() { }

	protected virtual void OnDraggingTriggered() { }

	protected virtual void OnDraggingUpdateEvent(Ray ray, float enter) { }

	public virtual void OnMoveFromWorldOffset(Vector3 localOffsetPosition) { }

	protected override void OnSplineChangedEvent(MapEditorSpriteShapeController spline) { }

	protected virtual void PostUpdateChecks() { }

	[CompilerGenerated]
	public void set_Index(int value) { }

	public void ShowHideNode(bool show) { }

	protected virtual void Update() { }

}

