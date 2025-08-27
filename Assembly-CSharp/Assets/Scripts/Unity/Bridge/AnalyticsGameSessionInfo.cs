namespace Assets.Scripts.Unity.Bridge;

public class AnalyticsGameSessionInfo
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_0
	{
		public int playerId; //Field offset: 0x10

		public <>c__DisplayClass90_0() { }

		internal long <GetTotalDamageDoneByPlayerId>b__0(TowerPopInfo t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass91_0
	{
		public int playerId; //Field offset: 0x10

		public <>c__DisplayClass91_0() { }

		internal bool <GetTowersPlacedByPlayerId>b__0(TowerPlaceInfo t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass92_0
	{
		public int playerId; //Field offset: 0x10

		public <>c__DisplayClass92_0() { }

		internal bool <GetPowersActivatedByPlayerId>b__0(PowerActivateInfo p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_0
	{
		public int playerId; //Field offset: 0x10

		public <>c__DisplayClass93_0() { }

		internal bool <GetAbilitiesActivatedByPlayerId>b__0(AbilityActivateInfo a) { }

	}

	internal struct AbilityActivateInfo
	{
		public string abilityName; //Field offset: 0x0
		public string baseTowerName; //Field offset: 0x8
		public string towerName; //Field offset: 0x10
		public Int32[] towerUpgrades; //Field offset: 0x18
		public int round; //Field offset: 0x20
		public int livesCost; //Field offset: 0x24
		public float livesLeft; //Field offset: 0x28
		public int playerId; //Field offset: 0x2C
		public float createdAt; //Field offset: 0x30
		public int x; //Field offset: 0x34
		public int y; //Field offset: 0x38

	}

	internal class BaseTowerUpgradeInfo
	{
		public string baseTowerName; //Field offset: 0x10
		public int round; //Field offset: 0x18
		public float cost; //Field offset: 0x1C
		public bool isHero; //Field offset: 0x20
		public int playerId; //Field offset: 0x24
		public int x; //Field offset: 0x28
		public int y; //Field offset: 0x2C
		public double cashBefore; //Field offset: 0x30
		public double cashAfter; //Field offset: 0x38
		public float createdAt; //Field offset: 0x40

		public BaseTowerUpgradeInfo() { }

		public override BaseTowerUpgradeInfo Clone() { }

	}

	internal struct LifeLeakInfo
	{
		public int round; //Field offset: 0x0
		public int livesLost; //Field offset: 0x4
		public float livesBefore; //Field offset: 0x8
		public float livesAfter; //Field offset: 0xC
		public float shieldBefore; //Field offset: 0x10
		public float shieldAfter; //Field offset: 0x14
		public string leakedBloon; //Field offset: 0x18
		public float createdAt; //Field offset: 0x20

	}

	internal class ParagonUpgradeInfo : BaseTowerUpgradeInfo
	{
		public int paragonDegree; //Field offset: 0x48

		public ParagonUpgradeInfo() { }

		public virtual BaseTowerUpgradeInfo Clone() { }

	}

	internal struct PowerActivateInfo
	{
		public string powerName; //Field offset: 0x0
		public int round; //Field offset: 0x8
		public int x; //Field offset: 0xC
		public int y; //Field offset: 0x10
		public bool isInstamonkey; //Field offset: 0x14
		public int playerId; //Field offset: 0x18
		public float createdAt; //Field offset: 0x1C

	}

	internal class TargettingChangeSummary
	{
		public string baseTowerName; //Field offset: 0x10
		public int round; //Field offset: 0x18
		public int playerId; //Field offset: 0x1C
		public int x; //Field offset: 0x20
		public int y; //Field offset: 0x24
		public int count; //Field offset: 0x28

		public TargettingChangeSummary() { }

		public bool IsMatchingTower(string baseTowerName, int round, int playerId, int x, int y) { }

	}

	internal struct TowerPlaceInfo
	{
		public string baseTowerName; //Field offset: 0x0
		public int round; //Field offset: 0x8
		public float cost; //Field offset: 0xC
		public int x; //Field offset: 0x10
		public int y; //Field offset: 0x14
		public bool isHero; //Field offset: 0x18
		public bool isInsta; //Field offset: 0x19
		public int playerId; //Field offset: 0x1C
		public double cashBefore; //Field offset: 0x20
		public double cashAfter; //Field offset: 0x28
		public float createdAt; //Field offset: 0x30

	}

	internal struct TowerPopInfo
	{
		public ObjectId towerId; //Field offset: 0x0
		public string baseTowerName; //Field offset: 0x8
		public Int32[] resultTiers; //Field offset: 0x10
		public bool isHero; //Field offset: 0x18
		public bool isParagon; //Field offset: 0x19
		public int heroLevel; //Field offset: 0x1C
		public int playerId; //Field offset: 0x20
		public long damageDone; //Field offset: 0x28
		public long cashEarned; //Field offset: 0x30
		public SpriteReference towerDisplay; //Field offset: 0x38
		public bool shouldShowCashIconInstead; //Field offset: 0x40
		public long necroBloonsReanimated; //Field offset: 0x48

	}

	internal struct TowerSellInfo
	{
		public string baseTowerName; //Field offset: 0x0
		public string towerName; //Field offset: 0x8
		public Int32[] tiers; //Field offset: 0x10
		public float claim; //Field offset: 0x18
		public int round; //Field offset: 0x1C
		public int playerId; //Field offset: 0x20
		public double cashBefore; //Field offset: 0x28
		public double cashAfter; //Field offset: 0x30
		public float createdAt; //Field offset: 0x38
		public int x; //Field offset: 0x3C
		public int y; //Field offset: 0x40

	}

	internal class TowerUpgradeInfo : BaseTowerUpgradeInfo
	{
		public Int32[] resultTiers; //Field offset: 0x48
		public int pathUpgraded; //Field offset: 0x50

		public TowerUpgradeInfo() { }

		public virtual BaseTowerUpgradeInfo Clone() { }

	}

	private float startTime; //Field offset: 0x10
	[JsonProperty]
	private float storedSessionLength; //Field offset: 0x14
	public Dictionary<String, Int32> towersPlacedByBaseName; //Field offset: 0x18
	public Dictionary<String, Int32> towersPlacedByName; //Field offset: 0x20
	public Dictionary<String, Int32> towersPlacedByTowerSet; //Field offset: 0x28
	public Dictionary<Int32, Int32> upgradesPurchasedByTier; //Field offset: 0x30
	public Dictionary<Int32, Int32> heroUpgradesPurchasedByTier; //Field offset: 0x38
	public Dictionary<String, Int32> abilitiesActivatedByName; //Field offset: 0x40
	public Dictionary<String, NamedMonkeyStats> namedMonkeyStats; //Field offset: 0x48
	public Dictionary<String, Int32> paragonsPurchasedByName; //Field offset: 0x50
	public int processedTowerIndex; //Field offset: 0x58
	public int processedTowerSoldIndex; //Field offset: 0x5C
	public int processedPowerActivateIndex; //Field offset: 0x60
	public int processedLivesLeakedIndex; //Field offset: 0x64
	public int processedTowerUpgradeIndex; //Field offset: 0x68
	public int processedActivatedAbilities; //Field offset: 0x6C
	public List<BaseTowerUpgradeInfo> upgradesPurchased; //Field offset: 0x70
	public List<TowerPlaceInfo> towersPlaced; //Field offset: 0x78
	public List<TowerPopInfo> towersPopInfo; //Field offset: 0x80
	public List<TowerSellInfo> towersSold; //Field offset: 0x88
	public List<PowerActivateInfo> powersActivated; //Field offset: 0x90
	public List<AbilityActivateInfo> abilitiesActivated; //Field offset: 0x98
	public List<TargettingChangeSummary> targettingChanges; //Field offset: 0xA0
	public List<Int32> bossRushLoseRounds; //Field offset: 0xA8
	public List<LifeLeakInfo> livesLeaked; //Field offset: 0xB0
	public float totalCashGained; //Field offset: 0xB8
	public float cashGainedFromSelling; //Field offset: 0xBC
	public float totalCashSpent; //Field offset: 0xC0
	public double cashEarned; //Field offset: 0xC8
	public double ecoEarned; //Field offset: 0xD0
	public int instaMonkeysUsed; //Field offset: 0xD8
	public int heroesOnScreen; //Field offset: 0xDC
	public string nameOfHeroUsed; //Field offset: 0xE0
	public float heroExpGained; //Field offset: 0xE8
	public int heroLevel; //Field offset: 0xEC
	public int timesHeroPlaced; //Field offset: 0xF0
	public int timesHeroSold; //Field offset: 0xF4
	public long damageDealt; //Field offset: 0xF8
	public int bloonsPopped; //Field offset: 0x100
	public int moabsPopped; //Field offset: 0x104
	public int bfbsPopped; //Field offset: 0x108
	public int zomgsPopped; //Field offset: 0x10C
	public int ddtsPopped; //Field offset: 0x110
	public int badsPopped; //Field offset: 0x114
	public int fortifiedPopped; //Field offset: 0x118
	public int purplesPopped; //Field offset: 0x11C
	public int camosPopped; //Field offset: 0x120
	public int ceramicsPopped; //Field offset: 0x124
	public int regrowPopped; //Field offset: 0x128
	public int leadPopped; //Field offset: 0x12C
	public int bossesPopped; //Field offset: 0x130
	public bool thirdLevelHeroAbilityUsed; //Field offset: 0x134
	public bool tenthLevelHeroAbilityUsed; //Field offset: 0x135
	public double coopCashSent; //Field offset: 0x138
	public double coopCashRecieved; //Field offset: 0x140
	public float livesLost; //Field offset: 0x148
	public float shieldLost; //Field offset: 0x14C
	public bool freeplay; //Field offset: 0x150
	public bool wonGameRoundTrigger; //Field offset: 0x151
	public int bloonsLeaked; //Field offset: 0x154
	public string leaderboardId; //Field offset: 0x158
	public int bloonPopsOnPeninsula; //Field offset: 0x160
	public long bloonPopsMasterAlchemist; //Field offset: 0x168
	public int bloonsRevealedByShimmer; //Field offset: 0x170
	public bool masterOfLife; //Field offset: 0x174
	public int rainbowBloonsPoppedWithMagic; //Field offset: 0x178
	public List<String> whatDidItCostTowers; //Field offset: 0x180
	public bool adoraDarkTempleTransformed; //Field offset: 0x188
	public bool axisOfHavok; //Field offset: 0x189
	public bool kaliMaa; //Field offset: 0x18A
	public float necroBloonsReanimated; //Field offset: 0x18C
	public int tier5InstasUsed; //Field offset: 0x190
	public int dartingGunnerPops; //Field offset: 0x194
	public int ddtFortifiedRemoved; //Field offset: 0x198
	public int mostTowersAtOnce; //Field offset: 0x19C
	public long damageDoneToBoss; //Field offset: 0x1A0
	public int moabTakedownsCount; //Field offset: 0x1A8
	public int redeployChinookCount; //Field offset: 0x1AC
	public HashSet<Int32> roundInstaRewardAwarded; //Field offset: 0x1B0
	public bool perfectParagon; //Field offset: 0x1B8
	public int mostHeroesAtOnce; //Field offset: 0x1BC
	public int criticalHits; //Field offset: 0x1C0
	public int obstaclesRemoved; //Field offset: 0x1C4
	public bool studentLoans; //Field offset: 0x1C8
	public int gluedBloons; //Field offset: 0x1CC
	public double cashSpentThisRound; //Field offset: 0x1D0

	[JsonIgnore]
	public float CurrentSessionLength
	{
		 get { } //Length: 46
	}

	public AnalyticsGameSessionInfo() { }

	public void AddTowerPopInfo(TowerPopInfo popInfo) { }

	public AnalyticsGameSessionInfo Clone() { }

	public float get_CurrentSessionLength() { }

	public int GetAbilitiesActivatedByPlayerId(int playerId) { }

	public int GetPowersActivatedByPlayerId(int playerId) { }

	public long GetTotalDamageDoneByPlayerId(int playerId) { }

	public int GetTowersPlacedByPlayerId(int playerId) { }

	[OnSerializing]
	private void OnSerializingMethod(StreamingContext context) { }

}

