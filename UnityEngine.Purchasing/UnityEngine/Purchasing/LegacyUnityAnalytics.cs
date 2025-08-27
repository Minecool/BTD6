namespace UnityEngine.Purchasing;

internal class LegacyUnityAnalytics : ILegacyUnityAnalytics
{

	public LegacyUnityAnalytics() { }

	public override void SendCustomEvent(string name, Dictionary<String, Object> data) { }

	public override void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature) { }

}

