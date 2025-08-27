//Type is in global namespace

internal class SteamStore : IStore
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		private struct <<OnSteamworksAuthorizationResponse>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass12_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public SteamStore <>4__this; //Field offset: 0x10
		public Purchaser purchaser; //Field offset: 0x18
		public bool authorized; //Field offset: 0x20
		public ulong orderId; //Field offset: 0x28

		public <>c__DisplayClass12_0() { }

		[AsyncStateMachine(typeof(<<OnSteamworksAuthorizationResponse>b__0>d))]
		internal Task <OnSteamworksAuthorizationResponse>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Client client; //Field offset: 0x10
		public SteamStore <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <ProcessNonConsumables>b__0() { }

	}

	[CompilerGenerated]
	private struct <OnSteamworksAuthorizationResponseAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Purchaser purchaser; //Field offset: 0x20
		public bool authorized; //Field offset: 0x28
		public SteamStore <>4__this; //Field offset: 0x30
		public ulong orderId; //Field offset: 0x38
		private List<Product> <processingPurchases>5__2; //Field offset: 0x40
		private int <i>5__3; //Field offset: 0x48
		private Product <processingPurchase>5__4; //Field offset: 0x50
		private TaskAwaiter<SteamIapVerification> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PurchaseAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ProductDefinition product; //Field offset: 0x28
		public SteamStore <>4__this; //Field offset: 0x30
		private TaskAwaiter<SteamOrderModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RetrieveProductsAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SteamStore <>4__this; //Field offset: 0x28
		public ReadOnlyCollection<ProductDefinition> productDefinitions; //Field offset: 0x30
		private NumberFormatInfo <nfi>5__2; //Field offset: 0x38
		private Dictionary<String, String> <productPrices>5__3; //Field offset: 0x40
		private Dictionary<String, Decimal> <productPricesRaw>5__4; //Field offset: 0x48
		private TaskAwaiter<SteamIapsModel> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private IStoreCallback storeCallback; //Field offset: 0x10
	private string currencyCode; //Field offset: 0x18

	private static bool IsDebugBuild
	{
		private get { } //Length: 3
	}

	public SteamStore() { }

	[CompilerGenerated]
	private void <Purchase>b__9_0(ulong order, ulong tran) { }

	public void Destroy() { }

	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	private static bool get_IsDebugBuild() { }

	public override void Initialize(IStoreCallback storeCallback) { }

	private void OnSteamworksAuthorizationResponse(bool authorized, int appId, ulong orderId) { }

	[AsyncStateMachine(typeof(<OnSteamworksAuthorizationResponseAsync>d__13))]
	private Task OnSteamworksAuthorizationResponseAsync(Purchaser purchaser, bool authorized, ulong orderId) { }

	private void ProcessNonConsumables() { }

	public override void Purchase(ProductDefinition product, string developerPayload) { }

	[AsyncStateMachine(typeof(<PurchaseAsync>d__10))]
	private void PurchaseAsync(ProductDefinition product, string developerPayload) { }

	public override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefinitions) { }

	[AsyncStateMachine(typeof(<RetrieveProductsAsync>d__7))]
	private void RetrieveProductsAsync(ReadOnlyCollection<ProductDefinition> productDefinitions) { }

}

