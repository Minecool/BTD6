namespace Facepunch.Steamworks;

public class Inventory : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Item, Item, Item> <>9__19_0; //Field offset: 0x8
		public static Func<Definition, Int32> <>9__38_0; //Field offset: 0x10
		public static Func<IGrouping`2<Int32, Definition>, SteamItemDef_t> <>9__38_1; //Field offset: 0x18
		public static Func<IGrouping`2<Int32, Definition>, UInt32> <>9__38_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal Item <ApplyResult>b__19_0(Item oldItem, Item newItem) { }

		internal int <StartPurchase>b__38_0(Definition x) { }

		internal SteamItemDef_t <StartPurchase>b__38_1(IGrouping<Int32, Definition> x) { }

		internal uint <StartPurchase>b__38_2(IGrouping<Int32, Definition> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Result r; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <ApplyResult>b__1(Item x) { }

		internal bool <ApplyResult>b__2(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public StartPurchaseSuccess callback; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal void <StartPurchase>b__3(SteamInventoryStartPurchaseResult_t result, bool error) { }

	}

	[CompilerGenerated]
	private sealed class <get_DefinitionsWithPrices>d__28 : IEnumerable<Definition>, IEnumerable, IEnumerator<Definition>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Definition <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Inventory <>4__this; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30

		private override Definition System.Collections.Generic.IEnumerator<Facepunch.Steamworks.Inventory.Definition>.Current
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
		public <get_DefinitionsWithPrices>d__28(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Definition> System.Collections.Generic.IEnumerable<Facepunch.Steamworks.Inventory.Definition>.GetEnumerator() { }

		[DebuggerHidden]
		private override Definition System.Collections.Generic.IEnumerator<Facepunch.Steamworks.Inventory.Definition>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class Definition
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass77_0
		{
			public Definition[] definitions; //Field offset: 0x10
			public Definition <>4__this; //Field offset: 0x18

			public <>c__DisplayClass77_0() { }

			internal Recipe <LinkExchange>b__0(string x) { }

		}

		internal Inventory inventory; //Field offset: 0x10
		[CompilerGenerated]
		private int <Id>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private string <Name>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private string <Description>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private string <IconUrl>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private string <IconLargeUrl>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private string <Type>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private string <ExchangeSchema>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private Recipe[] <Recipes>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private Recipe[] <IngredientFor>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private DateTime <Created>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private DateTime <Modified>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private string <PriceCategory>k__BackingField; //Field offset: 0x70
		[CompilerGenerated]
		private double <PriceDollars>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private double <LocalPrice>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		private string <LocalPriceFormatted>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		private bool <Marketable>k__BackingField; //Field offset: 0x90
		private Dictionary<String, String> customProperties; //Field offset: 0x98

		public DateTime Created
		{
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string Description
		{
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string ExchangeSchema
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string IconLargeUrl
		{
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string IconUrl
		{
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public private int Id
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public Recipe[] IngredientFor
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public internal double LocalPrice
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			internal set { } //Length: 9
		}

		internal string LocalPriceFormatted
		{
			[CompilerGenerated]
			internal set { } //Length: 8
		}

		public bool Marketable
		{
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public DateTime Modified
		{
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string Name
		{
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string PriceCategory
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		internal double PriceDollars
		{
			[CompilerGenerated]
			internal set { } //Length: 6
		}

		public Recipe[] Recipes
		{
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string Type
		{
			[CompilerGenerated]
			 set { } //Length: 5
		}

		internal Definition(Inventory i, int id) { }

		[CompilerGenerated]
		public string get_ExchangeSchema() { }

		[CompilerGenerated]
		public int get_Id() { }

		[CompilerGenerated]
		public Recipe[] get_IngredientFor() { }

		[CompilerGenerated]
		public double get_LocalPrice() { }

		[CompilerGenerated]
		public string get_PriceCategory() { }

		public bool GetBoolProperty(string name) { }

		public T GetProperty(string name) { }

		public string GetStringProperty(string name) { }

		internal void InRecipe(Recipe r) { }

		internal void Link(Definition[] definitions) { }

		private void LinkExchange(Definition[] definitions) { }

		[CompilerGenerated]
		public void set_Created(DateTime value) { }

		[CompilerGenerated]
		public void set_Description(string value) { }

		[CompilerGenerated]
		public void set_ExchangeSchema(string value) { }

		[CompilerGenerated]
		public void set_IconLargeUrl(string value) { }

		[CompilerGenerated]
		public void set_IconUrl(string value) { }

		[CompilerGenerated]
		private void set_Id(int value) { }

		[CompilerGenerated]
		public void set_IngredientFor(Recipe[] value) { }

		[CompilerGenerated]
		internal void set_LocalPrice(double value) { }

		[CompilerGenerated]
		internal void set_LocalPriceFormatted(string value) { }

		[CompilerGenerated]
		public void set_Marketable(bool value) { }

		[CompilerGenerated]
		public void set_Modified(DateTime value) { }

		[CompilerGenerated]
		public void set_Name(string value) { }

		[CompilerGenerated]
		public void set_PriceCategory(string value) { }

		[CompilerGenerated]
		internal void set_PriceDollars(double value) { }

		[CompilerGenerated]
		public void set_Recipes(Recipe[] value) { }

		[CompilerGenerated]
		public void set_Type(string value) { }

		internal void SetupCommonProperties() { }

		internal void UpdatePrice() { }

	}

	internal class Item : IEquatable<Item>
	{
		public ulong Id; //Field offset: 0x10
		public int Quantity; //Field offset: 0x18
		public int DefinitionId; //Field offset: 0x1C
		internal Inventory Inventory; //Field offset: 0x20
		[CompilerGenerated]
		private Dictionary<String, String> <Properties>k__BackingField; //Field offset: 0x28
		private Definition _cachedDefinition; //Field offset: 0x30
		public bool TradeLocked; //Field offset: 0x38
		private SteamInventoryUpdateHandle_t updateHandle; //Field offset: 0x40

		public Definition Definition
		{
			 get { } //Length: 148
		}

		internal Dictionary<String, String> Properties
		{
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		internal Item(Inventory Inventory, ulong Id, int Quantity, int DefinitionId) { }

		public override bool Equals(Item other) { }

		public virtual bool Equals(object obj) { }

		public Definition get_Definition() { }

		public virtual int GetHashCode() { }

		public static bool op_Equality(Item left, Item right) { }

		[CompilerGenerated]
		internal void set_Properties(Dictionary<String, String> value) { }

	}

	internal struct Recipe
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Ingredient, Boolean> <>9__3_1; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal bool <FromString>b__3_1(Ingredient x) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public Definition[] definitions; //Field offset: 0x10

			public <>c__DisplayClass3_0() { }

			internal Ingredient <FromString>b__0(string x) { }

		}

		internal struct Ingredient
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass3_0
			{
				public Ingredient i; //Field offset: 0x10

				public <>c__DisplayClass3_0() { }

				internal bool <FromString>b__0(Definition x) { }

			}

			public int DefinitionId; //Field offset: 0x0
			public Definition Definition; //Field offset: 0x8
			public int Count; //Field offset: 0x10

			internal static Ingredient FromString(string part, Definition[] definitions) { }

		}

		public Definition Result; //Field offset: 0x0
		public Ingredient[] Ingredients; //Field offset: 0x8

		internal static Recipe FromString(string part, Definition[] definitions, Definition Result) { }

	}

	internal class Result : IDisposable
	{
		internal static Dictionary<Int32, Result> Pending; //Field offset: 0x0
		internal Inventory inventory; //Field offset: 0x10
		[CompilerGenerated]
		private SteamInventoryResult_t <Handle>k__BackingField; //Field offset: 0x18
		public Action<Result> OnResult; //Field offset: 0x20
		[CompilerGenerated]
		private Item[] <Items>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private Item[] <Removed>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private Item[] <Consumed>k__BackingField; //Field offset: 0x38
		protected bool _gotResult; //Field offset: 0x40
		[CompilerGenerated]
		private uint <Timestamp>k__BackingField; //Field offset: 0x44

		public internal Item[] Consumed
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		private SteamInventoryResult_t Handle
		{
			[CompilerGenerated]
			private get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		internal bool IsSuccess
		{
			internal get { } //Length: 79
		}

		public internal Item[] Items
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public internal Item[] Removed
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		internal uint Timestamp
		{
			[CompilerGenerated]
			internal get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		internal Result(Inventory inventory, int Handle, bool pending) { }

		public override void Dispose() { }

		internal void Fill() { }

		[CompilerGenerated]
		public Item[] get_Consumed() { }

		[CompilerGenerated]
		private SteamInventoryResult_t get_Handle() { }

		internal bool get_IsSuccess() { }

		[CompilerGenerated]
		public Item[] get_Items() { }

		[CompilerGenerated]
		public Item[] get_Removed() { }

		[CompilerGenerated]
		internal uint get_Timestamp() { }

		internal void OnSteamResult(SteamInventoryResultReady_t data) { }

		internal Byte[] Serialize() { }

		[CompilerGenerated]
		internal void set_Consumed(Item[] value) { }

		[CompilerGenerated]
		private void set_Handle(SteamInventoryResult_t value) { }

		[CompilerGenerated]
		internal void set_Items(Item[] value) { }

		[CompilerGenerated]
		internal void set_Removed(Item[] value) { }

		[CompilerGenerated]
		private void set_Timestamp(uint value) { }

		internal Result Status() { }

	}

	internal sealed class StartPurchaseSuccess : MulticastDelegate
	{

		public StartPurchaseSuccess(object object, IntPtr method) { }

		public override void Invoke(ulong orderId, ulong transactionId) { }

	}

	public Action OnUpdate; //Field offset: 0x10
	public Item[] Items; //Field offset: 0x18
	public Byte[] SerializedItems; //Field offset: 0x20
	public DateTime SerializedExpireTime; //Field offset: 0x28
	internal uint LastTimestamp; //Field offset: 0x30
	internal SteamInventory inventory; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsServer>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnDefinitionsUpdated; //Field offset: 0x48
	public Definition[] Definitions; //Field offset: 0x50
	[CompilerGenerated]
	private string <Currency>k__BackingField; //Field offset: 0x58

	public private string Currency
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public IEnumerable<Definition> DefinitionsWithPrices
	{
		[IteratorStateMachine(typeof(<get_DefinitionsWithPrices>d__28))]
		 get { } //Length: 101
	}

	private bool IsServer
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal Inventory(BaseSteamworks steamworks, SteamInventory c, bool server) { }

	[CompilerGenerated]
	private Definition <LoadDefinitions>b__15_0(SteamItemDef_t x) { }

	[CompilerGenerated]
	private void <UpdatePrices>b__43_0(SteamInventoryRequestPricesResult_t result, bool b) { }

	internal void ApplyResult(Result r, bool isFullUpdate) { }

	public Definition CreateDefinition(int id) { }

	public override void Dispose() { }

	public void FetchItemDefinitions() { }

	public Definition FindDefinition(int DefinitionId) { }

	[CompilerGenerated]
	public string get_Currency() { }

	[IteratorStateMachine(typeof(<get_DefinitionsWithPrices>d__28))]
	public IEnumerable<Definition> get_DefinitionsWithPrices() { }

	[CompilerGenerated]
	private bool get_IsServer() { }

	internal Item ItemFrom(SteamInventoryResult_t handle, SteamItemDetails_t detail, int index) { }

	private bool LoadDefinitions() { }

	private void onDefinitionsUpdated(SteamInventoryDefinitionUpdate_t obj) { }

	private void onFullUpdate(SteamInventoryFullUpdate_t data) { }

	private void onResult(Result r, bool isFullUpdate) { }

	private void onResultReady(SteamInventoryResultReady_t data) { }

	public static float PriceCategoryToFloat(string price) { }

	public void Refresh() { }

	[CompilerGenerated]
	private void set_Currency(string value) { }

	[CompilerGenerated]
	private void set_IsServer(bool value) { }

	public bool StartPurchase(Definition[] items, StartPurchaseSuccess callback = null) { }

	public void UpdatePrices() { }

}

