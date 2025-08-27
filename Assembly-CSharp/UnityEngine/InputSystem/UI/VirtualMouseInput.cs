namespace UnityEngine.InputSystem.UI;

[AddComponentMenu("Input/Virtual Mouse")]
public class VirtualMouseInput : MonoBehaviour
{
	internal enum CursorMode
	{
		SoftwareCursor = 0,
		HardwareCursorIfAvailable = 1,
	}

	[Header("Cursor")]
	[SerializeField]
	private CursorMode m_CursorMode; //Field offset: 0x20
	[SerializeField]
	private Graphic m_CursorGraphic; //Field offset: 0x28
	[SerializeField]
	private RectTransform m_CursorTransform; //Field offset: 0x30
	[Header("Motion")]
	[SerializeField]
	private float m_CursorSpeed; //Field offset: 0x38
	[SerializeField]
	private float m_ScrollSpeed; //Field offset: 0x3C
	[SerializeField]
	[Space(10)]
	private InputActionProperty m_StickAction; //Field offset: 0x40
	[SerializeField]
	private InputActionProperty m_LeftButtonAction; //Field offset: 0x58
	[SerializeField]
	private InputActionProperty m_MiddleButtonAction; //Field offset: 0x70
	[SerializeField]
	private InputActionProperty m_RightButtonAction; //Field offset: 0x88
	[SerializeField]
	private InputActionProperty m_ForwardButtonAction; //Field offset: 0xA0
	[SerializeField]
	private InputActionProperty m_BackButtonAction; //Field offset: 0xB8
	[SerializeField]
	private InputActionProperty m_ScrollWheelAction; //Field offset: 0xD0
	private Canvas m_Canvas; //Field offset: 0xE8
	private Mouse m_VirtualMouse; //Field offset: 0xF0
	private Mouse m_SystemMouse; //Field offset: 0xF8
	private Action m_AfterInputUpdateDelegate; //Field offset: 0x100
	private Action<CallbackContext> m_ButtonActionTriggeredDelegate; //Field offset: 0x108
	private double m_LastTime; //Field offset: 0x110
	private Vector2 m_LastStickValue; //Field offset: 0x118

	public InputActionProperty backButtonAction
	{
		 get { } //Length: 27
		 set { } //Length: 268
	}

	public Graphic cursorGraphic
	{
		 get { } //Length: 5
		 set { } //Length: 92
	}

	public CursorMode cursorMode
	{
		 get { } //Length: 4
		 set { } //Length: 244
	}

	public float cursorSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public RectTransform cursorTransform
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public InputActionProperty forwardButtonAction
	{
		 get { } //Length: 27
		 set { } //Length: 268
	}

	public InputActionProperty leftButtonAction
	{
		 get { } //Length: 21
		 set { } //Length: 253
	}

	public InputActionProperty middleButtonAction
	{
		 get { } //Length: 24
		 set { } //Length: 259
	}

	public InputActionProperty rightButtonAction
	{
		 get { } //Length: 27
		 set { } //Length: 268
	}

	public float scrollSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public InputActionProperty scrollWheelAction
	{
		 get { } //Length: 27
		 set { } //Length: 48
	}

	public InputActionProperty stickAction
	{
		 get { } //Length: 21
		 set { } //Length: 45
	}

	public Mouse virtualMouse
	{
		 get { } //Length: 8
	}

	public VirtualMouseInput() { }

	public InputActionProperty get_backButtonAction() { }

	public Graphic get_cursorGraphic() { }

	public CursorMode get_cursorMode() { }

	public float get_cursorSpeed() { }

	public RectTransform get_cursorTransform() { }

	public InputActionProperty get_forwardButtonAction() { }

	public InputActionProperty get_leftButtonAction() { }

	public InputActionProperty get_middleButtonAction() { }

	public InputActionProperty get_rightButtonAction() { }

	public float get_scrollSpeed() { }

	public InputActionProperty get_scrollWheelAction() { }

	public InputActionProperty get_stickAction() { }

	public Mouse get_virtualMouse() { }

	private void OnAfterInputUpdate() { }

	private void OnButtonActionTriggered(CallbackContext context) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	public void set_backButtonAction(InputActionProperty value) { }

	public void set_cursorGraphic(Graphic value) { }

	public void set_cursorMode(CursorMode value) { }

	public void set_cursorSpeed(float value) { }

	public void set_cursorTransform(RectTransform value) { }

	public void set_forwardButtonAction(InputActionProperty value) { }

	public void set_leftButtonAction(InputActionProperty value) { }

	public void set_middleButtonAction(InputActionProperty value) { }

	public void set_rightButtonAction(InputActionProperty value) { }

	public void set_scrollSpeed(float value) { }

	public void set_scrollWheelAction(InputActionProperty value) { }

	public void set_stickAction(InputActionProperty value) { }

	private static void SetAction(ref InputActionProperty field, InputActionProperty value) { }

	private static void SetActionCallback(InputActionProperty field, Action<CallbackContext> callback, bool install = true) { }

	public void SetVirtualCursorEnabled(bool enabled) { }

	private void TryEnableHardwareCursor() { }

	private void TryFindCanvas() { }

	private void UpdateMotion() { }

}

