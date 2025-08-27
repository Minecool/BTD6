namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class UpgradeInfoPopup : MonoBehaviour
{
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x20
	public NK_TextMeshProUGUI decriptionTxt; //Field offset: 0x28
	public Animator animator; //Field offset: 0x30
	private bool openedRight; //Field offset: 0x38
	private bool showing; //Field offset: 0x39
	private UpgradeObject upgradeObj; //Field offset: 0x40
	private bool forCurrent; //Field offset: 0x48

	public UpgradeInfoPopup() { }

	public void Hide() { }

	public void Init(UpgradeObject upgradeObj) { }

	public bool IsShowing() { }

	public void OpenedSide(bool right) { }

	public void Show(bool forCurrent) { }

	public void Update() { }

}

