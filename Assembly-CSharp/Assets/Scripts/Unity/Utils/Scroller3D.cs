namespace Assets.Scripts.Unity.Utils;

public class Scroller3D : MonoBehaviour, IScroller
{
	private const float kDragScale = 1; //Field offset: 0x0
	private bool isDirty; //Field offset: 0x20
	private List<Scrollable3DElement> children; //Field offset: 0x28
	[SerializeField]
	private float horizontalDragScale; //Field offset: 0x30
	[SerializeField]
	private float horizontalDragThreshold; //Field offset: 0x34
	[SerializeField]
	private float verticalDragThreshold; //Field offset: 0x38
	[SerializeField]
	private float size; //Field offset: 0x3C
	[SerializeField]
	private float itemSize; //Field offset: 0x40
	[SerializeField]
	private float itemSpacing; //Field offset: 0x44
	[CompilerGenerated]
	private bool <DragEnabled>k__BackingField; //Field offset: 0x48
	private bool _horizontalThresholdReached; //Field offset: 0x49
	private bool _verticalThresholdReached; //Field offset: 0x4A
	private float _horizontalNormalizedPosition; //Field offset: 0x4C
	[CompilerGenerated]
	private float <verticalNormalizedPosition>k__BackingField; //Field offset: 0x50
	private Vector2 positionAtDragStart; //Field offset: 0x54
	private float horizontalNormalizedPositionAtDragStart; //Field offset: 0x5C

	public override bool DragEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override float horizontalNormalizedPosition
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	private bool horizontalThresholdReached
	{
		private get { } //Length: 5
		private set { } //Length: 9
	}

	public override float verticalNormalizedPosition
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	private bool verticalThresholdReached
	{
		private get { } //Length: 5
		private set { } //Length: 91
	}

	public Scroller3D() { }

	public void AddChild(Transform child) { }

	private void BeginDragChild(Scrollable3DElement child, PointerEventData eventData) { }

	public override void CancelDrag() { }

	private void DoLayout() { }

	private void DragChild(Scrollable3DElement child, PointerEventData eventData) { }

	private void EndDragChild(Scrollable3DElement child, PointerEventData eventData) { }

	[CompilerGenerated]
	public override bool get_DragEnabled() { }

	public override float get_horizontalNormalizedPosition() { }

	private bool get_horizontalThresholdReached() { }

	[CompilerGenerated]
	public override float get_verticalNormalizedPosition() { }

	private bool get_verticalThresholdReached() { }

	private void LateUpdate() { }

	private void RemoveChild(Scrollable3DElement child) { }

	[CompilerGenerated]
	public override void set_DragEnabled(bool value) { }

	public override void set_horizontalNormalizedPosition(float value) { }

	private void set_horizontalThresholdReached(bool value) { }

	[CompilerGenerated]
	public override void set_verticalNormalizedPosition(float value) { }

	private void set_verticalThresholdReached(bool value) { }

	private void SetDirty() { }

}

