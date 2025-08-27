namespace UnityEngine.Purchasing;

internal class LegacyAnalyticsAdapter : IAnalyticsAdapter
{
	private readonly ILegacyUnityAnalytics m_LegacyAnalytics; //Field offset: 0x10

	public LegacyAnalyticsAdapter(ILegacyUnityAnalytics legacyAnalytics) { }

	public override void SendTransactionEvent(Product product) { }

	public override void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

}

