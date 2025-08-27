namespace UnityEngine.Purchasing;

internal class GoogleConsumeResponseListener : AndroidJavaProxy
{
	private readonly Action<IGoogleBillingResult> m_OnConsumeResponse; //Field offset: 0x20

	internal GoogleConsumeResponseListener(Action<IGoogleBillingResult> onConsumeResponseAction) { }

	[Preserve]
	private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken) { }

}

