namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopPlayerRibbonPanel : MonoBehaviour
{
	public NK_TextMeshProUGUI mainInfoTxt; //Field offset: 0x20
	public NK_TextMeshProUGUI subInfoTxt; //Field offset: 0x28
	public GameObject ribbonPanel; //Field offset: 0x30
	public Image towerIcon; //Field offset: 0x38

	public CoopPlayerRibbonPanel() { }

	public void Initialise(bool active, Sprite icon, string titleText, string subText, double data) { }

}

