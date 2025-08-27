namespace Assets.Scripts.Models.Profile;

public class LegendsStats
{
	public KonFuze tilesCaptured; //Field offset: 0x10
	public KonFuze tilesCapturedWithinCampaign; //Field offset: 0x18
	public KonFuze bossesDefeated; //Field offset: 0x20
	public Dictionary<RogueTileType, KonFuze> winsByTileType; //Field offset: 0x28
	public KonFuze fullParty; //Field offset: 0x30
	public KonFuze campaignMapsWon; //Field offset: 0x38
	public KonFuze loops; //Field offset: 0x40
	public KonFuze masterBlacksmith; //Field offset: 0x48
	public KonFuze overgeared; //Field offset: 0x50
	public KonFuze perfectAdventure; //Field offset: 0x58
	public KonFuze perfectTrade; //Field offset: 0x60
	public KonFuze extractedArtifacts; //Field offset: 0x68
	public KonFuze totalBoostMonkeys; //Field offset: 0x70
	public KonFuze totalArtifacts; //Field offset: 0x78
	public KonFuze trainingWeights; //Field offset: 0x80
	public KonFuze tomfoolery; //Field offset: 0x88
	public HashSet<String> tier5sAcrossAll; //Field offset: 0x90
	public HashSet<String> miniGameTilesCompleted; //Field offset: 0x98
	public HashSet<String> legendaryBoostTypesCollected; //Field offset: 0xA0
	public HashSet<String> towerTypesPlaced; //Field offset: 0xA8
	public KonFuze commonArtifactsCollected; //Field offset: 0xB0
	public KonFuze rareArtifactsCollected; //Field offset: 0xB8
	public KonFuze legendaryArtifactsCollected; //Field offset: 0xC0
	public KonFuze commonBoostsCollected; //Field offset: 0xC8
	public KonFuze rareBoostsCollected; //Field offset: 0xD0
	public KonFuze legendaryBoostsCollected; //Field offset: 0xD8
	public BasicStats basicStats; //Field offset: 0xE0

	public LegendsStats() { }

	public LegendsStats Clone() { }

	public void Combine(LegendsStats stats) { }

	public void Default() { }

}

