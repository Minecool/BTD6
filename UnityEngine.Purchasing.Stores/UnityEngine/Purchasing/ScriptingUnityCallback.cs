namespace UnityEngine.Purchasing;

internal class ScriptingUnityCallback : IUnityCallback
{
	private readonly IUnityCallback forwardTo; //Field offset: 0x10
	private readonly IUtil util; //Field offset: 0x18

	public ScriptingUnityCallback(IUnityCallback forwardTo, IUtil util) { }

}

