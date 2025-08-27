namespace Assets.Scripts.Unity.Gift;

public class GiftMessageModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BaseLoot, Boolean> <>9__19_0; //Field offset: 0x8
		public static Func<BaseLoot, Boolean> <>9__19_1; //Field offset: 0x10
		public static Func<BaseLoot, Boolean> <>9__19_2; //Field offset: 0x18
		public static Func<ProfileBanner, String> <>9__22_2; //Field offset: 0x20
		public static Func<ProfileAvatar, String> <>9__22_4; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <AddLoot>b__22_2(ProfileBanner banner) { }

		internal string <AddLoot>b__22_4(ProfileAvatar avatar) { }

		internal bool <get_HasValidReward>b__19_0(BaseLoot x) { }

		internal bool <get_HasValidReward>b__19_1(BaseLoot x) { }

		internal bool <get_HasValidReward>b__19_2(BaseLoot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public List<String> errors; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal void <Parse>b__0(object sender, ErrorEventArgs args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public string legendsIapId; //Field offset: 0x10
		public List<TrophyStoreItem> legendsTrophyStoreItems; //Field offset: 0x18
		public Func<TrophyItemTypeData, Boolean> <>9__5; //Field offset: 0x20

		public <>c__DisplayClass22_0() { }

		internal bool <AddLoot>b__0(TrophyStoreItem x) { }

		internal bool <AddLoot>b__1(ProfileBanner banner) { }

		internal bool <AddLoot>b__3(ProfileAvatar avatar) { }

		internal bool <AddLoot>b__5(TrophyItemTypeData itemType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_1
	{
		public ProfileBanner banner; //Field offset: 0x10

		public <>c__DisplayClass22_1() { }

		internal bool <AddLoot>b__6(TrophyStoreItem trophyStoreItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_2
	{
		public ProfileAvatar avatar; //Field offset: 0x10

		public <>c__DisplayClass22_2() { }

		internal bool <AddLoot>b__7(TrophyStoreItem trophyStoreItem) { }

	}

	[CompilerGenerated]
	private struct <AddLoot>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GiftCurrency[] giftCurrencies; //Field offset: 0x20
		public GiftMessageModel <>4__this; //Field offset: 0x28
		private Btd6Player <player>5__2; //Field offset: 0x30
		private bool <isOnlineProfileGift>5__3; //Field offset: 0x38
		private GiftCurrency[] <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48
		private GiftCurrency <giftCurrency>5__6; //Field offset: 0x50
		private BossEvent <bossEvent>5__7; //Field offset: 0x58
		private TaskAwaiter<BossDataModel> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Parse>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GiftMessageModel <>4__this; //Field offset: 0x20
		public string serverGiftJson; //Field offset: 0x28
		private ServerGift <serverGift>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public readonly string id; //Field offset: 0x10
	public readonly LootSet loot; //Field offset: 0x18
	public readonly LootSet visualOnlyLoot; //Field offset: 0x20
	public readonly LootSet invisibleLoot; //Field offset: 0x28
	private GiftCurrency[] currencies; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsPrimeDrop>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsPhatMojo>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x40
	private bool isParsed; //Field offset: 0x48

	public bool HasValidReward
	{
		 get { } //Length: 634
	}

	public private bool IsPhatMojo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsPrimeDrop
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string Message
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public GiftMessageModel(string id) { }

	[AsyncStateMachine(typeof(<AddLoot>d__22))]
	private Task AddLoot(GiftCurrency[] giftCurrencies) { }

	private string FixTowerName(string towerName) { }

	public bool get_HasValidReward() { }

	[CompilerGenerated]
	public bool get_IsPhatMojo() { }

	[CompilerGenerated]
	public bool get_IsPrimeDrop() { }

	[CompilerGenerated]
	public string get_Message() { }

	private static Int32[] GetTiers(string tiers) { }

	[AsyncStateMachine(typeof(<Parse>d__21))]
	public Task Parse(string serverGiftJson) { }

	[CompilerGenerated]
	private void set_IsPhatMojo(bool value) { }

	[CompilerGenerated]
	private void set_IsPrimeDrop(bool value) { }

	[CompilerGenerated]
	private void set_Message(string value) { }

}

