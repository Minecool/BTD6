namespace UnityEngine.InputSystem.Plugins.InputForUI;

internal class InputSystemProvider : IEventProviderImpl
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Event> <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Update>b__33_0(Event a, Event b) { }

	}

	internal static class Actions
	{
		public static readonly string PointAction; //Field offset: 0x0
		public static readonly string MoveAction; //Field offset: 0x8
		public static readonly string SubmitAction; //Field offset: 0x10
		public static readonly string CancelAction; //Field offset: 0x18
		public static readonly string LeftClickAction; //Field offset: 0x20
		public static readonly string MiddleClickAction; //Field offset: 0x28
		public static readonly string RightClickAction; //Field offset: 0x30
		public static readonly string ScrollWheelAction; //Field offset: 0x38

		private static Actions() { }

	}

	private static Action<InputActionAsset> s_OnRegisterActions; //Field offset: 0x0
	private InputEventPartialProvider m_InputEventPartialProvider; //Field offset: 0x10
	private DefaultInputActions m_DefaultInputActions; //Field offset: 0x18
	private InputActionAsset m_InputActionAsset; //Field offset: 0x20
	private InputActionReference m_PointAction; //Field offset: 0x28
	private InputActionReference m_MoveAction; //Field offset: 0x30
	private InputActionReference m_SubmitAction; //Field offset: 0x38
	private InputActionReference m_CancelAction; //Field offset: 0x40
	private InputActionReference m_LeftClickAction; //Field offset: 0x48
	private InputActionReference m_MiddleClickAction; //Field offset: 0x50
	private InputActionReference m_RightClickAction; //Field offset: 0x58
	private InputActionReference m_ScrollWheelAction; //Field offset: 0x60
	private InputAction m_NextPreviousAction; //Field offset: 0x68
	private List<Event> m_Events; //Field offset: 0x70
	private PointerState m_MouseState; //Field offset: 0x78
	private PointerState m_PenState; //Field offset: 0xA0
	private bool m_SeenPenEvents; //Field offset: 0xC8
	private PointerState m_TouchState; //Field offset: 0xD0
	private bool m_SeenTouchEvents; //Field offset: 0xF8
	private NavigationEventRepeatHelper m_RepeatHelper; //Field offset: 0x100
	private bool m_ResetSeenEventsOnUpdate; //Field offset: 0x108

	private DiscreteTime m_CurrentTime
	{
		private get { } //Length: 41
	}

	private EventModifiers m_EventModifiers
	{
		private get { } //Length: 26
	}

	private static InputSystemProvider() { }

	public InputSystemProvider() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void Bootstrap() { }

	private void DirectionNavigation(DiscreteTime currentTime) { }

	private void DispatchFromCallback(in Event ev) { }

	private static int FindTouchFingerIndex(Touchscreen touchscreen, CallbackContext ctx) { }

	private DiscreteTime get_m_CurrentTime() { }

	private EventModifiers get_m_EventModifiers() { }

	private InputDevice GetActiveDeviceFromDirection(Direction direction) { }

	private EventSource GetEventSource(CallbackContext ctx) { }

	private EventSource GetEventSource(InputDevice device) { }

	private PointerState GetPointerStateForSource(EventSource eventSource) { }

	public override void Initialize() { }

	public void OnActionsChange() { }

	private void OnCancelPerformed(CallbackContext ctx) { }

	private void OnClickPerformed(CallbackContext ctx, EventSource eventSource, Button button) { }

	public override void OnFocusChanged(bool focus) { }

	private void OnLeftClickPerformed(CallbackContext ctx) { }

	private void OnMiddleClickPerformed(CallbackContext ctx) { }

	private void OnPointerPerformed(CallbackContext ctx) { }

	private void OnRightClickPerformed(CallbackContext ctx) { }

	private void OnScrollWheelPerformed(CallbackContext ctx) { }

	private void OnSubmitPerformed(CallbackContext ctx) { }

	private ValueTuple<Vector2, Boolean> ReadCurrentNavigationMoveVector() { }

	private Direction ReadNextPreviousDirection() { }

	private void RegisterActions() { }

	private void RegisterFixedActions() { }

	private void ResetSeenEvents() { }

	private static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	private void SelectInputActionAsset() { }

	public override void Shutdown() { }

	private static int SortEvents(Event a, Event b) { }

	private void UnregisterActions() { }

	private void UnregisterFixedActions() { }

	public override void Update() { }

}

