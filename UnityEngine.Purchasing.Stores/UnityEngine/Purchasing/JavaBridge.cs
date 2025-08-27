namespace UnityEngine.Purchasing;

internal class JavaBridge : AndroidJavaProxy, IUnityCallback
{
	private readonly IUnityCallback forwardTo; //Field offset: 0x20

	public JavaBridge(IUnityCallback forwardTo) { }

}

