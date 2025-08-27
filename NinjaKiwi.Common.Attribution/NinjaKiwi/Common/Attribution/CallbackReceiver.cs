namespace NinjaKiwi.Common.Attribution;

public class CallbackReceiver : MonoBehaviour
{
	private Action<String> callback; //Field offset: 0x20

	public CallbackReceiver() { }

	public void InstallCallback(Action<String> callback) { }

	private void StringCallback(string str) { }

}

