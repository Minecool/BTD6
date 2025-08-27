namespace UnityEngine.Purchasing;

internal class FakeStore : JSONStore, IStoreExtension, INativeStore
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public FakeStore <>4__this; //Field offset: 0x10
		public List<ProductDescription> products; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <StoreRetrieveProducts>g__handleAllowInitializeOrRetrieveProducts|0(bool allow, InitializationFailureReason failureReason) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public FakeStore <>4__this; //Field offset: 0x10
		public ProductDefinition product; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <FakePurchase>g__handleAllowPurchase|0(bool allow, PurchaseFailureReason failureReason) { }

	}

	internal enum DialogType
	{
		Purchase = 0,
		RetrieveProducts = 1,
	}

	private IStoreCallback m_Biller; //Field offset: 0x48
	private readonly List<String> m_PurchasedProducts; //Field offset: 0x50
	public bool purchaseCalled; //Field offset: 0x58
	[CompilerGenerated]
	private string <unavailableProductId>k__BackingField; //Field offset: 0x60
	public FakeStoreUIMode UIMode; //Field offset: 0x68

	public override string unavailableProductId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public FakeStore() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(string id, string receipt, string transactionID) { }

	private void FakePurchase(ProductDefinition product, string developerPayload) { }

	public override void FinishTransaction(string productJSON, string transactionID) { }

	public virtual void FinishTransaction(ProductDefinition product, string transactionId) { }

	[CompilerGenerated]
	public override string get_unavailableProductId() { }

	public virtual void Initialize(IStoreCallback biller) { }

	public override void Purchase(string productJSON, string developerPayload) { }

	public override void RetrieveProducts(string json) { }

	protected override bool StartUI(object model, DialogType dialogType, Action<Boolean, T> callback) { }

	public void StoreRetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefinitions) { }

}

