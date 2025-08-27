namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CtTeamScorePopup : MonoBehaviour
{
	public NK_TextMeshProUGUI regularTilesHeld; //Field offset: 0x20
	public NK_TextMeshProUGUI regularTileIncome; //Field offset: 0x28
	public NK_TextMeshProUGUI relicTilesHeld; //Field offset: 0x30
	public NK_TextMeshProUGUI relicTileIncome; //Field offset: 0x38
	public NK_TextMeshProUGUI bannerTilesHeld; //Field offset: 0x40
	public NK_TextMeshProUGUI bannerTileIncome; //Field offset: 0x48
	public NK_TextMeshProUGUI totalTilesHeld; //Field offset: 0x50
	public NK_TextMeshProUGUI totalTileIncome; //Field offset: 0x58
	public GameObject defaultEmptyPanel; //Field offset: 0x60
	public GameObject containerPanel; //Field offset: 0x68

	public CtTeamScorePopup() { }

	private void SetDetailedIncome(ContestedTerritoryIncome income) { }

	public void SetDetailedPlayerIncome(string playerId) { }

	public void SetDetailedTeamIncome(string guildId) { }

}

