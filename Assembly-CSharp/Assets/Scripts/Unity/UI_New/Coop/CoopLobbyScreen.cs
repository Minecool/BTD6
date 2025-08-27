namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopLobbyScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String> <>9__74_0; //Field offset: 0x8
		public static Func<String, Boolean> <>9__88_0; //Field offset: 0x10
		public static Func<String, String> <>9__99_0; //Field offset: 0x18
		public static Func<TowerData, Boolean> <>9__136_0; //Field offset: 0x20
		public static Action<Exception> <>9__143_0; //Field offset: 0x28
		public static Func<KeyValuePair`2<Byte, String>, Boolean> <>9__170_0; //Field offset: 0x30
		public static Func<KeyValuePair`2<Byte, String>, Boolean> <>9__173_0; //Field offset: 0x38
		public static Func<String, PlayerInfo> <>9__174_0; //Field offset: 0x40
		public static Func<PlayerInfo, Boolean> <>9__174_1; //Field offset: 0x48
		public static Func<PlayerInfo, String> <>9__174_2; //Field offset: 0x50

		private static <>c() { }

		public <>c() { }

		internal PlayerInfo <AreHackersInLobby>b__174_0(string json) { }

		internal bool <AreHackersInLobby>b__174_1(PlayerInfo p) { }

		internal string <AreHackersInLobby>b__174_2(PlayerInfo p) { }

		internal bool <GenerateBossChallengeDCM>b__136_0(TowerData x) { }

		internal bool <get_AllPlayersHaveLinkAccount>b__88_0(string x) { }

		internal string <get_PlayerIdsInLobby>b__74_0(string x) { }

		internal string <InitUI>b__99_0(string difficulty) { }

		internal bool <RequiresHackerCheck>b__173_0(KeyValuePair<Byte, String> kvp) { }

		internal void <StartLobbyConnectionSequence>b__143_0(Exception ex) { }

		internal bool <UpdateFastTrackDisplay>b__170_0(KeyValuePair<Byte, String> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass160_0
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass160_0() { }

		internal bool <PlayerDataChanged>b__0(CoopPlayerPanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass174_0
	{
		public CoopLobbyScreen <>4__this; //Field offset: 0x10
		public IEnumerable<String> playerIds; //Field offset: 0x18

		public <>c__DisplayClass174_0() { }

		internal bool <AreHackersInLobby>b__3(string id) { }

		internal bool <AreHackersInLobby>b__4(string id) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass175_0
	{
		public CoopLobbyScreen <>4__this; //Field offset: 0x10
		public int slotNumber; //Field offset: 0x18

		public <>c__DisplayClass175_0() { }

		internal Task <PlayerInfoClicked>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass182_0
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass182_0() { }

		internal bool <CheckForMyPlayerInfoChanges>b__0(CoopPlayerPanel x) { }

	}

	[CompilerGenerated]
	private struct <AreHackersInLobby>d__174 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		private Enumerator<String, Task<Boolean>> <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangePublicLobby>d__154 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		public bool makePublic; //Field offset: 0x28
		private string <id>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeSlotCountAsync>d__180 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public int newMaxPlayers; //Field offset: 0x28
		public CoopLobbyScreen <>4__this; //Field offset: 0x30
		public int increment; //Field offset: 0x38
		public int slotNumber; //Field offset: 0x3C
		private TaskAwaiter<JObject> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CopyLobbyCodeAsync>d__185 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CountdownToGame>d__148 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCoopGameTypeChanged>d__106 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		public int coopGameTypeIndex; //Field offset: 0x28
		private CoopGameType <previousCoopGameType>5__2; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayerInfoClickedAsync>d__176 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int slotNumber; //Field offset: 0x20
		public CoopLobbyScreen <>4__this; //Field offset: 0x28
		private bool <isOwnStats>5__2; //Field offset: 0x30
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PreLoadBossEventData>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<BossDataModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequiresHackerCheck>d__173 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetCoopGameType>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		public CoopGameType newGameType; //Field offset: 0x28
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x30
		private TaskAwaiter<BossDataModel> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetPublicButtonAsync>d__169 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x28
		private CancellationToken <token>5__2; //Field offset: 0x30
		private bool <canBePublic>5__3; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartLobbyConnectionSequence>d__143 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		private LobbyConnection <>7__wrap1; //Field offset: 0x28
		private CancellationTokenSource <canceller>5__3; //Field offset: 0x30
		private object <>7__wrap3; //Field offset: 0x38
		private int <>7__wrap4; //Field offset: 0x40
		private CancellationToken <token>5__6; //Field offset: 0x48
		private Task<Boolean> <requiresHackerCheckTask>5__7; //Field offset: 0x50
		private Task<Boolean> <areHackersInLobbyTask>5__8; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x68
		private YieldAwaiter <>u__3; //Field offset: 0x70
		private LobbyBrokenException <lbex>5__9; //Field offset: 0x78
		private NetworkException <ex>5__10; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <VerifyPlayersStatuses>d__144 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <VerifyPlayerStatus>d__145 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		public string playerId; //Field offset: 0x28
		public string expectedStatus; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private bool <isFirstRequest>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitToStartLobby>d__149 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopLobbyScreen <>4__this; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private TaskAwaiter<Task> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class BossEliteChangedMessage : Writable, Writable
	{
		public bool isElite; //Field offset: 0x10

		public BossEliteChangedMessage(bool isElite) { }

		public static BossEliteChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class BossRankedChangedMessage : Writable, Writable
	{
		public bool isRanked; //Field offset: 0x10

		public BossRankedChangedMessage(bool isRanked) { }

		public static BossRankedChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class BossTypeChangedMessage : Writable, Writable
	{
		public int bossType; //Field offset: 0x10

		public BossTypeChangedMessage(int bossType) { }

		public static BossTypeChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class BrokenLobbyMessage : Writable, Writable
	{
		public BrokenLobbyType brokenLobbyType; //Field offset: 0x10

		public BrokenLobbyMessage(BrokenLobbyType brokenLobbyType) { }

		public static BrokenLobbyMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private enum BrokenLobbyType
	{
		OutOfSync = 0,
		HackerDetected = 1,
	}

	private class CoopDivisionTypeChangedMessage : Writable, Writable
	{
		public int coopDivisionType; //Field offset: 0x10

		public CoopDivisionTypeChangedMessage(int coopDivisionType) { }

		public static CoopDivisionTypeChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class CoopGameTypeChangedMessage : Writable, Writable
	{
		public CoopGameType coopGameType; //Field offset: 0x10
		public string mapId; //Field offset: 0x18
		public bool goldenBloonActive; //Field offset: 0x20
		public bool monkeyTeamsActive; //Field offset: 0x21
		public String[] monkeyTeams; //Field offset: 0x28
		public bool collectionBonusActive; //Field offset: 0x30
		public string difficulty; //Field offset: 0x38
		public string gameMode; //Field offset: 0x40
		public int coopDivision; //Field offset: 0x48
		public bool bossEliteMode; //Field offset: 0x4C
		public bool bossRankedMode; //Field offset: 0x4D
		public string coopDCEventId; //Field offset: 0x50
		public string bossEventId; //Field offset: 0x58
		public int seed; //Field offset: 0x60

		public CoopGameTypeChangedMessage(CoopGameType coopGameType, string mapId, bool goldenBloonActive, bool monkeyTeamsActive, String[] monkeyTeams, bool collectionBonusActive, string difficulty, string gameMode, int coopDivision, bool bossEliteMode, bool bossRankedMode, string coopDCEventId, string bossEventId, int seed) { }

		public static CoopGameTypeChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class DifficultyChangedMessage : Writable, Writable
	{
		public string difficulty; //Field offset: 0x10

		public DifficultyChangedMessage(string difficulty) { }

		public static DifficultyChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class GameModeChangedMessage : Writable, Writable
	{
		public string gameMode; //Field offset: 0x10
		public bool goldenBloonActive; //Field offset: 0x18

		public GameModeChangedMessage(string gameMode, bool goldenBloonActive) { }

		public static GameModeChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class LobbyBrokenException : Exception
	{
		[CompilerGenerated]
		private readonly BrokenLobbyType <BrokenLobbyType>k__BackingField; //Field offset: 0x90

		public BrokenLobbyType BrokenLobbyType
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public LobbyBrokenException(BrokenLobbyType brokenLobbyType) { }

		[CompilerGenerated]
		public BrokenLobbyType get_BrokenLobbyType() { }

	}

	private class MapChangedMessage : Writable, Writable
	{
		public string mapId; //Field offset: 0x10
		public bool goldenBloonActive; //Field offset: 0x18
		public bool monkeyTeamsActive; //Field offset: 0x19
		public String[] monkeyTeams; //Field offset: 0x20
		public bool collectionBonusActive; //Field offset: 0x28

		public MapChangedMessage(string mapId, bool goldenBloonActive, bool monkeyTeamsActive, String[] monkeyTeams, bool collectionBonusActive) { }

		public static MapChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class MaxPlayersChangedMessage : Writable, Writable
	{
		public int maxPlayers; //Field offset: 0x10

		public MaxPlayersChangedMessage(int maxPlayers) { }

		public static MaxPlayersChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private enum MessageCode
	{
		BrokenLobby = 0,
		CoopGameTypeChanged = 1,
		MapChanged = 2,
		DifficultyChanged = 3,
		GameModeChanged = 4,
		BossEliteChanged = 5,
		BossRankedChanged = 6,
		MaxPlayersChanged = 7,
		CoopDivisionChanged = 8,
		PlayerStatusUpdated = 9,
		PlayerStatusRequested = 10,
		BossTypeChanged = 11,
		ScoringTypeChanged = 12,
	}

	private class PlayerStatusMessage : Writable, Writable
	{
		public string playerId; //Field offset: 0x10
		public string statusHash; //Field offset: 0x18

		public PlayerStatusMessage(string playerId, string statusHash) { }

		public static PlayerStatusMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class PlayerStatusRequestMessage : Writable, Writable
	{
		public string playerId; //Field offset: 0x10

		public PlayerStatusRequestMessage(string playerId) { }

		public static PlayerStatusRequestMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class ScoringTypeChangedMessage : Writable, Writable
	{
		public int scoringType; //Field offset: 0x10

		public ScoringTypeChangedMessage(int scoringType) { }

		public static ScoringTypeChangedMessage ReadFrom(BinaryReader recieved) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private static LobbyConnection lobbyConnection; //Field offset: 0x0
	public TMP_Dropdown coopGameTypeDD; //Field offset: 0x48
	public GameObject coopGameTypeDDInteractiveObj; //Field offset: 0x50
	public MapInfoPane mapInfoPane; //Field offset: 0x58
	public Button mapSelectBtn; //Field offset: 0x60
	public GameObject mapSelectBtnInteractiveObj; //Field offset: 0x68
	public GameObject coopDivisionSelectUI; //Field offset: 0x70
	public Button coopDivisionLeftBtn; //Field offset: 0x78
	public Button coopDivisionRightBtn; //Field offset: 0x80
	public GameObject standardGameObj; //Field offset: 0x88
	public GameObject bossEventObj; //Field offset: 0x90
	public TMP_Dropdown difficultyDD; //Field offset: 0x98
	public GameObject difficultyDDInteractiveObj; //Field offset: 0xA0
	public TMP_Dropdown gameModeDD; //Field offset: 0xA8
	public GameObject gameModeDDInteractiveObj; //Field offset: 0xB0
	public Image bossImg; //Field offset: 0xB8
	public NK_TextMeshProUGUI bossName; //Field offset: 0xC0
	public Toggle bossEliteTog; //Field offset: 0xC8
	public Toggle bossRankedTog; //Field offset: 0xD0
	public Button changeBossButton; //Field offset: 0xD8
	public BossSelectPanel bossSelectPanel; //Field offset: 0xE0
	public MapSelectPanel bossChallengeMapSelectPanel; //Field offset: 0xE8
	public GameObject togglesGroup; //Field offset: 0xF0
	public Toggle timeTog; //Field offset: 0xF8
	public Toggle cashTog; //Field offset: 0x100
	public Toggle tiersTog; //Field offset: 0x108
	public GameObject scoringIconsGroup; //Field offset: 0x110
	public GameObject leastCashIcon; //Field offset: 0x118
	public GameObject leastTiersIcon; //Field offset: 0x120
	public GameObject gameTimeIcon; //Field offset: 0x128
	public TextMeshProUGUI rankedToggleText; //Field offset: 0x130
	public Button readyBtn; //Field offset: 0x138
	public Button publicBtn; //Field offset: 0x140
	public Button lockedInfoBtn; //Field offset: 0x148
	public GameObject lockedInfoPanel; //Field offset: 0x150
	public Button lockedInfoCloseButton; //Field offset: 0x158
	public GameObject loadingWheel; //Field offset: 0x160
	public NK_TextMeshProUGUI loadingWheelTxt; //Field offset: 0x168
	public GameObject copyCodeTick; //Field offset: 0x170
	public GameObject debugReadyPanel; //Field offset: 0x178
	public NK_TextMeshProUGUI txtGameCode; //Field offset: 0x180
	public Button shareSocialBtn; //Field offset: 0x188
	public Button challengeRulesBtn; //Field offset: 0x190
	public LootPanel lootPanel; //Field offset: 0x198
	public CoopPlayerPanel[] playerPanels; //Field offset: 0x1A0
	[CompilerGenerated]
	private Action CancelEvent; //Field offset: 0x1A8
	private CoopLobbyData coopLobbyData; //Field offset: 0x1B0
	private int maxPlayers; //Field offset: 0x1B8
	private bool gameCountdownStarted; //Field offset: 0x1BC
	private bool isOldFashionedQuickMatch; //Field offset: 0x1BD
	private bool isPublic; //Field offset: 0x1BE
	private TaskCompletionSource<Boolean> readyClicked; //Field offset: 0x1C0
	private Dictionary<String, Task`1<Boolean>> hackerStatuses; //Field offset: 0x1C8
	private readonly Dictionary<String, String> otherPlayersStatusHashes; //Field offset: 0x1D0
	private String[] currDiffGameModes; //Field offset: 0x1D8
	private int bossChallengeSeed; //Field offset: 0x1E0
	private List<CoopGameType> validCoopGameTypes; //Field offset: 0x1E8
	private CoopGameType currCoopGameType; //Field offset: 0x1F0
	private string coopDCEventId; //Field offset: 0x1F8
	private BossDataModel bossDataModel; //Field offset: 0x200
	private BossChallengeMenuData bossChallengeMenuData; //Field offset: 0x208
	public Button debugUnlockAllModes; //Field offset: 0x210
	public Button debugUnlockAllModesBlackChimps; //Field offset: 0x218
	public Button debugImportCustomMapData; //Field offset: 0x220
	public AudioClip playerJoinedSound; //Field offset: 0x228
	public AudioClip playerLeftSound; //Field offset: 0x230
	public GameObject fastTrackMode; //Field offset: 0x238
	private TaskCompletionSource<BossEvent> _bossEvent; //Field offset: 0x240
	private string _bossEventId; //Field offset: 0x248
	private bool isUpdatingGameSettings; //Field offset: 0x250
	private bool _isEliteBoss; //Field offset: 0x251
	private bool _isRankedBoss; //Field offset: 0x252
	private float coopGameTypeCheckerTimer; //Field offset: 0x254
	private CancellationTokenSource publicButtonCanceller; //Field offset: 0x258

	private event Action CancelEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private bool AllPlayersHaveLinkAccount
	{
		private get { } //Length: 343
	}

	private BossEvent BossEvent
	{
		private get { } //Length: 265
	}

	private string BossEventId
	{
		private get { } //Length: 74
		private set { } //Length: 8
	}

	private bool CanPlayRankedBossEvent
	{
		private get { } //Length: 236
	}

	private bool CanStartGame
	{
		private get { } //Length: 32
	}

	private Coop CoopSkuSettings
	{
		private get { } //Length: 147
	}

	public static ConnectionDetails CurrentConnectionDetails
	{
		 get { } //Length: 91
	}

	public static string CurrentLobbyID
	{
		 get { } //Length: 72
	}

	private bool IsEliteBoss
	{
		private get { } //Length: 8
		private set { } //Length: 197
	}

	private bool IsModdedRankedBoss
	{
		private get { } //Length: 67
	}

	private bool IsRankedBoss
	{
		private get { } //Length: 8
		private set { } //Length: 197
	}

	private List<String> LimitedHeroSelection
	{
		private get { } //Length: 71
		private set { } //Length: 10
	}

	public static IEnumerable<String> PlayerIdsInLobby
	{
		 get { } //Length: 345
	}

	public CoopLobbyScreen() { }

	[CompilerGenerated]
	private void <OnMapSelectClicked>b__113_0() { }

	[CompilerGenerated]
	private void <OnShareCodeClicked>b__183_0() { }

	[CompilerGenerated]
	private bool <RefreshOpenCloseButtons>b__165_0(CoopPlayerPanel x) { }

	[CompilerGenerated]
	private bool <RefreshOpenCloseButtons>b__165_1(CoopPlayerPanel x) { }

	[CompilerGenerated]
	private string <SetCoopGameTypeDropdown>b__101_0(CoopGameType gameType) { }

	[CompilerGenerated]
	private void <StartLobbyConnectionSequence>b__143_1() { }

	[CompilerGenerated]
	private void add_CancelEvent(Action value) { }

	[AsyncStateMachine(typeof(<AreHackersInLobby>d__174))]
	private Task<Boolean> AreHackersInLobby() { }

	protected virtual void Awake() { }

	private void BossEventClicked() { }

	private void BossSelectClicked() { }

	private void CancelPublicButtonLoad() { }

	[AsyncStateMachine(typeof(<ChangePublicLobby>d__154))]
	public Task ChangePublicLobby(bool makePublic) { }

	private void ChangeScoringType(LeaderboardScoringType scoringType) { }

	private void ChangeSlotCount(int slotNumber, int increment) { }

	[AsyncStateMachine(typeof(<ChangeSlotCountAsync>d__180))]
	private void ChangeSlotCountAsync(int slotNumber, int increment, int newMaxPlayers) { }

	private void CheckAndSetAvailableGameTypes() { }

	private void CheckForMyPlayerInfoChanges() { }

	private Task<Boolean> CheckHackerStatus(PlayerInfo player) { }

	private void CheckSpecialMapEvents() { }

	private void ClearAnyOldCoopData() { }

	public void CloseSlotClicked(int slotNumber) { }

	private void CopyLobbyCode() { }

	[AsyncStateMachine(typeof(<CopyLobbyCodeAsync>d__185))]
	private Task CopyLobbyCodeAsync() { }

	[AsyncStateMachine(typeof(<CountdownToGame>d__148))]
	private Task CountdownToGame(CancellationToken canceller) { }

	private DailyChallengeModel GenerateBossChallengeDCM() { }

	private bool get_AllPlayersHaveLinkAccount() { }

	private BossEvent get_BossEvent() { }

	private string get_BossEventId() { }

	private bool get_CanPlayRankedBossEvent() { }

	private bool get_CanStartGame() { }

	private Coop get_CoopSkuSettings() { }

	public static ConnectionDetails get_CurrentConnectionDetails() { }

	public static string get_CurrentLobbyID() { }

	private bool get_IsEliteBoss() { }

	private bool get_IsModdedRankedBoss() { }

	private bool get_IsRankedBoss() { }

	private List<String> get_LimitedHeroSelection() { }

	public static IEnumerable<String> get_PlayerIdsInLobby() { }

	private BucketName GetBucketName(bool isPublic) { }

	private string GetCoopGameTypeLocKey(CoopGameType coopGameType) { }

	private PlayerStatusMessage GetCurrentStatusMessage() { }

	private string GetMyStatusHash() { }

	public LeaderboardScoringType GetScoringType() { }

	private LootSet GetVictoryLoot() { }

	private void InitUI() { }

	private void OnBossChanged(BossType bossType) { }

	private void OnBossEliteToggleChanged(bool isElite) { }

	private void OnBossRankedToggleChanged(bool isRanked) { }

	private void OnCoopDivisionLeftClicked() { }

	private void OnCoopDivisionRightClicked() { }

	[AsyncStateMachine(typeof(<OnCoopGameTypeChanged>d__106))]
	private Task OnCoopGameTypeChanged(int coopGameTypeIndex) { }

	private void OnCoopGameTypeChangedAsync(CoopGameType coopGameType) { }

	private void OnCoopGameTypeChangedAsync(int coopGameTypeIndex) { }

	private void OnDifficultyChanged(int value) { }

	private void OnDisconnected() { }

	private void OnGameModeChanged(int value) { }

	public void OnInfoButtonClicked() { }

	public void OnInfoCloseClicked() { }

	private void OnLobbyNotAvailable(string msg) { }

	public void OnMakePublicClicked() { }

	private void OnMapChanged(string newMapId) { }

	private void OnMapSelectClicked() { }

	public void OnReadyClicked() { }

	private void OnScoringTypeClicked(bool isOn) { }

	private void OnShareCodeClicked() { }

	public virtual void Open(object data) { }

	public void OpenSlotClicked(int slotNumber) { }

	public virtual bool OverrideClose() { }

	private void PickRandomForQuickMatch(BucketName bucket) { }

	private void PlayerCountChanged() { }

	private void PlayerDataChanged(byte playerNumber) { }

	public void PlayerInfoClicked(int slotNumber) { }

	[AsyncStateMachine(typeof(<PlayerInfoClickedAsync>d__176))]
	public Task PlayerInfoClickedAsync(int slotNumber) { }

	private void PlayerJoined(byte playerNumber) { }

	private void PlayerLeft(byte playerNumber) { }

	[AsyncStateMachine(typeof(<PreLoadBossEventData>d__95))]
	private Task PreLoadBossEventData() { }

	private void QuitDueToBrokenLobby(BrokenLobbyType brokenLobyType) { }

	public void RecieveChallengeMap(string mapID) { }

	public virtual void ReClose() { }

	private void RefreshOpenCloseButtons() { }

	[CompilerGenerated]
	private void remove_CancelEvent(Action value) { }

	public virtual void ReOpen(object _) { }

	private void ReportCurrentStatus() { }

	[AsyncStateMachine(typeof(<RequiresHackerCheck>d__173))]
	private Task<Boolean> RequiresHackerCheck() { }

	private void set_BossEventId(string value) { }

	private void set_IsEliteBoss(bool value) { }

	private void set_IsRankedBoss(bool value) { }

	private void set_LimitedHeroSelection(List<String> value) { }

	private void SetBossRankedMode(bool isRanked) { }

	[AsyncStateMachine(typeof(<SetCoopGameType>d__108))]
	private Task SetCoopGameType(CoopGameType newGameType) { }

	private void SetCoopGameTypeDropdown(List<CoopGameType> validCoopGameTypes, bool loading = false) { }

	private void SetCoopMapDivision() { }

	private void SetDifficulty(string value) { }

	private void SetGameMode(string value) { }

	private void SetMap(string mapId, bool isFirstLoad = false) { }

	[AsyncStateMachine(typeof(<SetPublicButtonAsync>d__169))]
	private void SetPublicButtonAsync() { }

	private void SetupBoss() { }

	private void SetupBossChallenge() { }

	public void ShowChallengeRules() { }

	[AsyncStateMachine(typeof(<StartLobbyConnectionSequence>d__143))]
	private Task StartLobbyConnectionSequence() { }

	public void Update() { }

	private void UpdateAllPlayerPanels(bool forceRefresh = false) { }

	private void UpdateButtonStates(bool initialState = false) { }

	private void UpdateFastTrackDisplay() { }

	private void UpdatePlayerPanel(CoopPlayerPanel playerPanel, byte playerNumber, PlayerInfo playerInfo, bool animateHeroIcon) { }

	private void UpdateScoringToggles() { }

	[AsyncStateMachine(typeof(<VerifyPlayersStatuses>d__144))]
	private Task VerifyPlayersStatuses(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<VerifyPlayerStatus>d__145))]
	private Task VerifyPlayerStatus(string playerId, string expectedStatus, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WaitToStartLobby>d__149))]
	private Task WaitToStartLobby(CancellationToken canceller) { }

}

