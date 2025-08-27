namespace Assets.Scripts.Unity.UI_New.Store;

public class Purchaser : MonoBehaviour, IDetailedStoreListener, IStoreListener, IPurchaser
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static OnMenuEvent <>9__41_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <CheckAndShowLoginReminder>b__41_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public string productID; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <IsProcessing>b__0(Product p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <GetLocalizedPriceString>b__0(ProductCatalogItem p) { }

		internal bool <GetLocalizedPriceString>b__1(StoreItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		private struct <<ValidateWithLink>g__verifyWithLiNK|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass40_0 <>4__this; //Field offset: 0x20
			private IapVerification <verification>5__2; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public Purchaser <>4__this; //Field offset: 0x10
		public PurchaseEventArgs args; //Field offset: 0x18
		public ProfileModel profile; //Field offset: 0x20
		public string receiptKey; //Field offset: 0x28
		public string productID; //Field offset: 0x30
		public PurchaseModel purchase; //Field offset: 0x38
		public StoreItem product; //Field offset: 0x40

		public <>c__DisplayClass40_0() { }

		[AsyncStateMachine(typeof(<<ValidateWithLink>g__verifyWithLiNK|0>d))]
		internal Task <ValidateWithLink>g__verifyWithLiNK|0() { }

	}

	[CompilerGenerated]
	private struct <GiveStoreItem>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Purchaser <>4__this; //Field offset: 0x20
		public Product purchasedProduct; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static Purchaser instance; //Field offset: 0x0
	public Action OnInitialised; //Field offset: 0x20
	public Action OnPurchaseComplete; //Field offset: 0x28
	public Action OnPurchaseFailedCallback; //Field offset: 0x30
	[CompilerGenerated]
	private PurchaseValidator <CurrentPurchaseValidator>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <CanThrowValidationExceptions>k__BackingField; //Field offset: 0x40
	private IStoreController storeController; //Field offset: 0x48
	private IExtensionProvider storeExtensionProvider; //Field offset: 0x50
	private ProductCatalog catalog; //Field offset: 0x58
	private bool restoring; //Field offset: 0x60
	private InitializationFailureReason initializationFailureReason; //Field offset: 0x64
	public List<Product> processingPurchases; //Field offset: 0x68
	private Stack<LootSet> unviewedLoot; //Field offset: 0x70

	public override bool CanThrowValidationExceptions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override PurchaseValidator CurrentPurchaseValidator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public static bool SupportsManualPurchaseRestore
	{
		 get { } //Length: 71
	}

	public Purchaser() { }

	[CompilerGenerated]
	private void <RestorePurchases>b__27_0(bool result, string message) { }

	private void Awake() { }

	public override void BuyProduct(string productID) { }

	public override void BuyTowerProduct(string productID, string towerID) { }

	private static void CheckAndShowLoginReminder() { }

	[CompilerGenerated]
	public override bool get_CanThrowValidationExceptions() { }

	[CompilerGenerated]
	public override PurchaseValidator get_CurrentPurchaseValidator() { }

	public static bool get_SupportsManualPurchaseRestore() { }

	private static string GetFailureMessage(PurchaseFailureDescription failureDescription) { }

	public override string GetLocalizedPriceString(string productId) { }

	public Product GetProduct(string productId) { }

	private static string GetProductAnalyticName(string productId, LootSet loot) { }

	[AsyncStateMachine(typeof(<GiveStoreItem>d__46))]
	private Task GiveStoreItem(Product purchasedProduct) { }

	public override bool HasUnviewedLoot() { }

	public override void InitializePurchasing() { }

	private void InitiatePurchase(string productID, string towerID) { }

	public override bool IsInitialized() { }

	public override bool IsNonConsumablePurchased(string productID) { }

	public override bool IsOneTimeConsumablePurchased(string productID) { }

	public override bool IsProcessing() { }

	public override bool IsProcessing(string productID) { }

	private bool LocalReceiptValid(PurchaseEventArgs e) { }

	private void OnDestroy() { }

	public override void OnInitialized(IStoreController controller, IExtensionProvider extensions) { }

	public override void OnInitializeFailed(InitializationFailureReason error, string message) { }

	public override void OnInitializeFailed(InitializationFailureReason error) { }

	public override void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription) { }

	public override void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason) { }

	public override LootSet PopUnviewedLoot() { }

	public override PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args) { }

	public override void RestorePurchases() { }

	[CompilerGenerated]
	public override void set_CanThrowValidationExceptions(bool value) { }

	[CompilerGenerated]
	public override void set_CurrentPurchaseValidator(PurchaseValidator value) { }

	private void ShowPopup(string msg) { }

	private void ShowPurchaseFailedPopup(string message) { }

	private void TryAddNexusLoot(ref LootSet lootSet) { }

	private PurchaseProcessingResult ValidateWithLink(PurchaseEventArgs args, StoreItem product) { }

}

