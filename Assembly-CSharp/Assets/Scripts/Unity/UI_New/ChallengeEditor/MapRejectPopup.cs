namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class MapRejectPopup : MapManagementPopupBase
{
	[SerializeField]
	private NK_TextMeshProUGUI titleBannerText; //Field offset: 0x58
	[SerializeField]
	private NK_TextMeshProUGUI confirmButtonText; //Field offset: 0x60

	public MapRejectPopup() { }

	protected virtual void Awake() { }

}

