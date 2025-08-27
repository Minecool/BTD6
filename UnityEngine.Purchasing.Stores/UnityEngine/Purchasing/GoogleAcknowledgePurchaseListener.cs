namespace UnityEngine.Purchasing;

internal class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
{
	private readonly Action<IGoogleBillingResult> m_OnAcknowledgePurchaseResponse; //Field offset: 0x20

	internal GoogleAcknowledgePurchaseListener(Action<IGoogleBillingResult> onAcknowledgePurchaseResponseAction) { }

	[Preserve]
	private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult) { }

}

