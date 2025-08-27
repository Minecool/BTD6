namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GoogleQueryPurchasesService : IGoogleQueryPurchasesService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<IEnumerable`1<IGooglePurchase>, IEnumerable`1<IGooglePurchase>> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal IEnumerable<IGooglePurchase> <QueryPurchases>b__3_0(IEnumerable<IGooglePurchase> result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		[Nullable(0)]
		public GoogleQueryPurchasesService <>4__this; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public TaskCompletionSource<IEnumerable`1<IGooglePurchase>> taskCompletion; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		[NullableContext(0)]
		internal void <QueryPurchasesWithSkuType>b__0(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> purchases) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		[Nullable(0)]
		public string purchaseToken; //Field offset: 0x10
		[Nullable(0)]
		public GoogleQueryPurchasesService <>4__this; //Field offset: 0x18
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		public TaskCompletionSource<IGooglePurchase> taskCompletion; //Field offset: 0x20
		[Nullable(0)]
		public Func<AndroidJavaObject, Boolean> <>9__1; //Field offset: 0x28

		public <>c__DisplayClass5_0() { }

		[NullableContext(0)]
		internal void <GetPurchaseByToken>b__0(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> purchases) { }

		[NullableContext(0)]
		internal bool <GetPurchaseByToken>b__1(AndroidJavaObject purchase) { }

	}

	[CompilerGenerated]
	private struct <QueryPurchases>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1}])]
		public AsyncTaskMethodBuilder<List`1<IGooglePurchase>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public GoogleQueryPurchasesService <>4__this; //Field offset: 0x20
		[Nullable(0)]
		private TaskAwaiter<IEnumerable`1<IGooglePurchase>[]> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IGoogleBillingClient m_BillingClient; //Field offset: 0x10
	private readonly IGooglePurchaseBuilder m_PurchaseBuilder; //Field offset: 0x18

	internal GoogleQueryPurchasesService(IGoogleBillingClient billingClient, IGooglePurchaseBuilder purchaseBuilder) { }

	public override IGooglePurchase GetPurchaseByToken(string purchaseToken, string skuType) { }

	private static bool IsResultOk(IGoogleBillingResult result) { }

	[AsyncStateMachine(typeof(<QueryPurchases>d__3))]
	public override Task<List`1<IGooglePurchase>> QueryPurchases() { }

	private Task<IEnumerable`1<IGooglePurchase>> QueryPurchasesWithSkuType(string skuType) { }

}

