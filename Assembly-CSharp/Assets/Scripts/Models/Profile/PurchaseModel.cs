namespace Assets.Scripts.Models.Profile;

[DataContract]
public class PurchaseModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Int64>, String> <>9__25_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, Int64>, Int64> <>9__25_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, Int64>, Boolean> <>9__26_3; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, Int64>, String> <>9__26_4; //Field offset: 0x20
		public static Func<String, String> <>9__26_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <SyncWithWalletAsync>b__26_1(string x) { }

		internal bool <SyncWithWalletAsync>b__26_3(KeyValuePair<String, Int64> x) { }

		internal string <SyncWithWalletAsync>b__26_4(KeyValuePair<String, Int64> x) { }

		internal string <ValidateRemoteValues>b__25_0(KeyValuePair<String, Int64> x) { }

		internal long <ValidateRemoteValues>b__25_1(KeyValuePair<String, Int64> z) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public string productID; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <Push>b__0(PurchaseLootMeta p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public string productID; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <Pop>b__0(PurchaseLootMeta x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public String[] remotePurchasedItems; //Field offset: 0x10
		public long timestamp; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal bool <SyncWithWalletAsync>b__0(string x) { }

		internal long <SyncWithWalletAsync>b__2(string z) { }

	}

	[CompilerGenerated]
	private struct <SyncWithWalletAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private <>c__DisplayClass26_0 <>8__1; //Field offset: 0x28
		public PurchaseModel <>4__this; //Field offset: 0x30
		private string <currentPlayerId>5__2; //Field offset: 0x38
		private object <>7__wrap2; //Field offset: 0x40
		private int <>7__wrap3; //Field offset: 0x48
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateIapWalletAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Dictionary<String, Int64> values; //Field offset: 0x28
		public bool isFullSync; //Field offset: 0x30
		public PurchaseModel <>4__this; //Field offset: 0x38
		private string <currentPlayerId>5__2; //Field offset: 0x40
		private object <>7__wrap2; //Field offset: 0x48
		private int <>7__wrap3; //Field offset: 0x50
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string kWalletId = "PurchasedOneTimeIaps"; //Field offset: 0x0
	private const string kDoubleCashIapId = "btd6_doublecashmode"; //Field offset: 0x0
	private const string kDoubleCashIapSaleId = "btd6_doublecash_sale"; //Field offset: 0x0
	private static readonly TimeSpan kLinkRetryTimeout; //Field offset: 0x0
	[DataMember]
	private readonly List<PurchaseLootMeta> purchaseLoot; //Field offset: 0x10
	[DataMember]
	[Obsolete("Use PurchasedDoubleCashMode property instead")]
	private bool purchasedDoubleCashMode; //Field offset: 0x18
	[DataMember]
	private readonly HashSet<String> consumedValidations; //Field offset: 0x20
	[DataMember]
	private int validationVerion; //Field offset: 0x28
	[DataMember]
	[Obsolete("use purchasedOneTimeItems instead")]
	private HashSet<String> purchasedNonConsumables; //Field offset: 0x30
	[DataMember]
	[Obsolete("use purchasedOneTimeItems instead")]
	private HashSet<String> purchasedOnetimeConsumables; //Field offset: 0x38
	[DataMember]
	private readonly HashSet<String> purchasedOneTimeItems; //Field offset: 0x40

	public bool PurchasedDoubleCashMode
	{
		 get { } //Length: 145
	}

	private static PurchaseModel() { }

	public PurchaseModel() { }

	public void AddOneTimePurchaseItem(string itemId) { }

	public bool ConsumeValidation(string validation) { }

	public bool get_PurchasedDoubleCashMode() { }

	public IEnumerable<String> GetPurchasedOneTimeItems() { }

	public bool HasMadeOneTimePurchase(string itemId) { }

	public bool IsConsumed(string validation) { }

	[OnDeserialized]
	public void OnDeserialized(StreamingContext context = null) { }

	public LootSet Pop(string productID) { }

	public void Push(string productID, string loot) { }

	public void RemoveOneTimePurchaseItem(string itemId) { }

	[AsyncStateMachine(typeof(<SyncWithWalletAsync>d__26))]
	private void SyncWithWalletAsync() { }

	private void UpdateBankItemAsync(string itemId, long value) { }

	[AsyncStateMachine(typeof(<UpdateIapWalletAsync>d__24))]
	private void UpdateIapWalletAsync(Dictionary<String, Int64> values, bool isFullSync) { }

	public void Validate() { }

	private static Dictionary<String, Int64> ValidateRemoteValues(Dictionary<String, Int64> iapIdValues) { }

}

