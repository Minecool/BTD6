namespace Assets.Scripts.Unity.Gamepad;

[AddComponentMenu(null)]
public class GamepadButtonImage : MonoBehaviour
{
	private GamepadInputType buttonCode; //Field offset: 0x20
	private Image image; //Field offset: 0x28

	public GamepadButtonImage() { }

	private void Awake() { }

	private void Configure(GamepadInputType buttonCode, Image image) { }

	public static void Register(GamepadInputType buttonCode, Image image) { }

	private void UpdateImage(BTD6Gamepad _ = null) { }

}

