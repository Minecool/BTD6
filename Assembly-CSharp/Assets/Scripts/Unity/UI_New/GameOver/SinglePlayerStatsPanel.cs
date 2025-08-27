namespace Assets.Scripts.Unity.UI_New.GameOver;

public class SinglePlayerStatsPanel : MonoBehaviour
{
	public GameObject calloutBanner; //Field offset: 0x20
	public NK_TextMeshProUGUI playerHeader; //Field offset: 0x28
	public NK_TextMeshProUGUI mainHeaderInfoTxt; //Field offset: 0x30
	public NK_TextMeshProUGUI subHeaderInfoTxt; //Field offset: 0x38
	public Image towerIcon; //Field offset: 0x40
	public NK_TextMeshProUGUI[] headerStatTxt; //Field offset: 0x48
	public NK_TextMeshProUGUI[] outputStatTxt; //Field offset: 0x50
	public GameObject glowPanel; //Field offset: 0x58
	public GameObject monkeyStarDetailsPanel; //Field offset: 0x60
	public GameObject monkeyStarPopPanel; //Field offset: 0x68
	public NK_TextMeshProUGUI popInfoCountTxt; //Field offset: 0x70
	public GameObject monkeyStarCashPanel; //Field offset: 0x78
	public NK_TextMeshProUGUI cashInfoCountTxt; //Field offset: 0x80
	public NK_TextMeshProUGUI mainInfoTxt; //Field offset: 0x88
	public NK_TextMeshProUGUI towerInfo; //Field offset: 0x90
	public Image instaTowerIcon; //Field offset: 0x98
	public Image popInfoIcon; //Field offset: 0xA0

	public SinglePlayerStatsPanel() { }

	public void Initialise(bool isDisbled, string playerName, bool calloutEnabled, Sprite playerCalloutSprite, string calloutTitleLoc, string calloutSubTextLoc, double calloutSubTextData) { }

}

