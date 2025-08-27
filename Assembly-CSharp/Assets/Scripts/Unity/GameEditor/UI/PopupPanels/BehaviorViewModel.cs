namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class BehaviorViewModel : ComponentViewModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldInfo, Boolean> <>9__41_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GenerateVariableViewModels>b__41_0(FieldInfo field) { }

	}

	internal sealed class OnRemoveBehavior : MulticastDelegate
	{

		public OnRemoveBehavior(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnSaveBehavior : MulticastDelegate
	{

		public OnSaveBehavior(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BehaviorViewModel behaviour, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BehaviorViewModel behaviour) { }

	}

	[CompilerGenerated]
	private Behavior <Behavior>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private List<VariableBaseViewModel> <VariableViewModels>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private List<VariableBaseViewModel> <BehaviorViewModels>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsLeafNode>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsVariableListItem>k__BackingField; //Field offset: 0x41
	[CompilerGenerated]
	private Type <ComponentType>k__BackingField; //Field offset: 0x48
	public VariableViewModel<SpriteReference> Icon; //Field offset: 0x50
	public VariableViewModel<PrefabReference> Display; //Field offset: 0x58
	[CompilerGenerated]
	private GraphNodeModelDescriptor <ModelDescriptor>k__BackingField; //Field offset: 0x60

	public Behavior Behavior
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public List<VariableBaseViewModel> BehaviorViewModels
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public private Type ComponentType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private bool IsLeafNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsVariableListItem
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GraphNodeModelDescriptor ModelDescriptor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public List<VariableBaseViewModel> VariableViewModels
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BehaviorViewModel(EntityViewModel eVM, Behavior behavior) { }

	public BehaviorViewModel(Behavior behavior) { }

	private void BindData(Behavior behavior) { }

	private void GenerateVariableViewModels() { }

	[CompilerGenerated]
	public Behavior get_Behavior() { }

	[CompilerGenerated]
	public List<VariableBaseViewModel> get_BehaviorViewModels() { }

	[CompilerGenerated]
	public Type get_ComponentType() { }

	[CompilerGenerated]
	public bool get_IsLeafNode() { }

	[CompilerGenerated]
	public bool get_IsVariableListItem() { }

	[CompilerGenerated]
	public GraphNodeModelDescriptor get_ModelDescriptor() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public List<VariableBaseViewModel> get_VariableViewModels() { }

	public VariableViewModel<T> GetVariableViewModel() { }

	public virtual void Initialise() { }

	public virtual void OnDestroy() { }

	[CompilerGenerated]
	public void set_Behavior(Behavior value) { }

	[CompilerGenerated]
	public void set_BehaviorViewModels(List<VariableBaseViewModel> value) { }

	[CompilerGenerated]
	private void set_ComponentType(Type value) { }

	[CompilerGenerated]
	private void set_IsLeafNode(bool value) { }

	[CompilerGenerated]
	public void set_IsVariableListItem(bool value) { }

	[CompilerGenerated]
	public void set_ModelDescriptor(GraphNodeModelDescriptor value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_VariableViewModels(List<VariableBaseViewModel> value) { }

}

