namespace Assets.Scripts.Unity.Gamepad;

public class WrappedGamepad
{
	private const float hackDeadzone = 0.25; //Field offset: 0x0
	public readonly Gamepad gamepad; //Field offset: 0x10
	public bool btd6Activated; //Field offset: 0x18
	public readonly ControllerType controllerType; //Field offset: 0x1C

	public int deviceId
	{
		 get { } //Length: 373
	}

	public WrappedGamepad(Gamepad gamepad) { }

	public void ActivatedTest() { }

	private static ControllerType DetermineControllerType(Gamepad gamepad) { }

	public int get_deviceId() { }

	private static float HackClampAxis(float value) { }

	private Vector2 HackClampAxis(Vector2 value) { }

	public Vector2 HackReadLeftAxis() { }

	public Vector2 HackReadRightAxis() { }

}

