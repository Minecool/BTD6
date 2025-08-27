namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public abstract class ComponentView : ComponentViewBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public ComponentView<T> <>4__this; //Field offset: 0x0
		public BehaviorViewModel behaviorViewModel; //Field offset: 0x0

		public <>c__DisplayClass14_0() { }

		internal void <AddBehaviorLineItem>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public ComponentView<T> <>4__this; //Field offset: 0x0
		public VariableBaseViewModel behaviorViewModel; //Field offset: 0x0

		public <>c__DisplayClass15_0() { }

		internal void <AddBehaviorLineListItem>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public ComponentView<T> <>4__this; //Field offset: 0x0
		public VariableBaseViewModel variableViewModel; //Field offset: 0x0

		public <>c__DisplayClass16_0() { }

		internal void <AddVariableLineItem>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private T <ViewModelDef>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private List<VariableViewComponent> <VariableViewComponents>k__BackingField; //Field offset: 0x0

	public List<VariableViewComponent> VariableViewComponents
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public virtual ComponentViewModel ViewModel
	{
		 get { } //Length: 5
	}

	public T ViewModelDef
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	protected ComponentView`1() { }

	protected void AddBehaviorLineItem(Transform transform, BehaviorViewModel behaviorViewModel, PrefabReference customPrefab = null) { }

	protected void AddBehaviorLineListItem(Transform transform, VariableBaseViewModel behaviorViewModel, PrefabReference customPrefab = null) { }

	protected void AddVariableLineItem(Transform transform, VariableBaseViewModel variableViewModel, PrefabReference customPrefab = null) { }

	public void Awake() { }

	public virtual void Bind(EntityViewModel entityViewModel, object data) { }

	[CompilerGenerated]
	public List<VariableViewComponent> get_VariableViewComponents() { }

	public virtual ComponentViewModel get_ViewModel() { }

	[CompilerGenerated]
	public T get_ViewModelDef() { }

	public void OnDestroy() { }

	public virtual void Release() { }

	[CompilerGenerated]
	protected void set_VariableViewComponents(List<VariableViewComponent> value) { }

	[CompilerGenerated]
	public void set_ViewModelDef(T value) { }

}

