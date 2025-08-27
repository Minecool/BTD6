namespace UnityEngine.Purchasing;

internal class BillingClientStateListener : AndroidJavaProxy, IBillingClientStateListener
{
	private Action m_OnConnected; //Field offset: 0x20
	private Action<GoogleBillingResponseCode> m_Disconnect; //Field offset: 0x28

	internal BillingClientStateListener() { }

	[Preserve]
	public void onBillingServiceDisconnected() { }

	[Preserve]
	public void onBillingSetupFinished(AndroidJavaObject billingResult) { }

	public override void RegisterOnConnected(Action onConnected) { }

	public override void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected) { }

}

