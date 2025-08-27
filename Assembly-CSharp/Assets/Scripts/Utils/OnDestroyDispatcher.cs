namespace Assets.Scripts.Utils;

public class OnDestroyDispatcher : MonoBehaviour
{
	[CompilerGenerated]
	private Action<GameObject> OnObjectDestroyed; //Field offset: 0x20

	public event Action<GameObject> OnObjectDestroyed
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public OnDestroyDispatcher() { }

	[CompilerGenerated]
	public void add_OnObjectDestroyed(Action<GameObject> value) { }

	private void OnDestroy() { }

	[CompilerGenerated]
	public void remove_OnObjectDestroyed(Action<GameObject> value) { }

}

