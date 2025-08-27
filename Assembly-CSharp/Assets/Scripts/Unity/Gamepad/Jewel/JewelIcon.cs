namespace Assets.Scripts.Unity.Gamepad.Jewel;

[RequireComponent(typeof(Image))]
public class JewelIcon : MonoBehaviour
{
	[SerializeField]
	private GamepadInputType buttonCode; //Field offset: 0x20

	public JewelIcon() { }

	private void Start() { }

}

