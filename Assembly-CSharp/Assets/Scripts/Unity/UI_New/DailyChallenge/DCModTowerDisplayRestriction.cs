namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DCModTowerDisplayRestriction : MonoBehaviour
{
	public TowerImageLoader imgLoader; //Field offset: 0x20
	public TowerData towerData; //Field offset: 0x28
	public NK_TextMeshProUGUI text; //Field offset: 0x30
	public GameObject selectedTowerHighlight; //Field offset: 0x38
	private DCModTowerPathRestriction parentScript; //Field offset: 0x40

	public DCModTowerDisplayRestriction() { }

	public void ButtonClicked() { }

	public void Init(TowerData towerData, DCModTowerPathRestriction parentScript) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void UpdateText() { }

}

