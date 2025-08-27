namespace Assets.Scripts.Unity.Gamepad.DuelAction;

public class ActionButton : MonoBehaviour
{
	public Image icon; //Field offset: 0x20
	public Image holdBg; //Field offset: 0x28
	public Image holdProgress; //Field offset: 0x30
	public TMP_Text holdText; //Field offset: 0x38
	public GamepadInputType inputType; //Field offset: 0x40
	private ActionButtonHoldState holdState; //Field offset: 0x48
	[HideInInspector]
	public ButtonControl onClickButton; //Field offset: 0x50
	[HideInInspector]
	public Button targetButton; //Field offset: 0x58
	public bool holdToTrigger; //Field offset: 0x60
	private ButtonClickedEvent origButtonClick; //Field offset: 0x68
	public bool requiresSelection; //Field offset: 0x70
	private MultiplayerSelectable mSel; //Field offset: 0x78
	public BTD6Gamepad input; //Field offset: 0x80
	[HideInInspector]
	public bool isActive; //Field offset: 0x88
	private bool prevCanPress; //Field offset: 0x89
	private bool canPress; //Field offset: 0x8A
	public bool showInVMouseMode; //Field offset: 0x8B
	public bool autoHide; //Field offset: 0x8C
	public bool isFixed; //Field offset: 0x8D

	public ActionButton() { }

	public ActionButton CanNav(Button btn, bool canNav) { }

	public bool CanPress() { }

	public void CommonShowHold(bool show) { }

	public void DuelUpdate() { }

	public void Hide() { }

	private void Input_InputModeChanged(NKInputSystemUIInputModuleMode mode) { }

	private void Input_OnSelectedGameObjectChanged(BTD6Gamepad inputMod, MultiplayerSelectable current) { }

	private void LinkOnClick(Button targetButton) { }

	private void MainPlayerInputChanged(BTD6Gamepad newInput) { }

	private void OnDestroy() { }

	public void OnTargetButtonClick() { }

	private void RefreshVisible() { }

	public ActionButton RequiresSelection(bool required) { }

	private void RevertTargetClick() { }

	private void SetGameObjectActive(bool isActive) { }

	public ActionButton SetPos(AnchorPresets anchor, Vector2 anchoredPosition) { }

	protected override void SetVis(bool show) { }

	public void Show(Button targetButton) { }

	public void ShowHold(Button targetButton) { }

	protected override void Start() { }

	private void Update() { }

}

