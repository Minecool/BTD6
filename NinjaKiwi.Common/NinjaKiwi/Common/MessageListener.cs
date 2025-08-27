namespace NinjaKiwi.Common;

[AddComponentMenu(null)]
internal class MessageListener : MonoBehaviour
{
	private List<Action> onDestroyActions; //Field offset: 0x20
	private List<Action> onEnableActions; //Field offset: 0x28
	private List<Action> onDisableActions; //Field offset: 0x30

	public MessageListener() { }

	internal static void ListenWhileActive(GameObject gameObject, Action register, Action unregister) { }

	internal static void ListenWhileAlive(GameObject gameObject, Action register, Action unregister) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

}

