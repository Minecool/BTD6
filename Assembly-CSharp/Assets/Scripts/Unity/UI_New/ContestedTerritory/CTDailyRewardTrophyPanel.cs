namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CTDailyRewardTrophyPanel : MonoBehaviour
{
	[SerializeField]
	private GameObject emptyObj; //Field offset: 0x20
	[SerializeField]
	private GameObject completedObj; //Field offset: 0x28
	[SerializeField]
	private GameObject readyObj; //Field offset: 0x30
	[SerializeField]
	private NK_TextMeshProUGUI teamTrophiesEmptyTxt; //Field offset: 0x38
	[SerializeField]
	private NK_TextMeshProUGUI teamTrophiesReadyTxt; //Field offset: 0x40

	public CTDailyRewardTrophyPanel() { }

	public void SetStatus(DailyRewardPanelStatus status) { }

	public void SetTeamTrophies(int teamTrophies) { }

}

