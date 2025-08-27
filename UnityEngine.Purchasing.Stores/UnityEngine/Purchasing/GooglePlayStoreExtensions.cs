namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreExtensions : IGooglePlayStoreExtensions, IStoreExtension, IGooglePlayStoreExtensionsInternal
{
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; //Field offset: 0x10
	private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider; //Field offset: 0x18
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; //Field offset: 0x20
	private readonly ILogger m_Logger; //Field offset: 0x28
	[Nullable(2)]
	private IStoreCallback m_StoreCallback; //Field offset: 0x30

	internal GooglePlayStoreExtensions(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics) { }

	public override GooglePurchaseState GetPurchaseState(Product product) { }

	private IGooglePurchase GooglePurchaseFromProduct(Product product) { }

	public override bool IsPurchasedProductDeferred(Product product) { }

	public override void SetStoreCallback(IStoreCallback storeCallback) { }

	private bool TryIsPurchasedProductDeferred(Product product) { }

}

