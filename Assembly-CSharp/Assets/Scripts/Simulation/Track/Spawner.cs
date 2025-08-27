namespace Assets.Scripts.Simulation.Track;

public class Spawner : RootBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<BloonEmissionModel> <>9__45_0; //Field offset: 0x8
		public static Predicate<BloonEmissionModel> <>9__47_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <IsRoundOver>b__47_0(BloonEmissionModel x) { }

		internal bool <Process>b__45_0(BloonEmissionModel x) { }

	}

	public int spawnedRound; //Field offset: 0x58
	public int startRound; //Field offset: 0x5C
	public int endRound; //Field offset: 0x60
	public bool isSandbox; //Field offset: 0x64
	public Splitter spawnJunction; //Field offset: 0x68
	public Dictionary<Int32, RoundData> roundData; //Field offset: 0x70
	public List<BloonEmissionModel> emissionsRemoveList; //Field offset: 0x78
	public Action<Boolean> OnRoundSet; //Field offset: 0x80
	public Action<BloonModel> OnPreBloonSpawn; //Field offset: 0x88
	public RoundManager baseRoundManager; //Field offset: 0x90
	public FreeplayRoundManager freeplayRoundManager; //Field offset: 0x98
	public RoundManager roundManager; //Field offset: 0xA0
	public GoldenBloonManager goldenBloonManager; //Field offset: 0xA8
	public BossBloonManager bossBloonManager; //Field offset: 0xB0
	public List<Bloon> bloonsOutsideOfTrack; //Field offset: 0xB8
	public List<Bloon> bloonsOutsideOfTrackRemoveList; //Field offset: 0xC0
	private List<Int32> roundsCreated; //Field offset: 0xC8
	private bool b4FirstWave; //Field offset: 0xD0
	private bool roundsActive; //Field offset: 0xD1
	private List<RoundData> roundDataPool; //Field offset: 0xD8
	private PathSegment spawnOverrideThisFrame; //Field offset: 0xE0
	private BossRushManager bossRushManager; //Field offset: 0xE8
	private bool bossRushOverlapRounds; //Field offset: 0xF0
	private bool isGameEditorGame; //Field offset: 0xF1
	private KonFuze_NoShuffle currentRound; //Field offset: 0xF8
	private readonly List<Int32> roundEmissionsFinished; //Field offset: 0x100
	private Dictionary<Int32, Int32> blockRoundEnding; //Field offset: 0x108
	private readonly List<String> returnValue; //Field offset: 0x110

	public int CurrentRound
	{
		 get { } //Length: 32
	}

	public bool IsGameEditorGame
	{
		 get { } //Length: 8
	}

	public Spawner() { }

	[CompilerGenerated]
	private bool <Emit>b__43_0(Path x) { }

	[CompilerGenerated]
	private bool <GetBossSpawnLocation>b__31_0(Path x) { }

	public void AddEmissions(BloonEmissionModel[] newEmissions, int spawnRound, int emissionIndexOffset = 0) { }

	public bool AreRoundsActive() { }

	public void BlockRoundEnding(int roundNumber) { }

	public void CeaseAllEmissions() { }

	public void CheckForRoundEnd() { }

	private void CheckRoundManager() { }

	public void ClearRoundData() { }

	public Bloon Emit(BloonModel bloonModel, int roundNumber, int emissionIndex, float startingDist = 0, bool ignoreOnSpawnBehaviors = false) { }

	public void ForceAdvanceRound(bool autoStartRound) { }

	public int get_CurrentRound() { }

	public bool get_IsGameEditorGame() { }

	private void GetAllExitPathsForRound(int roundNumber, Path p, List<Path> returnData) { }

	public List<Path> GetAllPathsForRound(int roundNumber) { }

	public Vector3 GetBossSpawnLocation() { }

	public List<String> GetIncomingTags() { }

	public int GetNumberOfUniqueRounds() { }

	private RoundData GetRoundDataFromPool() { }

	public void GetRoundDisplayInfo(out bool b4FirstWave, out bool roundsActive) { }

	public float GetRoundDuration() { }

	public Path[] GetSpawnPathsForRound(int roundNumber) { }

	public void Init() { }

	public bool IsCurrentSpawnRoundEmitting() { }

	private bool IsRoundOver(int round) { }

	public void MatchReady() { }

	public void Process(int elapsed) { }

	public void ResetRound() { }

	private void ReturnRoundDataToPool(RoundData roundData) { }

	public void SetRound(int round, bool fromSave = false) { }

	public void SetSandbox(bool isSandbox) { }

	public void StartRound() { }

	public void UnblockRoundEnding(int roundNumber) { }

}

