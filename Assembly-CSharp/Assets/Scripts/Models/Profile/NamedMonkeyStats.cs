namespace Assets.Scripts.Models.Profile;

public class NamedMonkeyStats
{
	public string name; //Field offset: 0x10
	public string baseTower; //Field offset: 0x18
	public KonFuze gamesWon; //Field offset: 0x20
	public KonFuze highestRound; //Field offset: 0x28
	public KonFuze timesPlaced; //Field offset: 0x30
	public KonFuze totalPopCount; //Field offset: 0x38
	public KonFuze totalCoopPopCount; //Field offset: 0x40
	public KonFuze camoBloonsPopped; //Field offset: 0x48
	public KonFuze leadBloonsPopped; //Field offset: 0x50
	public KonFuze purpleBloonsPopped; //Field offset: 0x58
	public KonFuze regrowBloonsPopped; //Field offset: 0x60
	public KonFuze ceramicBloonsPopped; //Field offset: 0x68
	public KonFuze moabsPopped; //Field offset: 0x70
	public KonFuze bfbsPopped; //Field offset: 0x78
	public KonFuze zomgsPopped; //Field offset: 0x80
	public KonFuze ddtsPopped; //Field offset: 0x88
	public KonFuze badsPopped; //Field offset: 0x90
	public KonFuze bossesPopped; //Field offset: 0x98
	public KonFuze cashGenerated; //Field offset: 0xA0
	public KonFuze abilitiesUsed; //Field offset: 0xA8
	public KonFuze timesUpgraded; //Field offset: 0xB0
	public KonFuze timesSacrificed; //Field offset: 0xB8
	public KonFuze damageDoneToBosses; //Field offset: 0xC0

	public NamedMonkeyStats(string baseTower = null) { }

	public NamedMonkeyStats Clone() { }

	public void Combine(NamedMonkeyStats stats, bool selectedCoopMode) { }

	public void Default() { }

	public NamedMonkeyStats GetChange(NamedMonkeyStats newStats) { }

	public void SetName(string name) { }

}

