namespace NinjaKiwi.Common;

public abstract class MonoBehaviourSingleton : MonoBehaviour
{
	private static object _lock; //Field offset: 0x0
	private static T _instance; //Field offset: 0x0

	public static T Instance
	{
		 get { } //Length: 1071
	}

	private static MonoBehaviourSingleton`1() { }

	protected MonoBehaviourSingleton`1() { }

	protected override void Awake() { }

	public static T get_Instance() { }

	protected override void OnApplicationQuit() { }

}

