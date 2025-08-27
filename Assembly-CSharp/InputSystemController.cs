//Type is in global namespace

public class InputSystemController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Action<InputSystemMode> onChange; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal void <SubscribeToModeChanged>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public Action onSet; //Field offset: 0x10
		public Action<InputSystemMode> callback; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <SubscribeToGamepadModeSet>b__0(InputSystemMode x) { }

		internal void <SubscribeToGamepadModeSet>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public Action<GameObject> onChange; //Field offset: 0x10

		public <>c__DisplayClass33_0() { }

		internal void <SubscribeSelectedGameObjectChanged>b__0() { }

	}

	[CompilerGenerated]
	private static InputSystemController <instance>k__BackingField; //Field offset: 0x0
	public static bool virtualMouseHack; //Field offset: 0x8
	public InputSystemMode mode; //Field offset: 0x20
	public Btd6ActionMap actionMap; //Field offset: 0x28
	private GameObject prevSel; //Field offset: 0x30
	public StandaloneInputModule standaloneInputModule; //Field offset: 0x38
	public InputSystemUIInputModule inputSystemUIInputModule; //Field offset: 0x40
	[CompilerGenerated]
	private Action<InputSystemMode> ModeChanged; //Field offset: 0x48
	[CompilerGenerated]
	private Action<GameObject> SelectedGameObjectChanged; //Field offset: 0x50
	private int triggerModeChangedCountdown; //Field offset: 0x58

	public event Action<InputSystemMode> ModeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<GameObject> SelectedGameObjectChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	private EventSystem es
	{
		private get { } //Length: 64
	}

	public private static InputSystemController instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	public static Vector2 MousePosition
	{
		 get { } //Length: 213
	}

	public static Vector2 MousePositionNormalized
	{
		 get { } //Length: 328
	}

	public GameObject SelectedGameObject
	{
		 get { } //Length: 79
		 set { } //Length: 317
	}

	public static int TouchCount
	{
		 get { } //Length: 35
	}

	public InputSystemController() { }

	[CompilerGenerated]
	private void <Awake>b__38_0(InputControl ic) { }

	[CompilerGenerated]
	public void add_ModeChanged(Action<InputSystemMode> value) { }

	[CompilerGenerated]
	public void add_SelectedGameObjectChanged(Action<GameObject> value) { }

	private void Awake() { }

	private EventSystem get_es() { }

	[CompilerGenerated]
	public static InputSystemController get_instance() { }

	public static Vector2 get_MousePosition() { }

	public static Vector2 get_MousePositionNormalized() { }

	public GameObject get_SelectedGameObject() { }

	public static int get_TouchCount() { }

	public static bool GetMouseButton(int button = 0) { }

	public static bool GetMouseButtonDown(int button = 0) { }

	public static bool GetMouseButtonUp(int button = 0) { }

	public static void Initialize(InputSystemController prefab) { }

	private void LateUpdate() { }

	[CompilerGenerated]
	public void remove_ModeChanged(Action<InputSystemMode> value) { }

	[CompilerGenerated]
	public void remove_SelectedGameObjectChanged(Action<GameObject> value) { }

	[CompilerGenerated]
	private static void set_instance(InputSystemController value) { }

	public void set_SelectedGameObject(GameObject value) { }

	private void SetMode(InputSystemMode mode, bool setCursorVisiblity = true) { }

	public static void SubscribeSelectedGameObjectChanged(Component component, Action<GameObject> onChange) { }

	public static void SubscribeToGamepadModeSet(Component component, Action onSet) { }

	public static void SubscribeToModeChanged(Component component, Action<InputSystemMode> onChange) { }

	private void Update() { }

}

