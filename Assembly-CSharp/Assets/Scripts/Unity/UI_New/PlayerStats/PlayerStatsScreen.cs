namespace Assets.Scripts.Unity.UI_New.PlayerStats;

public class PlayerStatsScreen : GameMenu
{
	[CompilerGenerated]
	private struct <<Open>b__117_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Open>b__117_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ProfileAvatar, Boolean> <>9__147_1; //Field offset: 0x8
		public static Func<ProfileBanner, Boolean> <>9__147_2; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, BannerItem>, Boolean> <>9__147_0; //Field offset: 0x18
		public static Func<KeyValuePair`2<Int32, BossMedalSaveData>, Int32> <>9__157_0; //Field offset: 0x20
		public static Func<Int32, Boolean> <>9__159_1; //Field offset: 0x28
		public static Comparison<KeyValuePair`2<String, Int32>> <>9__172_0; //Field offset: 0x30
		public static Comparison<KeyValuePair`2<String, Int32>> <>9__172_1; //Field offset: 0x38
		public static Func<KeyValuePair`2<String, BannerItem>, Boolean> <>9__179_0; //Field offset: 0x40
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"legendsType", "legendsIapId"}])]
		public static Func<LegendsType, ValueTuple`2<LegendsType, String>> <>9__184_0; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal int <LoadAndShowBossMedals>b__157_0(KeyValuePair<Int32, BossMedalSaveData> kvp) { }

		internal bool <LoadTrophyStoreItemsAsync>b__147_0(KeyValuePair<String, BannerItem> o) { }

		internal bool <LoadTrophyStoreItemsAsync>b__147_1(ProfileAvatar x) { }

		internal bool <LoadTrophyStoreItemsAsync>b__147_2(ProfileBanner x) { }

		internal ValueTuple<LegendsType, String> <OnClickBuyIAP>b__184_0(LegendsType legendsType) { }

		internal bool <OnClickUiSettings>b__179_0(KeyValuePair<String, BannerItem> o) { }

		internal int <PopulateTowers>b__172_0(KeyValuePair<String, Int32> a, KeyValuePair<String, Int32> b) { }

		internal int <PopulateTowers>b__172_1(KeyValuePair<String, Int32> a, KeyValuePair<String, Int32> b) { }

		internal bool <ShowNoMedalTxtObj>b__159_1(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass146_0
	{
		public TowerDetailsModel towerSet; //Field offset: 0x10
		public Func<String, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass146_0() { }

		internal bool <SetDefaults>b__0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass173_0
	{
		public PlayerStatsScreen <>4__this; //Field offset: 0x10
		public AvatarItem avatarItem; //Field offset: 0x18

		public <>c__DisplayClass173_0() { }

		internal void <PopulateAvatarItem>b__0(bool selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass174_0
	{
		public PlayerStatsScreen <>4__this; //Field offset: 0x10
		public BannerItem bannerItem; //Field offset: 0x18

		public <>c__DisplayClass174_0() { }

		internal void <PopulateBannerItem>b__0(bool selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass176_0
	{
		public string trophyStoreId; //Field offset: 0x10

		public <>c__DisplayClass176_0() { }

		internal bool <IsLimitedItemActive>b__0(TrophyEvent trophyEvent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass184_0
	{
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass184_0() { }

		internal bool <OnClickBuyIAP>b__1(ValueTuple<LegendsType, String> x) { }

		internal bool <OnClickBuyIAP>b__2(ValueTuple<LegendsType, String> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass192_0
	{
		public PlayerStatsScreen <>4__this; //Field offset: 0x10
		public string name; //Field offset: 0x18
		public ReturnCallback <>9__1; //Field offset: 0x20
		public ReturnCallback <>9__2; //Field offset: 0x28

		public <>c__DisplayClass192_0() { }

		internal void <OnSetNamedMonkeyName>b__0(bool noProfanity) { }

		internal void <OnSetNamedMonkeyName>b__1() { }

		internal void <OnSetNamedMonkeyName>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass202_0
	{
		public string unlockPlayScene; //Field offset: 0x10
		public object menuData; //Field offset: 0x18

		public <>c__DisplayClass202_0() { }

		internal void <SetGoButton>b__0() { }

	}

	[CompilerGenerated]
	private struct <CheckForProfanity>d__195 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ProfanityFinish callOnFinish; //Field offset: 0x28
		public string str; //Field offset: 0x30
		private ProfanityFinish <>7__wrap1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FollowToggled>d__143 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x28
		private HashSet<String> <followingPlayers>5__2; //Field offset: 0x30
		private bool <isFollowingPlayer>5__3; //Field offset: 0x38
		private int <increment>5__4; //Field offset: 0x3C
		private Nullable<Int32> <currentCount>5__5; //Field offset: 0x40
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x48
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAndSetPlayerName>d__153 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTrophyStoreItemsAsync>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x28
		private TrophyStoreBankData <trophyStoreBankData>5__2; //Field offset: 0x30
		private TaskAwaiter<TrophyStoreBankData> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40
		private TaskAwaiter<Dictionary`2<String, TeamStoreItemContributions>> <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChangeIsOnlineStatus>d__206 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickBuyAsync>d__183 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickInviteToTeam>d__151 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Guild_GetMemberResponse> <>u__1; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickSendFriendRequest>d__150 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetAccoladesSection>d__141 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string playerID; //Field offset: 0x20
		public PlayerStatsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetFollowSection>d__142 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerStatsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateFollowersBank>d__144 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string playerId; //Field offset: 0x20
		public int increment; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum ContextMode
	{
		Settings = 0,
		MonkeyName = 1,
		Medals = 2,
	}

	private enum CosmeticsTab
	{
		none = 0,
		banner = 1,
		avatar = 2,
	}

	private sealed class ProfanityFinish : MulticastDelegate
	{

		public ProfanityFinish(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool result) { }

	}

	private enum StatCategoryValue
	{
		Overall = 0,
		MainGame = 1,
		Rogue = 2,
	}

	private const string FollowerBankWallet = "followers"; //Field offset: 0x0
	private const int kIndexOffset = 6; //Field offset: 0x0
	private const int maxSharedStats = 7; //Field offset: 0x0
	private const string All = "All"; //Field offset: 0x0
	private const string FollowerCountName = "followerCount"; //Field offset: 0x0
	public GameObject overallStatsPublic; //Field offset: 0x48
	public GameObject overallStatsPrivate; //Field offset: 0x50
	public GameObject topTowerPrefab; //Field offset: 0x58
	public GameObject topTowersContainer; //Field offset: 0x60
	public GameObject topHeroesContainer; //Field offset: 0x68
	public GameObject singlePlayerMedals; //Field offset: 0x70
	public GameObject coopPlayerMedals; //Field offset: 0x78
	public GameObject specialMedals; //Field offset: 0x80
	public GameObject medalPrefab; //Field offset: 0x88
	public Button settingsBtn; //Field offset: 0x90
	public Button avatarSettingsBtn; //Field offset: 0x98
	public Button previewPublicBtn; //Field offset: 0xA0
	public Button okBtn; //Field offset: 0xA8
	public Button cancelBtn; //Field offset: 0xB0
	public Button buyBtn; //Field offset: 0xB8
	[SerializeField]
	private Button buyIAPbtn; //Field offset: 0xC0
	public Button questBtn; //Field offset: 0xC8
	public Button goBtn; //Field offset: 0xD0
	public Button bannerButton; //Field offset: 0xD8
	public Button removeButton; //Field offset: 0xE0
	public NK_TextMeshProUGUI playerName; //Field offset: 0xE8
	public NK_TextMeshProUGUI questBtnText; //Field offset: 0xF0
	public Image playerAvatar; //Field offset: 0xF8
	public Image playerAvatarFrame; //Field offset: 0x100
	public Image playerBanner; //Field offset: 0x108
	public NK_TextMeshProUGUI sharedStats; //Field offset: 0x110
	public GameObject noMedalTxtObj; //Field offset: 0x118
	public GameObject onlineStatusObj; //Field offset: 0x120
	public GameObject onlineState; //Field offset: 0x128
	public GameObject invisibleState; //Field offset: 0x130
	public Toggle onlineStatusToggle; //Field offset: 0x138
	public Toggle avatarsTab; //Field offset: 0x140
	public Toggle bannersTab; //Field offset: 0x148
	public GameObject settingsMenu; //Field offset: 0x150
	public ToggleGroup avatarToggles; //Field offset: 0x158
	public ToggleGroup bannerToggles; //Field offset: 0x160
	public GameObject prefabStat; //Field offset: 0x168
	public GameObject statPanel; //Field offset: 0x170
	public AvatarItem avatarItemPrefab; //Field offset: 0x178
	public BannerItem bannerItemPrefab; //Field offset: 0x180
	public BannerItem teamBannerItemPrefab; //Field offset: 0x188
	public Button followBtn; //Field offset: 0x190
	public NK_TextMeshProUGUI followBtnTxt; //Field offset: 0x198
	public Image followingImg; //Field offset: 0x1A0
	public Image followingThrober; //Field offset: 0x1A8
	public Image followerCountThrober; //Field offset: 0x1B0
	public NK_TextMeshProUGUI followerCountTxt; //Field offset: 0x1B8
	public GameObject followerCountContainer; //Field offset: 0x1C0
	public AudioClip clickSound; //Field offset: 0x1C8
	public AudioClip returnSound; //Field offset: 0x1D0
	public AudioClip selectSound; //Field offset: 0x1D8
	public NK_TextMeshProUGUI level; //Field offset: 0x1E0
	public NK_TextMeshProUGUI xpInfo; //Field offset: 0x1E8
	public Image bar; //Field offset: 0x1F0
	public GameObject vetObj; //Field offset: 0x1F8
	public NK_TextMeshProUGUI vetRankTxt; //Field offset: 0x200
	public NK_TextMeshProUGUI vetXpTxt; //Field offset: 0x208
	public Image vetRankBarImg; //Field offset: 0x210
	[SerializeField]
	private GameObject accoladesObj; //Field offset: 0x218
	[SerializeField]
	private AccoladeStatsDisplay accoladesSentDisplay; //Field offset: 0x220
	[SerializeField]
	private AccoladeStatsDisplay accoladesRecievedDisplay; //Field offset: 0x228
	[SerializeField]
	private GameObject publicAccoladesToggleContainer; //Field offset: 0x230
	[SerializeField]
	private Button publicAccoladesToggleBtn; //Field offset: 0x238
	[SerializeField]
	private Image publicAccoladesToggleTick; //Field offset: 0x240
	public GameObject loadingWheel; //Field offset: 0x248
	public GameObject namedMonkeyMenu; //Field offset: 0x250
	public GameObject namedMonkeyOption; //Field offset: 0x258
	public Button namedMonkeyBannerBtn; //Field offset: 0x260
	public Button gamepadToggleContextBtn; //Field offset: 0x268
	public NK_TextMeshProUGUI gamepadToggleContextTxt; //Field offset: 0x270
	public Transform medalContainer; //Field offset: 0x278
	public string storeIdPrefix; //Field offset: 0x280
	public Button renameMonkeyBtn; //Field offset: 0x288
	public GameObject noHeroesToDisplayObj; //Field offset: 0x290
	[SerializeField]
	private GameObject lockedInfoContainer; //Field offset: 0x298
	[SerializeField]
	private NK_TextMeshProUGUI lockedInfoTxt; //Field offset: 0x2A0
	private readonly List<Btd6PlayerStatPair> publicOverallStatsList; //Field offset: 0x2A8
	private readonly List<Btd6PlayerStatPair> privateMainGameStatsList; //Field offset: 0x2B0
	private readonly List<Btd6PlayerStatPair> privateOverallStatsList; //Field offset: 0x2B8
	private readonly Dictionary<String, AvatarItem> avatarItems; //Field offset: 0x2C0
	private readonly Dictionary<String, BannerItem> bannerItems; //Field offset: 0x2C8
	private readonly Dictionary<String, NamedMonkeyPanel> namedMonkeys; //Field offset: 0x2D0
	private Btd6PlayerStats playerStats; //Field offset: 0x2D8
	private AvatarItem currentlySelectedAvatar; //Field offset: 0x2E0
	private BannerItem currentlySelectedBanner; //Field offset: 0x2E8
	private AvatarItem currentlyEquippedAvatar; //Field offset: 0x2F0
	private BannerItem currentlyEquippedBanner; //Field offset: 0x2F8
	private bool isOwnStats; //Field offset: 0x300
	private bool isPublicPreview; //Field offset: 0x301
	private int selectedStatCount; //Field offset: 0x304
	private List<String> selectedStatIds; //Field offset: 0x308
	private List<String> mainSelectedStatIds; //Field offset: 0x310
	private string selectedNamedMonkey; //Field offset: 0x318
	private bool hasPurchasedNamedMonkeys; //Field offset: 0x320
	private IReadOnlyDictionary<String, TeamStoreItemContributions> teamItemContributions; //Field offset: 0x328
	public GamepadContext gamepadContext; //Field offset: 0x330
	public GamepadContext settingsMenuGamepadContext; //Field offset: 0x338
	public GameObject isTeamMemberImg; //Field offset: 0x340
	public GameObject isFriendImg; //Field offset: 0x348
	public ButtonWithSyncingState inviteToTeamBtn; //Field offset: 0x350
	public ButtonWithSyncingState inviteFriendBtn; //Field offset: 0x358
	[SerializeField]
	private TMP_Dropdown statsCategoryDropdown; //Field offset: 0x360
	private CosmeticsTab selectedTab; //Field offset: 0x368
	private bool _canOpenSettings; //Field offset: 0x36C
	[CompilerGenerated]
	private bool <HasReceivedAccoladesToDisplay>k__BackingField; //Field offset: 0x36D
	[CompilerGenerated]
	private bool <HasSentAccoladesToDisplay>k__BackingField; //Field offset: 0x36E
	private Task setOnlineStatusTask; //Field offset: 0x370

	private static AccoladesSettings AccoladesSettings
	{
		private get { } //Length: 162
	}

	private bool CanOpenSettings
	{
		private get { } //Length: 8
		private set { } //Length: 168
	}

	private bool CanShowAccolades
	{
		private get { } //Length: 281
	}

	private bool HasReceivedAccoladesToDisplay
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool HasSentAccoladesToDisplay
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool IsEditMode
	{
		private get { } //Length: 8
	}

	public PlayerStatsScreen() { }

	[CompilerGenerated]
	private void <Awake>b__116_0(bool _) { }

	[AsyncStateMachine(typeof(<<Open>b__117_0>d))]
	[CompilerGenerated]
	private void <Open>b__117_0() { }

	[AsyncStateMachine(typeof(<<Open>b__117_1>d))]
	[CompilerGenerated]
	private void <Open>b__117_1() { }

	[CompilerGenerated]
	private void <Open>b__117_2() { }

	[CompilerGenerated]
	internal static bool <ShowNoMedalTxtObj>g__HasAnyMedals|159_0(Dictionary<String, Int32>[] medalDataDictionaries) { }

	private void AddSavedStatsToList(List<Btd6PlayerStatPair> statList, ref int currentStatIndex, KeyValuePair<String, Boolean>[] statPairs, string legendKey = "") { }

	protected virtual void Awake() { }

	private void BlockStatSelection(bool blocked) { }

	private bool CanShowUnownedProfileItem(IProfileItem profileItem) { }

	[AsyncStateMachine(typeof(<CheckForProfanity>d__195))]
	private void CheckForProfanity(string str, ProfanityFinish callOnFinish) { }

	private void ClearStats() { }

	public virtual void Close() { }

	private void CreateBossMedal(int bossType, bool isElite, KonFuze value) { }

	[AsyncStateMachine(typeof(<FollowToggled>d__143))]
	private void FollowToggled() { }

	private void GamepadSelectFirst() { }

	private void gamepadToggleContextBtnClick() { }

	private static AccoladesSettings get_AccoladesSettings() { }

	private bool get_CanOpenSettings() { }

	private bool get_CanShowAccolades() { }

	[CompilerGenerated]
	private bool get_HasReceivedAccoladesToDisplay() { }

	[CompilerGenerated]
	private bool get_HasSentAccoladesToDisplay() { }

	private bool get_IsEditMode() { }

	private List<ContextMode> GetActiveModes() { }

	private ContextMode GetContextMode() { }

	private string GetIapStoreId() { }

	private string GetLegendsStatsValue(PublicLegendsStats legendsStats, string statName) { }

	private string GetNamedMonkeyStatValue(PublicNamedMonkeyStats monkeyStats, string statName) { }

	private ContextMode GetNextContextMode() { }

	private string GetPlayerStatValue(Btd6PlayerStats playerStats, string statName) { }

	private int GetSpecificPlayerStatIndex(string statname) { }

	private string GetStoreId() { }

	private bool HasMedals() { }

	private bool HasNamedMonkeys() { }

	private bool IsLimitedItemActive(string trophyStoreId) { }

	[AsyncStateMachine(typeof(<LoadAndSetPlayerName>d__153))]
	private Task LoadAndSetPlayerName() { }

	private void LoadAndShowBossMedals() { }

	private void LoadAndShowLegendMedals() { }

	[AsyncStateMachine(typeof(<LoadTrophyStoreItemsAsync>d__147))]
	private void LoadTrophyStoreItemsAsync() { }

	private void NamedMonkeysBannerClicked() { }

	public void OnBannerButton() { }

	[AsyncStateMachine(typeof(<OnChangeIsOnlineStatus>d__206))]
	public Task OnChangeIsOnlineStatus() { }

	public void OnClickAvatarsTab(bool isEnabled) { }

	public void OnClickBannersTab(bool isEnabled) { }

	[AsyncStateMachine(typeof(<OnClickBuyAsync>d__183))]
	private void OnClickBuyAsync() { }

	private void OnClickBuyIAP() { }

	private void OnClickCancelUi() { }

	private void OnClickConfirmUi() { }

	[AsyncStateMachine(typeof(<OnClickInviteToTeam>d__151))]
	private Task OnClickInviteToTeam() { }

	public void OnClickPreviewPublic() { }

	private void OnClickQuest() { }

	public void OnClickRemoveButton() { }

	[AsyncStateMachine(typeof(<OnClickSendFriendRequest>d__150))]
	private Task OnClickSendFriendRequest() { }

	private void OnClickUiSettings() { }

	private void OnDropdownChanged(int value) { }

	private void OnSelectNamedMonkey(NamedMonkeyPanel panel) { }

	private void OnSetNamedMonkeyName(string name) { }

	public virtual void Open(object data) { }

	private void OpenTrophyStoreMenu(TrophyStoreFilter storeTab, TrophyStoreItem storeItem) { }

	public virtual bool OverrideClose() { }

	private void PopulateAvatarItem(GameObject content, ProfileAvatar profileAvatar, int price, ref string savedAvatarId) { }

	private void PopulateBannerItem(BannerItem prefab, GameObject content, ProfileBanner profileBanner, int price, ref string savedBannerId) { }

	private void PopulateFilteredLegendsStats(StatCategoryValue statCategory) { }

	private void PopulateMedals() { }

	private void PopulateNamedMonkeyStats(string namedMonkeyKey) { }

	private void PopulatePlayerInfo() { }

	private void PopulateStatList(List<Btd6PlayerStatPair> statList, bool isLegends) { }

	private void PopulateStats() { }

	private void PopulateTowers() { }

	private void ProfileItemClicked(ProfileItem item, bool selected) { }

	public virtual void ReOpen(object data) { }

	private void set_CanOpenSettings(bool value) { }

	[CompilerGenerated]
	private void set_HasReceivedAccoladesToDisplay(bool value) { }

	[CompilerGenerated]
	private void set_HasSentAccoladesToDisplay(bool value) { }

	[AsyncStateMachine(typeof(<SetAccoladesSection>d__141))]
	private Task SetAccoladesSection(string playerID) { }

	private void SetAvatarImageAndBanner() { }

	private void SetDefaults() { }

	private void SetFollowBtnTxt(bool isFollowingPlayer) { }

	[AsyncStateMachine(typeof(<SetFollowSection>d__142))]
	private Task SetFollowSection() { }

	private void SetGoButton(bool isCustomLock, bool hasPurchasedCustomLockItem, string unlockPlayScene, string iapId) { }

	private void SetInteractable(bool interactable) { }

	private void SetMonkeyName() { }

	private void SetStatsActive() { }

	private void ShowEarnedMedals(GameObject medalContainer, Dictionary<String, Int32> medalNamesCount, string objectNamePrefix = null) { }

	private bool ShowNoMedalTxtObj() { }

	private void Stat_OnDeselect(Btd6PlayerStatPair statPair) { }

	private void Stat_OnSelect(Btd6PlayerStatPair statPair) { }

	private void Stat_Warning(Btd6PlayerStatPair statPair) { }

	private void TogglePublicAccolades() { }

	private void UpdateAvatarDisplays() { }

	[AsyncStateMachine(typeof(<UpdateFollowersBank>d__144))]
	private Task<Boolean> UpdateFollowersBank(string playerId, int increment) { }

	private void UpdateGamepadToggleContextMessage() { }

	private void UpdateNav() { }

	private void UpdatePlayerAvatarAndBanner() { }

	private void UpdateSettingsMenuBtns(BannerItem bannerItem) { }

	private void UpdateSettingsMenuBtns(AvatarItem avatarItem) { }

}

