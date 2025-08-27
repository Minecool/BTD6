namespace Assets.Scripts.Data;

[CreateAssetMenu(menuName = "BTD6/Game Data")]
public class GameData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RoundSet, RoundSetModel> <>9__54_0; //Field offset: 0x8
		public static Func<IncomeSet, IncomeSetModel> <>9__55_0; //Field offset: 0x10
		public static Func<Mod, ModModel> <>9__56_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal IncomeSetModel <LoadIncomeSetsAsync>b__55_0(IncomeSet m) { }

		internal ModModel <LoadModsAsync>b__56_0(Mod m) { }

		internal RoundSetModel <LoadRoundSetsAsync>b__54_0(RoundSet m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass59_0() { }

		internal bool <RoundSetByName>b__0(RoundSetModel t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass60_0() { }

		internal bool <IncomeSetByName>b__0(IncomeSetModel t) { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameData <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadDataAsync>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameData <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadIncomeSetsAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameData <>4__this; //Field offset: 0x20
		private List<IncomeSet> <incomeSets>5__2; //Field offset: 0x28
		private TaskAwaiter<IList`1<IncomeSet>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadModsAsync>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameData <>4__this; //Field offset: 0x20
		private List<Mod> <mods>5__2; //Field offset: 0x28
		private TaskAwaiter<IList`1<Mod>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadRoundSetsAsync>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameData <>4__this; //Field offset: 0x20
		private List<RoundSet> <roundSets>5__2; //Field offset: 0x28
		private TaskAwaiter<IList`1<RoundSet>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static GameData _instance; //Field offset: 0x0
	public BTD6AssetLibrary assetLibrary; //Field offset: 0x18
	public TextAssetReference gameModel; //Field offset: 0x20
	public StoreItems storeItems; //Field offset: 0x28
	public SkinsData skinsData; //Field offset: 0x30
	public TrophyStoreItems trophyStoreItems; //Field offset: 0x38
	public ProfileAvatars profileAvatars; //Field offset: 0x40
	public ProfileBanners profileBanners; //Field offset: 0x48
	public AchievementData achievements; //Field offset: 0x50
	public Emotes emoteData; //Field offset: 0x58
	public LootIconSprites lootIconSprites; //Field offset: 0x60
	public TowerBackgroundSprites towerBackgroundSprites; //Field offset: 0x68
	public BuffIconSprites buffIconSprites; //Field offset: 0x70
	public RankInfo rankInfo; //Field offset: 0x78
	public MapSet mapSet; //Field offset: 0x80
	public AudioJukeBox audioJukeBox; //Field offset: 0x88
	public DarkTempleAssetChange darkTempleAssetChanges; //Field offset: 0x90
	public Bosses bosses; //Field offset: 0x98
	public ContestedTerritoryData contestedTerritoryData; //Field offset: 0xA0
	public AnimCurve animCurves; //Field offset: 0xA8
	public MenuBackgrounds menuBackgrounds; //Field offset: 0xB0
	public BloonImmuneSoundScriptable bloonImmuneSounds; //Field offset: 0xB8
	public PrefabReference bloonDebugText; //Field offset: 0xC0
	public BloonOverlayData bloonOverlays; //Field offset: 0xC8
	public TeamsData teamsData; //Field offset: 0xD0
	public RelicKnowledgeData relicKnowledge; //Field offset: 0xD8
	public QuestData questData; //Field offset: 0xE0
	public PrefabReference towerEffectText; //Field offset: 0xE8
	public MapEditorData mapEditorData; //Field offset: 0xF0
	public CustomInGameHuds customInGameHuds; //Field offset: 0xF8
	public TrackArrowData trackArrowData; //Field offset: 0x100
	public ModesData modesData; //Field offset: 0x108
	public TextAssetReference profanityFilter; //Field offset: 0x110
	public DynamicFontReferences dynamicFonts; //Field offset: 0x118
	public LootThemes lootThemes; //Field offset: 0x120
	public AllAccolades accolades; //Field offset: 0x128
	public BossRushData bossRushData; //Field offset: 0x130
	public GameEditorData gameEditorData; //Field offset: 0x138
	public RogueData rogueData; //Field offset: 0x140
	public ArtifactsData artifactsData; //Field offset: 0x148
	public TalkingHeadHints talkingHeadHints; //Field offset: 0x150
	public TowerSnappingData towerSnappingData; //Field offset: 0x158
	public GamepadData gamepadData; //Field offset: 0x160
	public PrefabReference hudControllerPrefab; //Field offset: 0x168
	public SweepstakesData sweepstakesData; //Field offset: 0x170
	public PowersProData powersProData; //Field offset: 0x178
	public ModModel[] mods; //Field offset: 0x180
	private RoundSetModel[] roundSets; //Field offset: 0x188
	private IncomeSetModel[] incomeSets; //Field offset: 0x190

	public static GameData Instance
	{
		 get { } //Length: 54
	}

	public GameData() { }

	public ProfileBanner AllBannersFirstOrDefault(string bannerId) { }

	public T FindAssetChangeItem(string id, TrophyItemType typeHint = -1, TeamStoreFlairType teamTypeHint = -1) { }

	public static GameData get_Instance() { }

	public int GetEndRound(string modeDifficulty) { }

	public int GetStartRound(string modeDifficulty) { }

	public IncomeSetModel IncomeSetByName(string name) { }

	public void Init() { }

	[AsyncStateMachine(typeof(<LoadAsync>d__53))]
	public Task LoadAsync() { }

	[AsyncStateMachine(typeof(<LoadDataAsync>d__57))]
	private Task LoadDataAsync() { }

	[AsyncStateMachine(typeof(<LoadIncomeSetsAsync>d__55))]
	private Task LoadIncomeSetsAsync() { }

	[AsyncStateMachine(typeof(<LoadModsAsync>d__56))]
	private Task LoadModsAsync() { }

	[AsyncStateMachine(typeof(<LoadRoundSetsAsync>d__54))]
	private Task LoadRoundSetsAsync() { }

	public RoundSetModel RoundSetByName(string name) { }

}

