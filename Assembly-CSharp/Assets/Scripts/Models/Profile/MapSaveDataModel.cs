namespace Assets.Scripts.Models.Profile;

public class MapSaveDataModel : BaseSaveDataModel
{
	public int version; //Field offset: 0x28
	public int round; //Field offset: 0x2C
	public ObjectId syncedObjectId; //Field offset: 0x30
	public int timeStep; //Field offset: 0x34
	public int roundTimeStep; //Field offset: 0x38
	public bool matchWon; //Field offset: 0x3C
	public bool matchJustWon; //Field offset: 0x3D
	public string gameVersion; //Field offset: 0x40
	public float health; //Field offset: 0x48
	public float shield; //Field offset: 0x4C
	public bool hasTakenLeakDamageLastRound; //Field offset: 0x50
	public bool claimedFreeplayLoot; //Field offset: 0x51
	public string savedMapsId; //Field offset: 0x58
	public string mapName; //Field offset: 0x60
	public string mapDifficulty; //Field offset: 0x68
	public string modeName; //Field offset: 0x70
	public GameType gameType; //Field offset: 0x78
	public int freeplayRoundSeed; //Field offset: 0x7C
	public ObjectId nextFreeAreaId; //Field offset: 0x80
	public List<LoanSaveDataModel> loans; //Field offset: 0x88
	public List<TowerSaveDataModel> placedTowers; //Field offset: 0x90
	public List<PowerSaveDataModel> powerPlaceHistory; //Field offset: 0x98
	public List<PropSaveDataModel> propsRequiringSaveData; //Field offset: 0xA0
	public List<ProjectileSaveDataModel> placedProjectiles; //Field offset: 0xA8
	public List<BloonSaveDataModel> bloons; //Field offset: 0xB0
	public List<String> activeRemoveablesByName; //Field offset: 0xB8
	public List<MapGizmoSaveData> gizmoSaveData; //Field offset: 0xC0
	public Dictionary<String, MapEventSaveData> mapEventSaveData; //Field offset: 0xC8
	public List<TowerDiscountSaveDataModel> towerDiscounts; //Field offset: 0xD0
	public Dictionary<Int32, PlayerSaveData> players; //Field offset: 0xD8
	public Dictionary<String, TowerMaxCountPlacedHistory> towerTypeMaxPlacedHistory; //Field offset: 0xE0
	public List<TowerHistory> towerHistory; //Field offset: 0xE8
	public Dictionary<String, Int32> towerMaxBaseIdAtATime; //Field offset: 0xF0
	public Dictionary<String, List`1<MutatorSaveDataModel>> activeMutators; //Field offset: 0xF8
	public Dictionary<Int32, Int32> emergencyUnlockActivatedAt; //Field offset: 0x100
	public int goldenBloonsPopped; //Field offset: 0x108
	public Nullable<Int32> gameId; //Field offset: 0x10C
	public int attemptId; //Field offset: 0x114
	public int continuesUsed; //Field offset: 0x118
	public Dictionary<String, String> metaData; //Field offset: 0x120
	public double cashSpent; //Field offset: 0x128
	public int tileId; //Field offset: 0x130
	public Nullable<Int64> ts; //Field offset: 0x138
	public List<String> activeRegenRemovablesByName; //Field offset: 0x148
	public HashSet<Int32> playersWhoPlacedAHero; //Field offset: 0x150
	[JsonConverter(typeof(ActiveKnowledgeConverter))]
	public ActiveKnowledge activeKnowledge; //Field offset: 0x158
	[JsonConverter(typeof(ActiveRelicKnowledgeConverter))]
	public ActiveRelicKnowledge activeRelicKnowledge; //Field offset: 0x160
	[JsonConverter(typeof(Assets.Scripts.Unity.Network.ReplayConverter`1<Assets.Scripts.Unity.Network.SinglePlayerReplay>))]
	public Replay replayRecorder; //Field offset: 0x168
	public int bloonLivesLostOverride; //Field offset: 0x170
	public RogueMapSaveData rogueMapSaveData; //Field offset: 0x178

	public MapSaveDataModel() { }

	public bool IsCompatible() { }

}

