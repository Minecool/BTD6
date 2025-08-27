namespace Assets.Scripts.Unity.Gamepad;

public class BTD6Gamepad : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Int32, WrappedGamepad>, Boolean> <>9__87_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<Int32, WrappedGamepad>, Int32> <>9__87_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetFreeDeviceID>b__87_0(KeyValuePair<Int32, WrappedGamepad> kv) { }

		internal int <GetFreeDeviceID>b__87_1(KeyValuePair<Int32, WrappedGamepad> kv) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public ExtendedPointerEventData extendedData; //Field offset: 0x10

		public <>c__DisplayClass65_0() { }

		internal bool <GetInput>b__0(BTD6Gamepad gamepad) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public int _deviceId; //Field offset: 0x10

		public <>c__DisplayClass86_0() { }

		internal bool <InputUpdate>b__0(Gamepad gp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_0
	{
		public KeyValuePair<Int32, WrappedGamepad> kv; //Field offset: 0x10

		public <>c__DisplayClass87_0() { }

		internal bool <GetFreeDeviceID>b__2(BTD6Gamepad i) { }

	}

	internal sealed class GameObjectChangedHandler : MulticastDelegate
	{

		public GameObjectChangedHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BTD6Gamepad inputMod, MultiplayerSelectable current, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BTD6Gamepad inputMod, MultiplayerSelectable current) { }

	}

	internal sealed class InputModeChangedHandler : MulticastDelegate
	{

		public InputModeChangedHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NKInputSystemUIInputModuleMode mode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NKInputSystemUIInputModuleMode mode) { }

	}

	internal sealed class OnButtonClicked : MulticastDelegate
	{

		public OnButtonClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GamepadInputType buttonCode, int userIndex, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GamepadInputType buttonCode, int userIndex) { }

	}

	internal sealed class OnMainPlayerInputChanged : MulticastDelegate
	{

		public OnMainPlayerInputChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BTD6Gamepad input, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BTD6Gamepad input) { }

	}

	private const int maxGamepads = 4; //Field offset: 0x0
	private const float navDeadZone = 0.9; //Field offset: 0x0
	public static readonly BTD6Gamepad[] all; //Field offset: 0x0
	private static readonly Dictionary<Int32, WrappedGamepad> allGamepads; //Field offset: 0x8
	private static int _mainUserIndex; //Field offset: 0x10
	[CompilerGenerated]
	private static int <multipleControlPadCount>k__BackingField; //Field offset: 0x14
	public static bool IsMultipleControlPadsEnabled; //Field offset: 0x18
	private static List<RaycastResult> m_RaycastResultCache; //Field offset: 0x20
	[SerializeField]
	private Transform rootTransform; //Field offset: 0x20
	[SerializeField]
	private Image cursorImage; //Field offset: 0x28
	[SerializeField]
	private Sprite cursorSprite; //Field offset: 0x30
	[SerializeField]
	private Sprite pressedCursorSprite; //Field offset: 0x38
	[SerializeField]
	public int userIndex; //Field offset: 0x40
	public int deviceID; //Field offset: 0x44
	public TickButton aButton; //Field offset: 0x48
	public TickButton bButton; //Field offset: 0x50
	public TickButton xButton; //Field offset: 0x58
	public TickButton YButton; //Field offset: 0x60
	public TickButton upTick; //Field offset: 0x68
	public TickButton downTick; //Field offset: 0x70
	public TickButton leftTick; //Field offset: 0x78
	public TickButton rightTick; //Field offset: 0x80
	public TickButton leftShoulderTick; //Field offset: 0x88
	public TickButton rightShoulderTick; //Field offset: 0x90
	public TickButton leftTriggerTick; //Field offset: 0x98
	public TickButton rightTriggerTick; //Field offset: 0xA0
	public TickButton leftStickButtonTick; //Field offset: 0xA8
	public TickButton rightStickButtonTick; //Field offset: 0xB0
	public TickButton[] tickButtons; //Field offset: 0xB8
	public NKInputSystemUIInputModuleMode mode; //Field offset: 0xC0
	public Vector2 virtualMousePos; //Field offset: 0xC4
	public bool isPressed; //Field offset: 0xCC
	public bool wasPressedThisFrame; //Field offset: 0xCD
	public bool wasReleasedThisFrame; //Field offset: 0xCE
	public float virtualMouseSpeed; //Field offset: 0xD0
	public bool radialMenuActive; //Field offset: 0xD4
	public bool towerPlacementMode; //Field offset: 0xD5
	private WrappedGamepad gamepad; //Field offset: 0xD8
	private bool isDPadNavEnabled; //Field offset: 0xE0
	private Rect mouseBounds; //Field offset: 0xE4
	private float slowMouseMove; //Field offset: 0xF4
	private MultiplayerEventSystem eventSystem; //Field offset: 0xF8
	private MultiplayerSelectable raycastTarget; //Field offset: 0x100
	private ExtendedPointerEventData eventData; //Field offset: 0x108
	private Vector2 prevLeftStick; //Field offset: 0x110
	private float refreshGamepadsCountdown; //Field offset: 0x118
	[CompilerGenerated]
	private MultiplayerSelectable <currentOverSel>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private GameObjectChangedHandler OnSelectedGameObjectChanged; //Field offset: 0x128
	private MultiplayerSelectable firstSelected; //Field offset: 0x130
	[CompilerGenerated]
	private InputModeChangedHandler InputModeChanged; //Field offset: 0x138
	private Vector2 customScrollAmount; //Field offset: 0x140
	private RectTransform customScrollTarget; //Field offset: 0x148
	private ScrollRect customScrollRect; //Field offset: 0x150
	private Vector2 customScrollSpeed; //Field offset: 0x158

	public event InputModeChangedHandler InputModeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GameObjectChangedHandler OnSelectedGameObjectChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public static int ActiveGamepadCount
	{
		 get { } //Length: 112
	}

	public MultiplayerSelectable currentOverSel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public static bool inTransition
	{
		 get { } //Length: 192
	}

	public static int multipleControlPadCount
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		 set { } //Length: 83
	}

	private static BTD6Gamepad() { }

	public BTD6Gamepad() { }

	[CompilerGenerated]
	public void add_InputModeChanged(InputModeChangedHandler value) { }

	[CompilerGenerated]
	public void add_OnSelectedGameObjectChanged(GameObjectChangedHandler value) { }

	private bool AnyVirtualMouse() { }

	public bool CanRaycast(GameObject target) { }

	private bool ClampVirualMousePos() { }

	protected static MultiplayerSelectable FindFirstRaycastSelectable(List<RaycastResult> candidates, NKInputSystemUIInputModuleMode mode, Transform root) { }

	public static void FlattenGamepads(Boolean[] active) { }

	public static int get_ActiveGamepadCount() { }

	[CompilerGenerated]
	public MultiplayerSelectable get_currentOverSel() { }

	public static bool get_inTransition() { }

	[CompilerGenerated]
	public static int get_multipleControlPadCount() { }

	public ButtonControl GetButton(GamepadInputType btn) { }

	public static ButtonControl GetButton(Gamepad gamepad, GamepadInputType btn) { }

	private int GetFreeDeviceID() { }

	public static string GetGameObjectPath(GameObject obj) { }

	public WrappedGamepad GetGamepad() { }

	private static WrappedGamepad GetGamepad(int _deviceID) { }

	private Vector2 GetGamepadAnchorPosition(RectTransform rt) { }

	public static BTD6Gamepad GetInput(PointerEventData pointerData) { }

	public static ControllerType GetMainPlayerControllerType() { }

	public static BTD6Gamepad GetMainPlayerInput() { }

	public void Init() { }

	public void InputUpdate() { }

	private static bool IsValidDeviceID(int id) { }

	private void navigate_started(MoveDirection moveDir, Vector2 dir) { }

	private void OnDisable() { }

	private void OnGUIX() { }

	private bool PointerShouldIgnoreTransform(Transform t) { }

	private void ProcessCustomScroll() { }

	private void ProcessPointerButton(ButtonControl btn, PointerEventData eventData) { }

	private bool ProcessPointerScroll(Vector2 scrollDelta, PointerEventData eventData) { }

	private MultiplayerSelectable Raycast() { }

	[CompilerGenerated]
	public void remove_InputModeChanged(InputModeChangedHandler value) { }

	[CompilerGenerated]
	public void remove_OnSelectedGameObjectChanged(GameObjectChangedHandler value) { }

	public static void ResetGamepads() { }

	[CompilerGenerated]
	public void set_currentOverSel(MultiplayerSelectable value) { }

	[CompilerGenerated]
	public static void set_multipleControlPadCount(int value) { }

	private void SetCursorActive(bool active) { }

	public void SetDPadNavEnabled(bool enabled) { }

	public static void SetMainUser(BTD6Gamepad mainUser) { }

	public static void SetMainUserIndex(int mainUserIndex) { }

	public void SetMode(NKInputSystemUIInputModuleMode mode) { }

	private void SetOver(MultiplayerSelectable mSel, bool isOver) { }

	private void SetOver(MultiplayerSelectable current) { }

	private void SetOverGameObject(GameObject current) { }

	public static void SetSelected(GameObject obj) { }

	private void SnapMouseToSelected() { }

	public void StartCustomVerticalScroll(RectTransform customScrollTarget) { }

	public void StopCustomScroll() { }

	private void UpdateJewelBar() { }

	private void UpdateVirtualMouse() { }

}

