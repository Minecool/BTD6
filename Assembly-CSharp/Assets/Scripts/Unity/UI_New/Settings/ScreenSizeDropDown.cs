namespace Assets.Scripts.Unity.UI_New.Settings;

public class ScreenSizeDropDown : MonoBehaviour
{
	public Animator animator; //Field offset: 0x20
	public Transform content; //Field offset: 0x28
	public NK_TextMeshProUGUI currentScreenSizeText; //Field offset: 0x30
	public GameObject fullscreenTick; //Field offset: 0x38
	public Button fullScreenButton; //Field offset: 0x40
	public GameObject sixtyFpsTick; //Field offset: 0x48
	public Button sixtyFpsButton; //Field offset: 0x50
	public GameObject listItemPrefab; //Field offset: 0x58
	private ScreenSizeDropDownSelection currentSelection; //Field offset: 0x60
	private List<ScreenSizeDropDownSelection> selections; //Field offset: 0x68
	private List<Resolution> genericResolutions; //Field offset: 0x70
	public GamepadContext gamepadContext; //Field offset: 0x78
	private PlayerPrefBool capFPSPref; //Field offset: 0x80
	private bool dropDownShowing; //Field offset: 0x88

	public ScreenSizeDropDown() { }

	private void AddIfNotInList(List<Resolution> supRes, Resolution res) { }

	private void Cancel() { }

	public void GamepadBackButton() { }

	private string GetResolutionString(Resolution resolution) { }

	public void OkButton() { }

	public void On60FpsCheck() { }

	public void OnFullscreenCheck() { }

	public void OnTickboxCheck(ScreenSizeDropDownSelection selection) { }

	private void Populate() { }

	private void RefreshGamepadSelection() { }

	private void Reset() { }

	public void ShowDropDown() { }

	private void Start() { }

	private void SwitchResolution() { }

}

