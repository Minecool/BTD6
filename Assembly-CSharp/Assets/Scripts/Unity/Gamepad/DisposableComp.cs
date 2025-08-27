namespace Assets.Scripts.Unity.Gamepad;

[AddComponentMenu(null)]
public class DisposableComp : MonoBehaviour
{
	private readonly List<Action> disposeActions; //Field offset: 0x20

	public DisposableComp() { }

	private void OnDestroy() { }

	public static void Register(Component component, Action disposeAction) { }

}

