namespace Assets.Scripts.Models.Profile;

public class AnalyticsKonFuze
{
	public Dictionary<String, KonFuze> heroesPlacedByName; //Field offset: 0x10
	public Dictionary<String, KonFuze> towersPlacedByBaseName; //Field offset: 0x18
	public Dictionary<Int32, KonFuze> upgradesPurchasedByTier; //Field offset: 0x20
	public Dictionary<Int32, KonFuze> heroUpgradesPurchasedByTier; //Field offset: 0x28
	public Dictionary<String, KonFuze> abilitiesActivatedByName; //Field offset: 0x30
	public Dictionary<String, KonFuze> heroLevelsByName; //Field offset: 0x38
	public Dictionary<String, KonFuze> heroWonCount; //Field offset: 0x40
	public Dictionary<String, KonFuze> powerHistory; //Field offset: 0x48
	public Dictionary<String, KonFuze> monkeyTypeWins; //Field offset: 0x50
	public KonFuze gameID; //Field offset: 0x58
	public KonFuze gamesPlayed; //Field offset: 0x60
	public KonFuze bloonsPopped; //Field offset: 0x68
	public KonFuze moabsPopped; //Field offset: 0x70
	public KonFuze bfbsPopped; //Field offset: 0x78
	public KonFuze zomgsPopped; //Field offset: 0x80
	public KonFuze ddtsPopped; //Field offset: 0x88
	public KonFuze badsPopped; //Field offset: 0x90
	public KonFuze fortifiedPopped; //Field offset: 0x98
	public KonFuze purplesPopped; //Field offset: 0xA0
	public KonFuze camosPopped; //Field offset: 0xA8
	public KonFuze bossesPopped; //Field offset: 0xB0
	public KonFuze ceramicsPopped; //Field offset: 0xB8
	public KonFuze regrowPopped; //Field offset: 0xC0
	public KonFuze leadPopped; //Field offset: 0xC8
	public KonFuze totalTowersPlaced; //Field offset: 0xD0
	public KonFuze totalTowersSold; //Field offset: 0xD8
	public KonFuze totalPowersActivated; //Field offset: 0xE0
	public KonFuze totalUpgradesPurchased; //Field offset: 0xE8
	public KonFuze totalAbilitiesActivated; //Field offset: 0xF0
	public KonFuze timesHeroPlaced; //Field offset: 0xF8
	public KonFuze timesHeroSold; //Field offset: 0x100
	public KonFuze timesGameRestarted; //Field offset: 0x108
	public KonFuze thirdLevelHeroAbilityUsed; //Field offset: 0x110
	public KonFuze tenthLevelHeroAbilityUsed; //Field offset: 0x118
	public KonFuze monkeyMoneyEarned; //Field offset: 0x120
	public KonFuze cashEarned; //Field offset: 0x128
	public KonFuze ecoEarned; //Field offset: 0x130
	public KonFuze instaMonkeysUsed; //Field offset: 0x138
	public KonFuze bloonsLeaked; //Field offset: 0x140
	public Dictionary<String, NamedMonkeyStats> namedMonkeyStats; //Field offset: 0x148
	public KonFuze damageDoneToBosses; //Field offset: 0x150
	public BasicStats basicStats; //Field offset: 0x158
	public BasicStats basicStatsFiller; //Field offset: 0x160
	public KonFuze coopMaxHeroesPlacedOnScreen; //Field offset: 0x168
	public KonFuze coopBloonsPopped; //Field offset: 0x170
	public KonFuze coopPowersUsed; //Field offset: 0x178
	public KonFuze coopInstaMonkeysUsed; //Field offset: 0x180
	public KonFuze coopCashGiven; //Field offset: 0x188
	public KonFuze coopMapsBeaten; //Field offset: 0x190
	public KonFuze coop2PlayerMapsBeaten; //Field offset: 0x198
	public KonFuze coop3PlayerMapsBeaten; //Field offset: 0x1A0
	public KonFuze coop4PlayerMapsBeaten; //Field offset: 0x1A8
	public KonFuze coopCashRecieved; //Field offset: 0x1B0
	public KonFuze coopCashSent; //Field offset: 0x1B8
	public KonFuze reportedFirstSession; //Field offset: 0x1C0
	public KonFuze reportedFirstPurchase; //Field offset: 0x1C8
	public KonFuze bloonPopsOnPeninsula; //Field offset: 0x1D0
	public KonFuze bloonPopsMasterAlchemist; //Field offset: 0x1D8
	public KonFuze bloonsRevealedByShimmer; //Field offset: 0x1E0
	public KonFuze masterOfLife; //Field offset: 0x1E8
	public KonFuze rainbowBloonsPoppedWithMagic; //Field offset: 0x1F0
	public List<String> whatDidItCostTowers; //Field offset: 0x1F8
	public KonFuze adoraDarkTempleTransformed; //Field offset: 0x200
	public KonFuze axisOfHavok; //Field offset: 0x208
	public KonFuze kaliMaa; //Field offset: 0x210
	public KonFuze necroBloonsReanimated; //Field offset: 0x218
	public KonFuze toolsToDarwinUpgradeCount; //Field offset: 0x220
	public KonFuze instaCenturyTowerCount; //Field offset: 0x228
	public KonFuze tier5InstasUsed; //Field offset: 0x230
	public KonFuze dartlingGunnerPops; //Field offset: 0x238
	public KonFuze crashOfTheTitansCount; //Field offset: 0x240
	public KonFuze moabTakedownsCount; //Field offset: 0x248
	public KonFuze redeployChinookCount; //Field offset: 0x250
	public Dictionary<String, KonFuze> paragonsPurchasedByName; //Field offset: 0x258
	public KonFuze perfectParagon; //Field offset: 0x260
	public KonFuze criticalHits; //Field offset: 0x268
	public KonFuze studentLoans; //Field offset: 0x270
	public KonFuze gluedBloons; //Field offset: 0x278
	public KonFuze illBeBackMoneySpent; //Field offset: 0x280
	public KonFuze dailyReidCount; //Field offset: 0x288
	public Dictionary<String, LegendsStats> legendsStatsByName; //Field offset: 0x290
	public bool hasTransferredStatsV49; //Field offset: 0x298
	public KonFuze hasPlacedVtsg; //Field offset: 0x2A0
	public KonFuze caveMonkeyRestingPlaceHits; //Field offset: 0x2A8
	public HashSet<String> seenPowers; //Field offset: 0x2B0

	private AnalyticsKonFuze() { }

	public AnalyticsKonFuze(bool initKonfuze = false) { }

	public void AddToSweepstakesStats(AnalyticsKonFuze toAdd) { }

	public void CheckLegacyStats() { }

	public void Combine(AnalyticsKonFuze toCombine, bool selectedCoopMode = false) { }

	public void Default() { }

	public BasicStats GetBasicStats(bool overrideGametype = false, GameType gameTypeOverride = 0) { }

	public int GetGamesWonWithDifferentHeroes() { }

	public LegendsStats GetLegendsStatsByName(string name) { }

	public void Validate() { }

}

