namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class ActorComponentView : ComponentView<ActorComponentViewModel>
{
	public Button addBehaviorButton; //Field offset: 0x40
	public Button addVariableButton; //Field offset: 0x48
	public Transform behaviorsContainer; //Field offset: 0x50
	public Transform variablesContainer; //Field offset: 0x58

	public ActorComponentView() { }

	public virtual void Bind(EntityViewModel entityViewModel, object data) { }

	protected virtual void ClearContainers() { }

	public virtual bool HasUnsavedChanges() { }

	public virtual void OnShowView() { }

	private void PopulateBehaviors() { }

	private void PopulateVariable() { }

	public virtual void Release() { }

}

