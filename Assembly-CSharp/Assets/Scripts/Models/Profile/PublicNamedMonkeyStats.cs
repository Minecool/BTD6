namespace Assets.Scripts.Models.Profile;

public class PublicNamedMonkeyStats
{
	internal enum StatNames
	{
		PlayerStatsGamesWon = 0,
		PlayerStatsHighestRound = 1,
		PlayerStatsTimesPlaced = 2,
		PlayerStatsPopCount = 3,
		PlayerStatsCoopPopCount = 4,
		PlayerStatsCamoPopped = 5,
		PlayerStatsLeadPopped = 6,
		PlayerStatsPurplePopped = 7,
		PlayerStatsRegrowPopped = 8,
		PlayerStatsCeramicPopped = 9,
		PlayerStatsMoabsPopped = 10,
		PlayerStatsBfbsPopped = 11,
		PlayerStatsZomgsPopped = 12,
		PlayerStatsDdtsPopped = 13,
		PlayerStatsBadsPopped = 14,
		PlayerStatsCashGenerated = 15,
		PlayerStatsAbilitiesUsed = 16,
		PlayerStatsTimesUpgraded = 17,
		PlayerStatsTimesSacrificed = 18,
		PlayerStatsBossesPopped = 19,
		PlayerStatsDamageDoneToBosses = 20,
	}

	public string name; //Field offset: 0x10
	public string BaseTower; //Field offset: 0x18
	public int gamesWon; //Field offset: 0x20
	public int highestRound; //Field offset: 0x24
	public int timesPlaced; //Field offset: 0x28
	public long totalPopCount; //Field offset: 0x30
	public long totalCoopPopCount; //Field offset: 0x38
	public long camoBloonsPopped; //Field offset: 0x40
	public long leadBloonsPopped; //Field offset: 0x48
	public long purpleBloonsPopped; //Field offset: 0x50
	public long regrowBloonsPopped; //Field offset: 0x58
	public long ceramicBloonsPopped; //Field offset: 0x60
	public long moabsPopped; //Field offset: 0x68
	public long bfbsPopped; //Field offset: 0x70
	public long zomgsPopped; //Field offset: 0x78
	public long ddtsPopped; //Field offset: 0x80
	public long badsPopped; //Field offset: 0x88
	public long bossesPopped; //Field offset: 0x90
	public long cashGenerated; //Field offset: 0x98
	public long abilitiesUsed; //Field offset: 0xA0
	public long timesUpgraded; //Field offset: 0xA8
	public long timesSacrificed; //Field offset: 0xB0
	public long damageDoneToBosses; //Field offset: 0xB8

	[JsonConstructor]
	public PublicNamedMonkeyStats() { }

	public PublicNamedMonkeyStats(NamedMonkeyStats nms) { }

	public static String[] GetStatNames() { }

	public bool IsDefaultValues() { }

}

