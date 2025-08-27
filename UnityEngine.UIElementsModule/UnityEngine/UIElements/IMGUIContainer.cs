namespace UnityEngine.UIElements;

public class IMGUIContainer : VisualElement, IDisposable
{
	private struct GUIGlobals
	{
		public Matrix4x4 matrix; //Field offset: 0x0
		public Color color; //Field offset: 0x40
		public Color contentColor; //Field offset: 0x50
		public Color backgroundColor; //Field offset: 0x60
		public bool enabled; //Field offset: 0x70
		public bool changed; //Field offset: 0x71
		public int displayIndex; //Field offset: 0x74
		public float pixelsPerPoint; //Field offset: 0x78

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	internal static readonly BindingId cullingEnabledProperty; //Field offset: 0x0
	internal static readonly BindingId contextTypeProperty; //Field offset: 0x98
	public static readonly string ussClassName; //Field offset: 0x130
	internal static readonly string ussFoldoutChildDepthClassName; //Field offset: 0x138
	internal static readonly List<String> ussFoldoutChildDepthClassNames; //Field offset: 0x140
	private static readonly ProfilerMarker k_OnGUIMarker; //Field offset: 0x148
	private static readonly ProfilerMarker k_ImmediateCallbackMarker; //Field offset: 0x150
	private static Event s_DefaultMeasureEvent; //Field offset: 0x158
	private static Event s_MeasureEvent; //Field offset: 0x160
	private static Event s_CurrentEvent; //Field offset: 0x168
	private Action m_OnGUIHandler; //Field offset: 0x4A8
	private ObjectGUIState m_ObjectGUIState; //Field offset: 0x4B0
	internal bool useOwnerObjectGUIState; //Field offset: 0x4B8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Rect <lastWorldClip>k__BackingField; //Field offset: 0x4BC
	private bool m_CullingEnabled; //Field offset: 0x4CC
	private bool m_IsFocusDelegated; //Field offset: 0x4CD
	private bool m_RefreshCachedLayout; //Field offset: 0x4CE
	private LayoutCache m_Cache; //Field offset: 0x4D0
	private Rect m_CachedClippingRect; //Field offset: 0x4D8
	private Matrix4x4 m_CachedTransform; //Field offset: 0x4E8
	private ContextType m_ContextType; //Field offset: 0x528
	private bool lostFocus; //Field offset: 0x52C
	private bool receivedFocus; //Field offset: 0x52D
	private FocusChangeDirection focusChangeDirection; //Field offset: 0x530
	private bool hasFocusableControls; //Field offset: 0x538
	private int newKeyboardFocusControlID; //Field offset: 0x53C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; //Field offset: 0x540
	private GUIGlobals m_GUIGlobals; //Field offset: 0x544

	private LayoutCache cache
	{
		private get { } //Length: 116
	}

	public virtual bool canGrabFocus
	{
		 get { } //Length: 41
	}

	[CreateProperty]
	public ContextType contextType
	{
		 get { } //Length: 7
		 set { } //Length: 124
	}

	[CreateProperty]
	public bool cullingEnabled
	{
		 get { } //Length: 10
		 set { } //Length: 136
	}

	internal bool focusOnlyIfHasFocusableControls
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal ObjectGUIState guiState
	{
		internal get { } //Length: 187
	}

	internal Rect lastWorldClip
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 11
	}

	private float layoutMeasuredHeight
	{
		private get { } //Length: 44
	}

	private float layoutMeasuredWidth
	{
		private get { } //Length: 44
	}

	public Action onGUIHandler
	{
		 get { } //Length: 10
		 set { } //Length: 84
	}

	private static IMGUIContainer() { }

	public IMGUIContainer(Action onGUIHandler) { }

	public IMGUIContainer() { }

	[CompilerGenerated]
	private void <DoOnGUI>b__59_0() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposeManaged) { }

	private void DoIMGUIRepaint() { }

	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true) { }

	private LayoutCache get_cache() { }

	public virtual bool get_canGrabFocus() { }

	public ContextType get_contextType() { }

	public bool get_cullingEnabled() { }

	[CompilerGenerated]
	internal bool get_focusOnlyIfHasFocusableControls() { }

	internal ObjectGUIState get_guiState() { }

	[CompilerGenerated]
	internal Rect get_lastWorldClip() { }

	private float get_layoutMeasuredHeight() { }

	private float get_layoutMeasuredWidth() { }

	public Action get_onGUIHandler() { }

	private Rect GetCurrentClipRect() { }

	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent)}])]
	[EventInterest(EventInterestOptionsInternal::TriggeredByOS (426094))]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[EventInterest(EventInterestOptionsInternal::TriggeredByOS (426094))]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent)}])]
	internal virtual void HandleEventBubbleUpDisabled(EventBase evt) { }

	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	private bool IsContainerCapturingTheMouse() { }

	private static bool IsDockAreaMouseUp(EventBase evt) { }

	private bool IsEventInsideLocalWindow(EventBase evt) { }

	private bool IsLocalEvent(EventBase evt) { }

	public void MarkDirtyLayout() { }

	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	private void RestoreGlobals() { }

	private void SaveGlobals() { }

	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true) { }

	private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	public void set_contextType(ContextType value) { }

	public void set_cullingEnabled(bool value) { }

	[CompilerGenerated]
	internal void set_lastWorldClip(Rect value) { }

	public void set_onGUIHandler(Action value) { }

	private void SetFoldoutDepthClass() { }

	private bool VerifyBounds(EventBase evt) { }

}

