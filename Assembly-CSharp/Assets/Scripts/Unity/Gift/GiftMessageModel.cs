namespace Assets.Scripts.Unity.Gift;

public class GiftMessageModel : ILocalisedGift
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BaseLoot, Boolean> <>9__19_0; //Field offset: 0x8
		public static Func<BaseLoot, Boolean> <>9__19_1; //Field offset: 0x10
		public static Func<BaseLoot, Boolean> <>9__19_2; //Field offset: 0x18
		public static Func<ProfileBanner, String> <>9__20_2; //Field offset: 0x20
		public static Func<ProfileAvatar, String> <>9__20_4; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <AddLoot>b__20_2(ProfileBanner banner) { }

		internal string <AddLoot>b__20_4(ProfileAvatar avatar) { }

		internal bool <Parse>b__19_0(BaseLoot x) { }

		internal bool <Parse>b__19_1(BaseLoot x) { }

		internal bool <Parse>b__19_2(BaseLoot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string legendsIapId; //Field offset: 0x10
		public List<TrophyStoreItem> legendsTrophyStoreItems; //Field offset: 0x18
		public Func<TrophyItemTypeData, Boolean> <>9__5; //Field offset: 0x20

		public <>c__DisplayClass20_0() { }

		internal bool <AddLoot>b__0(TrophyStoreItem x) { }

		internal bool <AddLoot>b__1(ProfileBanner banner) { }

		internal bool <AddLoot>b__3(ProfileAvatar avatar) { }

		internal bool <AddLoot>b__5(TrophyItemTypeData itemType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_1
	{
		public ProfileBanner banner; //Field offset: 0x10

		public <>c__DisplayClass20_1() { }

		internal bool <AddLoot>b__6(TrophyStoreItem trophyStoreItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_2
	{
		public ProfileAvatar avatar; //Field offset: 0x10

		public <>c__DisplayClass20_2() { }

		internal bool <AddLoot>b__7(TrophyStoreItem trophyStoreItem) { }

	}

	[CompilerGenerated]
	private struct <AddLoot>d__20 : IAsyncStateMachine
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
	private struct <Parse>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GiftMessageModel> <>t__builder; //Field offset: 0x8
		public string id; //Field offset: 0x20
		public ServerGift serverGift; //Field offset: 0x28
		private GiftMessageModel <gift>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly LootSet <Loot>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly LootSet <VisualOnlyLoot>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly LootSet <InvisibleLoot>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly Dictionary<String, String> <LocalisedMessages>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly GiftType <GiftType>k__BackingField; //Field offset: 0x38

	public override GiftType GiftType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LootSet InvisibleLoot
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Dictionary<String, String> LocalisedMessages
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LootSet Loot
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LootSet VisualOnlyLoot
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private GiftMessageModel(string id, Dictionary<String, String> localisedMessages, GiftType giftType) { }

	[AsyncStateMachine(typeof(<AddLoot>d__20))]
	private Task AddLoot(GiftCurrency[] giftCurrencies) { }

	public LootSet ApplyAndGetDisplayLoot() { }

	private string FixTowerName(string towerName) { }

	[CompilerGenerated]
	public override GiftType get_GiftType() { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public LootSet get_InvisibleLoot() { }

	[CompilerGenerated]
	public override Dictionary<String, String> get_LocalisedMessages() { }

	[CompilerGenerated]
	public LootSet get_Loot() { }

	[CompilerGenerated]
	public LootSet get_VisualOnlyLoot() { }

	private static Int32[] GetTiers(string tiers) { }

	[AsyncStateMachine(typeof(<Parse>d__19))]
	public static Task<GiftMessageModel> Parse(string id, ServerGift serverGift) { }

}

