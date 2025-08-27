namespace Assets.Scripts.Utils.Messaging;

public static class BridgeMessagingUtils
{
	internal sealed class OnSimulationClearedWithoutQuit : MulticastDelegate
	{

		public OnSimulationClearedWithoutQuit(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public static OnSimulationClearedWithoutQuit OnSimulationClearedWithoutQuitCallback; //Field offset: 0x0
	private static Dictionary<Type, Action> cleanupDelegates; //Field offset: 0x8

	public static void CleanupAll() { }

	public static void RegisterCleanupDelegate(Action cleanupDelegate) { }

	public static void UnregisterCleanupDelegate() { }

}

