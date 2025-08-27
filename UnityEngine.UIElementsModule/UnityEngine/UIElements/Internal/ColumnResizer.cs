namespace UnityEngine.UIElements.Internal;

internal class ColumnResizer : PointerManipulator
{
	private Vector2 m_Start; //Field offset: 0x28
	protected bool m_Active; //Field offset: 0x30
	private bool m_Resizing; //Field offset: 0x31
	private MultiColumnCollectionHeader m_Header; //Field offset: 0x38
	private Column m_Column; //Field offset: 0x40
	private VisualElement m_PreviewElement; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ColumnLayout <columnLayout>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <preview>k__BackingField; //Field offset: 0x58

	public ColumnLayout columnLayout
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool preview
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ColumnResizer(Column column) { }

	private void BeginDragResize(float pos) { }

	private void DragResize(float pos) { }

	private void EndDragResize(float pos, bool cancelled) { }

	[CompilerGenerated]
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	public bool get_preview() { }

	private void OnKeyDown(KeyDownEvent e) { }

	private void OnPointerDown(PointerDownEvent e) { }

	private void OnPointerMove(PointerMoveEvent e) { }

	private void OnPointerUp(PointerUpEvent e) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	[CompilerGenerated]
	public void set_columnLayout(ColumnLayout value) { }

	[CompilerGenerated]
	public void set_preview(bool value) { }

	protected virtual void UnregisterCallbacksFromTarget() { }

	private void UpdatePreviewPosition() { }

}

