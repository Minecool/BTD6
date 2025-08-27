namespace UnityEngine.Purchasing;

internal class CoreServicesEnvironmentSubject
{
	private static CoreServicesEnvironmentSubject s_Instance; //Field offset: 0x0
	private string m_LastKnownEnvironment; //Field offset: 0x10
	private List<ICoreServicesEnvironmentObserver> m_Observers; //Field offset: 0x18

	public CoreServicesEnvironmentSubject() { }

	internal static CoreServicesEnvironmentSubject Instance() { }

	internal bool IsDefaultLiveEnvironment(string environment) { }

	private void NotifyObservers() { }

	public void SubscribeToUpdatesAndGetCurrent(ICoreServicesEnvironmentObserver newObserver) { }

	internal void UpdateCurrentEnvironment(string currentEnvironment) { }

}

