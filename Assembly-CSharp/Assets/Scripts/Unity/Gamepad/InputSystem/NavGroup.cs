namespace Assets.Scripts.Unity.Gamepad.InputSystem;

public class NavGroup : MonoBehaviour
{
	public NavGroupDirection direction; //Field offset: 0x20

	public NavGroup() { }

	private static NavGroup Register(GameObject target, NavGroupDirection dir, Selectable[] buttons) { }

	private static NavGroup Register(GameObject target, NavGroupDirection dir, GameObject[] buttons) { }

	public static NavGroup Register(NavGroupDirection dir, GameObject[] buttons) { }

	public static NavGroup RegisterHorizontal(GameObject container) { }

	public static NavGroup RegisterVertical(GameObject container) { }

}

