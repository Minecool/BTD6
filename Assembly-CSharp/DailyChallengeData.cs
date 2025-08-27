//Type is in global namespace

public class DailyChallengeData
{
	internal class BloonHealthMultipliersData
	{
		public float bloons; //Field offset: 0x10
		public float moabs; //Field offset: 0x14
		public float boss; //Field offset: 0x18

		public BloonHealthMultipliersData() { }

	}

	internal class BloonModifiersData
	{
		public BloonHealthMultipliersData healthMultipliers; //Field offset: 0x10
		public float speedMultiplier; //Field offset: 0x18
		public float moabSpeedMultiplier; //Field offset: 0x1C
		public float bossSpeedMultiplier; //Field offset: 0x20
		public float regrowRateMultiplier; //Field offset: 0x24
		public bool allCamo; //Field offset: 0x28
		public bool allRegen; //Field offset: 0x29

		public BloonModifiersData() { }

	}

	internal class EditorPowerData
	{
		[PowerType]
		public string power; //Field offset: 0x10
		public int max; //Field offset: 0x18

		public EditorPowerData() { }

	}

	internal class EditorTowerData
	{
		internal enum BlockedTiers
		{
			Blocked = -1,
			Available = 0,
			BlockTier5 = 1,
			BlockTier4 = 2,
			BlockTier3 = 3,
			BlockTier2 = 4,
			BlockTier1 = 5,
		}

		[TowerType]
		public string tower; //Field offset: 0x10
		public int max; //Field offset: 0x18
		public BlockedTiers path1NumBlockedTiers; //Field offset: 0x1C
		public BlockedTiers path2NumBlockedTiers; //Field offset: 0x20
		public BlockedTiers path3NumBlockedTiers; //Field offset: 0x24
		public bool restrictParagon; //Field offset: 0x28

		public EditorTowerData() { }

	}

	internal class MapEditorAreaAssets
	{
		[ReorderableList("items", True)]
		[SerializeField]
		private MapEditorAreaDataContainer areasContainer; //Field offset: 0x10

		public IEnumerable<MapEditorAreaData> PlacedAreas
		{
			 get { } //Length: 15
		}

		public MapEditorAreaAssets() { }

		public IEnumerable<MapEditorAreaData> get_PlacedAreas() { }

		public void Import(List<MapEditorAreaData> data) { }

	}

	internal class MapEditorAreaDataContainer
	{
		public MapEditorAreaData[] items; //Field offset: 0x10

		public MapEditorAreaDataContainer() { }

	}

	internal class MapEditorPathAssets
	{
		[ReorderableList("items", True)]
		[SerializeField]
		private MapEditorPathDataContainer pathContainer; //Field offset: 0x10

		public IEnumerable<MapEditorPathData> PlacedPaths
		{
			 get { } //Length: 15
		}

		public MapEditorPathAssets() { }

		public IEnumerable<MapEditorPathData> get_PlacedPaths() { }

		public void Import(List<MapEditorPathData> data) { }

	}

	internal class MapEditorPathDataContainer
	{
		public MapEditorPathData[] items; //Field offset: 0x10

		public MapEditorPathDataContainer() { }

	}

	internal class MapEditorPowerAssets
	{
		[ReorderableList("items", True)]
		[SerializeField]
		private MapEditorPowerDataContainer powersContainer; //Field offset: 0x10

		public IEnumerable<MapEditorPowerData> PlacedPowers
		{
			 get { } //Length: 15
		}

		public MapEditorPowerAssets() { }

		public IEnumerable<MapEditorPowerData> get_PlacedPowers() { }

		public void Import(List<MapEditorPowerData> data) { }

	}

	internal class MapEditorPowerDataContainer
	{
		public MapEditorPowerData[] items; //Field offset: 0x10

		public MapEditorPowerDataContainer() { }

	}

	internal class MapEditorPropAssets
	{
		[ReorderableList("items", True)]
		[SerializeField]
		private MapEditorPropDataContainer propsContainer; //Field offset: 0x10

		public IEnumerable<MapEditorPropData> PlacedProps
		{
			 get { } //Length: 15
		}

		public MapEditorPropAssets() { }

		public IEnumerable<MapEditorPropData> get_PlacedProps() { }

		public void Import(List<MapEditorPropData> data) { }

	}

	internal class MapEditorPropDataContainer
	{
		public MapEditorPropData[] items; //Field offset: 0x10

		public MapEditorPropDataContainer() { }

	}

	internal class MapEditorStampAssets
	{
		[ReorderableList("items", True)]
		[SerializeField]
		private MapEditorStampDataContainer stampsContainer; //Field offset: 0x10

		public IEnumerable<MapEditorStampData> PlacedStamps
		{
			 get { } //Length: 15
		}

		public MapEditorStampAssets() { }

		public IEnumerable<MapEditorStampData> get_PlacedStamps() { }

		public void Import(List<MapEditorStampData> data) { }

	}

	internal class MapEditorStampDataContainer
	{
		public MapEditorStampData[] items; //Field offset: 0x10

		public MapEditorStampDataContainer() { }

	}

	internal class MapEditorTowerAssets
	{
		[ReorderableList("items", True)]
		[SerializeField]
		private MapEditorTowerDataContainer towersContainer; //Field offset: 0x10

		public IEnumerable<MapEditorTowerData> PlacedTowers
		{
			 get { } //Length: 15
		}

		public MapEditorTowerAssets() { }

		public IEnumerable<MapEditorTowerData> get_PlacedTowers() { }

		public void Import(List<MapEditorTowerData> data) { }

	}

	internal class MapEditorTowerDataContainer
	{
		public MapEditorTowerData[] items; //Field offset: 0x10

		public MapEditorTowerDataContainer() { }

	}

	internal class PowerDataContainer
	{
		public EditorPowerData[] items; //Field offset: 0x10

		public PowerDataContainer() { }

	}

	internal class PowerList
	{
		[ReorderableList("items", True)]
		[SerializeField]
		private PowerDataContainer PowerRestrictionsContainer; //Field offset: 0x10

		public IEnumerable<EditorPowerData> Powers
		{
			 get { } //Length: 27
		}

		public PowerList() { }

		public List<PowerData> Convert() { }

		public IEnumerable<EditorPowerData> get_Powers() { }

		public void Import(List<PowerData> datas) { }

	}

	internal class StartRulesData
	{
		public int lives; //Field offset: 0x10
		public int maxLives; //Field offset: 0x14
		public int cash; //Field offset: 0x18
		public int round; //Field offset: 0x1C
		public int endRound; //Field offset: 0x20
		public int revives; //Field offset: 0x24

		public StartRulesData() { }

	}

	internal class TowerDataContainer
	{
		public EditorTowerData[] items; //Field offset: 0x10

		public TowerDataContainer() { }

	}

	internal class TowerList
	{
		[ReorderableList("items", True)]
		[SerializeField]
		private TowerDataContainer TowerRestrictionsContainer; //Field offset: 0x10

		public IEnumerable<EditorTowerData> Towers
		{
			 get { } //Length: 27
		}

		public TowerList() { }

		public List<TowerData> Convert() { }

		public IEnumerable<EditorTowerData> get_Towers() { }

		public void Import(List<TowerData> datas) { }

	}

	public string id; //Field offset: 0x10
	public string name; //Field offset: 0x18
	[MapName]
	public string map; //Field offset: 0x20
	[Difficulty]
	public string difficulty; //Field offset: 0x28
	[Mode]
	public string mode; //Field offset: 0x30
	public CoopDivision coopDivisionType; //Field offset: 0x38
	public ChallengeType chalType; //Field offset: 0x3C
	[Range(0, 5)]
	public float removeableCostMultiplier; //Field offset: 0x40
	[Range(0, 5)]
	public float abilityCooldownReductionMultiplier; //Field offset: 0x44
	[Range(1, 4)]
	public int numberOfPlayers; //Field offset: 0x48
	public int maxTowers; //Field offset: 0x4C
	public int maxPowers; //Field offset: 0x50
	public int leastCashUsed; //Field offset: 0x54
	public int leastTiersUsed; //Field offset: 0x58
	public int seed; //Field offset: 0x5C
	public int maxParagons; //Field offset: 0x60
	public bool ignoreLeastMode; //Field offset: 0x64
	public bool disableSelling; //Field offset: 0x65
	public bool disableMK; //Field offset: 0x66
	public bool disablePowers; //Field offset: 0x67
	public bool disableInstas; //Field offset: 0x68
	public bool disableDoubleCash; //Field offset: 0x69
	public bool disableFastTrack; //Field offset: 0x6A
	public bool noContinues; //Field offset: 0x6B
	public bool noInstaReward; //Field offset: 0x6C
	public bool displayIncludedTowers; //Field offset: 0x6D
	public bool displayIncludedPowers; //Field offset: 0x6E
	public bool disableHeroBoosting; //Field offset: 0x6F
	public bool disableTowerXp; //Field offset: 0x70
	public bool disablePlayerCosmetics; //Field offset: 0x71
	public List<String> roundSets; //Field offset: 0x78
	public BloonModifiersData bloonModifiers; //Field offset: 0x80
	public StartRulesData startRules; //Field offset: 0x88
	[TowerType]
	public String[] temporaryUnlockedTowers; //Field offset: 0x90
	public TowerList towerList; //Field offset: 0x98
	public PowerList powerList; //Field offset: 0xA0
	public String[] rewards; //Field offset: 0xA8
	public MapEditorPropAssets mapEditorPropAssets; //Field offset: 0xB0
	public MapEditorTowerAssets mapEditorTowerAssets; //Field offset: 0xB8
	public MapEditorPowerAssets mapEditorPowerAssets; //Field offset: 0xC0
	public MapEditorStampAssets mapEditorStampAssets; //Field offset: 0xC8
	public MapEditorPathAssets mapEditorPathAssets; //Field offset: 0xD0
	public MapEditorAreaAssets mapEditorAreaAssets; //Field offset: 0xD8
	public int baseMapTextureId; //Field offset: 0xE0
	public string musicTrack; //Field offset: 0xE8
	[ExtendedDrawer]
	public MapEditorLayerBehaviorsMod mapEditorLayerBehaviorsMod; //Field offset: 0xF0
	[ExtendedDrawer]
	public SimulationBehaviorsMod simulationBehaviorsMod; //Field offset: 0xF8
	public List<String> overriddenPlayerCosmetics; //Field offset: 0x100

	public DailyChallengeModel DCM
	{
		 get { } //Length: 7
	}

	public DailyChallengeData() { }

	private string ConvertRewards() { }

	private DailyChallengeModel GenerateModel() { }

	public DailyChallengeModel get_DCM() { }

	public void ImportCustomMapModelData(CustomMapModel data) { }

	public void ImportDcmData(DailyChallengeModel data) { }

	private String[] ImportRewards(string rewards) { }

}

