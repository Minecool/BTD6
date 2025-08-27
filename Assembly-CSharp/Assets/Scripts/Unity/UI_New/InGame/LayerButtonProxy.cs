namespace Assets.Scripts.Unity.UI_New.InGame;

public class LayerButtonProxy : MonoBehaviour
{
	public Image icon; //Field offset: 0x20
	public TextMeshProUGUI layerName; //Field offset: 0x28
	public Image bg; //Field offset: 0x30
	public GameObject selectedBackground; //Field offset: 0x38
	public GameObject linkedIcon; //Field offset: 0x40
	public GameObject linkedIconSelected; //Field offset: 0x48
	public Button selectedBtn; //Field offset: 0x50
	public Button deleteBtn; //Field offset: 0x58
	public Toggle visibleTgl; //Field offset: 0x60
	public PipEventChecker pathWarningPip; //Field offset: 0x68
	public EditorLayerButton layerLinkedTo; //Field offset: 0x70

	protected bool IsSelected
	{
		 get { } //Length: 27
	}

	public bool IsWarningPipeVisible
	{
		 get { } //Length: 29
	}

	public LayerData LayerData
	{
		 get { } //Length: 58
	}

	public LayerButtonProxy() { }

	[CompilerGenerated]
	private void <SetCallBackListeners>b__20_0() { }

	[CompilerGenerated]
	private void <SetCallBackListeners>b__20_1(bool isOn) { }

	public void Awake() { }

	public void Bind(EditorLayerButton layer) { }

	protected bool get_IsSelected() { }

	public bool get_IsWarningPipeVisible() { }

	public LayerData get_LayerData() { }

	public override void OnCheckWarningPip() { }

	public void OnDeleteClicked() { }

	private void OnDeletedEventCallback() { }

	public void OnDestroy() { }

	public void OnSelectClicked() { }

	public void OnSelectedLayerChanged(EditorLayerButton selectedButton) { }

	public void OnToggleVisbility(bool isOn) { }

	public void SetCallBackListeners() { }

}

