namespace Assets.Scripts.Unity.UI_New.InGame.Removables;

public class RemovablePanel : MonoBehaviour
{
	public static RemovablePanel instance; //Field offset: 0x0
	private readonly string visibleStateLabel; //Field offset: 0x20
	public GameObject background; //Field offset: 0x28
	public Animator panelAnimator; //Field offset: 0x30
	public RectTransform panelRect; //Field offset: 0x38
	public Button confirmBtn; //Field offset: 0x40
	public Button cancelBtn; //Field offset: 0x48
	public NK_TextMeshProUGUI costTxt; //Field offset: 0x50
	private MapInteractable mapInteractable; //Field offset: 0x58

	public RemovablePanel() { }

	public void DeInit() { }

	public void Init() { }

	private void OnCancelClicked() { }

	private void OnConfirmClicked() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnSelectionChanged(Selectable selected) { }

	private void ShowPanel(bool show) { }

	private void UpdateText() { }

}

