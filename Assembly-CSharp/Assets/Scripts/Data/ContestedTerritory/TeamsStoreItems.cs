namespace Assets.Scripts.Data.ContestedTerritory;

public class TeamsStoreItems : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TeamsStoreItem, Boolean> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_PurchasableStoreItems>b__4_0(TeamsStoreItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string storeItemId; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <GetStoreItem>b__0(TeamsStoreItem storeIcon) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public string itemName; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <GetTeamSlotItemOrDefault>b__0(TeamsStoreItem storeIcon) { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsStoreItems <>4__this; //Field offset: 0x20
		private TaskAwaiter<IList`1<TeamsStoreItem>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private List<TeamsStoreItem> storeItems; //Field offset: 0x18

	public IEnumerable<TeamsStoreItem> PurchasableStoreItems
	{
		 get { } //Length: 247
	}

	public IEnumerable<TeamsStoreItem> StoreItems
	{
		 get { } //Length: 5
	}

	public TeamsStoreItems() { }

	private void AddStoreItem(TeamsStoreItem storeItem) { }

	public IEnumerable<TeamsStoreItem> get_PurchasableStoreItems() { }

	public IEnumerable<TeamsStoreItem> get_StoreItems() { }

	public TeamsStoreItem GetStoreItem(string storeItemId) { }

	public PrefabReference GetTeamSlotItemOrDefault(string itemName, TeamStoreWorldSlot type, int baseSlotId = -1) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__5))]
	public Task LoadAsync() { }

}

