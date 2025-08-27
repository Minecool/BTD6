namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class BehaviorBrowerLineItemView : MonoBehaviour
{
	public TextMeshProUGUI title; //Field offset: 0x20
	public Button addBtn; //Field offset: 0x28
	public Button infoBtn; //Field offset: 0x30
	[CompilerGenerated]
	private BehaviorBrowserLineItemViewModel <ViewModel>k__BackingField; //Field offset: 0x38

	public private BehaviorBrowserLineItemViewModel ViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public BehaviorBrowerLineItemView() { }

	[CompilerGenerated]
	private void <Initialise>b__7_0() { }

	[CompilerGenerated]
	private void <Initialise>b__7_1() { }

	[CompilerGenerated]
	public BehaviorBrowserLineItemViewModel get_ViewModel() { }

	public void Initialise(Type behaviorType) { }

	public void OnBehaviorsFilterChanged(string filter) { }

	public void OnDestroy() { }

	[CompilerGenerated]
	private void set_ViewModel(BehaviorBrowserLineItemViewModel value) { }

}

