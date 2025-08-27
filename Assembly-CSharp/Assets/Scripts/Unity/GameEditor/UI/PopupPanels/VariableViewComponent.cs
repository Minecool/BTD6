namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class VariableViewComponent : MonoBehaviour
{
	public TextMeshProUGUI variableName; //Field offset: 0x20
	[CompilerGenerated]
	private EntityViewModel <EntityViewModel>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private object <Data>k__BackingField; //Field offset: 0x30

	public private object Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private EntityViewModel EntityViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public VariableViewComponent() { }

	public void Awake() { }

	public override void Bind(EntityViewModel eVM, object data) { }

	protected override void ClearContainer() { }

	[CompilerGenerated]
	public object get_Data() { }

	[CompilerGenerated]
	public EntityViewModel get_EntityViewModel() { }

	public void OnDestroy() { }

	protected override void OnUpdateView() { }

	protected override void OnValueChanged() { }

	public override void Release() { }

	[CompilerGenerated]
	private void set_Data(object value) { }

	[CompilerGenerated]
	private void set_EntityViewModel(EntityViewModel value) { }

}

