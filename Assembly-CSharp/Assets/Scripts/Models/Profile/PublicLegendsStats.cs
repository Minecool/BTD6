namespace Assets.Scripts.Models.Profile;

public class PublicLegendsStats
{
	internal enum StatNames
	{
		RogueTilesCaptured = 0,
		RogueCampaignMapsWon = 1,
		RogueCommonArtifactsCollected = 2,
		RogueRareArtifactsCollected = 3,
		RogueLegendaryArtifactsCollected = 4,
		RogueExtractedArtifacts = 5,
		RogueStandardTilesCaptured = 6,
		RogueMiniGameTilesCaptured = 7,
		RogueMiniBossTilesCaptured = 8,
		RogueCommonBoostsCollected = 9,
		RogueRareBoostsCollected = 10,
		RogueLegendaryBoostsCollected = 11,
		PlayerStatsMonkeysPlaced = 12,
		PlayerStatsPopCount = 13,
		PlayerStatsCamoPopped = 14,
		PlayerStatsLeadPopped = 15,
		PlayerStatsPurplePopped = 16,
		PlayerStatsRegrowPopped = 17,
		PlayerStatsCeramicPopped = 18,
		PlayerStatsMoabsPopped = 19,
		PlayerStatsBfbsPopped = 20,
		PlayerStatsZomgsPopped = 21,
		PlayerStatsDdtsPopped = 22,
		PlayerStatsBadsPopped = 23,
		PlayerStatsBossesPopped = 24,
		PlayerStatsAbilitiesUsed = 25,
		PlayerStatsMonkeysUpgraded = 26,
		PlayerStatsDamageDoneToBosses = 27,
	}

	public int rogueTilesCaptured; //Field offset: 0x10
	public int rogueCampaignMapsWon; //Field offset: 0x14
	public int rogueCommonArtifactsCollected; //Field offset: 0x18
	public int rogueRareArtifactsCollected; //Field offset: 0x1C
	public int rogueLegendaryArtifactsCollected; //Field offset: 0x20
	public int rogueExtractedArtifacts; //Field offset: 0x24
	public int rogueStandardTilesCaptured; //Field offset: 0x28
	public int rogueMiniGameTilesCaptured; //Field offset: 0x2C
	public int rogueMiniBossTilesCaptured; //Field offset: 0x30
	public int rogueCommonBoostsCollected; //Field offset: 0x34
	public int rogueRareBoostsCollected; //Field offset: 0x38
	public int rogueLegendaryBoostsCollected; //Field offset: 0x3C
	public int rogueMonkeysPlaced; //Field offset: 0x40
	public int rogueTotalPopCount; //Field offset: 0x44
	public int rogueCamoBloonsPopped; //Field offset: 0x48
	public int rogueLeadBloonsPopped; //Field offset: 0x4C
	public int roguePurpleBloonsPopped; //Field offset: 0x50
	public int rogueRegrowBloonsPopped; //Field offset: 0x54
	public int rogueCeramicBloonsPopped; //Field offset: 0x58
	public int rogueMoabsPopped; //Field offset: 0x5C
	public int rogueBfbsPopped; //Field offset: 0x60
	public int rogueZomgsPopped; //Field offset: 0x64
	public int rogueDdtsPopped; //Field offset: 0x68
	public int rogueBadsPopped; //Field offset: 0x6C
	public int rogueBossesPopped; //Field offset: 0x70
	public int rogueAbilitiesUsed; //Field offset: 0x74
	public int rogueMonkeysUpgraded; //Field offset: 0x78
	public int rogueDamageDoneToBosses; //Field offset: 0x7C

	[JsonConstructor]
	public PublicLegendsStats() { }

	public PublicLegendsStats(LegendsStats ls) { }

	public static String[] GetStatNames() { }

	public bool IsDefaultValues() { }

}

