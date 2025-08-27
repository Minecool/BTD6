namespace Assets.Scripts.Unity.UI_New;

public class DebugCollapsableOutputPanel : MonoBehaviour
{
	public NK_TextMeshProUGUI headerTxt; //Field offset: 0x20
	public GameObject contentPanel; //Field offset: 0x28
	public NK_TextMeshProUGUI contextTxt; //Field offset: 0x30
	public GameObject plusObj; //Field offset: 0x38
	public GameObject minusObj; //Field offset: 0x40
	public Button toggleBtn; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsUnused>k__BackingField; //Field offset: 0x50

	public bool IsUnused
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public DebugCollapsableOutputPanel() { }

	[CompilerGenerated]
	private void <Awake>b__10_0() { }

	public void Awake() { }

	[CompilerGenerated]
	public bool get_IsUnused() { }

	public void Initialise(string title, string output) { }

	public void OnSetDefaultState() { }

	private void OnToggleButton() { }

	[CompilerGenerated]
	public void set_IsUnused(bool value) { }

}

