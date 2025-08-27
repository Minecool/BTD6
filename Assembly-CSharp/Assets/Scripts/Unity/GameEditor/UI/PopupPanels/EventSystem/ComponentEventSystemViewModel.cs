namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels.EventSystem;

public class ComponentEventSystemViewModel : ComponentViewModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<BehaviorViewModel> <>9__21_0; //Field offset: 0x8
		public static Action<BehaviorViewModel> <>9__21_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <GenerateBehaviorViewModels>b__21_0(BehaviorViewModel x) { }

		internal void <GenerateBehaviorViewModels>b__21_1(BehaviorViewModel x) { }

	}

	[CompilerGenerated]
	private readonly List<BehaviorViewModel> <TriggerViewModels>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly List<BehaviorViewModel> <ActionViewModels>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private BehaviorViewModel <BehaviorViewModel>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private EntityEvent <EventSystem>k__BackingField; //Field offset: 0x38

	public VariableViewModel<EntityAction[]> ActionVariableViewModel
	{
		 get { } //Length: 77
	}

	public List<BehaviorViewModel> ActionViewModels
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private BehaviorViewModel BehaviorViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private EntityEvent EventSystem
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public VariableViewModel<EntityTrigger[]> TriggerVariableViewModel
	{
		 get { } //Length: 77
	}

	public List<BehaviorViewModel> TriggerViewModels
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ComponentEventSystemViewModel(EntityViewModel eVM, BehaviorViewModel bVM) { }

	public void ChangeNameTriggered(string newName) { }

	private void CreateEventSystem() { }

	public void GenerateBehaviorViewModels() { }

	public VariableViewModel<EntityAction[]> get_ActionVariableViewModel() { }

	[CompilerGenerated]
	public List<BehaviorViewModel> get_ActionViewModels() { }

	[CompilerGenerated]
	public BehaviorViewModel get_BehaviorViewModel() { }

	[CompilerGenerated]
	public EntityEvent get_EventSystem() { }

	public VariableViewModel<EntityTrigger[]> get_TriggerVariableViewModel() { }

	[CompilerGenerated]
	public List<BehaviorViewModel> get_TriggerViewModels() { }

	public virtual void Initialise() { }

	private void OnAddActionCallback(BehaviorViewModel forViewModel, BehaviorViewModel chosenBehaviorViewModel) { }

	private void OnAddTriggerCallback(BehaviorViewModel forViewModel, BehaviorViewModel chosenBehaviorViewModel) { }

	public void OnBackClickedTriggered() { }

	public void OnCreateActionClickedTriggered() { }

	public void OnCreateTriggerClickedTriggered() { }

	public virtual void OnDestroy() { }

	public void RemoveBehaviorTriggered(BehaviorViewModel removedBehaviorViewModel, Action OnRemoveComplete) { }

	[CompilerGenerated]
	private void set_BehaviorViewModel(BehaviorViewModel value) { }

	[CompilerGenerated]
	private void set_EventSystem(EntityEvent value) { }

}

