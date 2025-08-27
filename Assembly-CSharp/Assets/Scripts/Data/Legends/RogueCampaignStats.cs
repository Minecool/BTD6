namespace Assets.Scripts.Data.Legends;

public class RogueCampaignStats
{
	public int gameTilesWon; //Field offset: 0x10
	public int specialTilesWon; //Field offset: 0x14
	public int bloonEncountersWon; //Field offset: 0x18
	public int tokensSpent; //Field offset: 0x1C
	public int heartsLost; //Field offset: 0x20
	public int encountersReloaded; //Field offset: 0x24
	public int boostsPlaced; //Field offset: 0x28
	public List<String> towerTypesPlaced; //Field offset: 0x30
	public int artifactsEarned; //Field offset: 0x38
	public int boostsChosen; //Field offset: 0x3C
	public DateTime startTimeStamp; //Field offset: 0x40

	public RogueCampaignStats() { }

	public void AddTowerTypePlaced(string type) { }

	public void Combine(RogueCampaignStats other) { }

	public float GetStatFromKey(string locKey) { }

	public List<String> GetStatLocKeys() { }

}

