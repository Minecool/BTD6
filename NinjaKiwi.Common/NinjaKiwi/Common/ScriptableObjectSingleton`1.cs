namespace NinjaKiwi.Common;

public abstract class ScriptableObjectSingleton : ScriptableObject
{
	protected static T _instance; //Field offset: 0x0

	public static T Instance
	{
		 get { } //Length: 396
	}

	protected ScriptableObjectSingleton`1() { }

	public static T get_Instance() { }

}

