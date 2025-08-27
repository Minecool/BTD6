namespace UnityEngine.Purchasing;

internal class WinRTStore : AbstractStore, IWindowsIAPCallback, IMicrosoftExtensions, IStoreExtension
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ProductDefinition, Boolean> <>9__8_0; //Field offset: 0x8
		public static Func<ProductDefinition, WinProductDescription> <>9__8_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <RetrieveProducts>b__8_0(ProductDefinition def) { }

		internal WinProductDescription <RetrieveProducts>b__8_1(ProductDefinition def) { }

	}

	private IWindowsIAP win8; //Field offset: 0x10
	private IStoreCallback callback; //Field offset: 0x18
	private readonly IUtil util; //Field offset: 0x20
	private readonly ILogger logger; //Field offset: 0x28
	private bool m_CanReceivePurchases; //Field offset: 0x30

	public WinRTStore(IWindowsIAP win8, IUtil util, ILogger logger) { }

	public virtual void FinishTransaction(ProductDefinition product, string transactionId) { }

	private void init(int delay) { }

	public virtual void Initialize(IStoreCallback biller) { }

	public virtual void Purchase(ProductDefinition product, string developerPayload) { }

	public void restoreTransactions(bool pausing) { }

	public virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefs) { }

}

