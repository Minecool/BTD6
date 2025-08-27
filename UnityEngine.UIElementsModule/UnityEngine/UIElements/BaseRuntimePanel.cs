namespace UnityEngine.UIElements;

internal abstract class BaseRuntimePanel : Panel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Vector2 <.cctor>b__52_0(Vector2 p) { }

	}

	private static int s_CurrentRuntimePanelCounter; //Field offset: 0x0
	internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace; //Field offset: 0x8
	private GameObject m_SelectableGameObject; //Field offset: 0x1B8
	internal readonly int m_RuntimePanelCreationIndex; //Field offset: 0x1C0
	private float m_SortingPriority; //Field offset: 0x1C4
	internal int resolvedSortingIndex; //Field offset: 0x1C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action destroyed; //Field offset: 0x1D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action drawsInCamerasChanged; //Field offset: 0x1D8
	private bool m_DrawsInCameras; //Field offset: 0x1E0
	private float m_PixelsPerUnit; //Field offset: 0x1E4
	internal RenderTexture targetTexture; //Field offset: 0x1E8
	internal int worldSpaceLayer; //Field offset: 0x1F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <targetDisplay>k__BackingField; //Field offset: 0x1F4
	private Func<Vector2, Vector2> m_ScreenToPanelSpace; //Field offset: 0x1F8

	public event Action destroyed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	internal event Action drawsInCamerasChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 158
		[CompilerGenerated]
		internal remove { } //Length: 158
	}

	internal bool drawsInCameras
	{
		internal get { } //Length: 10
		internal set { } //Length: 46
	}

	internal float pixelsPerUnit
	{
		internal get { } //Length: 11
		internal set { } //Length: 9
	}

	internal int screenRenderingHeight
	{
		internal get { } //Length: 78
	}

	internal int screenRenderingWidth
	{
		internal get { } //Length: 78
	}

	public Func<Vector2, Vector2> screenToPanelSpace
	{
		 get { } //Length: 8
		 set { } //Length: 118
	}

	public override GameObject selectableGameObject
	{
		 get { } //Length: 8
		 set { } //Length: 145
	}

	public float sortingPriority
	{
		 get { } //Length: 9
		 set { } //Length: 140
	}

	internal int targetDisplay
	{
		[CompilerGenerated]
		internal get { } //Length: 7
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	private static BaseRuntimePanel() { }

	protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null) { }

	[CompilerGenerated]
	public void add_destroyed(Action value) { }

	[CompilerGenerated]
	internal void add_drawsInCamerasChanged(Action value) { }

	private void AssignPanelToComponents(BaseRuntimePanel panel) { }

	protected virtual void Dispose(bool disposing) { }

	internal bool get_drawsInCameras() { }

	internal float get_pixelsPerUnit() { }

	internal int get_screenRenderingHeight() { }

	internal int get_screenRenderingWidth() { }

	public Func<Vector2, Vector2> get_screenToPanelSpace() { }

	public override GameObject get_selectableGameObject() { }

	public float get_sortingPriority() { }

	[CompilerGenerated]
	internal int get_targetDisplay() { }

	internal static int getScreenRenderingHeight(int display) { }

	internal static int getScreenRenderingWidth(int display) { }

	private void InvokeDrawsInCamerasChanged() { }

	internal void PointerEntersPanel(int pointerId, Vector2 position) { }

	internal void PointerLeavesPanel(int pointerId, Vector2 position) { }

	[CompilerGenerated]
	public void remove_destroyed(Action value) { }

	[CompilerGenerated]
	internal void remove_drawsInCamerasChanged(Action value) { }

	public virtual void Render() { }

	internal Vector2 ScreenToPanel(Vector2 screen) { }

	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false) { }

	internal void set_drawsInCameras(bool value) { }

	internal void set_pixelsPerUnit(float value) { }

	public void set_screenToPanelSpace(Func<Vector2, Vector2> value) { }

	public override void set_selectableGameObject(GameObject value) { }

	public void set_sortingPriority(float value) { }

	[CompilerGenerated]
	internal void set_targetDisplay(int value) { }

	internal override void Update() { }

}

