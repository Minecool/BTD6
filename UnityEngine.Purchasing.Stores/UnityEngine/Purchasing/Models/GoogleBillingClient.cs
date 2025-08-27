namespace UnityEngine.Purchasing.Models;

internal class GoogleBillingClient : IGoogleBillingClient
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public string type; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal AndroidJavaObject <QueryProductDetailsParamsProductList>b__0(string product) { }

	}

	private static AndroidJavaClass s_AndroidProductClassName; //Field offset: 0x0
	private static AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName; //Field offset: 0x8
	private static AndroidJavaClass s_BillingFlowParamsClass; //Field offset: 0x10
	private static AndroidJavaClass s_ProductDetailsParamsClass; //Field offset: 0x18
	private static AndroidJavaClass s_SubscriptionUpdateParamsClass; //Field offset: 0x20
	private static AndroidJavaClass s_ConsumeParamsClass; //Field offset: 0x28
	private static AndroidJavaClass s_AcknowledgePurchaseParamsClass; //Field offset: 0x30
	private static AndroidJavaClass s_BillingClientClass; //Field offset: 0x38
	private readonly AndroidJavaObject m_BillingClient; //Field offset: 0x10
	private string m_ObfuscatedAccountId; //Field offset: 0x18
	private string m_ObfuscatedProfileId; //Field offset: 0x20
	private readonly IUtil m_Util; //Field offset: 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; //Field offset: 0x30

	internal GoogleBillingClient(IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	public override void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge) { }

	private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayProrationMode prorationMode) { }

	public override void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume) { }

	private static AndroidJavaClass GetAcknowledgePurchaseParamsClass() { }

	private static AndroidJavaClass GetBillingClientClass() { }

	private static AndroidJavaClass GetBillingFlowParamClass() { }

	public override GoogleBillingConnectionState GetConnectionState() { }

	private static AndroidJavaClass GetConsumeParamsClass() { }

	private static AndroidJavaClass GetProductDetailsParamsClass() { }

	private static AndroidJavaClass GetProductParamsClass() { }

	private static AndroidJavaClass GetQueryProductDetailsParamsParamsClass() { }

	private static AndroidJavaClass GetSubscriptionUpdateParamClass() { }

	public override AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, Nullable<GooglePlayProrationMode> prorationMode) { }

	private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, Nullable<GooglePlayProrationMode> prorationMode) { }

	public override void QueryProductDetailsAsync(List<String> products, string type, Action<IGoogleBillingResult, List`1<AndroidJavaObject>> onProductDetailsResponseAction) { }

	private static AndroidJavaObject QueryProductDetailsParams(List<String> products, string type) { }

	private static AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product) { }

	private static AndroidJavaObject QueryProductDetailsParamsProductList(List<String> products, string type) { }

	public override void QueryPurchasesAsync(string skuType, Action<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> onQueryPurchasesResponse) { }

	private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	public override void StartConnection(IBillingClientStateListener billingClientStateListener) { }

}

