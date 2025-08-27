namespace Assets.Scripts.Unity.UI_New;

public class CollapsiblePanel : MonoBehaviour
{
	public NK_TextMeshProUGUI headerTxt; //Field offset: 0x20
	public GameObject openObj; //Field offset: 0x28
	public GameObject closeObj; //Field offset: 0x30
	public GameObject contentContainer; //Field offset: 0x38
	public Button toggleBtn; //Field offset: 0x40
	private bool isVisible; //Field offset: 0x48
	public bool defaultVisible; //Field offset: 0x49

	public CollapsiblePanel() { }

	[CompilerGenerated]
	private void <Awake>b__7_0() { }

	public void Awake() { }

	private void OnToggleButton() { }

	private void SetDefaultState() { }

}

