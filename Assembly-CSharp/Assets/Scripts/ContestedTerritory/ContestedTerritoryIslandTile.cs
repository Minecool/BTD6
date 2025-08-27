namespace Assets.Scripts.ContestedTerritory;

public class ContestedTerritoryIslandTile : CtTile
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<ContestedTerritoryGameType, ContestedTerritoryGameSettings>, Boolean> <>9__48_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<ContestedTerritoryGameType, ContestedTerritoryGameSettings>, ContestedTerritoryGameType> <>9__48_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<ContestedTerritoryGameType, ContestedTerritoryGameSettings>, ContestedTerritoryGameSettings> <>9__48_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <GenerateRules>b__48_0(KeyValuePair<ContestedTerritoryGameType, ContestedTerritoryGameSettings> x) { }

		internal ContestedTerritoryGameType <GenerateRules>b__48_1(KeyValuePair<ContestedTerritoryGameType, ContestedTerritoryGameSettings> x) { }

		internal ContestedTerritoryGameSettings <GenerateRules>b__48_2(KeyValuePair<ContestedTerritoryGameType, ContestedTerritoryGameSettings> x) { }

	}

	[CompilerGenerated]
	private struct <UpdateTileAsCaptured>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryIslandTile <>4__this; //Field offset: 0x20
		public NodeStatus newNodeStatus; //Field offset: 0x28
		public bool forceStatusChanged; //Field offset: 0x30
		private bool <hasChanged>5__2; //Field offset: 0x31
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string kNoScoreSetKey = "No Score Set"; //Field offset: 0x0
	private ContestedTerritoryIslandTileRules rules; //Field offset: 0x38
	[CompilerGenerated]
	private NodeStatus <status>k__BackingField; //Field offset: 0x40
	private string capturedByTeamName; //Field offset: 0x48
	private string capturedByPlayerName; //Field offset: 0x50
	private string capturedByPlayerId; //Field offset: 0x58
	private RelicKnowledgeItemBase relicKnowledgeReward; //Field offset: 0x60
	private Nullable<TimeSpan> remainingShieldDuration; //Field offset: 0x68
	public Action TileStatusChanged; //Field offset: 0x78
	public Action OnTileScoreChanged; //Field offset: 0x80
	public bool hasMarker; //Field offset: 0x88
	public int lastCaptureCtPoints; //Field offset: 0x8C

	public BossType BossType
	{
		 get { } //Length: 121
	}

	public DateTime CapturedAt
	{
		 get { } //Length: 27
	}

	public string CapturedByPlayerId
	{
		 get { } //Length: 5
	}

	public string CapturedByPlayerName
	{
		 get { } //Length: 5
	}

	public string CapturedByTeamId
	{
		 get { } //Length: 27
	}

	public string CapturedByTeamName
	{
		 get { } //Length: 5
	}

	public int CurrentScore
	{
		 get { } //Length: 120
	}

	public Nullable<DateTime> FullDegradeAt
	{
		 get { } //Length: 147
	}

	public ContestedTerritoryGameData GameData
	{
		 get { } //Length: 94
	}

	public bool IsBossTile
	{
		 get { } //Length: 40
	}

	public bool IsCaptured
	{
		 get { } //Length: 39
	}

	public bool IsShielded
	{
		 get { } //Length: 57
	}

	public Nullable<DateTime> NextDegradeAt
	{
		 get { } //Length: 147
	}

	public RelicKnowledgeItemBase RelicKnowledgeReward
	{
		 get { } //Length: 5
	}

	public private NodeStatus status
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public ContestedTerritoryIslandTileTheme Theme
	{
		 get { } //Length: 48
	}

	private static NodeStatus UncapturedNodeStatus
	{
		private get { } //Length: 180
	}

	public ContestedTerritoryIslandTile() { }

	public void AddRelicReward(RelicKnowledgeItemBase relicKnowledge) { }

	public void AssignTeam(string teamId) { }

	public void GenerateRules(CtMapGenerationSettings mapGenerationSettings) { }

	public BossType get_BossType() { }

	public DateTime get_CapturedAt() { }

	public string get_CapturedByPlayerId() { }

	public string get_CapturedByPlayerName() { }

	public string get_CapturedByTeamId() { }

	public string get_CapturedByTeamName() { }

	public int get_CurrentScore() { }

	public Nullable<DateTime> get_FullDegradeAt() { }

	public ContestedTerritoryGameData get_GameData() { }

	public bool get_IsBossTile() { }

	public bool get_IsCaptured() { }

	public bool get_IsShielded() { }

	public Nullable<DateTime> get_NextDegradeAt() { }

	public RelicKnowledgeItemBase get_RelicKnowledgeReward() { }

	[CompilerGenerated]
	public NodeStatus get_status() { }

	public ContestedTerritoryIslandTileTheme get_Theme() { }

	private static NodeStatus get_UncapturedNodeStatus() { }

	public ValueTuple<Int32, String> GetRateDisplayString() { }

	public string GetScoreDisplayString() { }

	public void InitialiseTileAsCaptured(NodeStatus nodeStatusBase) { }

	[CompilerGenerated]
	private void set_status(NodeStatus value) { }

	public void SetTileUncaptured() { }

	public void ShieldTile(TimeSpan duration) { }

	[AsyncStateMachine(typeof(<UpdateTileAsCaptured>d__51))]
	public Task UpdateTileAsCaptured(NodeStatus newNodeStatus, bool forceStatusChanged = false) { }

}

