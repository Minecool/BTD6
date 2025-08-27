namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class AppleStoreImpl : JSONStore, IAppleExtensions, IStoreExtension, IAppleConfiguration, IStoreConfiguration
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Comparison<AppleInAppPurchaseReceipt> <>9__39_1; //Field offset: 0x8
		[Nullable(0)]
		public static Func<KeyValuePair`2<String, Object>, String> <>9__62_0; //Field offset: 0x10
		[Nullable(0)]
		public static Func<KeyValuePair`2<String, Object>, String> <>9__62_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal int <FindMostRecentReceipt>b__39_1(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

		[NullableContext(0)]
		internal string <OnFetchStorePromotionVisibilitySucceeded>b__62_0(KeyValuePair<String, Object> k) { }

		[NullableContext(0)]
		internal string <OnFetchStorePromotionVisibilitySucceeded>b__62_1(KeyValuePair<String, Object> k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		[Nullable(0)]
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		[NullableContext(0)]
		internal bool <FindMostRecentReceipt>b__0(AppleInAppPurchaseReceipt r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		[Nullable(0)]
		public string subject; //Field offset: 0x10
		[Nullable(0)]
		public string payload; //Field offset: 0x18
		[Nullable(0)]
		public string receipt; //Field offset: 0x20
		[Nullable(0)]
		public string transactionId; //Field offset: 0x28
		[Nullable(0)]
		public string originalTransactionId; //Field offset: 0x30
		public bool isRestored; //Field offset: 0x38

		public <>c__DisplayClass64_0() { }

		internal void <MessageCallback>b__0() { }

	}

	[Nullable(2)]
	private static IUtil s_Util; //Field offset: 0x0
	[Nullable(2)]
	private static AppleStoreImpl s_Instance; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<Product> m_DeferredCallback; //Field offset: 0x48
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Action<List`1<Product>> m_RevokedCallback; //Field offset: 0x50
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<String> m_RefreshReceiptError; //Field offset: 0x58
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<String> m_RefreshReceiptSuccess; //Field offset: 0x60
	[Nullable(2)]
	private Action<Boolean> m_ObsoleteRestoreCallback; //Field offset: 0x68
	[Nullable(2)]
	private Action<Boolean, String> m_RestoreCallback; //Field offset: 0x70
	[Nullable(2)]
	private Action m_FetchStorePromotionOrderError; //Field offset: 0x78
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Action<List`1<Product>> m_FetchStorePromotionOrderSuccess; //Field offset: 0x80
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<Product> m_PromotionalPurchaseCallback; //Field offset: 0x88
	[Nullable(2)]
	private Action m_FetchStorePromotionVisibilityError; //Field offset: 0x90
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<String, AppleStorePromotionVisibility> m_FetchStorePromotionVisibilitySuccess; //Field offset: 0x98
	[Nullable(2)]
	private INativeAppleStore m_Native; //Field offset: 0xA0
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; //Field offset: 0xA8
	[Nullable(2)]
	private string m_CachedAppReceipt; //Field offset: 0xB0
	private Nullable<Double> m_CachedAppReceiptModificationDate; //Field offset: 0xB8
	[Nullable(2)]
	private string m_ProductsJson; //Field offset: 0xC8

	[Nullable(2)]
	public override string appReceipt
	{
		[NullableContext(2)]
		 get { } //Length: 365
	}

	private Nullable<Double> appReceiptModificationDate
	{
		private get { } //Length: 155
	}

	protected AppleStoreImpl(IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	private List<ProductDescription> EnrichProductDescriptions(List<ProductDescription> productDescriptions, AppleReceipt appleReceipt) { }

	[NullableContext(2)]
	private static AppleInAppPurchaseReceipt FindMostRecentReceipt(AppleReceipt appleReceipt, string productId) { }

	private static AppleInAppPurchaseReceipt FirstNonCancelledReceipt(AppleInAppPurchaseReceipt[] foundReceipts) { }

	[NullableContext(2)]
	public override string get_appReceipt() { }

	private Nullable<Double> get_appReceiptModificationDate() { }

	[NullableContext(2)]
	private AppleReceipt GetAppleReceiptFromBase64String(string receipt) { }

	[NullableContext(2)]
	private bool HasInAppPurchaseReceipts(AppleReceipt appleReceipt) { }

	private static bool IsNonSubscriptionRestored(string transactionId, string originalTransactionId) { }

	private bool IsRestored(string productId, AppleInAppPurchaseReceipt productReceipt, string transactionId, string originalTransactionId) { }

	private static bool IsSubscriptionRestored(AppleInAppPurchaseReceipt productReceipt, Product previousProduct) { }

	private static bool IsValidPurchaseState(AppleInAppPurchaseReceipt mostRecentReceipt, string productId) { }

	[MonoPInvokeCallback(typeof(UnityPurchasingCallback))]
	private static void MessageCallback(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	public void OnAppReceiptRefreshedFailed(string error) { }

	public void OnAppReceiptRetrieved(string receipt) { }

	private void OnEntitlementsRevoked(string productIds) { }

	public void OnFetchStorePromotionOrderFailed() { }

	public void OnFetchStorePromotionOrderSucceeded(string productIds) { }

	public void OnFetchStorePromotionVisibilityFailed() { }

	public void OnFetchStorePromotionVisibilitySucceeded(string result) { }

	public virtual void OnProductsRetrieved(string json) { }

	public void OnPromotionalPurchaseAttempted(string productId) { }

	public void OnPurchaseDeferred(string productId) { }

	public void OnPurchaseSucceeded(string id, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	public void OnTransactionsRestoredFail(string error) { }

	public void OnTransactionsRestoredSuccess() { }

	private void ProcessMessage(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	private bool RestoreActiveEntitlement(AppleReceipt appleReceipt, string productId) { }

	[NullableContext(2)]
	public override void RestoreTransactions(Action<Boolean, String> callback) { }

	private void RevokeEntitlement(AppleReceipt appleReceipt, string productId, List<Product> revokedProducts, Product product) { }

	public void SetNativeStore(INativeAppleStore apple) { }

	private void UpdateAppleProductFields(string id, string originalTransactionId, bool isRestored) { }

}

