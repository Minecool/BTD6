namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class VariableSwitchableScriptView : VariableViewBase
{
	public Button switchButton; //Field offset: 0x38
	public Button editButton; //Field offset: 0x40
	public Button addButton; //Field offset: 0x48
	public TextMeshProUGUI selectedBehaviorName; //Field offset: 0x50
	public IVariableBehaviorViewModel ViewModel; //Field offset: 0x58

	public bool HasValidData
	{
		 get { } //Length: 223
	}

	public VariableSwitchableScriptView() { }

	public virtual void Bind(EntityViewModel eVM, object data) { }

	public bool get_HasValidData() { }

	private void OnAddButtonClicked() { }

	private void OnBehaviorSelectedTriggered(BehaviorViewModel forViewModel, BehaviorViewModel selectedBehaviorViewModel) { }

	private void OnEditButtonClicked() { }

	private void OnSwitchButtonClicked() { }

	protected virtual void OnUpdateView() { }

	protected virtual void OnValueChanged() { }

	public virtual void Release() { }

	private void SetupBehaiorData() { }

}

