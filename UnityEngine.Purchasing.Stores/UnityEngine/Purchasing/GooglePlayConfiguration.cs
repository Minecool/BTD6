namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayConfiguration : IGooglePlayConfiguration, IStoreConfiguration, IGooglePlayConfigurationInternal
{
	[Nullable(2)]
	private Action m_InitializationConnectionLister; //Field offset: 0x10
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; //Field offset: 0x18
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<Product> m_DeferredPurchaseAction; //Field offset: 0x20
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction; //Field offset: 0x28
	[Nullable(2)]
	private Action<Int32> m_QueryProductDetailsFailedListener; //Field offset: 0x30
	private bool m_FetchPurchasesAtInitialize; //Field offset: 0x38
	private bool m_FetchPurchasesExcludeDeferred; //Field offset: 0x39

	public GooglePlayConfiguration(IGooglePlayStoreService googlePlayStoreService) { }

	public override bool DoesRetrievePurchasesExcludeDeferred() { }

	public override bool IsFetchPurchasesAtInitializeSkipped() { }

	public override void NotifyDeferredProrationUpgradeDowngradeSubscription(IStoreCallback storeCallback, string productId) { }

	[NullableContext(2)]
	public override void NotifyDeferredPurchase(IStoreCallback storeCallback, IGooglePurchase purchase, string receipt, string transactionId) { }

	public override void NotifyInitializationConnectionFailed() { }

	public override void NotifyQueryProductDetailsFailed(int retryCount) { }

}

