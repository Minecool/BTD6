namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopPlayerPanelFreeplay : MonoBehaviour
{
	public NK_TextMeshProUGUI txtPlayerName; //Field offset: 0x20
	public NK_TextMeshProUGUI txtLevel; //Field offset: 0x28
	public Image rankImg; //Field offset: 0x30
	public Sprite regularRankSpr; //Field offset: 0x38
	public Sprite veteranRankSpr; //Field offset: 0x40
	public Image heroIcon; //Field offset: 0x48
	public Image playerNumber; //Field offset: 0x50
	public GameObject playerPanel; //Field offset: 0x58
	public GameObject disconnectedPanel; //Field offset: 0x60
	public CoopConfirmFreeplayPanel loadingPanel; //Field offset: 0x68
	public CoopDifficuiltyMedalPanel medalPanel; //Field offset: 0x70
	public CoopPlayerRibbonPanel ribbonPanel; //Field offset: 0x78
	public Image bannerImage; //Field offset: 0x80
	public GameObject bannerObject; //Field offset: 0x88

	public CoopPlayerPanelFreeplay() { }

	public void Initialise(bool isDisbled, string playerName = "", int playerLvl = 1, bool isVeteran = false, int medalIndex = 0, int medalCount = 0, bool calloutEnabled = false, Sprite calloutSprite = null, string calloutHeader = "", string calloutSubText = "", double calloutData = 0, bool disconnected = false, string bannerName = "") { }

	public void PlayerConfirmedSandbox() { }

	public void PlayerDisconnected() { }

}

