namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class ActorComponentViewModel : EntityComponentViewModel<ActorPrefabModelData>
{
	public Prop Actor; //Field offset: 0x28

	public ActorComponentViewModel(EntityViewModel eVM, ActorPrefabModelData data) { }

	private void CreateActorModel() { }

	public bool HasUnsavedChanges() { }

	public virtual void Initialise() { }

	public void OnAddBehaviorClicked() { }

	public virtual void OnDestroy() { }

	public void OnNameChangedCallback(string newName) { }

}

