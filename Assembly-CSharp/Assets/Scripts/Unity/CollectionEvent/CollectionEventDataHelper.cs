namespace Assets.Scripts.Unity.CollectionEvent;

public class CollectionEventDataHelper
{
	[CompilerGenerated]
	private struct <HasPendingRewards>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public bool navigateToMenuIfNoInternet; //Field offset: 0x20
		public bool canShowNoInternetPopup; //Field offset: 0x21
		public CollectionEventDataHelper <>4__this; //Field offset: 0x28
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum ThemeType
	{
		NOT_SET = -1,
		Easter = 0,
		Halloween = 1,
		Christmas = 2,
		Fireworks = 3,
		Totem = 4,
		PartyTime = 5,
		NUM_OF_THEMES = 6,
	}

	private static CollectionEventDataHelper _instance; //Field offset: 0x0
	private const int numberOfMilestones = 5; //Field offset: 0x0
	[HideInInspector]
	public static string from; //Field offset: 0x8
	private Int32[] milestones; //Field offset: 0x10
	private Int32[] costs; //Field offset: 0x18
	private CollectablesEvent activeEvent; //Field offset: 0x20
	private CollectablesEvent previousEvent; //Field offset: 0x28
	private Collection collection; //Field offset: 0x30
	private CollectionEventDataModel collectionEventProfileData; //Field offset: 0x38
	private InstaMonkeyReward[] instaMonkeyRewards; //Field offset: 0x40
	public readonly SeededRandom seededRandom; //Field offset: 0x48
	public string preferredInstaType; //Field offset: 0x50
	public int preferredInstaIndex; //Field offset: 0x58
	private Nullable<ThemeType> _theme; //Field offset: 0x5C
	private List<LootSet> lootSets; //Field offset: 0x68

	public CollectablesEvent ActiveEvent
	{
		 get { } //Length: 124
	}

	public int AmountCollected
	{
		 get { } //Length: 38
	}

	public int AmountLastSeen
	{
		 get { } //Length: 38
	}

	public int AmountRewardedFor
	{
		 get { } //Length: 38
	}

	public Collection Collection
	{
		 get { } //Length: 5
	}

	public CollectionEventDataModel CollectionEventProfileData
	{
		 get { } //Length: 5
	}

	public Int32[] Costs
	{
		 get { } //Length: 5
	}

	public static CollectionEventDataHelper instance
	{
		 get { } //Length: 254
	}

	public Int32[] Milestones
	{
		 get { } //Length: 5
	}

	public CollectablesEvent PreviousEvent
	{
		 get { } //Length: 5
	}

	public ThemeType Theme
	{
		 get { } //Length: 346
	}

	public CollectablesEvent ThisEvent
	{
		 get { } //Length: 41
	}

	public CollectionEventDataHelper() { }

	public List<LootSet> GenerateLootSets() { }

	public CollectablesEvent get_ActiveEvent() { }

	public int get_AmountCollected() { }

	public int get_AmountLastSeen() { }

	public int get_AmountRewardedFor() { }

	public Collection get_Collection() { }

	public CollectionEventDataModel get_CollectionEventProfileData() { }

	public Int32[] get_Costs() { }

	public static CollectionEventDataHelper get_instance() { }

	public Int32[] get_Milestones() { }

	public CollectablesEvent get_PreviousEvent() { }

	public ThemeType get_Theme() { }

	public CollectablesEvent get_ThisEvent() { }

	public int GetCrateIndex(int amount) { }

	public float GetMilestoneBarProgress(int amount) { }

	public int GetMilestoneIndex(int amount) { }

	public int GetNumOfCollectedItems(string selectedMode, string selectedMap, string selectedDifficulty, bool forceBonus) { }

	public SeededRandom GetServerSeededRandom() { }

	[AsyncStateMachine(typeof(<HasPendingRewards>d__47))]
	public Task<Boolean> HasPendingRewards(bool canShowNoInternetPopup = false, bool navigateToMenuIfNoInternet = false) { }

	public bool IsEventActive() { }

	public bool IsThereAPreviousEvent() { }

	public void OnCollect(bool save = true) { }

	public void SyncToSku() { }

	public bool UpdateLastSeen() { }

}

