namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class RemoveableLayerButton : MonoBehaviour
{
	public EditorLayerButton layerLinkedTo; //Field offset: 0x20
	public Image icon; //Field offset: 0x28
	public TextMeshProUGUI layerName; //Field offset: 0x30
	public Image bg; //Field offset: 0x38
	public GameObject selectedBackground; //Field offset: 0x40
	public GameObject linkedIcon; //Field offset: 0x48
	public GameObject linkedIconSelected; //Field offset: 0x50
	public Button selectedBtn; //Field offset: 0x58
	public Toggle visibleTgl; //Field offset: 0x60
	private bool isSelected; //Field offset: 0x68

	public LayerData LayerData
	{
		 get { } //Length: 29
	}

	public RemoveableLayerButton() { }

	[CompilerGenerated]
	private void <Bind>b__12_0() { }

	public void Bind(EditorLayerButton layer) { }

	public LayerData get_LayerData() { }

	public void OnSelected() { }

	public void OnToggleVisbility(bool isOn) { }

	public void SetSelected(bool isSelected) { }

}

