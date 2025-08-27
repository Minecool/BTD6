namespace Assets.Scripts.Data.Legends;

[CreateAssetMenu(fileName = "RogueData", menuName = "BTD6/RogueData")]
public class RogueData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RogueModeGenericRules, Boolean> <>9__105_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetRules>b__105_0(RogueModeGenericRules x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass104_0
	{
		public RogueBloonModifier rogueTileModifier; //Field offset: 0x10

		public <>c__DisplayClass104_0() { }

		internal bool <GetBloonModifierForType>b__0(RogueBloonModifierData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass117_0
	{
		public int bossTier; //Field offset: 0x10
		public IEnumerable<SpawnBloonsActionModel> spawnBloonsActionModels; //Field offset: 0x18

		public <>c__DisplayClass117_0() { }

		internal bool <SwapBloonariusEliteSpawns>b__0(BloonModel bloon) { }

	}

	public const string mainSave = "MainSave"; //Field offset: 0x0
	public const string questSave = "QuestSave"; //Field offset: 0x0
	public const string trainingSave = "TrainingSave"; //Field offset: 0x0
	public const string velocityBoostType = "Velocity"; //Field offset: 0x0
	public const string quickeningBoostType = "Quickening"; //Field offset: 0x0
	public const string toughnessBoostType = "Toughness"; //Field offset: 0x0
	public const string tokenName = "Token"; //Field offset: 0x0
	public const string tokenXpName = "TokenRogueXp"; //Field offset: 0x0
	public const string tokenMonkeyMoneyName = "TokenMonkeyMoney"; //Field offset: 0x0
	public static String[] ignoreCountArtifacts; //Field offset: 0x0
	public string legendsId; //Field offset: 0x18
	public SpriteReference commonBackground; //Field offset: 0x20
	public SpriteReference rareBackground; //Field offset: 0x28
	public SpriteReference legendaryBackground; //Field offset: 0x30
	public SpriteReference enduranceRaceSprite; //Field offset: 0x38
	public SpriteReference raceSprite; //Field offset: 0x40
	public SpriteReference leastCashSprite; //Field offset: 0x48
	public SpriteReference bossRushSprite; //Field offset: 0x50
	public SpriteReference raceSpriteLarge; //Field offset: 0x58
	public SpriteReference leastCashSpriteLarge; //Field offset: 0x60
	public SpriteReference rogueXpIcon; //Field offset: 0x68
	public List<SpriteReference> artifactAllTowerBackgrounds; //Field offset: 0x70
	public List<SpriteReference> artifactPrimaryBackgrounds; //Field offset: 0x78
	public List<SpriteReference> artifactMilitaryBackgrounds; //Field offset: 0x80
	public List<SpriteReference> artifactMagicBackgrounds; //Field offset: 0x88
	public List<SpriteReference> artifactSupportBackgrounds; //Field offset: 0x90
	public List<SpriteReference> boostAllTowerBackgrounds; //Field offset: 0x98
	public List<SpriteReference> boostPrimaryBackgrounds; //Field offset: 0xA0
	public List<SpriteReference> boostMilitaryBackgrounds; //Field offset: 0xA8
	public List<SpriteReference> boostMagicBackgrounds; //Field offset: 0xB0
	public List<SpriteReference> boostSupportBackgrounds; //Field offset: 0xB8
	public SpriteReference tokenArtifactBackground; //Field offset: 0xC0
	public int campaignStageCount; //Field offset: 0xC8
	public int maxInstaInventorySize; //Field offset: 0xCC
	public int maxArtifactInventorySize; //Field offset: 0xD0
	public float heroXpInjectionMultiplier; //Field offset: 0xD4
	public int merchantItemCount; //Field offset: 0xD8
	public int merchantMMTokenCount; //Field offset: 0xDC
	public int merchantXpTokenCount; //Field offset: 0xE0
	public int legendaryTileCount; //Field offset: 0xE4
	public int endOfRoundInstaChance; //Field offset: 0xE8
	public int midRoundInstaChance; //Field offset: 0xEC
	public int bonusRecruitInstas; //Field offset: 0xF0
	public float freeplayBloonHealthPerStage; //Field offset: 0xF4
	public int startingArtifactPower; //Field offset: 0xF8
	public int xpStandardTile; //Field offset: 0xFC
	public int xpLootTile; //Field offset: 0x100
	public int xpRestTile; //Field offset: 0x104
	public int xpMerchantTile; //Field offset: 0x108
	public int xpBronzeScore; //Field offset: 0x10C
	public int xpSilverScore; //Field offset: 0x110
	public int xpGoldScore; //Field offset: 0x114
	public int xpBossPerStage; //Field offset: 0x118
	public float xpMultiplierIncreasePerStage; //Field offset: 0x11C
	public int xpMultiplierScalingStageCap; //Field offset: 0x120
	public List<RogueMapTemplate> mapTemplates; //Field offset: 0x128
	public List<RogueMapTemplate> finalLevelTemplates; //Field offset: 0x130
	public RogueTileAssetData[] rogueTileAssetData; //Field offset: 0x138
	public PrefabReference waterfallTop; //Field offset: 0x140
	public PrefabReference waterfallBottom; //Field offset: 0x148
	public String[] bannedBossMaps; //Field offset: 0x150
	public String[] bannedBossRushMaps; //Field offset: 0x158
	public RogueXpShopItem[] xpShopItems; //Field offset: 0x160
	public RogueXpShopItem[] xpShopCursedItems; //Field offset: 0x168
	public List<RogueHeroStarterKit> rogueHeroStarterKits; //Field offset: 0x170
	public ArtifactDataBase[] startingArtifacts; //Field offset: 0x178
	public SerializableDictionary<String, Int32> powerTowers; //Field offset: 0x180
	public int baseRerollCost; //Field offset: 0x188
	public int baseTokenRerollCost; //Field offset: 0x18C
	public int gridSize; //Field offset: 0x190
	public float reverseChance; //Field offset: 0x194
	public float legendaryChance; //Field offset: 0x198
	public float rareChance; //Field offset: 0x19C
	public float legendaryChancePerStage; //Field offset: 0x1A0
	public float rareChancePerStage; //Field offset: 0x1A4
	public int maxTokenReward; //Field offset: 0x1A8
	public Single[] stage1MapChances; //Field offset: 0x1B0
	public Single[] stage2MapChances; //Field offset: 0x1B8
	public Single[] stage3MapChances; //Field offset: 0x1C0
	public Single[] stage4MapChances; //Field offset: 0x1C8
	public Single[] upgradeCostMultipliers; //Field offset: 0x1D0
	public Single[] purchaseCostMultipliers; //Field offset: 0x1D8
	public float boostInstaCostMultiplier; //Field offset: 0x1E0
	public PrefabReference rogueWorldPrefab; //Field offset: 0x1E8
	public float tileSpacingX; //Field offset: 0x1F0
	public float tileSpacingZ; //Field offset: 0x1F4
	public float tileSpacingGrid; //Field offset: 0x1F8
	public RogueGameModeRules rogueGameModeRules; //Field offset: 0x200
	public int restHealAmount; //Field offset: 0x208
	public int maxLives; //Field offset: 0x20C
	public float xpShopIncreaseMultiplier; //Field offset: 0x210
	public int startingLivesChimps; //Field offset: 0x214
	public int instaInventorySizeAdditionChimps; //Field offset: 0x218
	public float baseStartingCashAdditionChimps; //Field offset: 0x21C
	public float rerollCostMultiplierChimps; //Field offset: 0x220
	public float goalScalingChimps; //Field offset: 0x224
	public float chimpsInstacostMultiplier; //Field offset: 0x228
	public float heroXpMultiplier; //Field offset: 0x22C
	public LegendsUIAudio rogueUIAudio; //Field offset: 0x230
	public RogueBloonModifierData[] bloonModifiers; //Field offset: 0x238
	public LegendsFeatsData featsData; //Field offset: 0x240

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	private static RogueData() { }

	public RogueData() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public SpriteReference GetArtifactFrameOfType(string type, int tier) { }

	public SpriteReference GetBackgroundSprite(int rarity) { }

	public RogueBloonModifierData GetBloonModifierForType(RogueBloonModifier rogueTileModifier) { }

	public SpriteReference GetBoostFrameOfType(string type, int tier) { }

	public string GetBoostType(ArtifactLoot artifact) { }

	public static string GetLocsDescriptionKeyForTileType(RogueTileType type) { }

	public static string GetLocsNameKeyForMinigameType(RogueMiniGameType type) { }

	public static string GetLocsNameKeyForTileType(RogueTileType type) { }

	public SpriteReference GetMinigameGoalSprite(RogueMiniGameType miniGameType) { }

	public SpriteReference GetMinigameLargeSprite(RogueMiniGameType miniGameType) { }

	public RogueModeGenericRules GetRules() { }

	public int GetStartingArtifactPower() { }

	public static void SwapBloonariusEliteSpawns(GameModel moddedGameModel, int stage) { }

}

