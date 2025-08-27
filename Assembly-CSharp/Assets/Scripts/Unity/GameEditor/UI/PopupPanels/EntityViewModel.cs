namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class EntityViewModel : ViewModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<BehaviorViewModel> <>9__27_0; //Field offset: 0x8
		public static Action<BehaviorViewModel> <>9__38_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <GenerateBehaviorViewModels>b__38_0(BehaviorViewModel x) { }

		internal void <OnDestroy>b__27_0(BehaviorViewModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public EntityViewModel <>4__this; //Field offset: 0x10
		public Action<String> onCallback; //Field offset: 0x18

		public <>c__DisplayClass39_0() { }

		internal void <OnChangeNameClicked>b__0(string defaultValue) { }

	}

	internal sealed class OnAddBehavior : MulticastDelegate
	{

		public OnAddBehavior(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BehaviorViewModel forBehaviour, BehaviorViewModel chosenBehaviour, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BehaviorViewModel forBehaviour, BehaviorViewModel chosenBehaviour) { }

	}

	internal sealed class OnAddBehaviorListItem : MulticastDelegate
	{

		public OnAddBehaviorListItem(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(VariableBaseViewModel forList, Action<BehaviorViewModel> OnRemoveComplete, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(VariableBaseViewModel forList, Action<BehaviorViewModel> OnRemoveComplete) { }

	}

	internal sealed class OnEditBehavior : MulticastDelegate
	{

		public OnEditBehavior(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BehaviorViewModel editedBehaviour, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BehaviorViewModel editedBehaviour) { }

	}

	internal sealed class OnNameChanged : MulticastDelegate
	{

		public OnNameChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string newName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string newName) { }

	}

	internal sealed class OnRemoveBehavior : MulticastDelegate
	{

		public OnRemoveBehavior(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BehaviorViewModel behaviour, Action OnRemoveComplete, bool triggerUpdate, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BehaviorViewModel behaviour, Action OnRemoveComplete, bool triggerUpdate = false) { }

	}

	[CompilerGenerated]
	private List<BehaviorViewModel> <BehaviorViewModels>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Stack<BehaviorViewModel> <ViewModelStack>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private BehaviorViewModel <SelectedBehaviorViewModel>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private BehaviorViewModel <RootBehaviorViewModel>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private CustomPrefabModelData <Data>k__BackingField; //Field offset: 0x30

	public List<BehaviorViewModel> BehaviorViewModels
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public private CustomPrefabModelData Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private BehaviorViewModel RootBehaviorViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private BehaviorViewModel SelectedBehaviorViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Stack<BehaviorViewModel> ViewModelStack
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public EntityViewModel(CustomPrefabModelData prefab, Behavior behavior) { }

	public void AddBehaviorListItemTriggered(VariableBaseViewModel forList, Action<BehaviorViewModel> OnComplete) { }

	public override void AddBehaviorTriggered(BehaviorViewModel forViewModel, BehaviorViewModel chosenBehaviorViewModel) { }

	public void Back() { }

	public void BreadcrumbStackPopped(BehaviorViewModel breadcrumbClicked) { }

	public BehaviorViewModel FindBehaviorViewModelForBehavior(object behaviorToFind) { }

	public override void GenerateBehaviorViewModels(BehaviorViewModel behaviorViewModel, bool addToStack = true) { }

	[CompilerGenerated]
	public List<BehaviorViewModel> get_BehaviorViewModels() { }

	[CompilerGenerated]
	public CustomPrefabModelData get_Data() { }

	[CompilerGenerated]
	public BehaviorViewModel get_RootBehaviorViewModel() { }

	[CompilerGenerated]
	public BehaviorViewModel get_SelectedBehaviorViewModel() { }

	[CompilerGenerated]
	public Stack<BehaviorViewModel> get_ViewModelStack() { }

	public List<BehaviorViewModel> GetBehaviorsListFromVariableViewModel(VariableBaseViewModel vVM) { }

	public override void Initialise(bool isNewEntity) { }

	public void OnChangeNameClicked(string defaultValue, Action<String> onCallback = null) { }

	public virtual void OnDestroy() { }

	public void OnEditBehaviorTriggered(BehaviorViewModel selectedBehaviorVM) { }

	private void OnNameChangedCallback(string newName, Action<String> onCallback) { }

	public override void RemoveAllBehaviorsInList(List<BehaviorViewModel> behaviors, Action OnRemoveComplete = null) { }

	public override void RemoveBehaviorTriggered(BehaviorViewModel removeBehaviorViewModel, Action OnRemoveComplete, bool triggerUpdate = true) { }

	public void Reset() { }

	public void Save() { }

	[CompilerGenerated]
	public void set_BehaviorViewModels(List<BehaviorViewModel> value) { }

	[CompilerGenerated]
	private void set_Data(CustomPrefabModelData value) { }

	[CompilerGenerated]
	private void set_RootBehaviorViewModel(BehaviorViewModel value) { }

	[CompilerGenerated]
	private void set_SelectedBehaviorViewModel(BehaviorViewModel value) { }

	[CompilerGenerated]
	public void set_ViewModelStack(Stack<BehaviorViewModel> value) { }

}

