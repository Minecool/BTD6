namespace Assets.Scripts.Models.Store;

public class LootSet : List<BaseLoot>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<BaseLoot> <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <SortByType>b__7_0(BaseLoot x, BaseLoot y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__20
	{
		public static readonly <>c__20<T> <>9; //Field offset: 0x0
		public static Predicate<BaseLoot> <>9__20_0; //Field offset: 0x0

		private static <>c__20`1() { }

		public <>c__20`1() { }

		internal bool <FindAllLootByType>b__20_0(BaseLoot l) { }

	}

	[CompilerGenerated]
	private sealed class <>c__21
	{
		public static readonly <>c__21<T> <>9; //Field offset: 0x0
		public static Predicate<BaseLoot> <>9__21_0; //Field offset: 0x0

		private static <>c__21`1() { }

		public <>c__21`1() { }

		internal bool <FindLootByType>b__21_0(BaseLoot l) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public BaseLoot lootType; //Field offset: 0x10

		public <>c__DisplayClass73_0() { }

		internal bool <Equals>b__0(BaseLoot x) { }

	}

	public string activeTower; //Field offset: 0x28
	private string transactionID; //Field offset: 0x30
	public bool dontShowRewardsUI; //Field offset: 0x38
	public string unlockUISceneName; //Field offset: 0x40

	public string TransactionID
	{
		 get { } //Length: 5
		 set { } //Length: 248
	}

	public LootSet() { }

	public void AddAchievement(string achievementName) { }

	public void AddBigBloonsMode() { }

	public void AddBigTowersMode() { }

	public void AddBossBadges(BossType bossType, bool isElite, int quantity, string bossLocs) { }

	public void AddBossLeaderboardBadges(LeaderboardBadgeType badgeType, int quantity, bool isElite) { }

	public void AddCollectionEventItem(int amount) { }

	public void AddContestedTerritoryPointsLoot(int points) { }

	public void AddContestedTerritoryRelicLoot(string relicType) { }

	public void AddCtLeaderboardBadges(LeaderboardBadgeType badgeType, int quantity, bool isGlobal, bool isTeam) { }

	public void AddDoubleCashMode() { }

	public void AddFastTrack() { }

	public void AddFullTowerAndParagonUnlock(string tower) { }

	public void AddFullTowerUnlock(string tower) { }

	public void AddHeroBooster() { }

	public void AddInstaRank(int rankLevel) { }

	public void AddInstaTower(string baseTower, Int32[] tiers, int quantity) { }

	public void AddInstaTowersPacks(int quantity) { }

	public void AddKnowledgePoints(int knowledgePoints) { }

	public void AddLegendsArtifactFeatLoot(string legendsName, string featName) { }

	public void AddLegendsArtifactLoot(string legendsName, string artifactName) { }

	public void AddLegendsUnlockLoot(LegendsType legendsType, bool canUnlock) { }

	public void AddMapEditorUnlock() { }

	public void AddMonkeyMoney(int monkeyMoney, Nullable<Int32> bonusMonkeyMoney = null) { }

	public void AddNexusCreatorLoot(string nexusLoot) { }

	public void AddParagonTowerUnlock(string tower) { }

	public void AddPower(string power, int quantity) { }

	public void AddPowersPacks(int quantity) { }

	public void AddPowersProUnlockLoot(string proPowerId, bool isFullUnlock) { }

	public void AddPropPack(string propPackName) { }

	public void AddQuestUnlock(string questId, int questPartIndex) { }

	public void AddRaceBadges(LeaderboardBadgeType badgeType, int quantity) { }

	public void AddRacesPass(int racesPass) { }

	public void AddRandomInstaMonkey(string fixedBaseMonkey, int tier, int quantity = 1, TowerSet fixedTowerSetType = 0) { }

	public void AddRandomPower(RandomPowerType powerType, int quantity) { }

	public void AddRogueMedalFeatLoot(int amt) { }

	public void AddRogueShopXpLoot(int amount) { }

	public void AddRogueXpShopItemLoot(string xpShopItemName, int level) { }

	public void AddSmallBloonsMode() { }

	public void AddSmallBossesMode() { }

	public void AddSmallTowersMode() { }

	public void AddSweepstakeTicketLoot(int amt, string localizedTitle) { }

	public void AddTeamTrophies(int teamTrophies, Nullable<Int32> bonusTrophies = null) { }

	public void AddTowerUnlock(string baseTowerId, bool showUnlockScreen, bool showUnlockScreenImmediately) { }

	public void AddTowerXP(string tower, int towerXP) { }

	public void AddTrophies(int amount) { }

	public void AddTrophyItem(string id) { }

	public void Apply(LootFrom from) { }

	public LootSet Convert(string tower = "") { }

	public static LootSet Deserialize(string data, LootSet lootSet = null) { }

	public bool Equals(LootSet other) { }

	public List<BaseLoot> FindAllLootByType() { }

	public BaseLoot FindLootByType() { }

	public string get_TransactionID() { }

	public int GetInstaRankLevel() { }

	public List<BaseLoot> GetInstaTowers() { }

	public int GetKnowledgePoints() { }

	public int GetMonkeyMoney() { }

	public List<BaseLoot> GetPowers() { }

	public int GetRacesPassQuantity() { }

	public int GetRandomPowersQuantity() { }

	public int GetTeamTrophyTotal() { }

	public int GetTotalQuantity() { }

	public int GetTowerXP() { }

	public int GetTrophyStoreItems() { }

	public void RemoveHiddenLoot() { }

	public void ResetDailyChest() { }

	public string Serialize() { }

	public void set_TransactionID(string value) { }

	private void SortByType() { }

}

