namespace Assets.Scripts.Models.Profile;

public class BasicStats
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

	public BasicStats() { }

	public void Combine(BasicStats toCombine, bool selectedCoopMode = false) { }

	public void Default() { }

	public void Validate() { }

}

