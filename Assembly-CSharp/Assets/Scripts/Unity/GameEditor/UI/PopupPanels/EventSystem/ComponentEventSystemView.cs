namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels.EventSystem;

public class ComponentEventSystemView : ComponentView<ComponentEventSystemViewModel>
{
	public Transform triggersContainer; //Field offset: 0x40
	public Transform actionsContainer; //Field offset: 0x48
	public NK_TextMeshProInputField searchField; //Field offset: 0x50
	public Button addActionBtn; //Field offset: 0x58
	public Button addTriggerBtn; //Field offset: 0x60

	public ComponentEventSystemView() { }

	public virtual void Bind(EntityViewModel eVM, object data) { }

	protected virtual void ClearContainers() { }

	public virtual void OnShowView() { }

	public virtual void Release() { }

}

