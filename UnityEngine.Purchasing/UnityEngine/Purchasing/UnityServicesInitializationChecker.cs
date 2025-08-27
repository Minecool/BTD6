namespace UnityEngine.Purchasing;

internal class UnityServicesInitializationChecker : IUnityServicesInitializationChecker
{
	private readonly ILogger m_Logger; //Field offset: 0x10

	public UnityServicesInitializationChecker(ILogger logger) { }

	public override void CheckAndLogWarning() { }

	private bool IsUninitialized() { }

	private void LogWarning() { }

}

