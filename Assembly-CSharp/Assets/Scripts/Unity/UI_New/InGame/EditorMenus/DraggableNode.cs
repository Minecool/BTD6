namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public abstract class DraggableNode : MonoBehaviour
{
	protected static DraggableNode currentDraggedNode; //Field offset: 0x0
	public BoxCollider boxCollider; //Field offset: 0x20
	public GameObject highlightedGlowObj; //Field offset: 0x28
	public Animator placementAnim; //Field offset: 0x30
	protected Plane dragPlane; //Field offset: 0x38
	protected Vector3 origionalPositionDuringMovingMode; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsDragging>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private bool <IsSelected>k__BackingField; //Field offset: 0x55
	[CompilerGenerated]
	private bool <IsHighlighted>k__BackingField; //Field offset: 0x56
	[CompilerGenerated]
	private MapEditorSpriteShapeController <SpriteShapeController>k__BackingField; //Field offset: 0x58

	public override bool CannotRunUpdateLoop
	{
		 get { } //Length: 209
	}

	public bool IsDragging
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private bool IsHighlighted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsSelected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MapEditorSpriteShapeController SpriteShapeController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	protected DraggableNode() { }

	private bool CanDragNode() { }

	protected void CheckForValidTouchInput() { }

	public abstract void ForceResetIndex(int index) { }

	public override bool get_CannotRunUpdateLoop() { }

	[CompilerGenerated]
	public bool get_IsDragging() { }

	[CompilerGenerated]
	public bool get_IsHighlighted() { }

	[CompilerGenerated]
	public bool get_IsSelected() { }

	[CompilerGenerated]
	public MapEditorSpriteShapeController get_SpriteShapeController() { }

	protected override int GetDraggingPriority() { }

	protected override void OnDraggingEnded() { }

	protected override void OnDraggingTriggered() { }

	protected abstract void OnDraggingUpdateEvent(Ray ray, float enter) { }

	public override void OnEnterMoveFromWorldOffsetMode() { }

	public override void OnMoveFromWorldOffset(Vector3 positionOffset) { }

	protected override void PostUpdateChecks() { }

	protected override bool PreUpdateOverrideChecks() { }

	private void RayCastCollisionCheck(Vector3 position) { }

	protected override void RemoveListeners() { }

	[CompilerGenerated]
	public void set_IsDragging(bool value) { }

	[CompilerGenerated]
	private void set_IsHighlighted(bool value) { }

	[CompilerGenerated]
	public void set_IsSelected(bool value) { }

	[CompilerGenerated]
	public void set_SpriteShapeController(MapEditorSpriteShapeController value) { }

	protected override void Update() { }

}

