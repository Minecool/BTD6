namespace Assets.Scripts.Unity.Gamepad;

public class TickButton
{
	private const float startRepeatDuration = 0.5; //Field offset: 0x0
	private const float repeatDuration = 0.1; //Field offset: 0x0
	[CompilerGenerated]
	private readonly GamepadInputType <ButtonCode>k__BackingField; //Field offset: 0x10
	private float startRepeatCountdown; //Field offset: 0x14
	private float repeatCountdown; //Field offset: 0x18
	public bool wasRepeatPressedThisFrame; //Field offset: 0x1C

	public GamepadInputType ButtonCode
	{
		[CompilerGenerated]
		 get { } //Length: 94
	}

	public TickButton(GamepadInputType buttonCode) { }

	[CompilerGenerated]
	public GamepadInputType get_ButtonCode() { }

	public bool Update(float dt, Gamepad gamepad) { }

	public bool Update(float dt, Gamepad gamepad, bool prevPressed, bool pressed) { }

	private bool Update(float dt, bool wasPressedThisFrame, bool wasReleasedThisFrame, bool isPressed) { }

}

