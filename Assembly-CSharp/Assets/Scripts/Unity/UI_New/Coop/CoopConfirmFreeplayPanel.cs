namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopConfirmFreeplayPanel : MonoBehaviour
{
	public GameObject loadingPanel; //Field offset: 0x20
	public NK_TextMeshProUGUI txtText; //Field offset: 0x28
	public Image imgTick; //Field offset: 0x30
	public Image imgCross; //Field offset: 0x38
	public Image imgLoadingIcon; //Field offset: 0x40

	public CoopConfirmFreeplayPanel() { }

	public void Initialise(bool isDisbled) { }

	public void PlayerConfirmedSandbox() { }

	public void PlayerDisconnected() { }

}

