namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeEditorModifierSettings : MonoBehaviour
{
	[SerializeField]
	private ModifierSettingsButton mkToggle; //Field offset: 0x20
	[SerializeField]
	private ModifierSettingsButton sellingToggle; //Field offset: 0x28
	[SerializeField]
	private ModifierSettingsButton powersToggle; //Field offset: 0x30
	[SerializeField]
	private ModifierSettingsButton continuesToggle; //Field offset: 0x38
	[SerializeField]
	private ModifierSettingsButton allCamoToggle; //Field offset: 0x40
	[SerializeField]
	private ModifierSettingsButton allRegenToggle; //Field offset: 0x48
	[SerializeField]
	private ModifierSettingsButton disableDoubleCashToggle; //Field offset: 0x50
	[SerializeField]
	private ModifierSettingsButton disableFastTrack; //Field offset: 0x58
	[SerializeField]
	private GameObject infoPopup; //Field offset: 0x60
	[SerializeField]
	private NK_TextMeshProUGUI infoPopupTxt; //Field offset: 0x68
	[SerializeField]
	private float infoPopupOffsetY; //Field offset: 0x70
	[SerializeField]
	private Lightbox bgClose; //Field offset: 0x78
	public Transform includedContainer; //Field offset: 0x80
	public Transform excludedContainer; //Field offset: 0x88
	[HideInInspector]
	public ModifierSettingsButton selectedIcon; //Field offset: 0x90
	public TextMeshProUGUI descriptionTitle; //Field offset: 0x98
	public TextMeshProUGUI descriptionBody; //Field offset: 0xA0
	public Button removeAllButton; //Field offset: 0xA8
	public GameObject popupObj; //Field offset: 0xB0
	public Button editModifiersButton; //Field offset: 0xB8
	public GameObject dispayIconsContainer; //Field offset: 0xC0
	public Image displayPrefab; //Field offset: 0xC8
	private List<GameObject> displayIcons; //Field offset: 0xD0

	public ChallengeEditorModifierSettings() { }

	public void ApplyDCMtoUI(DailyChallengeModel dcm) { }

	public void ApplyUIToDCM(DailyChallengeModel dcm) { }

	public void Awake() { }

	public void CloseEditPopup() { }

	public void CloseInfoPopup() { }

	private void ExcludeAllSettings() { }

	public void OpenEditPopup() { }

	public void OpenInfoPopup(ChallengeEditorModifierIcon icon) { }

	private void SetDisplayIcons() { }

	public void ShowInfo(ModifierSettingsButton icon) { }

}

