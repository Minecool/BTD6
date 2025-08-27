namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public abstract class ComponentViewBase : MonoBehaviour
{
	[CompilerGenerated]
	private bool <IsBound>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private EntityViewModel <EntityViewModel>k__BackingField; //Field offset: 0x28

	public EntityViewModel EntityViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool IsBound
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public abstract ComponentViewModel ViewModel
	{
		 get { } //Length: 0
	}

	protected ComponentViewBase() { }

	public abstract void Bind(EntityViewModel entityViewModel, object data) { }

	protected abstract void ClearContainers() { }

	[CompilerGenerated]
	public EntityViewModel get_EntityViewModel() { }

	[CompilerGenerated]
	public bool get_IsBound() { }

	public abstract ComponentViewModel get_ViewModel() { }

	public override bool HasUnsavedChanges() { }

	public abstract void OnShowView() { }

	public abstract void Release() { }

	[CompilerGenerated]
	protected void set_EntityViewModel(EntityViewModel value) { }

	[CompilerGenerated]
	protected void set_IsBound(bool value) { }

}

