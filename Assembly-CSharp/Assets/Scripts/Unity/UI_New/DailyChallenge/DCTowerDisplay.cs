namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DCTowerDisplay : MonoBehaviour
{
	public TowerImageLoader imgLoader; //Field offset: 0x20
	public GameObject towerCountGO; //Field offset: 0x28
	public TMP_Text towerCountTxt; //Field offset: 0x30
	public GameObject excludedGO; //Field offset: 0x38
	public NK_TextMeshProUGUI excludedTowerPaths; //Field offset: 0x40

	public DCTowerDisplay() { }

}

