namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class CoreAnalyticsAdapter : IAnalyticsAdapter
{
	private readonly IAnalyticsService m_Analytics; //Field offset: 0x10
	private readonly ILogger m_Logger; //Field offset: 0x18
	[Nullable(2)]
	private IAnalyticsStandardEventComponent m_CoreAnalytics; //Field offset: 0x20

	public CoreAnalyticsAdapter(IAnalyticsService analytics, ILogger logger) { }

	private Dictionary<String, Object> BuildTransactionFailedParameters(Product product, PurchaseFailureReason reason) { }

	private Dictionary<String, Object> BuildTransactionParameters(Product product) { }

	private long CheckCurrencyCodeAndExtractRealCurrencyAmount(Product product) { }

	[NullableContext(2)]
	private IAnalyticsStandardEventComponent CoreAnalytics() { }

	private Dictionary<String, Object> CreateRealCurrencyFromProduct(Product product) { }

	private long ExtractRealCurrencyAmount(Product product) { }

	private static Dictionary<String, Object> GenerateItemReceivedForPurchase(Product product) { }

	private Dictionary<String, Object> GenerateRealCurrencySpentOnPurchase(Product product) { }

	private static string GetTransactionName(Product product) { }

	public override void SendTransactionEvent(Product product) { }

	public override void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

}

