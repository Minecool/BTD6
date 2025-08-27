namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class BehaviorListViewModel
{
	[CompilerGenerated]
	private readonly EntityViewModel <EntityViewModel>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly VariableBaseViewModel <VariableViewModel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<BehaviorViewModel> <BehaviorViewModels>k__BackingField; //Field offset: 0x20

	public private List<BehaviorViewModel> BehaviorViewModels
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public EntityViewModel EntityViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public VariableBaseViewModel VariableViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BehaviorListViewModel(EntityViewModel eVM, VariableBaseViewModel vVM) { }

	[CompilerGenerated]
	public List<BehaviorViewModel> get_BehaviorViewModels() { }

	[CompilerGenerated]
	public EntityViewModel get_EntityViewModel() { }

	[CompilerGenerated]
	public VariableBaseViewModel get_VariableViewModel() { }

	public void Initialise() { }

	public void OnDestroy() { }

	[CompilerGenerated]
	private void set_BehaviorViewModels(List<BehaviorViewModel> value) { }

	public void UpdateBehaviorViewModels() { }

}

