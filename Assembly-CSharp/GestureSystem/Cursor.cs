namespace GestureSystem;

public abstract class Cursor
{
	private struct ButtonState
	{
		public bool isPressed; //Field offset: 0x0
		public float value; //Field offset: 0x4

	}

	private const float cursorSpeed = 36; //Field offset: 0x0
	[CompilerGenerated]
	private ControllerEventDelegate onMenuPressed; //Field offset: 0x10
	[CompilerGenerated]
	private ControllerEventDelegate onBackPressed; //Field offset: 0x18
	protected GameObject cursorObject; //Field offset: 0x20
	protected ClickState cursorState; //Field offset: 0x28
	protected Vector2 previousPosition; //Field offset: 0x2C
	protected Vector2 cursorPosition; //Field offset: 0x34
	protected GameObject currentObject; //Field offset: 0x40
	protected InputMode inputMode; //Field offset: 0x48
	private GCButton[] positiveActions; //Field offset: 0x50
	private bool controllerStateChanged; //Field offset: 0x58
	private Dictionary<GCButton, ButtonState> controllerState; //Field offset: 0x60
	protected List<RaycastResult> raycastResults; //Field offset: 0x68

	public override event ControllerEventDelegate onBackPressed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event ControllerEventDelegate onMenuPressed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override InputMode Mode
	{
		 get { } //Length: 4
	}

	public override Vector2 Position
	{
		 get { } //Length: 19
	}

	public override ClickState State
	{
		 get { } //Length: 4
	}

	protected Cursor() { }

	[CompilerGenerated]
	private void <Init>b__23_0() { }

	[CompilerGenerated]
	private void <Init>b__23_1() { }

	[CompilerGenerated]
	private void <Init>b__23_2(GCButton button, bool isPressed, float value) { }

	[CompilerGenerated]
	public override void add_onBackPressed(ControllerEventDelegate value) { }

	[CompilerGenerated]
	public override void add_onMenuPressed(ControllerEventDelegate value) { }

	private static bool AnythingPressed(Dictionary<GCButton, ButtonState> controllerState) { }

	protected Vector2 ClampToScreen(Vector2 pos) { }

	protected void ExecuteEvent(GameObject receiver, EventFunction<T> eventHandler) { }

	public override InputMode get_Mode() { }

	public override Vector2 get_Position() { }

	public override ClickState get_State() { }

	protected GameObject GetObjectUnderCursor() { }

	public override void Hide() { }

	public override void Init(GameObject prefab, Transform parent) { }

	protected PointerEventData NewPointerEventAtCurrPosition() { }

	public void OnBackPressed() { }

	protected abstract void OnSwitchedInputMode(InputMode mode) { }

	protected void PerformCursorMove() { }

	private void PerformSelectionForButtons() { }

	[CompilerGenerated]
	public override void remove_onBackPressed(ControllerEventDelegate value) { }

	[CompilerGenerated]
	public override void remove_onMenuPressed(ControllerEventDelegate value) { }

	public override void Reveal() { }

	protected void SwitchInputMode(InputMode mode) { }

	public abstract void Update() { }

	protected bool UpdateGameController() { }

}

