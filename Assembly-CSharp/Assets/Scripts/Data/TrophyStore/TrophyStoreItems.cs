namespace Assets.Scripts.Data.TrophyStore;

public class TrophyStoreItems : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public TrophyItemLootSet lootSet; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <GetLootItems>b__0(TrophyStoreItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <GetStoreItem>b__0(TrophyStoreItem o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public TrophyStoreFilter tab; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GetStoreTypeIcon>b__0(TrophyStoreTypeIcon o) { }

	}

	[CompilerGenerated]
	private sealed class <get_StoreItems>d__4 : IEnumerable<TrophyStoreItem>, IEnumerable, IEnumerator<TrophyStoreItem>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TrophyStoreItem <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public TrophyStoreItems <>4__this; //Field offset: 0x28
		private bool <isChildAccount>5__2; //Field offset: 0x30
		private Enumerator<TrophyStoreItem> <>7__wrap2; //Field offset: 0x38

		private override TrophyStoreItem System.Collections.Generic.IEnumerator<Assets.Scripts.Data.TrophyStore.TrophyStoreItem>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_StoreItems>d__4(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<TrophyStoreItem> System.Collections.Generic.IEnumerable<Assets.Scripts.Data.TrophyStore.TrophyStoreItem>.GetEnumerator() { }

		[DebuggerHidden]
		private override TrophyStoreItem System.Collections.Generic.IEnumerator<Assets.Scripts.Data.TrophyStore.TrophyStoreItem>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TrophyStoreItems <>4__this; //Field offset: 0x20
		private TaskAwaiter<IList`1<TrophyStoreItem>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string kNamedMonkeysStoreItemId = "GameUIUpgradesNamedMonkeys"; //Field offset: 0x0
	[SerializeField]
	private List<TrophyStoreTypeIcon> trophyStoreTypeToIcon; //Field offset: 0x18
	private List<TrophyStoreItem> storeItems; //Field offset: 0x20

	public IEnumerable<TrophyStoreItem> StoreItems
	{
		[IteratorStateMachine(typeof(<get_StoreItems>d__4))]
		 get { } //Length: 101
	}

	public TrophyStoreItems() { }

	private void AddStoreItem(TrophyStoreItem i) { }

	[IteratorStateMachine(typeof(<get_StoreItems>d__4))]
	public IEnumerable<TrophyStoreItem> get_StoreItems() { }

	public List<TrophyStoreItem> GetAllItems() { }

	public List<TrophyStoreItem> GetLootItems(TrophyItemLootSet lootSet) { }

	public TrophyStoreItem GetStoreItem(string id) { }

	public SpriteReference GetStoreTypeIcon(TrophyStoreFilter tab) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__5))]
	public Task LoadAsync() { }

	public bool TryGetStoreItem(string id, out TrophyStoreItem item) { }

}

